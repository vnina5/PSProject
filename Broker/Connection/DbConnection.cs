﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Broker.Connection
{
    public class DbConnection
    {
        private SqlConnection connection;
        private SqlTransaction transaction;
        public void OpenConnection()
        {
            if (!IsReady())
            {
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PSProject"].ConnectionString);
                //connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PSProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

                connection.Open();
            }
        }

        public SqlCommand GetCommand()
        {
            if (transaction == null)
                transaction = connection.BeginTransaction();

            return new SqlCommand("", connection, transaction);
        }

        public bool IsReady()
        {
            return (connection != null) && (connection.State != ConnectionState.Closed);
        }

        public void Commit()
        {
            transaction?.Commit();
        }

        public void Rollback()
        {
            transaction?.Rollback();
        }

        public void Close()
        {
            connection?.Close();
            transaction?.Dispose();
            transaction = null;
        }
    }
}
