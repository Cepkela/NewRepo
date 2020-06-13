using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4_Galutinis_Darbas.Models
{
    public class Place
    {
        public string startPoint { get; set; }
        public int startPointID { get; set; }
        public string endPoint { get; set; }
        public int endPointID { get; set; }
        public double distance { get; set; }

        public ArrayList streets = new ArrayList();

        public Place()
        {

        }
        public Place(string startPoint, string endPoint, string distance)
        {

        }
    }
}
