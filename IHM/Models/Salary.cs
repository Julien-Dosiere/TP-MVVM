using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHM.Models
{
    class Salary
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

        // public int AdresseId { get; set; }
        public virtual Service Service { get; set; }
        // public virtual Adresse Adresse { get; set; }
    }
}
