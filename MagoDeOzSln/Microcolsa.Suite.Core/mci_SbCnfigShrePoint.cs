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
    
    public partial class mci_SbCnfigShrePoint
    {
        public mci_SbCnfigShrePoint()
        {
            this.mci_TpoArchvdor = new HashSet<TipoArchivador>();
        }
    
        public int Id { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<TipoArchivador> mci_TpoArchvdor { get; set; }
    }
}
