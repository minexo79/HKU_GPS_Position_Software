using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace GPS_Resuce_Receiver_GUI
{
    public partial class dockDisplayGps : DockContent
    {
        public dockDisplayGps()
        {
            InitializeComponent();

            tableLayoutPanel1.AutoSize = true;
            CloseButton = false;
        }
    }
}
