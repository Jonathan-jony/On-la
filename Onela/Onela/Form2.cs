using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onela
{
    public partial class Frm2 : Form
    {
        public Contact _contact;
        public static string _firstName = "";
        public static string _lastName = "";
        public static string _numberPhone = "";

        public Frm2()
        {
            InitializeComponent();
            _contact = new Contact(_firstName, _lastName, _numberPhone);
        }
        private void textBox_firstnameNewContacts_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_createContacts_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
=======
            _firstName = textBox_firstnameNewContacts.Text;
            _lastName = textBox_lastnameNewContacts.Text;
            _numberPhone = textBox_numberNewContacts.Text;
            Frm1 frm1 = new Frm1();
            frm1.Show();
>>>>>>> feature/form
        }
    }
}
