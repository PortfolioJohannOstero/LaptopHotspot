namespace LaptopHotspot
{
    partial class SetupHelpPopup
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
            this.rb_help = new System.Windows.Forms.RichTextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rb_help
            // 
            this.rb_help.Location = new System.Drawing.Point(12, 12);
            this.rb_help.Name = "rb_help";
            this.rb_help.Size = new System.Drawing.Size(777, 448);
            this.rb_help.TabIndex = 0;
            this.rb_help.Text = "";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(12, 466);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(777, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // SetupHelpPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 496);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.rb_help);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SetupHelpPopup";
            this.Text = "Help - Setup Sharing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rb_help;
        private System.Windows.Forms.Button btn_close;
    }
}