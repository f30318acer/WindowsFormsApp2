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
    
    public partial class SocialRelationTable
    {
        public int FirstMemberID { get; set; }
        public int SecondMemberID { get; set; }
        public int SocialRelationID { get; set; }
        public int RelationshipStatusID { get; set; }
    
        public virtual MemberRelationshipAllTable MemberRelationshipAllTable { get; set; }
        public virtual MemberTable MemberTable { get; set; }
        public virtual MemberTable MemberTable1 { get; set; }
    }
}
