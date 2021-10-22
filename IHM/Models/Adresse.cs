using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHM.Models
{
    public class Adresse
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Rue { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }

        public override string ToString()
        {
            return $"{Numero} {Rue} {CodePostal} {Ville}";
        }
    }
}
