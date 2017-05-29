using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppUsercontrol
{
    public partial class UserCtrl : UserControl
    {
        public string str_result;
        public string log;
        public string gender = "";

        //Create Delegate and Event Log

        public delegate void Compare_name(object sender, EventArgs dt);
        public event Compare_name chkCompare_name;

        public delegate void Click_gender(object sender, EventArgs dt);
        public event Click_gender chkGender;

        public delegate void Click_save(object sender, EventArgs dt);
        public event Click_save chkSaved;

        public delegate void Save_log(object sender, EventArgs dt);
        public event Save_log chkSave_log;

        public UserCtrl()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            if (chkSaved != null)
            {
                string result = this.Name + "\nName : " + txtBox_name.Text + "\nGender : " + gender + "\n";
                str_result += result;
                chkSaved(str_result, e);
            }
            if (chkSave_log != null)
            {
                string result = this.Name + " : Click Save\n";
                log += result;
                chkSave_log(log, e);
            }
        }

        private void txtBox_name_TextChanged(object sender, EventArgs e)
        {
            
            if (chkCompare_name != null)
            {
                string result = this.Name + " : Name Changed\n";
                log += result;
                chkCompare_name(log, e);
            }
        }

        private void chkBox_male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
            if (chkGender != null)
            {
                string result = this.Name + " : Gender " + gender + " Changed\n";
                log += result;
                chkGender(log, e);
            }
        }

        private void chkBox_female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
            if (chkGender != null)
            {
                string result = this.Name + " : Gender " + gender + " Changed\n";
                log += result;
                chkGender(log, e);
            }
        }
    }
}
