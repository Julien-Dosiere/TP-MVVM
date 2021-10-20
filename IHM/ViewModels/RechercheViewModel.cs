using IHM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHM.ViewModels
{
    class RechercheViewModel
    {
        APIClient client = new APIClient();

        public ListeDemandes ListeDemandes { get; set; }


        public RechercheViewModel()
        {
            ListeDemandes = new ListeDemandes();
        }

        public void GetDemandes()
        {

            ListeDemandes.Demandes = client.GetDemandes();
        }
    }
}
