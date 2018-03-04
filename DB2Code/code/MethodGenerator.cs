using System.CodeDom;
using System.Collections.Generic;
using System.Data;

namespace DB2Code
{
    internal class MethodGenerator
    {
        private CodeVariableDeclarationStatement mCmd, mSql, mDr;
        private MethodGenerateOptions mOptions;
        private List<CodeMemberMethod> mMemberMethods;

        /// <summary>
        /// 型別方法的集合
        /// </summary>
        public List<CodeMemberMethod> MemberMethods
        {
            get { return mMemberMethods; }
            set { mMemberMethods = value; }
        }

        public MethodGenerator(MethodGenerateOptions options)
        {
            this.mOptions = options;
            this.mCmd = new CodeVariableDeclarationStatement(this.mOptions.CommandName, "cmd");
            this.mSql = new CodeVariableDeclarationStatement(typeof(string), "sqlStr");
            this.mDr = new CodeVariableDeclarationStatement(this.mOptions.DataReaderName, "dr");
            this.mMemberMethods = new List<CodeMemberMethod>();
        }

        public void CreateMethod(MethodType methodtype)
        {
            switch (methodtype)
            {
                case MethodType.Select:
                    this.CrateSelect();
                    break;

                case MethodType.Insert:
                    this.CreateInset();
                    break;

                case MethodType.Update:
                    this.CreateUpdate();
                    break;

                default:
                    break;
            }
        }

        #region"Select"

        private void CrateSelect()
        {
            CodeMemberMethod memberMethod;

            memberMethod = this.CreateGetData("AllData");
            this.mMemberMethods.Add(memberMethod);

            memberMethod = this.CreateGetData("ByKey");
            this.mMemberMethods.Add(memberMethod);

            memberMethod = this.CreateGetObjectMethod(this.mOptions.DataTable);
            this.mMemberMethods.Add(memberMethod);
        }

        /// <summary>
        /// 產生取得資料的方法
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private CodeMemberMethod CreateGetData(string type)
        {
            string typeName = string.Format("{0}Data", this.mOptions.TableName);
            CodeMemberMethod memberMethod = new CodeMemberMethod();
            CodeAssignStatement codeAssign;
            CodeObjectCreateExpression obj;
            CodeIterationStatement whileLoop;
            CodeVariableDeclarationStatement codeVar;
            CodeMethodInvokeExpression methodInvoke;
            //建立泛型型別
            CodeTypeReference typeReference = new CodeTypeReference();
            typeReference.BaseType = string.Format("System.Collections.Generic.List`1[{0}Data]", this.mOptions.TableName);

            //設定方法的基本屬性
            memberMethod.ReturnType = typeReference;
            if (type == "AllData")
            {
                //GetAllData
                memberMethod.Attributes = MemberAttributes.Public;
                memberMethod.Name = "GetAllData";
                memberMethod.CustomAttributes.Add(new CodeAttributeDeclaration("System.ComponentModel.DataObjectMethod", new CodeAttributeArgument(new CodeSnippetExpression("System.ComponentModel.DataObjectMethodType.Select"))));
            }
            else
            {
                //GetDataByKey
                memberMethod.Attributes = MemberAttributes.Private;
                memberMethod.Name = "GetDataBykey";
                memberMethod.Parameters.Add(new CodeParameterDeclarationExpression(typeof(string), "key"));
                memberMethod.Parameters.Add(new CodeParameterDeclarationExpression(typeof(string), "value"));
            }

            //變數宣告
            memberMethod.Statements.Add(this.mSql);
            memberMethod.Statements.Add(this.mCmd);
            memberMethod.Statements.Add(this.mDr);
            //xxData data;
            codeVar = new CodeVariableDeclarationStatement(typeName, "data");
            memberMethod.Statements.Add(codeVar);
            //List<xx> datas = new List<xx>();
            obj = new CodeObjectCreateExpression(typeReference, new CodeExpression[] { });
            codeVar = new CodeVariableDeclarationStatement(typeReference, "datas", obj);
            memberMethod.Statements.Add(codeVar);

            //設定Sql字串
            if (type == "AllData")
            {
                codeAssign = new CodeAssignStatement(new CodeVariableReferenceExpression("sqlStr"), new CodePrimitiveExpression("Select * From " + this.mOptions.TableName));
                memberMethod.Statements.Add(codeAssign);
            }
            else
            {
                methodInvoke = new CodeMethodInvokeExpression(new CodeSnippetExpression("string"), "Format", new CodeSnippetExpression("\"Select * From " + this.mOptions.TableName + " Where {0} = @{0}\""), new CodeVariableReferenceExpression("key"));
                codeAssign = new CodeAssignStatement(new CodeVariableReferenceExpression("sqlStr"), methodInvoke);
                memberMethod.Statements.Add(codeAssign);
            }

            //cmd的初始化
            //cmd = new iDB2Command(sqlStr,con);
            obj = new CodeObjectCreateExpression(new CodeTypeReference(this.mOptions.CommandName), new CodeExpression[] { new CodeVariableReferenceExpression("sqlStr"), new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "mCon") });
            codeAssign = new CodeAssignStatement(new CodeVariableReferenceExpression("cmd"), obj);
            memberMethod.Statements.Add(codeAssign);

