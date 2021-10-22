using IHM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IHM.Commandes
{
    public class EnregistrerAdresseCommande : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private AdresseViewModel adresseViewModel;

        public EnregistrerAdresseCommande(AdresseViewModel adresseViewModel)
        {
            this.adresseViewModel = adresseViewModel;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            adresseViewModel.AjouterAdresse();
        }
    }
}
