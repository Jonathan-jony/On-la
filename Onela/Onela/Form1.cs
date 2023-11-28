using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Onela
{
    public partial class Frm1 : Form
    {
        private ListContacts listContacts;
        private string _firstname;
        private string _lastname;
        private string _numberPhone;

        List<Contact> contact = new List<Contact>();
        public Frm1()
        {
            InitializeComponent();
        }

        private void button_addContacts_Click(object sender, EventArgs e)
        {
            Frm2 frm2 = new Frm2(this);
            frm2.Show();
        }

        public void UpdateListBox(ListContacts)
        {

            if (ListContacts.getContacts() == null)
            {
                label1.Visible = true;
                listBox1.Visible = false;
            }
            foreach (Contact contact in ListContacts.getContacts())
            {
                label1.Visible = false;
                listBox1.Visible = true;
                listBox1.Items.Add(contact.Firstname + " " + contact.Lastname);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListBox(ListContacts);
        }
    }
}
