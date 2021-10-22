using IHM.ViewModels;
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
    /// Interaction logic for GestionAdresses.xaml
    /// </summary>
    public partial class GestionAdresses : Page
    {

        public AdresseViewModel dataContext;
        public GestionAdresses()
        {
            InitializeComponent();
            dataContext = new AdresseViewModel();
            DataContext = dataContext;


        }

        

        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            dataContext.AjouterAdresse();
        }
    }
}
