using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHM.Models
{


    public class AdresseGouv
    {
        public string type { get; set; }
        public string version { get; set; }
        public Feature[] features { get; set; }
        public string attribution { get; set; }
        public string licence { get; set; }
        public string query { get; set; }
        public int limit { get; set; }
    }

    public class Feature
    {
        public string type { get; set; }
        public Geometry geometry { get; set; }
        public AdressProperties properties { get; set; }
    }

    public class AdressProperties
    {
        public string label { get; set; }
        public float score { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string housenumber { get; set; }
        public string postcode { get; set; }
        public string citycode { get; set; }
        public float x { get; set; }
        public float y { get; set; }
        public string city { get; set; }
        public string context { get; set; }
        public string type { get; set; }
        public float importance { get; set; }
        public int population { get; set; }
        public string oldcitycode { get; set; }
        public string oldcity { get; set; }
    }


}
