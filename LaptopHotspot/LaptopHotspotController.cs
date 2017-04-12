using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Principal;
using System.IO;

namespace LaptopHotspot
{
    class LaptopHotspotController : Form
    {
        private const int LaptopHotSpotStateIndex = 0;

        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
        private bool hotspotState = false;

        setupHostedNetwork_popup popup = null;
        cmdController cmd = null;

        /* -------   Constructor   ------- */
        /* Takes care of the System Tray allocation and setup */
        public LaptopHotspotController()
        {
            cmd = new cmdController("netsh");

            hotspotState = true;

            trayMenu = new ContextMenu();

            if (getCompatibility())
            {
                trayMenu.MenuItems.Add(stateToText(!hotspotState), LaptoptHotspotState);
                trayMenu.MenuItems.Add("Setup Hot spot", SetupHotSpot);
                
            } else
                trayMenu.MenuItems.Add("Is not compatible with your system!", ShowCompatibility);

            trayMenu.MenuItems.Add("Exit", OnExit);

            trayIcon = new NotifyIcon();
            trayIcon.Text = "Laptop Hot spot";
            trayIcon.Icon = new Icon("icon.ico", 40, 40);

            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;
        }

        /* -------- Overrides -------- */
        /* Overrides the OnLoad method. Since we are not using a basic form controller, we simply override it for ourselves instead of VS doing it for us */
        protected override void OnLoad(EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;

            setState(hotspotState);

            base.OnLoad(e);
        }
        /* Again, just cleaning up, which would otherwise be done automatically by VS (Just good practice) */
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                trayIcon.Dispose();

            base.Dispose(disposing);
        }

        /* ---------------- EVENTS -------------- */
        /* Closes the program */
        private void OnExit(object sender, EventArgs e)
        {
            cmd.start(cmdArguments.STOP_NETWORK);
            Application.Exit();
        }

        /* And event that manages the On/Off Button in the system tray (when you right click) */
        private void LaptoptHotspotState(object sender, EventArgs e)
        {
            hotspotState = !hotspotState;

            trayMenu.MenuItems[LaptopHotSpotStateIndex].Text = stateToText(!hotspotState);
            setState(hotspotState);
        }

        /* Allows you to set up the Wifi hot spot  */
        private void SetupHotSpot(object sender, EventArgs e)
        {
            if(popup == null)
            {
                cmd.start(cmdArguments.STOP_NETWORK);
                popup = new setupHostedNetwork_popup(cmd.MethodName);
                popup.FormClosed += new FormClosedEventHandler(popupClosed);
                
                popup.Show();
            }
        }
        private void popupClosed(object sender, FormClosedEventArgs e)
        {
            popup.FormClosed -= new FormClosedEventHandler(popupClosed);
            popup = null;

            cmd.start(cmdArguments.START_NETWORK);
        }

        // Empty function
        private void ShowCompatibility(object sender, EventArgs e) {}

        /* -------------- Custom Methods ----------- */
        /* Converts the state of the hot spot into readable text. Also, if there is an error, it will return that instead */
        private string stateToText(bool state)
        {
           if (!getUserPrivilege())
                return "Need to run as administrator!";
            
            
            return state ? "On" : "Off";
        }

        /* Returns the state in which the program is in. Is it being run as an administrator or not! */
        private bool getUserPrivilege()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator);
        }

        /* Sets the state of the laptop hot spot. Takes a boolean value that determines if it will be on or off!"
         * Also, if it does not comply with admin elevation, spits out an error! */
        private void setState(bool state)
        {

            if (!getUserPrivilege())
            {
                trayIcon.BalloonTipTitle = "You need to \"Run As Administrator\"";
                trayIcon.BalloonTipIcon = ToolTipIcon.Error;
                trayIcon.BalloonTipText = " ";
            }
            else
            {
                cmd.start(state ? cmdArguments.START_NETWORK : cmdArguments.STOP_NETWORK);

                trayIcon.BalloonTipText = "Laptop Hot-spot is ";
                trayIcon.BalloonTipText += stateToText(hotspotState);
            }


            trayIcon.ShowBalloonTip(2);
        }

        private bool getCompatibility()
        {
            cmd.start(cmdArguments.SHOW_NETWORK_DRIVERS);
            string s = cmd.extractLineFromOutput("Hosted network supported");

            return s.Contains("Yes");
        }
    }
}
