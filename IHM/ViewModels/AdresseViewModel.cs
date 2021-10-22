using IHM.Commandes;
using IHM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IHM.ViewModels
{
    public class AdresseViewModel:IDisposable
    {
        public Adresse AdresseVM { get; set; }
        public VerifAdresseCommande VerifAdresseCommande { get; set; }

        public ObservableCollection<Adresse> AdressesVM { get; set; }

        public EnregistrerAdresseCommande EnregistrerAdresseCommande { get; set; }

        public ComptesDBContext db = new ComptesDBContext();

        public AdresseViewModel()
        {
            AdresseVM = new Adresse();

            if (VerifAdresseCommande == null)
            {
                VerifAdresseCommande = new VerifAdresseCommande(this);
            }
            if (EnregistrerAdresseCommande == null)
            {
                EnregistrerAdresseCommande = new EnregistrerAdresseCommande(this);
            }
            if (AdresseVM == null)
            {
                AdresseVM = new Adresse();
            }
            if (AdressesVM == null)
            {
                AdressesVM = new ObservableCollection<Adresse>();
            }
        }

        public void AjouterAdresse()
        {
            db.Adresses.Add(AdresseVM);
            db.SaveChanges();
            MessageBox.Show("Adresse ajoutee");
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
