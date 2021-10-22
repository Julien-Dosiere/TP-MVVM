using IHM.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IHM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Authentifier();
        }

        private void Authentifier()
        {
            this.Hide();
            Authentification FenAuth = new Authentification();
            if (FenAuth.ShowDialog() == true)
            {
                this.Show();
            } 
            else
            {
                MessageBox.Show("Connexion abandonné, fermeture de l'application");
                this.Close();
            }
        }


        private void NouvelleDemande_Click(object sender, RoutedEventArgs e)
        {
            frmPages.Navigate(new NouvelleDemande());
        }

        private void RechercherDemande_Click(object sender, RoutedEventArgs e)
        {
            frmPages.Navigate(new RechercherDemande());
        }

        private void CreationSalarie_Click(object sender, RoutedEventArgs e)
        {
            frmPages.Navigate(new CreationSalarie());
        }

        private void GestionCompte_Click(object sender, RoutedEventArgs e)
        {
            frmPages.Navigate(new GestionCompte());
        }

        private void GestionAdresses_Click(object sender, RoutedEventArgs e)
        {
            frmPages.Navigate(new GestionAdresses());
        }
    }
}
