using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIS1175Demo10
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if(name != "")
            {
                MessageBox.Show("Hello " + name);
            }
            if(rdbMale.Checked)
            {
                MessageBox.Show("Male ");
            }
            if (rdbFemale.Checked)
            {
                MessageBox.Show("Female ");
            }

            if (rdbNone.Checked)
            {
                MessageBox.Show("Sex Unknown ");
            }
            if(lstHobby.SelectedIndex >= 0)
            {
                /*    string hobby = lstHobby.SelectedItem.ToString();
                    MessageBox.Show("Hobby is "+hobby);*/
                string hobbies = "";
                foreach(string hobby in lstHobby.SelectedItems)
                {
                    hobbies += hobby + ",";
                }
                MessageBox.Show("Hobbies are " + hobbies);
            }
            

        }

        private void rdbMale_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Male is Clicked");
        }
    }
}
