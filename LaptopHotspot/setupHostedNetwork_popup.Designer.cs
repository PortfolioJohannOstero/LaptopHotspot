namespace LaptopHotspot
{
    partial class setupHostedNetwork_popup
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
            this.lbl_decr_networkName = new System.Windows.Forms.Label();
            this.tb_networkName = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_descr_password = new System.Windows.Forms.Label();
            this.rb_cmdOutput = new System.Windows.Forms.RichTextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_descr_output = new System.Windows.Forms.Label();
            this.lbl_descr_help = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.cb_showPassword = new System.Windows.Forms.CheckBox();
            this.lbl_descr_help2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_decr_networkName
            // 
            this.lbl_decr_networkName.AutoSize = true;
            this.lbl_decr_networkName.Location = new System.Drawing.Point(12, 9);
            this.lbl_decr_networkName.Name = "lbl_decr_networkName";
            this.lbl_decr_networkName.Size = new System.Drawing.Size(115, 13);
            this.lbl_decr_networkName.TabIndex = 0;
            this.lbl_decr_networkName.Text = "Network Name (SSID):";
            // 
            // tb_networkName
            // 
            this.tb_networkName.Location = new System.Drawing.Point(12, 25);
            this.tb_networkName.Name = "tb_networkName";
            this.tb_networkName.Size = new System.Drawing.Size(198, 20);
            this.tb_networkName.TabIndex = 1;
            this.tb_networkName.Text = "Avoid_Spaces & Special_Characters";
            this.tb_networkName.TextChanged += new System.EventHandler(this.tb_networkName_TextChanged);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(12, 76);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(198, 20);
            this.tb_password.TabIndex = 3;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // lbl_descr_password
            // 
            this.lbl_descr_password.AutoSize = true;
            this.lbl_descr_password.Location = new System.Drawing.Point(12, 60);
            this.lbl_descr_password.Name = "lbl_descr_password";
            this.lbl_descr_password.Size = new System.Drawing.Size(143, 13);
            this.lbl_descr_password.TabIndex = 2;
            this.lbl_descr_password.Tag = "";
            this.lbl_descr_password.Text = "Password (8 - 16 Characters)";
            // 
            // rb_cmdOutput
            // 
            this.rb_cmdOutput.Location = new System.Drawing.Point(216, 25);
            this.rb_cmdOutput.Name = "rb_cmdOutput";
            this.rb_cmdOutput.Size = new System.Drawing.Size(198, 238);
            this.rb_cmdOutput.TabIndex = 4;
            this.rb_cmdOutput.Text = "";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(339, 269);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_descr_output
            // 
            this.lbl_descr_output.AutoSize = true;
            this.lbl_descr_output.Location = new System.Drawing.Point(213, 9);
            this.lbl_descr_output.Name = "lbl_descr_output";
            this.lbl_descr_output.Size = new System.Drawing.Size(42, 13);
            this.lbl_descr_output.TabIndex = 7;
            this.lbl_descr_output.Text = "Output:";
            // 
            // lbl_descr_help
            // 
            this.lbl_descr_help.ForeColor = System.Drawing.Color.Red;
            this.lbl_descr_help.Location = new System.Drawing.Point(12, 204);
            this.lbl_descr_help.Name = "lbl_descr_help";
            this.lbl_descr_help.Size = new System.Drawing.Size(198, 59);
            this.lbl_descr_help.TabIndex = 9;
            this.lbl_descr_help.Text = "If this is your first time setting up your hosted network, you will have to share" +
    " your network. If you are in doubt, then please refer to the help button below!\r" +
    "\n";
            // 
            // btn_apply
            // 
            this.btn_apply.Enabled = false;
            this.btn_apply.Location = new System.Drawing.Point(216, 269);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 5;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(12, 267);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(75, 23);
            this.btn_help.TabIndex = 10;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // cb_showPassword
            // 
            this.cb_showPassword.AutoSize = true;
            this.cb_showPassword.Location = new System.Drawing.Point(15, 102);
            this.cb_showPassword.Name = "cb_showPassword";
            this.cb_showPassword.Size = new System.Drawing.Size(102, 17);
            this.cb_showPassword.TabIndex = 11;
            this.cb_showPassword.Text = "Show Password";
            this.cb_showPassword.UseVisualStyleBackColor = true;
            this.cb_showPassword.CheckedChanged += new System.EventHandler(this.cb_showPassword_CheckedChanged);
            // 
            // lbl_descr_help2
            // 
            this.lbl_descr_help2.Location = new System.Drawing.Point(12, 122);
            this.lbl_descr_help2.Name = "lbl_descr_help2";
            this.lbl_descr_help2.Size = new System.Drawing.Size(198, 72);
            this.lbl_descr_help2.TabIndex = 12;
            this.lbl_descr_help2.Text = "Keep in mind that while this window is open the hosted network will be turned off" +
    "";
            // 
            // setupHostedNetwork_popup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(421, 302);
            this.Controls.Add(this.lbl_descr_help2);
            this.Controls.Add(this.cb_showPassword);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.lbl_descr_help);
            this.Controls.Add(this.lbl_descr_output);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.rb_cmdOutput);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl_descr_password);
            this.Controls.Add(this.tb_networkName);
            this.Controls.Add(this.lbl_decr_networkName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "setupHostedNetwork_popup";
            this.Text = "Setup Hosted Network";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_decr_networkName;
        private System.Windows.Forms.TextBox tb_networkName;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_descr_password;
        private System.Windows.Forms.RichTextBox rb_cmdOutput;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_descr_output;
        private System.Windows.Forms.Label lbl_descr_help;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.CheckBox cb_showPassword;
        private System.Windows.Forms.Label lbl_descr_help2;
    }
}