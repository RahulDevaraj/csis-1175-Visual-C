using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIS1175Demo11
{
    public partial class RegForm : Form
    {
        double cost = 0.0;
        double skillCharge = 0.0;
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            rdbBeginner.Text = "Beginner";
            rdbIntermediate.Text = "Intermediate";
            rdbAdvanced.Text = "Advanced";

            /*          cobGender.Items.Add("Male");
                        cobGender.Items.Add("Female");
                        cobGender.Items.Add("Not Disclose");
                        cobGender.SelectedIndex = 0;
            */

            cobGender.Items.AddRange(new object[] { "Male", "Female", "Not disclose" });



        }

        private void rdbBeginner_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbBeginner.Checked)
            {
                skillCharge = 10;
                lblMessage.Text = "Beginner - Extra $10 charged";
                computeCost_CheckedChanged(sender, e);
            }

        }
            

        private void rdbIntermediate_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbIntermediate.Checked)
            {
                skillCharge = 0;
                lblMessage.Text = "";
                computeCost_CheckedChanged(sender, e);
            }
        }

        private void rdbAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbAdvanced.Checked)
            {
                skillCharge = -15;
                lblMessage.Text = "Advanced - $15 Discounted";
                computeCost_CheckedChanged(sender, e);
            }
        }

        private  void computeCost_CheckedChanged(object sender, EventArgs e)
        {
            cost = 0.0;
            if (chkSwim.Checked)
                cost += 50;
            if (chkSnorkel.Checked)
                cost += 25;
            if (chkDive.Checked)
                cost += 100;

            cost += skillCharge;
           // cost *= 1.12;
            lblTotal.Text = "Total : $" + cost.ToString("F2");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult results;

            results = MessageBox.Show("Confirm the order?","Confirmation",buttons);
            if(results == DialogResult.Yes)
            {
                MessageBox.Show("Thanks. Confirmed");
                Close();
            }
/*            else
                if(result == DialogResult.No)
            {

            }*/
            
        }
    }
}
