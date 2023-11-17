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

namespace Onela
{
    public partial class Frm1 : Form
    {
<<<<<<< HEAD

        public Form1()
=======
        public Frm1()
>>>>>>> b7ca33b6d9f705418da76a6dc721e1cc7d1f1c43
        {
            InitializeComponent();
        }

        private void button_addContacts_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.Hide();
            Form2 Form2 = new Form2();
            Form2.Show();
=======
            Frm2 frm2 = new Frm2();
            frm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_user.Text = Frm2._firstName;
>>>>>>> b7ca33b6d9f705418da76a6dc721e1cc7d1f1c43
        }
    }
}