            //Command加入參數
            if (type == "ByKey")
            {
                CodePropertyReferenceExpression codeProperty;

                //cmd.Parameters.AddWithValue("@"+key, value);
                codeProperty = new CodePropertyReferenceExpression(new CodeVariableReferenceExpression("cmd"), "Parameters");

                methodInvoke = new CodeMethodInvokeExpression(codeProperty, "AddWithValue", new CodeExpression[] { new CodeSnippetExpression("\"@\" + key"), new CodeVariableReferenceExpression("value") });
                memberMethod.Statements.Add(methodInvoke);
            }

            memberMethod.Statements.Add(new CodeMethodInvokeExpression(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "mCon"), "Open", new CodeExpression[] { }));

            //dr = cmd.ExecuteReader();
            codeAssign = new CodeAssignStatement(new CodeVariableReferenceExpression("dr"), new CodeMethodInvokeExpression(new CodeVariableReferenceExpression("cmd"), "ExecuteReader", new CodeExpression[] { }));
            memberMethod.Statements.Add(codeAssign);

            //white迴圈
            whileLoop = new CodeIterationStatement();
            //while(dr.Read())
            //{
            methodInvoke = new CodeMethodInvokeExpression(new CodeVariableReferenceExpression("dr"), "Read", new CodeExpression[] { });

            whileLoop.InitStatement = new CodeExpressionStatement(new CodeSnippetExpression(""));
            whileLoop.TestExpression = methodInvoke;
            whileLoop.IncrementStatement = new CodeExpressionStatement(new CodeSnippetExpression(""));

            //data = this.Getxx(dr);
            methodInvoke = new CodeMethodInvokeExpression(new CodeThisReferenceExpression(), "Get" + this.mOptions.TableName, new CodeExpression[] { new CodeVariableReferenceExpression("dr") });
            codeAssign = new CodeAssignStatement(new CodeVariableReferenceExpression("data"), methodInvoke);
            whileLoop.Statements.Add(codeAssign);

            whileLoop.Statements.Add(new CodeMethodInvokeExpression(new CodeVariableReferenceExpression("datas"), "Add", new CodeExpression[] { new CodeVariableReferenceExpression("data") }));

            memberMethod.Statements.Add(whileLoop);

            memberMethod.Statements.Add(new CodeMethodInvokeExpression(new CodeVariableReferenceExpression("dr"), "Close", new CodeExpression[] { }));

            memberMethod.Statements.Add(new CodeMethodInvokeExpression(new CodeVariableReferenceExpression("cmd"), "Dispose", new CodeExpression[] { }));

