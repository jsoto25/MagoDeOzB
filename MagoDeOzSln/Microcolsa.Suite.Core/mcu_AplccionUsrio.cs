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
    
    public partial class mcu_AplccionUsrio
    {
        public mcu_AplccionUsrio()
        {
            this.mcu_MdloAplccion = new HashSet<mcu_MdloAplccion>();
        }
    
        public int intId { get; set; }
        public byte[] Aplicacion { get; set; }
    
        public virtual ICollection<mcu_MdloAplccion> mcu_MdloAplccion { get; set; }
    }
}