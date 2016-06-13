using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.GUI_s;
namespace Test.GUI_s
{
    public partial class Backend : Form
    {
         Data d;

        public Backend(Data D)
        { 
            InitializeComponent();
            this.d = D;
        }

        public Backend()
        {
            InitializeComponent();
            Data d = new Data();
            this.d = d;
        }
        
        string profilepath;

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form = new Home(d);
            form.Show();
            form.Update();
        }


        public void ClearForm()
        {
            tbFirstName.Clear();
            tbSirName.Clear();
            textBox3.Clear();
            textBox1.Clear();
            cbBetaald.Checked = false;
            if (cbBetaald.Checked == false)
            {
                textBox1.Enabled = false;
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (cbBetaald.Checked == true)
                {
                    Paid pe = new Paid(tbFirstName.Text, tbSirName.Text, textBox3.Text, Convert.ToDecimal(textBox1.Text),
                        profilepath,rtbAboutMe.Text);
                    d.employees.Add(pe as IEmployee);
                }
                else
                {
                    Charity ce = new Charity(tbFirstName.Text, tbSirName.Text, textBox3.Text, profilepath,rtbAboutMe.Text);
                    d.employees.Add(ce as IEmployee);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Update();
            ClearForm();
        }

        private void cbBetaald_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbBetaald.Checked == true)
            {
                textBox1.Enabled = true;
            }
            if (cbBetaald.Checked == false)
            {
                textBox1.Enabled = false;
            }
        }

        private void btnProfilePic_Click(object sender, EventArgs e)
        {
           
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                profilepath = Convert.ToString(Path.GetFullPath(sfd.FileName));
            }
            else
            {
                profilepath = "";
            }
        }
    }

}
