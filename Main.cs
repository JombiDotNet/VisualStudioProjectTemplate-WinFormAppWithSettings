using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
  public partial class Main : Form
  {
    public Main()
    {
      InitializeComponent();
      this.RestoreSettings();
    }

    private void Main_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.StoreSettings();
    }

    #region Settings
    private void RestoreSettings()
    {
      this.SuspendLayout();
      FormWindowState windowState = Properties.Settings.Default.Form_Main_WindowState;

      if (windowState == FormWindowState.Normal)
      {
        this.Location = Properties.Settings.Default.Form_Main_Location;
        this.Size = Properties.Settings.Default.Form_Main_Size;
      }
      else
      {
        this.WindowState = windowState;
      }
      this.ResumeLayout();
    }

    private void StoreSettings()
    {
      Properties.Settings.Default.Form_Main_WindowState = this.WindowState;

      if (this.WindowState == FormWindowState.Normal) // Only save locaiton and size if the form is not minimized or maximized.
      {
        Properties.Settings.Default.Form_Main_Location = this.Location;
        Properties.Settings.Default.Form_Main_Size = this.Size;
      }

      Properties.Settings.Default.Save();
    }
    #endregion
  }
}
