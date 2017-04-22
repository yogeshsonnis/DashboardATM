using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_dashboardATM_AIFile.Classes
{
    public class ATM_Model
    {
        public string Project { get; set; }
        public string Produkt { get; set; }
        public string CalculationName { get; set; }
        public string Tags { get; set; }
        public string User { get; set; }
        public string Date { get; set; }
        public int Pagingtag { get; set; }
        public string PagingText { get; set; }

        public string ProductCalculation { get; set; }
    }
}
