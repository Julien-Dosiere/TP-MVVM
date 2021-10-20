using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHM.Models
{
    class Demande
    {
        public int Id { get; set; }
        public string Motif { get; set; }
        public string Statut { get; set; }
        public string Info { get; set; }
        public string Email { get; set; }
        public Nullable<int> IdSalarie { get; set; }

        public virtual Salary Salary { get; set; }
    }
}
