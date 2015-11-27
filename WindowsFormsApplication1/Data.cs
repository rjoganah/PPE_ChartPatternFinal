using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Data
    {
        public Double close;
        public DateTime datehour;

        public Data()
        {

        }

        public Data(Double receivedCLose, DateTime receivedDate)
        {
            this.close = receivedCLose;
            this.datehour = receivedDate;
        }

        
    }
}
