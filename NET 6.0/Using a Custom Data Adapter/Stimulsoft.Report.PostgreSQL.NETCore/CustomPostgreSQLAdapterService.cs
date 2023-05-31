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
using System.Data;
using Npgsql;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Dictionary.Design;
using Stimulsoft.Base;
using Stimulsoft.Base.Localization;

namespace Stimulsoft.Report.Dictionary
{
	public class CustomPostgreSQLAdapterService : StiSqlAdapterService
	{
        #region Properties
        public override string ServiceName => "Custom " + StiLocalization.Get("Adapters", "AdapterPostgreSQLConnection");
        #endregion

        #region Methods
        /// <summary>
        /// Returns new data connector for this type of the database.
        /// </summary>
        /// <returns>Created connector.</returns>
        public override StiSqlDataConnector CreateConnector(string connectionString = "")
        {
            return StiPostgreSqlConnector.Get(connectionString);
        }

        public override StiDataColumnsCollection GetColumnsFromData(StiData data, StiDataSource dataSource, CommandBehavior commandBehavior)
		{
			var dataColumns = new StiDataColumnsCollection();
			var sqlSource = dataSource as StiSqlSource;

			try
			{
                if (sqlSource.SqlCommand != null && sqlSource.SqlCommand.Length > 0 && data.Data is NpgsqlConnection)
                {
                    var connection = data.Data as NpgsqlConnection;
                    OpenConnection(connection, data, dataSource.Dictionary);

                    using (var dataAdapter = new NpgsqlDataAdapter(sqlSource.SqlCommand, connection))
                    using (DataTable dataTable = new DataTable())
                    {
                        dataTable.TableName = sqlSource.Name;

                        dataAdapter.SelectCommand.CommandTimeout = sqlSource.CommandTimeout;
                        dataAdapter.SelectCommand.Prepare();
                        dataAdapter.Fill(dataTable);

                        foreach (DataColumn column in dataTable.Columns)
                        {
                            dataColumns.Add(new StiDataColumn(column.ColumnName, column.Caption, column.DataType));
                        }
                    }
                    
                    CloseConnection(data, connection);
                }
            }
			catch (Exception e)
			{
				StiLogService.Write(this.GetType(), e);
                if (!StiOptions.Engine.HideExceptions) throw;
			}
			
			return dataColumns;
		}

		public override void SetDataSourceNames(StiData data, StiDataSource dataSource)
		{
			base.SetDataSourceNames(data, dataSource);

			dataSource.Name = "PostgreSQLSource";
			dataSource.Alias = "PostgreSQLSource";
		}

		public override Type GetDataSourceType()
		{
			return typeof(CustomPostgreSQLSource);
		}

		public override Type[] GetDataTypes()
		{
			return new Type[] { typeof(NpgsqlConnection) };
		}

		public override void ConnectDataSourceToData(StiDictionary dictionary, StiDataSource dataSource, bool loadData)
		{
			dataSource.Disconnect();

			if (!loadData)
			{
				dataSource.DataTable = new DataTable();
				return;
			}
			
			StiSqlSource sqlSource = dataSource as StiSqlSource;

			foreach (StiData data in dataSource.Dictionary.DataStore)
            {
                if (data.Name != sqlSource.NameInSource)continue;
                
                try
                {
                    if (!(data.Data is NpgsqlConnection))continue;
                    
                    var connection = data.ViewData as NpgsqlConnection;
                    OpenConnection(connection, data, dataSource.Dictionary);

                    sqlSource.DataAdapter = new NpgsqlDataAdapter(sqlSource.SqlCommand, connection);

                    foreach (StiDataParameter parameter in sqlSource.Parameters)
                    {
                        ((NpgsqlDataAdapter)sqlSource.DataAdapter).SelectCommand.Parameters.Add(
                            parameter.Name, (NpgsqlTypes.NpgsqlDbType)parameter.Type, parameter.Size);
                    }

                    var dataTable = new DataTable();
                    dataTable.TableName = sqlSource.Name;
                    dataSource.DataTable = dataTable;

                    sqlSource.DataAdapter.SelectCommand.CommandTimeout = sqlSource.CommandTimeout;
                    if (loadData && sqlSource.Parameters.Count > 0)
                    {
                        sqlSource.DataAdapter.SelectCommand.Prepare();
                        sqlSource.UpdateParameters();
                    }
                    else
                    {
                        if (loadData)
                        {
                            ((NpgsqlDataAdapter)sqlSource.DataAdapter).Fill(dataTable);
                            sqlSource.CheckColumnsIndexs();
                        }
                        else
                            ((NpgsqlDataAdapter)sqlSource.DataAdapter).FillSchema(dataTable, SchemaType.Source);
                    }

                    break;
                }
                catch (Exception e)
                {
                    StiLogService.Write(this.GetType(), e);
                    if (!StiOptions.Engine.HideExceptions) throw;
                }
            }
        }

        public override void CreateConnectionInDataStore(StiDictionary dictionary, StiSqlDatabase database)
		{
			try
			{
				#region Remove all old data from datastore
				int index = 0;
				foreach (StiData data in dictionary.DataStore)
				{
					if (data.Name == database.Name)
					{
						dictionary.DataStore.RemoveAt(index);
						break;
					}
					index++;
				}
				#endregion

				var sqlConnection = new NpgsqlConnection(database.ConnectionString);
				var data2 = new StiData(database.Name, sqlConnection);
				data2.IsReportData = true;
				dictionary.DataStore.Add(data2);
			}
			catch (Exception e)
			{
				StiLogService.Write(this.GetType(), e);
				if (!StiOptions.Engine.HideExceptions)throw;
			}
		}

        public override string TestConnection(string connectionString)
		{
			try
			{
				using (var sqlConnection = new NpgsqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    sqlConnection.Close();

                    return StiLocalization.Get("DesignerFx", "ConnectionSuccessfull");
                }
            }
            catch (Exception e)
            {
                return $"{StiLocalization.Get("DesignerFx", "ConnectionError")}: {e.Message}";
            }
		}
		#endregion
	}
}
