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
            if (this.textBox_handleBuy.Text == "")
            {
                MessageBox.Show("请输入买入按钮的的句柄...");
                return;
            }

            try
            {
                SendClick(this.textBox_handleBuy.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Button_Sellshort_Click(object sender, EventArgs e)
        {
            if (this.textBox_handleSellshort.Text == "")
            {
                MessageBox.Show("请输入卖空按钮的的句柄...");
                return;
            }

            try
            {
                SendClick(this.textBox_handleSellshort.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Button_Cover_Click(object sender, EventArgs e)
        {
            if (this.textBox_handleCover.Text == "")
            {
                MessageBox.Show("请输入平仓按钮的的句柄...");
                return;
            }

            try
            {
                SendClick(this.textBox_handleCover.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        /// <summary>
        /// 测试合约
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_TestIns_Click(object sender, EventArgs e)
        {
            if (this.textBox_handleIns.Text == "")
            {
                MessageBox.Show("请输入合约的句柄...");
                return;
            }

            try
            {
                SendString(this.textBox_handleIns.Text, this.textBox_ins.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        /// <summary>
        /// 测试手数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_testSha_Click(object sender, EventArgs e)
        {
            if (this.textBox_handleShares.Text == "")
            {
                MessageBox.Show("请输入手数的handle...");
                return;
            }

            try
            {
                SendString(this.textBox_handleShares.Text, this.textBox_shares.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        /// <summary>
        /// 测试类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_TestCov_Click(object sender, EventArgs e)
        {
            if (this.textBox_handletypes.Text == "")
            {
                MessageBox.Show("请输入类型的handle...");
                return;
            }

            try
            {
                SendString(this.textBox_handletypes.Text, this.textBox_jiageTypes.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void SendString(string hexptr, string info)
        {
            SendMessageHandle handel = new SendMessageHandle();
            handel.SendMessageToTextBox((IntPtr)Convert.ToInt32(hexptr, 16), info);
        }

        private string SendToMulticharts(string hexptr)
        {
            SendMessageHandle handel = new SendMessageHandle();
            return handel.SendMessageToMCOutPut((IntPtr)Convert.ToInt32(hexptr, 16));
        }

        private void SendClick(string hexptr)
        {
            SendMessageHandle handel = new SendMessageHandle();
            handel.SendMessageToButton((IntPtr)Convert.ToInt32(hexptr, 16));
        }

        /// <summary>
        /// 完整测试 多- 空 - 平
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_WholeBuy_Click(object sender, EventArgs e)
        {
            if (this.textBox_handleIns.Text == "" || this.textBox_handleBuy.Text == "")
            {
                MessageBox.Show("请输入合约的句柄/买入按钮的的句柄...");
                return;
            }

            try
            {
                SendString(this.textBox_handleIns.Text, this.textBox_ins.Text);
                SendClick(this.textBox_handleBuy.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Button_WholeSellshort_Click(object sender, EventArgs e)
        {
            if (this.textBox_handleIns.Text == "" || this.textBox_handleSellshort.Text == "")
            {
                MessageBox.Show("请输入合约的句柄/输入卖空按钮的的句柄...");
                return;
            }

            try
            {
                SendString(this.textBox_handleIns.Text, this.textBox_ins.Text);
                SendClick(this.textBox_handleSellshort.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Button_Wholecover_Click(object sender, EventArgs e)
        {
            if (this.textBox_handleIns.Text == "" || this.textBox_handleCover.Text == "")
            {
                MessageBox.Show("请输入合约的句柄/输入平仓按钮的的句柄...");
                return;
            }

            try
            {
                SendString(this.textBox_handleIns.Text, this.textBox_ins.Text);
                SendClick(this.textBox_handleCover.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_OutPut_Click(object sender, EventArgs e)
        {
            if (this.textBox_OutputHandle.Text == "")
            {
                MessageBox.Show("请输入MC-OutPut的句柄...");
                return;
            }

            try
            {
                string content = SendToMulticharts(this.textBox_OutputHandle.Text);
                if (content != null && content != "")
                {
                    this.textBox_outputInfo.AppendText(content);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private string m_startStr = string.Empty;
        /// <summary>
        /// 循环获取mc-ouput的值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerEvent_MCOutput(object sender, EventArgs e)
        {
            if (this.textBox_OutputHandle.Text == "") return;
            string content = SendToMulticharts(this.textBox_OutputHandle.Text);

            //加入richBox 分解并判断是否下单
            if (content != null && content != "" && content != m_startStr)
            {
                this.richTextBox_MCInfos.AppendText(content + "\n");

                //拆解下单




                m_startStr = content;
            }

        }

        /// <summary>
        /// 是否开启Timer取值开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChenckChanged_IsTmer(object sender, EventArgs e)
        {
            if(this.checkBox_TimeEvent.Checked)
            {
                this.timer1.Enabled = true;
                this.timer1.Start();
                return;
            }
            else
            {
                this.timer1.Enabled = false;
                this.timer1.Stop();
                return;
            }
        }
    }
}
