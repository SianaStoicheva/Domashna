using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneNaKlas
{
    internal class BankAccount
    {
        public int id;
        public double balance;

        public int ID
        {
            get
            { 
                return id; 
            }
            set 
            { 
                id = value; 
            }
        }

        public double Balance
        {
            get 
            { 
                return Balance; 
            }
            set 
            { 
                Balance = value; 
            }
        }
        public BankAccount()
        {
            this.id = id;
            this.balance = balance;
        }

        
    }
}
