using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCMCTest2.Classes
{
    class Borrower
    {
        public int Id { get; set; }
        
        private string _eName = string.Empty; 
        public string Name
        {
            get { return _eName; }
            set
            {
                if (value != null)
                {
                    _eName = value;
                }
                else
                {
                    _eName = string.Empty;
                }
            }
        }

        public string Gender { get; set; }

        public double MonthlyIncome { get; set; }
        
    }
}
