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
    public partial class SetupHelpPopup : Form
    {
        public SetupHelpPopup()
        {
            InitializeComponent();

            try
            {
                rb_help.LoadFile("help.rtf");
            } catch(Exception e)
            {
                rb_help.ForeColor = Color.Red;
                rb_help.Text = "Could not locate the help file!";
            }
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
