using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace Onela
{
    internal class contact
    {
=======

namespace Onela
{
    public class Contact
    {
        private static string _firstname;
        private string _lastname;
        private string _numberphone;

        public Contact(string Firstname, string Lastname, string numberPhone) 
        { 
             _firstname = Firstname;
             _lastname = Lastname;
             _numberphone = numberPhone;
        }
        public static string Firstname
        {
            get 
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }
        public string Lastname
        {
            get 
            {
                return _lastname;
            }
            set
            {
                _lastname= value;
            }
        }
        public string Numberphone
        {
            get
            {
                return _numberphone;
            }
            set
            {
                _numberphone = value;
            }
        }
>>>>>>> feature/form
    }
}
