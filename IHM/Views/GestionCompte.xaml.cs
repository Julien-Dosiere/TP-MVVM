﻿using IHM.Helpers;
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
    /// Interaction logic for GestionCompte.xaml
    /// </summary>
    public partial class GestionCompte : Page
    {
        public GestionCompte()
        {
            InitializeComponent();
        }

        private void Enregistrer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ComptesDBContext db = new ComptesDBContext();

                Compte compte = new Compte();

                compte.Login = tbxNom.Text;

                compte.Password = CryptHelper.Base64Encode(tbxPass.Text);

                db.Comptes.Add(compte);

                db.SaveChanges();

                MessageBox.Show("Compte créé");

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
