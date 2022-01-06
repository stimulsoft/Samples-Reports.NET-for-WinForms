#region Copyright (C) 2003-2019 Stimulsoft
/*
{*******************************************************************}
{																	}
{	Stimulsoft Reports       										}
{																	}
{	Copyright (C) 2003-2019 Stimulsoft     							}
{	ALL RIGHTS RESERVED												}
{																	}
{	The entire contents of this file is protected by U.S. and		}
{	International Copyright Laws. Unauthorized reproduction,		}
{	reverse-engineering, and distribution of all or any portion of	}
{	the code contained in this file is strictly prohibited and may	}
{	result in severe civil and criminal penalties and will be		}
{	prosecuted to the maximum extent possible under the law.		}
{																	}
{	RESTRICTIONS													}
{																	}
{	THIS SOURCE CODE AND ALL RESULTING INTERMEDIATE FILES			}
{	ARE CONFIDENTIAL AND PROPRIETARY								}
{	TRADE SECRETS OF Stimulsoft										}
{																	}
{	CONSULT THE END USER LICENSE AGREEMENT FOR INFORMATION ON		}
{	ADDITIONAL RESTRICTIONS.										}
{																	}
{*******************************************************************}
*/
#endregion Copyright (C) 2003-2019 Stimulsoft
using System;
using System.Collections;
using System.Data;
using System.ComponentModel;
using Npgsql;
using Stimulsoft.Base;
using Stimulsoft.Base.Localization;
using Stimulsoft.Base.Serializing;
using Stimulsoft.Report.Dictionary.Design;
using Stimulsoft.Report.Events;

namespace Stimulsoft.Report.Dictionary
{
    [TypeConverter(typeof(StiSqlSourceConverter))]
    public class CustomPostgreSQLSource : StiSqlSource
    {
        #region Methods
        protected override Type ConvertDbTypeToTypeInternal(int sqlType)
        {
            NpgsqlTypes.NpgsqlDbType dbType = (NpgsqlTypes.NpgsqlDbType)sqlType;
            switch (dbType)
            {
                case NpgsqlTypes.NpgsqlDbType.Bigint:
                case NpgsqlTypes.NpgsqlDbType.Smallint:
                case NpgsqlTypes.NpgsqlDbType.Integer:
                    return typeof(Int64);

                case NpgsqlTypes.NpgsqlDbType.Money:
                case NpgsqlTypes.NpgsqlDbType.Numeric:
                    return typeof(decimal);

                case NpgsqlTypes.NpgsqlDbType.Double:
                case NpgsqlTypes.NpgsqlDbType.Real:
                    return typeof(double);

                case NpgsqlTypes.NpgsqlDbType.Boolean:
                    return typeof(bool);

                case NpgsqlTypes.NpgsqlDbType.Date:
                case NpgsqlTypes.NpgsqlDbType.Timestamp:
                    return typeof(DateTime);

                default:
                    return typeof(string);
            }
        }

        public override Type GetParameterTypesEnum()
        {
            return typeof(NpgsqlTypes.NpgsqlDbType);
        }

        public override StiDataParameter AddParameter()
        {
            var parameter = new StiDataParameter(
                StiLocalization.Get("PropertyMain", "Parameter"), string.Empty, (int)NpgsqlTypes.NpgsqlDbType.Varchar, 0);
            Parameters.Add(parameter);
            return parameter;
        }

        public virtual StiDataParameter AddParameter(string name, string expression, NpgsqlTypes.NpgsqlDbType type, int size)
        {
            var parameter = AddParameter();

            parameter.Name = name;
            parameter.Expression = expression;
            parameter.Type = (int)type;
            parameter.Size = size;

            return parameter;
        }

        public override void UpdateParameters()
        {
            if (this.DataTable == null)return;
            
            InvokeConnecting();

            var npgsqlAdapter = DataAdapter as NpgsqlDataAdapter;
            foreach (StiDataParameter parameter in Parameters)
            {
                npgsqlAdapter.SelectCommand.Parameters[parameter.Name].Value = parameter.GetParameterValue();
            }

            var dataTable = this.DataTable;
            dataTable.Rows.Clear();

            npgsqlAdapter.SelectCommand.CommandTimeout = this.CommandTimeout;
            npgsqlAdapter.Fill(dataTable);

            CheckColumnsIndexs();
        }

        public override StiDataAdapterService GetDataAdapter()
        {
            return new CustomPostgreSQLAdapterService();
        }

        /// <summary>
        /// Returns new data connector for this datasource.
        /// </summary>
        /// <returns>Created connector.</returns>
        public override StiSqlDataConnector CreateConnector(string connectionString = null)
        {
            return StiPostgreSqlConnector.Get(connectionString);
        }
        #endregion

        #region Properties
        protected override string DataAdapterType => "Stimulsoft.Report.Dictionary.CustomPostgreSQLAdapterService";
        #endregion        

        public CustomPostgreSQLSource()
            : this("", "", "")
        {
        }

        public CustomPostgreSQLSource(string nameInSource, string name)
            : this(nameInSource, name, name)
        {
        }

        public CustomPostgreSQLSource(string nameInSource, string name, string alias)
            : this(nameInSource, name, alias, string.Empty)
        {

        }

        public CustomPostgreSQLSource(string nameInSource, string name, string alias, string sqlCommand) :
            base(nameInSource, name, alias, sqlCommand)
        {
        }

        public CustomPostgreSQLSource(string nameInSource, string name, string alias, string sqlCommand,
            bool connectOnStart) :
            base(nameInSource, name, alias, sqlCommand, connectOnStart)
        {
        }

        public CustomPostgreSQLSource(string nameInSource, string name, string alias, string sqlCommand,
            bool connectOnStart, bool reconnectOnEachRow) :
            base(nameInSource, name, alias, sqlCommand, connectOnStart, reconnectOnEachRow)
        {
        }

        public CustomPostgreSQLSource(string nameInSource, string name, string alias, string sqlCommand,
            bool connectOnStart, bool reconnectOnEachRow, int commandTimeout) :
            base(nameInSource, name, alias, sqlCommand, connectOnStart, reconnectOnEachRow, commandTimeout)
        {
        }

        public CustomPostgreSQLSource(string nameInSource, string name, string alias, string sqlCommand,
            bool connectOnStart, bool reconnectOnEachRow, int commandTimeout, string key) :
            base(nameInSource, name, alias, sqlCommand, connectOnStart, reconnectOnEachRow, commandTimeout, key)
        {
        }
    }
}

