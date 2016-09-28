using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace MySchool
{
    /// <summary>
    /// ����ά�����ݿ������ַ������� Connection ����
    /// </summary>
  public class DBHelper
    {
        // ���ݿ������ַ���
        private string connString = @"Data Source=DESKTOP-GMMJE92;Initial Catalog=MySchool;Integrated Security=True";

        // ���ݿ����� Connection ����
        private SqlConnection connection;

        /// <summary>
        /// Connection����
        /// </summary>
        public SqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new SqlConnection(connString);
                }
                return connection;
            }            
        }

        /// <summary>
        /// �����ݿ�����
        /// </summary>
        public void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            else if (Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
                Connection.Open();
            }
        }

        /// <summary>
        /// �ر����ݿ�����
        /// </summary>
        public void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open || Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
            }
        }
    }
}
