using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppUsercontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userCtrl1_Load(object sender, EventArgs e)
        {
            No1.chkSaved += Event_Handle_btnSave;
            No1.chkCompare_name += Event_Handle_Log;
            No1.chkGender += Event_Handle_Log;
            No1.chkSave_log += Event_Handle_Log;
        }
        
        private void userCtrl2_Load(object sender, EventArgs e)
        {
            No2.chkSaved += Event_Handle_btnSave;
            No2.chkCompare_name += Event_Handle_Log;
            No2.chkGender += Event_Handle_Log;
            No2.chkSave_log += Event_Handle_Log;
        }

        private void userCtrl3_Load(object sender, EventArgs e)
        {
            No3.chkSaved += Event_Handle_btnSave;
            No3.chkCompare_name += Event_Handle_Log;
            No3.chkGender += Event_Handle_Log;
            No3.chkSave_log += Event_Handle_Log;
        }

        private void Event_Handle_btnSave(Object sender, EventArgs dt)
        {
            lbl_result.Text = sender.ToString();
        }
        private void Event_Handle_Log(Object sender, EventArgs dt)
        {
            lbl_log.Text = sender.ToString();
        }
    }
}
