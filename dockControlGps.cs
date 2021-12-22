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
    public partial class dockControlGps : DockContent
    {
        public UInt16 id;

        public dockControlGps()
        {
            InitializeComponent();

            id = 0;

            CloseButton = false;
        }

        public void resetFilter()
        {
            id = 0;

            tbFilterIdDisplay.Text = $"目前過濾編號：無";
        }

        private void tbFilterReset_Click(object sender, EventArgs e)
        {
            resetFilter();
        }

        private void tbFilterSet_Click(object sender, EventArgs e)
        {
            id = UInt16.Parse(tbFilterID.Text);

            tbFilterIdDisplay.Text = $"目前過濾編號：{tbFilterID.Text}";
        }
    }
}
