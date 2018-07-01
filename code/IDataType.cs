using System.CodeDom;
using System.Data;
using System.Data.OleDb;

namespace DB2Code
{
    internal interface IDataType
    {
        CodeSnippetExpression GetDataType(string type);
    }

    public class MSSQLDataType : IDataType
    {
        CodeSnippetExpression IDataType.GetDataType(string type)
        {
            string name = typeof(SqlDbType).Name + ".";
            CodeSnippetExpression cs = new CodeSnippetExpression();

            switch (type)
            {
                case "System.String":
                    cs.Value = name + SqlDbType.NVarChar.ToString();
                    break;

                case "System.Int32":
                    cs.Value = name + SqlDbType.Int.ToString();
                    break;

                case "System.Demimal":
                    cs.Value = name + SqlDbType.Decimal.ToString();
                    break;

                case "System.DateTime":
                    cs.Value = name + SqlDbType.Date.ToString();
                    break;

                default:
                    break;
            }

            return cs;
        }
    }

    public class AccessDataType : IDataType
    {
        CodeSnippetExpression IDataType.GetDataType(string type)
        {
            string name = typeof(OleDbType).Name + ".";
            CodeSnippetExpression cs = new CodeSnippetExpression();

            switch (type)
            {
                case "System.String":
                    cs.Value = name + OleDbType.VarChar.ToString();
                    break;

                case "System.Int32":
                    cs.Value = name + OleDbType.Integer.ToString();
                    break;

                case "System.Demimal":
                    cs.Value = name + OleDbType.Decimal.ToString();
                    break;

                case "System.DateTime":
                    cs.Value = name + OleDbType.Date.ToString();
                    break;

                default:
                    break;
            }

            return cs;
        }
    }
}