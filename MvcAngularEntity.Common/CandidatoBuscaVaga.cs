//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcAngularEntity.Common
{
    using System;
    using System.Collections.Generic;
    
    public partial class CandidatoBuscaVaga
    {
        public int Id { get; set; }
        public Nullable<int> BuscaVagaId { get; set; }
        public Nullable<int> CandidatoId { get; set; }
        public Nullable<bool> Selecionado { get; set; }
    
        public virtual BuscaVaga BuscaVaga { get; set; }
        public virtual Candidato Candidato { get; set; }
    }
}
