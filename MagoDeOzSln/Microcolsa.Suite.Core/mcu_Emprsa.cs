//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microcolsa.Suite.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class mcu_Emprsa
    {
        public mcu_Emprsa()
        {
            this.mcu_Dpndncia = new HashSet<mcu_Dpndncia>();
        }
    
        public int intId { get; set; }
        public string strNit { get; set; }
        public string strNmbre { get; set; }
    
        public virtual ICollection<mcu_Dpndncia> mcu_Dpndncia { get; set; }
    }
}