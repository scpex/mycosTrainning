using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NookWindowsForm
{
    

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();           
         
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            no1.clickSaved += HandleUserControlLinkButtonClicked;
            no1.clickSomething += HandleUserControlLog;
            no1.changedName += HandleUserControlLog;
            no1.checkClickSaved += HandleUserControlLog;
        }


        // event handler  method to save input send to result textbox
        private void HandleUserControlLinkButtonClicked(object sender, EventArgs data)
        {
            
            textBox1.Text += sender.ToString();
        }

        // event handler  method to check input send to Log textbox
        private void HandleUserControlLog(object sender, EventArgs data)
        {

            textBox2.Text += sender.ToString();
        }

        private void no2_Load(object sender, EventArgs e)
        {
            no2.clickSaved += HandleUserControlLinkButtonClicked;
            no2.clickSomething += HandleUserControlLog;
            no2.changedName += HandleUserControlLog;
            no2.checkClickSaved += HandleUserControlLog;
        }

        private void no3_Load(object sender, EventArgs e)
        {
            no3.clickSaved += HandleUserControlLinkButtonClicked;
            no3.clickSomething += HandleUserControlLog;
            no3.changedName += HandleUserControlLog;
            no3.checkClickSaved += HandleUserControlLog;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {           
        }
    }
}
