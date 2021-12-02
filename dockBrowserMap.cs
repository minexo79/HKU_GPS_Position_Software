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
    public partial class dockBrowserMap : DockContent
    {
        public dockBrowserMap()
        {
            InitializeComponent();

            CloseButton = false;
        }
    }
}
