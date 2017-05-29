namespace WinAppUsercontrol
{
    partial class UserCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.chkBox_male = new System.Windows.Forms.CheckBox();
            this.chkBox_female = new System.Windows.Forms.CheckBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender";
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(71, 4);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(147, 20);
            this.txtBox_name.TabIndex = 2;
            this.txtBox_name.TextChanged += new System.EventHandler(this.txtBox_name_TextChanged);
            // 
            // chkBox_male
            // 
            this.chkBox_male.AutoSize = true;
            this.chkBox_male.Location = new System.Drawing.Point(71, 41);
            this.chkBox_male.Name = "chkBox_male";
            this.chkBox_male.Size = new System.Drawing.Size(49, 17);
            this.chkBox_male.TabIndex = 3;
            this.chkBox_male.Text = "Male";
            this.chkBox_male.UseVisualStyleBackColor = true;
            this.chkBox_male.CheckedChanged += new System.EventHandler(this.chkBox_male_CheckedChanged);
            // 
            // chkBox_female
            // 
            this.chkBox_female.AutoSize = true;
            this.chkBox_female.Location = new System.Drawing.Point(158, 41);
            this.chkBox_female.Name = "chkBox_female";
            this.chkBox_female.Size = new System.Drawing.Size(60, 17);
            this.chkBox_female.TabIndex = 4;
            this.chkBox_female.Text = "Female";
            this.chkBox_female.UseVisualStyleBackColor = true;
            this.chkBox_female.CheckedChanged += new System.EventHandler(this.chkBox_female_CheckedChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(71, 76);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // UserCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.chkBox_female);
            this.Controls.Add(this.chkBox_male);
            this.Controls.Add(this.txtBox_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserCtrl";
            this.Size = new System.Drawing.Size(223, 109);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.CheckBox chkBox_male;
        private System.Windows.Forms.CheckBox chkBox_female;
        private System.Windows.Forms.Button btn_save;
    }
}
