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

            // Paramétrer le tableau
            tabDisplayContact.ColumnCount = 2;
            tabDisplayContact.RowCount = 3;
        }

        private void button_addContacts_Click(object sender, EventArgs e)
        {
            Frm2 frm2 = new Frm2(this);
            frm2.Show();
        }

        private Label CreateLabel(string text)
        {
            Label label = new Label
            {
                Text = text,
                BorderStyle = BorderStyle.Fixed3D,
                AutoSize = true
        };
            return label;
        }

        public void UpdateTab(ListContacts listContacts)
        {

            if (listContacts.getContacts() == null)
            {
                label1.Visible = true;
                tabDisplayContact.Visible = false;
            }
            else
            {
                foreach (Contact contact in listContacts.getContacts())
                {
                    label1.Visible = false;
                    tabDisplayContact.Visible = true;
                    tabDisplayContact.Controls.Add(CreateLabel("Prénom:"), 0, 0);
                    tabDisplayContact.Controls.Add(CreateLabel(contact.Firstname), 1, 0);

                    tabDisplayContact.Controls.Add(CreateLabel("Nom:"), 0, 1);
                    tabDisplayContact.Controls.Add(CreateLabel(contact.Lastname), 1, 1);

                    tabDisplayContact.Controls.Add(CreateLabel("Numéro de téléphone:"), 0, 2);
                    tabDisplayContact.Controls.Add(CreateLabel(contact.Numberphone), 1, 2);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTab(listContacts);
        }

    }
}
