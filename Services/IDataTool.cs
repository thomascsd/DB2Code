using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DB2Code
{
    public interface IDataTool
    {
        DataTable GetDataTable(string sqlStr);

        DataTable GetSchema(string sqlStr);
    }

    /// <summary>
    /// MsSql的連結資料庫工具
    /// </summary>
    public class DataToolMSSQL : IDataTool
    {
        private SqlConnection mCon;

        public DataToolMSSQL(string constring)
        {
            this.mCon = new SqlConnection(constring);
        }

        DataTable IDataTool.GetDataTable(string sqlStr)
        {
            SqlCommand cmd = new SqlCommand(sqlStr, this.mCon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            cmd.Dispose();
            this.mCon.Close();
            return dt;
        }

        DataTable IDataTool.GetSchema(string sqlStr)
        {
            SqlCommand cmd = new SqlCommand(sqlStr, this.mCon);
            DataTable dt = new DataTable();
            SqlDataReader dr;
            this.mCon.Open();
            dr = cmd.ExecuteReader(CommandBehavior.KeyInfo);
            dt = dr.GetSchemaTable();
            dr.Close();
            this.mCon.Close();
            cmd.Dispose();
            return dt;
        }
    }

    /// <summary>
    /// Access的連結資料庫工具
    /// </summary>
    public class DataToolAccess : IDataTool
    {
        private OleDbConnection mCon;

        public DataToolAccess(string constring)
        {
            this.mCon = new OleDbConnection(constring);
        }

        DataTable IDataTool.GetDataTable(string sqlStr)
        {
            OleDbCommand cmd = new OleDbCommand(sqlStr, this.mCon);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Dispose();
            this.mCon.Close();
            return dt;
        }

        DataTable IDataTool.GetSchema(string sqlStr)
        {
            OleDbCommand cmd = new OleDbCommand(sqlStr, this.mCon);
            DataTable dt = new DataTable();
            OleDbDataReader dr;

            this.mCon.Open();
            dr = cmd.ExecuteReader(CommandBehavior.KeyInfo);
            dt = dr.GetSchemaTable();
            dr.Close();
            this.mCon.Close();
            cmd.Dispose();
            return dt;
        }
    }

    public class DataToolODBC : IDataTool
    {
        private System.Data.Odbc.OdbcConnection mCon;

        public DataToolODBC(string conString)
        {
            this.mCon = new System.Data.Odbc.OdbcConnection(conString);
        }

        #region IDataTool 成員

        public DataTable GetDataTable(string SQLstr)
        {
            DataTable dt = new DataTable();
            System.Data.Odbc.OdbcDataAdapter da;
            System.Data.Odbc.OdbcCommand cmd = new System.Data.Odbc.OdbcCommand(SQLstr, this.mCon);

            da = new System.Data.Odbc.OdbcDataAdapter(cmd);
            da.Fill(dt);

            this.mCon.Close();
            cmd.Dispose();

            return dt;
        }

        public DataTable GetSchema(string SQLstr)
        {
            System.Data.Odbc.OdbcCommand cmd = new System.Data.Odbc.OdbcCommand(SQLstr, this.mCon);
            System.Data.Odbc.OdbcDataReader dr;
            DataTable dt = new DataTable();

            this.mCon.Open();
            dr = cmd.ExecuteReader(CommandBehavior.KeyInfo);
            dt = dr.GetSchemaTable();

            dr.Close();
            cmd.Dispose();
            this.mCon.Close();

            return dt;
        }

        #endregion IDataTool 成員
    }
}