            memberMethod.Statements.Add(new CodeMethodInvokeExpression(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "mCon"), "Close", new CodeExpression[] { }));

            memberMethod.Statements.Add(new CodeMethodReturnStatement(new CodeVariableReferenceExpression("datas")));

            return memberMethod;
        }

        /// <summary>
        /// 產生取得物件的方法
        /// </summary>
        /// <param name="dt"></param>
        private CodeMemberMethod CreateGetObjectMethod(DataTable dt)
        {
            string columnName;
            CodeAssignStatement codeAssign;
            CodeMemberMethod memberMethod = new CodeMemberMethod();
            CodeVariableDeclarationStatement codeVar;
            CodeObjectCreateExpression obj;

            memberMethod.Attributes = MemberAttributes.Private;
            memberMethod.Name = string.Format("Get{0}", this.mOptions.TableName);
            memberMethod.ReturnType = new CodeTypeReference(this.mOptions.TableName + "Data");
            memberMethod.Parameters.Add(new CodeParameterDeclarationExpression(this.mOptions.DataReaderName, "dr"));

            //xx data = new xxx();
            obj = new CodeObjectCreateExpression(this.mOptions.TableName + "Data", new CodeExpression[] { });
            codeVar = new CodeVariableDeclarationStatement(this.mOptions.TableName + "Data", "data", obj);
            memberMethod.Statements.Add(codeVar);

            foreach (DataRow row in dt.Rows)
            {
                CodePropertyReferenceExpression property = new CodePropertyReferenceExpression();
                CodeCastExpression cast = new CodeCastExpression();
                CodeMethodInvokeExpression method;
                columnName = row["ColumnName"].ToString();
                string[] types = row["DataType"].ToString().Split(',');

                property.TargetObject = new CodeVariableReferenceExpression("data");
                property.PropertyName = columnName;

                if (types[0] == "System.String")
                {
                    //data.xx = dr["xx"].ToString()
                    method = new CodeMethodInvokeExpression(new CodeIndexerExpression(new CodeVariableReferenceExpression("dr"), new CodeSnippetExpression("\"" + columnName + "\"")), "ToString", new CodeExpression[] { });
                    codeAssign = new CodeAssignStatement(property, method);
                }
                else
                {
                    //data.xx = (int)dr["xx"]
                    cast.TargetType = new CodeTypeReference(types[0]);
                    cast.Expression = new CodeIndexerExpression(new CodeVariableReferenceExpression("dr"), new CodeSnippetExpression("\"" + columnName + "\""));

                    codeAssign = new CodeAssignStatement(property, cast);
                }

                memberMethod.Statements.Add(codeAssign);
            }
            memberMethod.Statements.Add(new CodeMethodReturnStatement(new CodeVariableReferenceExpression("data")));

            return memberMethod;
        }

        #endregion

        #region"Insert"

        private void CreateInset()
        {
            string typeName = string.Format("{0}Data", this.mOptions.TableName);
            CodeMemberMethod memberMethod = new CodeMemberMethod();
            CodeAssignStatement codeAssign;
            CodeObjectCreateExpression obj;
            //設定方法的基本屬性
            memberMethod.Attributes = MemberAttributes.Public;
            memberMethod.ReturnType = new CodeTypeReference("System.Void");
            memberMethod.Name = "Insert";
            memberMethod.CustomAttributes.Add(new CodeAttributeDeclaration("System.ComponentModel.DataObjectMethod", new CodeAttributeArgument(new CodeSnippetExpression("System.ComponentModel.DataObjectMethodType.Insert"))));
            //設定參數
            memberMethod.Parameters.Add(new CodeParameterDeclarationExpression(typeName, "data"));

            memberMethod.Statements.Add(this.mSql);
            memberMethod.Statements.Add(this.mCmd);

            //Sqlstr(Insert)字串
            codeAssign = new CodeAssignStatement(new CodeVariableReferenceExpression("sqlStr"), new CodePrimitiveExpression(SqlGenerator.CreateInsertSql(this.mOptions.TableName, this.mOptions.DataTable)));
            memberMethod.Statements.Add(codeAssign);

            //cmd的初始化
            //cmd = new iDB2Command(sqlStr,con);
            obj = new CodeObjectCreateExpression(new CodeTypeReference(this.mOptions.CommandName), new CodeExpression[] { new CodeVariableReferenceExpression("sqlStr"), new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "mCon") });
            codeAssign = new CodeAssignStatement(new CodeVariableReferenceExpression("cmd"), obj);
            memberMethod.Statements.Add(codeAssign);

            //新增
            foreach (DataRow row in this.mOptions.DataTable.Rows)
            {
                if (this.mOptions.DataBaseType == AccessDataBaseType.DB2)
                {
                    codeAssign = this.GetCodeAssign(row);
                    memberMethod.Statements.Add(codeAssign);
                }
                else
                {
                    memberMethod.Statements.Add(this.GetMethod(row));
                }
            }

            memberMethod.Statements.Add(new CodeMethodInvokeExpression(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "mCon"), "Open", new CodeExpression[] { }));

            memberMethod.Statements.Add(new CodeMethodInvokeExpression(new CodeVariableReferenceExpression("cmd"), "ExecuteNonQuery", new CodeExpression[] { }));

            memberMethod.Statements.Add(new CodeMethodInvokeExpression(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "mCon"), "Close", new CodeExpression[] { }));
            memberMethod.Statements.Add(new CodeMethodInvokeExpression(new CodeVariableReferenceExpression("cmd"), "Dispose", new CodeExpression[] { }));

            this.mMemberMethods.Add(memberMethod);
        }

        #endregion

        #region"Update"

        private void CreateUpdate()
        {
            string typeName = string.Format("{0}Data", this.mOptions.TableName);
            string columnName;
            CodeMemberMethod memberMethod = new CodeMemberMethod();
            CodeAssignStatement codeAssign;
            CodeObjectCreateExpression obj;
            List<string> names = new List<string>(); //欄位名稱
            List<string> keys = new List<string>();//主索引值

            //設定方法的基本屬性
            memberMethod.Attributes = MemberAttributes.Public;
            memberMethod.ReturnType = new CodeTypeReference("System.Void");
            memberMethod.Name = "Update";
            //設定參數
            memberMethod.Parameters.Add(new CodeParameterDeclarationExpression(typeName, "data"));
            memberMethod.CustomAttributes.Add(new CodeAttributeDeclaration("System.ComponentModel.DataObjectMethod", new CodeAttributeArgument(new CodeSnippetExpression("System.ComponentModel.DataObjectMethodType.Update"))));

            memberMethod.Statements.Add(this.mSql);
            memberMethod.Statements.Add(this.mCmd);

            //Sqlstr(update)
            codeAssign = new CodeAssignStatement(new CodeVariableReferenceExpression("sqlStr"), new CodePrimitiveExpression(SqlGenerator.CreateUpdateSql(this.mOptions.DataTable, this.mOptions.TableName, this.mOptions.SchemakeyName, this.mOptions.KeyColumnNames)));
            memberMethod.Statements.Add(codeAssign);

            //cmd的初始化
            //cmd = new iDB2Command(sqlStr,con);
            obj = new CodeObjectCreateExpression(new CodeTypeReference(this.mOptions.CommandName), new CodeExpression[] { new CodeVariableReferenceExpression("sqlStr"), new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "mCon") });
            codeAssign = new CodeAssignStatement(new CodeVariableReferenceExpression("cmd"), obj);
            memberMethod.Statements.Add(codeAssign);

            if (this.mOptions.KeyColumnNames.Count > 0)
            {
                //有指定屬於PK的欄位
                keys = this.mOptions.KeyColumnNames;

                foreach (DataRow row in this.mOptions.DataTable.Rows)
                {
                    columnName = row["ColumnName"].ToString();
                    if (!keys.Contains(columnName))
                    {
                        names.Add(columnName);
                    }
                }
            }
            else
            {
                //在資料表結構中，有指定表示該欄位屬於主索引值的名稱
                foreach (DataRow row in this.mOptions.DataTable.Rows)
                {
                    columnName = row["ColumnName"].ToString();
                    if ((bool)row[this.mOptions.SchemakeyName])
                    {
                        keys.Add(columnName);
                    }
                    else
                    {
                        names.Add(columnName);
                    }
                }
            }

            foreach (DataRow row in this.mOptions.DataTable.Rows)
            {
                columnName = row["ColumnName"].ToString();
                //不是pk的欄位
                if (names.Contains(columnName))
                {
                    if (this.mOptions.DataBaseType == AccessDataBaseType.DB2)
                    {
                        codeAssign = this.GetCodeAssign(row);
                        memberMethod.Statements.Add(codeAssign);
                    }
                    else
                    {
                        memberMethod.Statements.Add(this.GetMethod(row));
                    }
                }
            }

            foreach (DataRow row in this.mOptions.DataTable.Rows)
            {
                columnName = row["ColumnName"].ToString();
                //是主索引pk的欄位
                if (keys.Contains(columnName))
                {
                    if (this.mOptions.DataBaseType == AccessDataBaseType.DB2)
                    {
                        codeAssign = this.GetCodeAssign(row);
                        memberMethod.Statements.Add(codeAssign);
                    }
                    else
                    {
                        memberMethod.Statements.Add(this.GetMethod(row));
                    }
                }
            }

            memberMethod.Statements.Add(new CodeMethodInvokeExpression(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "mCon"), "Open", new CodeExpression[] { }));

            memberMethod.Statements.Add(new CodeMethodInvokeExpression(new CodeVariableReferenceExpression("cmd"), "ExecuteNonQuery", new CodeExpression[] { }));

            memberMethod.Statements.Add(new CodeMethodInvokeExpression(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), "mCon"), "Close", new CodeExpression[] { }));
            memberMethod.Statements.Add(new CodeMethodInvokeExpression(new CodeVariableReferenceExpression("cmd"), "Dispose", new CodeExpression[] { }));

            this.mMemberMethods.Add(memberMethod);
        }

        #endregion

        #region"Insert、Update共同方法"

        /// <summary>
        /// 取得Command的Parameter
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private CodeMethodInvokeExpression GetMethod(DataRow row)
        {
            string[] types = row["DataType"].ToString().Split(',');
            CodeAssignStatement codeAssign = new CodeAssignStatement();
            CodePropertyReferenceExpression codeProperty;
            CodeMethodInvokeExpression codeMethod;

            //cmd.Parameters.AddWithValue("@xx", data.xx);
            codeProperty = new CodePropertyReferenceExpression(new CodeVariableReferenceExpression("cmd"), "Parameters");

            codeMethod = new CodeMethodInvokeExpression(codeProperty, "AddWithValue", new CodeExpression[] { new CodePrimitiveExpression(string.Format("@{0}", row["ColumnName"])), new CodePropertyReferenceExpression(new CodeVariableReferenceExpression("data"), row["ColumnName"].ToString()) });

            return codeMethod;
        }

        /// <summary>
        /// 只有SA400才用
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private CodeAssignStatement GetCodeAssign(DataRow row)
        {
            string[] types = row["DataType"].ToString().Split(',');
            CodeAssignStatement codeAssign = new CodeAssignStatement();
            CodePropertyReferenceExpression codeProperty, codePropertyMethod;
            CodeMethodInvokeExpression codeMethod;

            //cmd.Parameters.Add("@xx",iDB2DbType.iDB2Decimal").Value = data.xx;
            codeProperty = new CodePropertyReferenceExpression(new CodeVariableReferenceExpression("cmd"), "Parameters");

            codeMethod = new CodeMethodInvokeExpression(codeProperty, "Add", new CodeExpression[] { new CodePrimitiveExpression(string.Format("@{0}", row["ColumnName"])), this.GetDataType(types[0]) });

            codePropertyMethod = new CodePropertyReferenceExpression(codeMethod, "Value");

            codeAssign.Left = codePropertyMethod;
            codeAssign.Right = new CodePropertyReferenceExpression(new CodeVariableReferenceExpression("data"), row["ColumnName"].ToString());

            return codeAssign;
        }

        private CodeSnippetExpression GetDataType(string type)
        {
            IDataType de = null;
            CodeSnippetExpression cs = new CodeSnippetExpression();

            switch (this.mOptions.DataBaseType)
            {
                case AccessDataBaseType.DB2:
                    de = new DB2DataType();
                    break;

                case AccessDataBaseType.MSSQL:
                    de = new MSSQLDataType();
                    break;

                case AccessDataBaseType.Access:
                    de = new AccessDataType();
                    break;
            }
            cs = de.GetDataType(type);

            return cs;
        }

        #endregion
    }

    internal class MethodGenerateOptions
    {
        #region"Property
        private AccessDataBaseType mDatabaseType;

        public AccessDataBaseType DataBaseType
        {
            get { return mDatabaseType; }
            set { mDatabaseType = value; }
        }

        private string mTableName;

        public string TableName
        {
            get { return mTableName; }
            set { mTableName = value; }
        }

        private string mCommandName;

        public string CommandName
        {
            get { return mCommandName; }
            set { mCommandName = value; }
        }

        private string mDataReaderName;

        public string DataReaderName
        {
            get { return mDataReaderName; }
            set { mDataReaderName = value; }
        }

        private List<string> mkeyColumnNames;

        public List<string> KeyColumnNames
        {
            get { return mkeyColumnNames; }
            set { mkeyColumnNames = value; }
        }

        private string mSchemaKeyName;

        public string SchemakeyName
        {
            get { return mSchemaKeyName; }
            set { mSchemaKeyName = value; }
        }

        private DataTable mDataTable;

        public DataTable DataTable
        {
            get { return mDataTable; }
            set { mDataTable = value; }
        }

        #endregion

        public MethodGenerateOptions()
        {
            this.mkeyColumnNames = new List<string>();
        }
    }
}