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

        public int? Id { get; set; }
        
        public string Name { get; set; }

        public Enums.GenderType Gender { get; set; }
      
        public double MonthlyIncome { get; set; }
        
    }
}
