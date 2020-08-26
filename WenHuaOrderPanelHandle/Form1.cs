using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WenHuaOrderPanelHandle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Buy_Click(object sender, EventArgs e)
        {

        }

        private void Button_Sellshort_Click(object sender, EventArgs e)
        {

        }

        private void Button_Cover_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 测试合约
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_TestIns_Click(object sender, EventArgs e)
        {
            SendMessageHandle handel = new SendMessageHandle();
            //handel.SendMessageToTextBox(, "hanyu");
        }
    }
}
