using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mock {
    public partial class frmEstimate : Form {
        double price = 45.50;
        string vehicle = "";
        string assessories =  "standard" ;

        public frmEstimate() {
            InitializeComponent();
            startUpDisplay(false);                   // setup display
            tbFord.Text = "45.50";                   // set text fields
            tbToyota.Text = "35.75";                 // set text fields
            tbBmw.Text = "50.00";                    // set text fields
            tbAudi.Text = "48.60";                   // set text fields
            radFord.Checked = true;
            radStandard.Checked = true;
            lblOutput.Visible = false;

            }

        private void cmdGo_Click(object sender, EventArgs e) {
            startUpDisplay(true);                // setup display
            lblMain.ForeColor = Color.Blue;

            }
        private void startUpDisplay(bool shouldShow) {           // setup display
            lblDays.Visible = shouldShow;
            tbDays.Visible = shouldShow;
            lblExVat.Visible = shouldShow;
            tbExVat.Visible = shouldShow;
            lblIncVat.Visible = shouldShow;
            tbIncVat.Visible = shouldShow;
            cmdCalculate.Visible = shouldShow;
            cmdClear.Visible = shouldShow;

            tbAudi.Visible = !shouldShow;
            tbBmw.Visible = !shouldShow;
            tbFord.Visible = !shouldShow;
            tbToyota.Visible = !shouldShow;
            lblCostPerDay.Visible = !shouldShow;
            }

        private void cmdCalculate_Click(object sender, EventArgs e) {
            int days = 0;

            if(String.IsNullOrEmpty(tbDays.Text)) {
                 MessageBox.Show("Number of days not entered"," Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            if(!String.IsNullOrEmpty(tbDays.Text)) {

                try {
                    days = int.Parse(tbDays.Text);
                    double subTotal = 0;
                    if(assessories == "standard") {
                        subTotal = days * price;
                       }
                     else {
                        double sub = days * price;
                    subTotal = (sub * .25) + sub;
                          }
                   
                    tbExVat.Text = subTotal.ToString();
                    double vat = (subTotal / 100) * 23;
                    double totalIncVat = subTotal + vat;
                    tbIncVat.Text = totalIncVat.ToString();
                    string output = vehicle + " hired with " + assessories + " assessories for " + days + " days";
                    lblOutput.Text = output;
                    lblOutput.Visible = true;                // setup display

                    }
                catch(Exception) {

                    MessageBox.Show("Number of days must be numeric", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
      
            }

        private void cmdClear_Click(object sender, EventArgs e) {  // clear all data
            tbDays.Text = "";
            tbIncVat.Text = "";
            tbExVat.Text = "";
            lblOutput.Text = "";
            lblOutput.Visible = false;               // setup display

            }

        private void cmdExit_Click(object sender, EventArgs e) { // display yes / no message box
            const string message = "Do you want to exit?";
            const string caption = "EXIT";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes) {
                Application.Exit();
                }
            else if(result == DialogResult.Yes) {
                this.Close();
                }
            }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {// display yes / no message box
            const string message = "Do you want to exit?";
            const string caption = "EXIT";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes) {
                Application.Exit();
                }
            else if(result == DialogResult.Yes) {
                this.Close();
                }
            }

        private void radFord_CheckedChanged(object sender, EventArgs e) {
            if(radFord.Checked) {
                price = double.Parse(tbFord.Text);  // set price for calculation
                vehicle = "Ford";                   // set text for label
                startUpDisplay(false);                   // setup display
                lblOutput.Visible = false;

                }
            }

        private void radToyota_CheckedChanged(object sender, EventArgs e) {
            if(radToyota.Checked) {
                price = double.Parse(tbToyota.Text);// set price for calculation
                vehicle = "Toyota";                  // set text for label
                startUpDisplay(false);                   // setup display
                lblOutput.Visible = false;

                }
            }

        private void radBmw_CheckedChanged(object sender, EventArgs e) {
            if(radBmw.Checked) {
                price = double.Parse(tbBmw.Text);// set price for calculation
                vehicle = "BMW";                     // set text for label
                startUpDisplay(false);               // setup display
                lblOutput.Visible = false;

                }
            }

        private void radAudi_CheckedChanged(object sender, EventArgs e) {
            if(radAudi.Checked) {
                price = double.Parse(tbAudi.Text);// set price for calculation
                vehicle = "Audi";                    // set text for label
                startUpDisplay(false);               // setup display
                lblOutput.Visible = false;

                }
            }

        private void radStandard_CheckedChanged(object sender, EventArgs e) {
            if(radStandard.Checked) {
                assessories = "standard";                // set text for label
                startUpDisplay(false);                   // setup display
                lblOutput.Visible = false;

                //tbFord.Text = "45.50";
                //tbToyota.Text = "35.75";
                //tbBmw.Text = "50.00";
                //tbAudi.Text = "48.60";
                }
            }

        private void radExtra_CheckedChanged(object sender, EventArgs e) {
            assessories = "extra";                     // set text for label
            startUpDisplay(false);                      // setup display
            lblOutput.Visible = false;

            //tbFord.Text = "56.87";
            //tbToyota.Text = "44.69";
            //tbBmw.Text = "62.25";
            //tbAudi.Text = "71.92";

            }
        }
    }
