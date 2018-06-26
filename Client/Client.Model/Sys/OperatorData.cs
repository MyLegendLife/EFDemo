using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Client.Model.Sys
{
    [System.ComponentModel.DesignerCategory("操作员")]
    [System.Serializable()]
    public class OperatorData : DataSet
    {
        public const string BaseSys_Operator_ROLE = "ROLE";
        public const string BaseSys_Operator_ROLEID = "ROLEID";
        public const string BaseSys_Operator_USERID = "USERID";
        public const string BaseSys_Operator_OPERATORNAME = "OPERATORNAME";
        public const string BaseSys_Operator_OPERATORID = "OPERATORID";
        public const string BaseSys_Operator_CODENO = "CODENO";
        public const string BaseSys_Operator_PASSWORD = "PASSWORD";

        public const string T_OPERATOR_PRIVILEGE_OPERATORID = "OPERATORID";
        public const string T_OPERATOR_PRIVILEGE_NODENAME = "NODENAME";
        public const string T_OPERATOR_PRIVILEGE_IMAGE = "IMAGE";
        public const string T_OPERATOR_PRIVILEGE_COMMENTARY = "COMMENTARY";
        public const string T_OPERATOR_PRIVILEGE_PLUGINID = "PLUGINID";
        public const string T_OPERATOR_PRIVILEGE_NODEID = "NODEID";
        public const string T_OPERATOR_PRIVILEGE_PRIVID = "PRIVID";
        public const string T_OPERATOR_PRIVILEGE_PARENTNODE = "PARENTNODE";
        public const string T_OPERATOR_PRIVILEGE_ISENDNODE = "ISENDNODE";
        public const string T_OPERATOR_PRIVILEGE_ISTOOLBAR = "ISTOOLBAR";

        public OperatorData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
        public OperatorData()
        {
            DataTable table = new DataTable("BaseSys_Operator");
            table.Columns.Add("ROLE", typeof(System.String));
            table.Columns.Add("ROLEID", typeof(System.String));
            table.Columns.Add("USERID", typeof(System.String));
            table.Columns.Add("OPERATORNAME", typeof(System.String));
            table.Columns.Add("OPERATORID", typeof(System.String));
            table.Columns.Add("CODENO", typeof(System.String));
            table.Columns.Add("PASSWORD", typeof(System.String));

            System.Collections.Generic.List<DataColumn> list = new System.Collections.Generic.List<DataColumn>();
            list.Add(table.Columns["OPERATORID"]);
            table.PrimaryKey = list.ToArray();

            this.Tables.Add(table);

            table = new DataTable("BaseSys_OperatorMenuAuthority");
            table.Columns.Add("OPERATORID", typeof(System.String));
            table.Columns.Add("NODENAME", typeof(System.String));
            table.Columns.Add("IMAGE", typeof(System.Byte[]));
            table.Columns.Add("COMMENTARY", typeof(System.String));
            table.Columns.Add("PLUGINID", typeof(System.String));
            table.Columns.Add("NODEID", typeof(System.String));
            table.Columns.Add("PRIVID", typeof(System.String));
            table.Columns.Add("PARENTNODE", typeof(System.String));
            table.Columns.Add("ISENDNODE", typeof(System.String));
            //table.Columns.Add("ISTOOLBAR", typeof(System.Int32));
            //table.Columns.Add("BARCAPTION", typeof(System.String));
            //table.Columns.Add("BARORDER", typeof(System.Int32));


            this.Tables.Add(table);
            this.Relations.Add(this.Tables[0].Columns[4], this.Tables[1].Columns[0]);
        }
    }
}
