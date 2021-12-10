using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPS_Resuce_Receiver_GUI
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
        }

        private void aboutForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            lblAboutMain.Text = "登山救援系統 版本 1.0";
            lblAboutAuthor.Text = "作者：蔡欣祐（弘光科技大學）";
            lblAboutDate.Text = "版本完成日期：2021 年 12 月 8 日";

            //lblAboutLibrary.Text = "本軟體所使用到的套件：\n";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
