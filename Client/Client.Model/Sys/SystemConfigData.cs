using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Client.Model.Sys
{
    [System.ComponentModel.DesignerCategory("系统配置")]
    [System.Serializable()]
    public class SystemConfigData : DataSet
    {
        public const string BaseSys_Configuration_CONFIGURENO = "CONFIGURENO";
        public const string BaseSys_Configuration_SETTYPE = "SETTYPE";
        public const string BaseSys_Configuration_SETCONTENT = "SETCONTENT";
        public const string BaseSys_Configuration_DEFAULTVALUE = "DEFAULTVALUE";
        public const string BaseSys_Configuration_DETAIL = "DETAIL";
        public const string BaseSys_Configuration_OPTIONALPARA = "OPTIONALPARA";

        private SystemConfigData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
        public SystemConfigData()
        {
            DataTable table = new DataTable("BaseSys_Configuration");
            table.Columns.Add("CONFIGURENO", typeof(System.String));
            table.Columns.Add("SETTYPE", typeof(System.String));
            table.Columns.Add("SETCONTENT", typeof(System.String));
            table.Columns.Add("DEFAULTVALUE", typeof(System.String));
            table.Columns.Add("DETAIL", typeof(System.String));
            table.Columns.Add("OPTIONALPARA", typeof(System.String));

            System.Collections.Generic.List<DataColumn> list = new System.Collections.Generic.List<DataColumn>();
            list.Add(table.Columns["CONFIGURENO"]);
            table.PrimaryKey = list.ToArray();

            this.Tables.Add(table);
        }
    }
}
