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
    
    public partial class mcu_MdloAplccion
    {
        public int intId { get; set; }
        public Nullable<int> intIdAplccion { get; set; }
        public string strNmbre { get; set; }
        public string strDscrpcion { get; set; }
    
        public virtual mcu_AplccionUsrio mcu_AplccionUsrio { get; set; }
    }
}
