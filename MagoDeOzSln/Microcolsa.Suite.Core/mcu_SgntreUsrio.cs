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
    using Microcolsa.Suite.Core.General;
    
    public partial class mcu_SgntreUsrio
    {
        public int intId { get; set; }
        public int intIdUsrio { get; set; }
        public byte[] blobSgntre { get; set; }
    
        public virtual Usuario mcu_Usrio { get; set; }
    }
}
