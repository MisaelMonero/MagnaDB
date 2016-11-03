﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MagnaDB
{
    public enum DateTimeSpecification
    {
        Date,
        DateAndTime,
        Time
    }

    public enum PresenceBehavior
    {
        IncludeOnly,
        ExcludeAll
    }

    public sealed class MagnaKey
    {
        public IDictionary<string, object> KeyDictionary { get; private set; }

        public MagnaKey(IDictionary<string, object> fieldsValues)
        {
            KeyDictionary = fieldsValues;
        }
    }

    public static class ModelExtensions
    {
        public static IEnumerable<T> ToIEnumerable<T>(this IEnumerable<T> tableModels, string extraConditions = "", params object[] values) where T : TableModel<T>, new()
        {
            return TableModel<T>.ToIEnumerable(extraConditions, values);
        }

        public static IEnumerable<T> ToIEnumerable<T>(this IEnumerable<T> tableModels, SqlConnection connection, string extraConditions = "", params object[] values) where T : TableModel<T>, new()
        {
            return TableModel<T>.ToIEnumerable(connection, extraConditions, values);
        }

        public static async Task<IEnumerable<T>> ToIEnumerableAsync<T>(this IEnumerable<T> tableModels, string extraConditions = "", params object[] values) where T : TableModel<T>, new()
        {
            return await TableModel<T>.ToIEnumerableAsync(extraConditions, values);
        }

        public static async Task<IEnumerable<T>> ToIEnumerableAsync<T>(this IEnumerable<T> tableModels, SqlConnection connection, string extraConditions = "", params object[] values) where T : TableModel<T>, new()
        {
            return await TableModel<T>.ToIEnumerableAsync(connection, extraConditions, values);
        }

        public static bool GroupInsert<T>(this IEnumerable<T> tableModels) where T : TableModel<T>, new()
        {
            return TableModel<T>.GroupInsert(tableModels);
        }

        public static bool GroupInsert<T>(this IEnumerable<T> tableModels, SqlConnection connection) where T : TableModel<T>, new()
        {
            return TableModel<T>.GroupInsert(tableModels, connection);
        }

        public static bool GroupInsert<T>(this IEnumerable<T> tableModels, SqlTransaction transaction) where T : TableModel<T>, new()
        {
            return TableModel<T>.GroupInsert(tableModels, transaction);
        }

        public static async Task<bool> GroupInsertAsync<T>(this IEnumerable<T> tableModels) where T : TableModel<T>, new()
        {
            return await TableModel<T>.GroupInsertAsync(tableModels);
        }

        public static async Task<bool> GroupInsertAsync<T>(this IEnumerable<T> tableModels, SqlConnection connection) where T : TableModel<T>, new()
        {
            return await TableModel<T>.GroupInsertAsync(tableModels, connection);
        }

        public static async Task<bool> GroupInsertAsync<T>(this IEnumerable<T> tableModels, SqlTransaction transaction) where T : TableModel<T>, new()
        {
            return await TableModel<T>.GroupInsertAsync(tableModels, transaction);
        }
    }

    public static class MagnaUtils
    {  
        public static MagnaKey MakeKey<T>(this T value, params Expression<Func<T, object>>[] properties) where T : ViewModel<T>, new()
        {
            Dictionary<string, object> fieldsValues = new Dictionary<string, object>();
            object iteraEvaluation;

            foreach (Expression<Func<T, object>> item in properties)
            {
                MemberExpression me = item.Body as MemberExpression;
                if (me == null)
                {
                    me = (item.Body as UnaryExpression).Operand as MemberExpression;
                }
                PropertyInfo prop = me.Member as PropertyInfo;
                iteraEvaluation = prop.GetValue(value);

                if (iteraEvaluation == null)
                    throw new InvalidKeyException("Columns/Properties belonging to a Primary Key must not be null");

                fieldsValues.Add(prop.Name, iteraEvaluation);
            }

            return new MagnaKey(fieldsValues);
        }

        public static bool IsNumberType(this object number)
        {
            if (number == null)
                return false;

            return (number is byte || number is short || number is int || number is long ||
                    number is sbyte || number is ushort || number is uint || number is ulong ||
                    number is float || number is double || number is decimal);
        }

        public static bool TryGetAttribute<T>(this PropertyInfo property, out T attribute) where T : Attribute
        {
            IEnumerable<T> attributes = property.GetCustomAttributes<T>();
            if (attributes.Count() > 0)
            {
                attribute = attributes.First();
                return true;
            }

            attribute = null;
            return false;
        }
    }

    /// <summary>
    /// Representa un Evento para Objetos Magnanteractive
    /// </summary>
    /// <param name="sender">La instancia que dispara el evento</param>
    /// <param name="e">Información acerca del evento</param>
    ///
    public delegate void MagnaEventHandler(object sender, MagnaEventArgs e);

    /// <summary>
    /// This class contains info about the Magna event context
    /// </summary>
    public class MagnaEventArgs : EventArgs
    {
        public MagnaEventArgs(int nrows, string connectionString)
        {
            RowsAffected = nrows;
            ConnectionString = connectionString;
        }

        public MagnaEventArgs(int nrows, SqlConnection connection)
        {
            RowsAffected = nrows;
            CurrentConnection = connection;
            ConnectionString = connection.ConnectionString;
        }

        public MagnaEventArgs(int nrows, SqlTransaction transaction)
        {
            RowsAffected = nrows;
            CurrentTransaction = transaction;
            CurrentConnection = transaction.Connection;
            ConnectionString = transaction.Connection.ConnectionString;
        }

        /// <summary>
        /// Represents the number of Rows affected by the executed operation
        /// </summary>
        public int RowsAffected { get; private set; }

        /// <summary>
        /// The Connection String of the Operation
        /// </summary>
        public string ConnectionString { get; private set; }

        /// <summary>
        /// If the operation was executed with an exposed connection retrieves the used connection
        /// </summary>
        public SqlConnection CurrentConnection { get; private set; }

        /// <summary>
        /// If the operation is executed against a trasaction retrieves the transaction in use
        /// </summary>
        public SqlTransaction CurrentTransaction { get; private set; }
    }
}
