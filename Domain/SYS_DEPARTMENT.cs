//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYS_DEPARTMENT
    {
        public SYS_DEPARTMENT()
        {
            this.SYS_POST_DEPARTMENT = new HashSet<SYS_POST_DEPARTMENT>();
            this.SYS_USER_DEPARTMENT = new HashSet<SYS_USER_DEPARTMENT>();
        }
    
        public string ID { get; set; }
        public string CODE { get; set; }
        public string NAME { get; set; }
        public Nullable<int> BUSINESSLEVEL { get; set; }
        public Nullable<int> SHOWORDER { get; set; }
        public string CREATEPERID { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public string PARENTID { get; set; }
        public Nullable<System.DateTime> UPDATEDATE { get; set; }
        public string UPDATEUSER { get; set; }
        public string PARENTCODE { get; set; }
    
        public virtual ICollection<SYS_POST_DEPARTMENT> SYS_POST_DEPARTMENT { get; set; }
        public virtual ICollection<SYS_USER_DEPARTMENT> SYS_USER_DEPARTMENT { get; set; }
    }
}
