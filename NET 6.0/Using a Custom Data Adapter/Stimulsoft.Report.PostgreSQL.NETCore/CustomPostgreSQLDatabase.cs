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
using System.ComponentModel;
using Stimulsoft.Base.Localization;
using Stimulsoft.Base.Serializing;
using Stimulsoft.Report.Dictionary.Design;
using Stimulsoft.Base;

namespace Stimulsoft.Report.Dictionary
{
	[TypeConverter(typeof(StiSqlDatabaseConverter))]
	public class CustomPostgreSQLDatabase : StiSqlDatabase
	{
        #region Properties
        public override string ServiceName => "Custom " + StiLocalization.Get("Database", "DatabasePostgreSQL");

        protected override string DataAdapterType => "Stimulsoft.Report.Dictionary.CustomPostgreSQLAdapterService";
        #endregion

        #region Methods
        /// <summary>
        /// Returns new data connector for this database.
        /// </summary>
        /// <returns>Created connector.</returns>
        public override StiDataConnector CreateConnector(string connectionString = null)
        {
            return StiPostgreSqlConnector.Get(connectionString);
        }

        public override void RegData(StiDictionary dictionary, bool loadData)
        {
            var adapter = GetDataAdapter();
            if (adapter == null)
                throw new Exception($"Database {GetType()} not found");

            adapter.CreateConnectionInDataStore(dictionary, this);
        }

        protected override Type GetDataAdapterType()
        {
            return typeof(CustomPostgreSQLAdapterService);
        }

        public override StiSqlSource CreateDataSource(string nameInSource, string name)
        {
            return new CustomPostgreSQLSource(nameInSource, name);
        }
        #endregion

        /// <summary>
        /// Creates a new object of the type CustomPostgreSQLDatabase.
        /// </summary>
        public CustomPostgreSQLDatabase()
            : this(string.Empty, string.Empty)
		{
		}

		/// <summary>
        /// Creates a new object of the type CustomPostgreSQLDatabase.
		/// </summary>
        public CustomPostgreSQLDatabase(string name, string connectionString)
            : base(name, connectionString)
        {
        }		

		/// <summary>
        /// Creates a new object of the type CustomPostgreSQLDatabase.
		/// </summary>
        public CustomPostgreSQLDatabase(string name, string alias, string connectionString)
            : base(name, alias, connectionString)
        {
        }

        /// <summary>
	    /// Creates a new object of the type CustomPostgreSQLDatabase.
	    /// </summary>
	    public CustomPostgreSQLDatabase(string name, string alias, string connectionString, bool promptUserNameAndpassword) 
            : base(name, alias, connectionString, promptUserNameAndpassword)
	    {
	    }

        /// <summary>
        /// Creates a new object of the type CustomPostgreSQLDatabase.
        /// </summary>
        public CustomPostgreSQLDatabase(string name, string alias, string connectionString, bool promptUserNameAndpassword, string key)
            : base(name, alias, connectionString, promptUserNameAndpassword, key)
        {
        }
	}
}
