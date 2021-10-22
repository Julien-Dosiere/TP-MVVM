using IHM.Helpers;
using IHM.Models;
using IHM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IHM.Commandes
{
    public class VerifAdresseCommande : ICommand
    {

        private AdresseViewModel adresseViewModel;

        public VerifAdresseCommande(AdresseViewModel adresseViewModel)
        {
            this.adresseViewModel = adresseViewModel;
        }
        
        public event EventHandler CanExecuteChanged;



        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            Adresse query = (Adresse)parameter;



            var adresses = await AccessAPI.GetAdresses(query.ToString());

            adresseViewModel.AdressesVM.Clear();

            foreach (var item in adresses)
            {
                adresseViewModel.AdressesVM.Add(item);
            }
        }
    }
}
