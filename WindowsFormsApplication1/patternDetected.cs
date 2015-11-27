using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class patternDetected
    {
        public DateTime dateDebut;
        public DateTime dateFin;
        public double maxValue;
        public double minValue;
        public String type;
        public int size;
        public double sum;

        public patternDetected(DateTime debut, DateTime fin, double value1, double value2,int size,double sum, String type)
        {
            // TODO: Complete member initialization
            this.dateDebut = debut;
            this.dateFin = fin;
            this.maxValue = value1;
            this.minValue = value2;
            this.size = size;
            this.type = type;
            this.sum = sum;
        }

       
    } 
}
