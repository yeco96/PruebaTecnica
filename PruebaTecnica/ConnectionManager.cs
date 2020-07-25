using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PruebaTecnica
{
        public class ConnectionManager 
        {
            public IDbConnection GetConnection(string keyName)
            {
                return new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[string.Format("{0}", keyName)].ConnectionString);
            }
        }
    }

