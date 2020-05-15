using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.domain
{
    public abstract class BaseDomain
    {
        public BaseDomain()
        {
            this.SqlConnection = new SqlConnection(@"data source=PC0446\MSSQL2017;initial catalog=ZomatoDb;Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework");
            this.SqlConnection.Open();
        }
        public SqlDataReader GetReader(string commandText)
        {
            this.SqlCommand = new SqlCommand(commandText, this.SqlConnection);
            return this.SqlCommand.ExecuteReader();

        }
        public void ExecuteNonQuery(string commandText)
        {
            
            this.SqlCommand = new SqlCommand(commandText, this.SqlConnection);
            this.SqlCommand.ExecuteNonQuery();
        }
        public void CloseConnection()
        {
            this.SqlConnection.Close();
        }

        private SqlConnection SqlConnection { get; set; }
        protected SqlCommand SqlCommand { get; set; }
    }
}