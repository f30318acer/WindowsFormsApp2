//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class EvaluateAllTable
    {
        public int EvaluateID { get; set; }
        public string EvaluateContent { get; set; }
        public Nullable<int> RelationID { get; set; }
        public Nullable<int> MemberID { get; set; }
        public Nullable<System.DateTime> IssusingTime { get; set; }
        public Nullable<int> ProductID { get; set; }
    
        public virtual MemberProductRelateAllTable MemberProductRelateAllTable { get; set; }
        public virtual ProductTable ProductTable { get; set; }
        public virtual MemberTable MemberTable { get; set; }
    }
}