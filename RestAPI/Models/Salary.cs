//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Salary
    {
        public int Id { get; set; }
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Nullable<System.DateTime> DateNaissance { get; set; }
        public string Adresse { get; set; }
        public string TypeContrat { get; set; }
        public string Photo { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public Nullable<bool> Responsable { get; set; }
        public Nullable<int> IdService { get; set; }
    
        public virtual Service Service { get; set; }
    }
}