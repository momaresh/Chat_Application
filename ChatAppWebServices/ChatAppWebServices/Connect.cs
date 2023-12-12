using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace ChatAppWebServices
{
    public class Connect
    {
        private SqlConnection _conn;
        private SqlCommand _command;
        private DataSet _reader;
        private SqlDataAdapter _adapter;
        private string conStr;

        public Connect()
        {
            conStr = @"Data Source=Mo_Maresh;Initial Catalog=ChatDB;Integrated Security=True";
            _conn = new SqlConnection(conStr);
        }

        public DataSet Reader(string query)
        {
            _conn.Open();
            _command = new SqlCommand();
            _command.Connection = _conn;
            _reader = new DataSet();
            _adapter = new SqlDataAdapter(query, conStr);
            _adapter.Fill(_reader, "Table");
            _conn.Close();
            return _reader;
        }

        public int Writer(string query)
        {
            int x;
            _conn.Open();
            _command = new SqlCommand();
            _command.Connection = _conn;

            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }

            _command.CommandText = query;
            x = _command.ExecuteNonQuery();
            _conn.Close();
            return x;
        }
    }
}