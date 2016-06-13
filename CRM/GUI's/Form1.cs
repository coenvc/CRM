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

namespace Test
{
    public partial class Home : Form
    {

        public Data d;

        public Home(Data D)
        {
            InitializeComponent();
            this.d = D ;
        }

        public Home()
        { 
            InitializeComponent();
            this.d = new Data(); 
        }
       

        public void Update()
        {
            listBox1.Items.Clear();
            foreach (IEmployee e in d.employees)
            {
                if ( e is Charity)
                {
                    listBox1.Items.Add(e as Charity);
                }
                if ( e is Paid)
                {
                    listBox1.Items.Add(e as Paid);
                }
            }
        }



        private void btnExport_Click(object sender, EventArgs e)
        {
            d.Export();
            Update();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            d.Import();
            Update();
        }

       
        private void btnSortSalary_Click(object sender, EventArgs e)
        {
            List<Paid> PaidEmployees = new List<Paid>();
            foreach (IEmployee employee in d.employees)
            { 
                if(employee is Paid) {  
                PaidEmployees.Add(employee as Paid);
                  }
            }
            PaidEmployees.Sort();
            listBox1.Items.Clear();
            foreach (Paid emp in PaidEmployees)
            {
                listBox1.Items.Add(emp);
            }
            
        }
        //Hiermee kunnen de salarissen van verschillende werknemers met elkaar vergeleken worden

        void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProfileForm pf = new ProfileForm(listBox1.SelectedItem as IEmployee,d);
            this.Hide();
            pf.Show();
        }

        private void GoToBackend_Click(object sender, EventArgs e)
        {
            this.Hide();
            Backend b = new Backend(d);
            b.Show();
        }
    }
}
