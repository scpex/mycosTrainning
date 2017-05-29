using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NookWindowsForm
{
   

    
    public partial class UserControl1 : UserControl
    {
        public string gender;
        // send when click save 
        public delegate void clickSave(object sender, EventArgs data);
        public event clickSave clickSaved;
        
        // check Select Gender
        public delegate void clickAny(object sender, EventArgs data);
        public event clickAny clickSomething;

        // check name change
        public delegate void changeName(object sender, EventArgs data);
        public event changeName changedName;

        // check button Save 
        public delegate void clickSaveLog(object sender, EventArgs data);
        public event clickSaveLog checkClickSaved;


        public UserControl1()
        {
            InitializeComponent();           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
            if (clickSomething != null)
            {
                string str = this.Name.ToString() + "checked: " + gender + System.Environment.NewLine;
                clickSomething(str, e);
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
        
          

            if (clickSaved != null) {
                string str = this.Name.ToString() + System.Environment.NewLine
                             + "Name: " + textBox1.Text + System.Environment.NewLine + "Gender: "
                             + gender + System.Environment.NewLine;           
                clickSaved(str, e);
            }

            
            if (checkClickSaved != null)
            {
                string str = this.Name.ToString() + "Click Save" + System.Environment.NewLine;
                checkClickSaved(str, e);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
            if (clickSomething != null)
            {
                string str = this.Name.ToString() + "checked: " + gender + System.Environment.NewLine;
                clickSomething(str, e);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (changedName != null)
            {
                string str = this.Name.ToString() + "change name" + System.Environment.NewLine;
                changedName(str, e);
            }
        }
    }
}
