namespace WinAppUsercontrol
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.No2 = new WinAppUsercontrol.UserCtrl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_log = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.No3 = new WinAppUsercontrol.UserCtrl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.No1 = new WinAppUsercontrol.UserCtrl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // No2
            // 
            this.No2.Location = new System.Drawing.Point(6, 19);
            this.No2.Name = "No2";
            this.No2.Size = new System.Drawing.Size(223, 109);
            this.No2.TabIndex = 3;
            this.No2.Load += new System.EventHandler(this.userCtrl3_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_result);
            this.groupBox1.Location = new System.Drawing.Point(269, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 362);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // lbl_result
            // 
            this.lbl_result.AccessibleRole = System.Windows.Forms.AccessibleRole.Slider;
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(7, 20);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 13);
            this.lbl_result.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.No2);
            this.groupBox2.Location = new System.Drawing.Point(13, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 131);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "No 2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_log);
            this.groupBox3.Location = new System.Drawing.Point(269, 381);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 221);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Event Log";
            // 
            // lbl_log
            // 
            this.lbl_log.AutoSize = true;
            this.lbl_log.Location = new System.Drawing.Point(7, 20);
            this.lbl_log.Name = "lbl_log";
            this.lbl_log.Size = new System.Drawing.Size(0, 13);
            this.lbl_log.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.No3);
            this.groupBox4.Location = new System.Drawing.Point(13, 290);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 140);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "No 3";
            // 
            // No3
            // 
            this.No3.Location = new System.Drawing.Point(14, 23);
            this.No3.Name = "No3";
            this.No3.Size = new System.Drawing.Size(223, 109);
            this.No3.TabIndex = 2;
            this.No3.Load += new System.EventHandler(this.userCtrl2_Load);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.No1);
            this.groupBox5.Location = new System.Drawing.Point(13, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 134);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "No 1";
            // 
            // No1
            // 
            this.No1.Location = new System.Drawing.Point(14, 20);
            this.No1.Name = "No1";
            this.No1.Size = new System.Drawing.Size(223, 109);
            this.No1.TabIndex = 1;
            this.No1.Load += new System.EventHandler(this.userCtrl1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 615);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Windows App using User Control and Event Handle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UserCtrl No1;
        private UserCtrl No3;
        private UserCtrl No2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_log;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

