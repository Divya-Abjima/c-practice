using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Class1  //getting info by set and get properties
    {
        private string userName;
        private int userID;
        private string email;
        
        public int UserId
        {
            set
            {
                if(value <=0)
                {
                    Console.WriteLine("Not a valid id number");
                }
                else
                {
                    this.userID = value;
                } 
                
            }
            get
            {
                if(this.userID > 0)
                {
                    return this.userID;
                }
                else
                {
                    return -1;
                }
               
            }
        }
    }
}
