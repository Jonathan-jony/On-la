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
        public Frm1()
        {
            InitializeComponent();
        }

        private void button_addContacts_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
=======
            Frm2 frm2 = new Frm2();
            frm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_user.Text = Frm2._firstName;
>>>>>>> feature/form
        }
    }
}
