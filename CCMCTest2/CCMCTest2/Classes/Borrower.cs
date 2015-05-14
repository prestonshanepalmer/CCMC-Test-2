using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCMCTest2.Classes
{
    class Borrower
    {
        public Borrower(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        
        private string _name = string.Empty; 
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null)
                {
                    _name = value;
                }
                else
                {
                    _name = string.Empty;
                }
            }
        }

        public enum GenderType
        {
            Unspecified = 1,
            Male = 2,
            Female = 3
        }

        
        public GenderType Gender = new GenderType();
        

        public double MonthlyIncome { get; set; }
        
    }
}
