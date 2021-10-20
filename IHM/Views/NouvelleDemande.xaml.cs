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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IHM.Views
{
    /// <summary>
    /// Interaction logic for NouvelleDemande.xaml
    /// </summary>
    public partial class NouvelleDemande : Page
    {
        public NouvelleDemande()
        {
            InitializeComponent();
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            Demande demande = new Demande();
            demande.Motif = tbxMotif.Text;
            demande.Email = TbxEmail.Text;
            APIClient client = new APIClient();
            bool result = client.PostDemande(demande);
            if (result)
                TblResult.Text = "Creation réussi !!";
            else
                TblResult.Text = "Probleme lors de la creation";
        }
    }
}
