using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaptopHotspot
{
    public partial class setupHostedNetwork_popup : Form
    {
        private string mName = "";
        private string mPassword = "";
        private cmdController cmd = null;
        private SetupHelpPopup popup = null;

        private bool nameIsNotEmpty = false;
        private bool passwordIsOverSixCharacters = false; 

        public setupHostedNetwork_popup(string method)
        {
            InitializeComponent();

            cmd = new cmdController(method);
            tb_password.MaxLength = 16;
            tb_password.UseSystemPasswordChar = !cb_showPassword.Checked;
        }

        // ------------------------- EVENTS
        private void btn_apply_Click(object sender, EventArgs e)
        {
            cmd.start("wlan set hostednetwork mode=allow ssid=\"" + mName + "\" key=\"" + mPassword + "\"");
            rb_cmdOutput.Text = cmd.extractAllOutput();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_networkName_TextChanged(object sender, EventArgs e)
        {
            mName = tb_networkName.Text;

            nameIsNotEmpty = mName != "";
            setApplyBtnState();
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            mPassword = tb_password.Text;

            passwordIsOverSixCharacters = mPassword.Length >= 8;
            setApplyBtnState();
        }

        private void setApplyBtnState()
        {
            btn_apply.Enabled = nameIsNotEmpty && passwordIsOverSixCharacters;
        }

        private void cb_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            tb_password.UseSystemPasswordChar = !cb_showPassword.Checked;
        }

        // ------------- Popup event
        private void btn_help_Click(object sender, EventArgs e)
        {
            if(popup == null)
            {
                popup = new SetupHelpPopup();
                popup.FormClosed += new FormClosedEventHandler(popupClosed);
                popup.Show();
            }
        }
        private void popupClosed(object sender, FormClosedEventArgs e)
        {
            popup.FormClosed -= new FormClosedEventHandler(popupClosed);
            popup = null;
        }
    }
}
