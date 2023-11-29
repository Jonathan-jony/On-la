using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onela
{
    public class Contact
    {
        private string firstName;§
        private string lastName;
        private string number;
        private string group = null;

        public Contact(string firstName,string lastName, string number, string group) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.number = number;
            this.group = group;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName= value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
               this.lastName= value;
            }
        }

        public string Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number= value;
            }
        }

        public string Group
        {
            get
            {
                return this.group;
            }
            set
            {
                this.group = value;
            }
        }
    }
}
