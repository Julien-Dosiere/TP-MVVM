using IHM.Helpers;
using IHM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IHM.Views
{
    /// <summary>
    /// Interaction logic for Authentification.xaml
    /// </summary>
    public partial class Authentification : Window
    {
        private static int NbEssai = 3;
        
        public Authentification()
        {
            InitializeComponent();
        }

        private void Connexion_Click(object sender, RoutedEventArgs e)
        {
            if (chkModeAuth.IsChecked == true)
            {
                AuthentificationWindows();
            }
            else
            {
                AuthentificationBase();
            }
           
        }

        private void AuthentificationBase()
        {

            ComptesDBContext db = new ComptesDBContext();

            string login = tbxLogin.Text;
            string password = CryptHelper.Base64Encode(pbxUser.Password);

           var compte = db.Comptes.FirstOrDefault(c => c.Login.Equals(login) && c.Password.Equals(password));

            if (compte != null)
            {
                this.DialogResult = true;
            }
            else 
            {
                NbEssai--;
                MessageBox.Show($"Identifiants incorrects, {NbEssai} essais restants");
                if (NbEssai == 0)
                {
                    MessageBox.Show("Nb essais depasses");
                    this.DialogResult = false;

                }

            }

            

        }

        private void AuthentificationWindows()
        {
        

            bool ok = true;

            ok = AccessHelper.IsAuthentificationValid(tbxLogin.Text, pbxUser.Password);

            if (ok)
            {
                this.DialogResult = true;
            }
            else
            {
                this.DialogResult = false;
            }
        }
    }
}
