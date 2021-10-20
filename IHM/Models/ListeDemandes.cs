using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHM.Models
{
    class ListeDemandes : INotifyPropertyChanged
    {
        private List<Demande> demandes;

        public List<Demande> Demandes
        {
            get { return demandes; }
            set { 
                demandes = value;
                Notify("Demandes");
            }
        }

        private void Notify(string v)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
