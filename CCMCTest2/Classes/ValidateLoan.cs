using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCMCTest2.Classes
{
    class ValidateLoan
    {
        private const string SameBorrowerName = "The same borrower cannot be added twice.";

        public void BorrowerNameValidation(object sender, CancelEventArgs e, string borrowername)
        {
            if (borrowername == "") 
            {
                e.Cancel = true;
            }
        }
        
    }
}
