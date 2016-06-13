using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class ProfileForm : Form
    {
        private Data d;
        public ProfileForm(IEmployee e,Data d)
        {
            this.d = d;

            InitializeComponent();

            if (e is Paid)
            {
                Paid emp = e as Paid;
                lbsalary.Visible = true;
                lblsalaris.Visible = true;
                this.lbsalary.Text = Convert.ToString(emp.Salary); 
            }
            else
            {
                lbsalary.Visible = false;
                lblsalaris.Visible = false;
            }
            this.ProfilePictur.ImageLocation = @e.Profilepath;
            this.lbFirsName.Text = e.FirstName;
            this.lbSirname.Text = e.SirName;
            this.lbAfdeling.Text = e.Department;
            this.aboutMe.Text = "This is where I tell you something about myself";
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            Home form = new Home(d);
            this.Hide();
            form.Show();
            form.Update();


        }
    } 
}
