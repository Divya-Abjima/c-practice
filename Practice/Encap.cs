using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
     class Encap
    {
        //user basic info
        private string fullName;
        private double phoneNo;
        private string email;

        public void setInfo(string name, double phone, string email)
        {
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name is required");
            }
            else
            {
                this.fullName = name;
                this.phoneNo = phone;
                this.email = email;
            }
            
        }
        public void getInfo()
        {
            
            if (string.IsNullOrEmpty(this.fullName))
            {

            }
            else
            {
                Console.WriteLine("Bsic information:\n");
                Console.WriteLine("Name: " + this.fullName + "\nPhone No: " + this.phoneNo + "\nEmail: " + this.email);
            }
        }
    }
}
