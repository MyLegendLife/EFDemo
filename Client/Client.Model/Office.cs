//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Office
    {
        public string Officeid { get; set; }
        public string Office1 { get; set; }
        public string CodeNo { get; set; }
        public string SpellNo { get; set; }
        public string CustomNo { get; set; }
        public string StrokeNo { get; set; }
        public string Department { get; set; }
        public Nullable<int> Parentid { get; set; }
        public int hasChild { get; set; }
        public Nullable<int> BedAmount { get; set; }
        public string DiseaseArea { get; set; }
        public string OfficeType { get; set; }
        public string Workkind { get; set; }
        public Nullable<int> LimitFund { get; set; }
        public string ServiceObject { get; set; }
        public Nullable<int> Link { get; set; }
        public string OfficeAddress { get; set; }
        public string Explanation { get; set; }
        public int StopFlag { get; set; }
        public Nullable<System.DateTime> StopDate { get; set; }
        public string StopOperator { get; set; }
        public string position { get; set; }
    }
}
