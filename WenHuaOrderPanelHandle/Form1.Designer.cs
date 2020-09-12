namespace WenHuaOrderPanelHandle
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ins = new System.Windows.Forms.TextBox();
            this.textBox_shares = new System.Windows.Forms.TextBox();
            this.textBox_jiageTypes = new System.Windows.Forms.TextBox();
            this.button_Buy = new System.Windows.Forms.Button();
            this.button_Cover = new System.Windows.Forms.Button();
            this.button_Sellshort = new System.Windows.Forms.Button();
            this.textBox_handleBuy = new System.Windows.Forms.TextBox();
            this.textBox_handleSellshort = new System.Windows.Forms.TextBox();
            this.textBox_handleCover = new System.Windows.Forms.TextBox();
            this.textBox_handleIns = new System.Windows.Forms.TextBox();
            this.textBox_handleShares = new System.Windows.Forms.TextBox();
            this.textBox_handletypes = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_TestIns = new System.Windows.Forms.Button();
            this.button_testSha = new System.Windows.Forms.Button();
            this.button_TestCov = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_WholeBuy = new System.Windows.Forms.Button();
            this.button_WholeSellshort = new System.Windows.Forms.Button();
            this.button_Wholecover = new System.Windows.Forms.Button();
            this.button_OutPut = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_OutputHandle = new System.Windows.Forms.TextBox();
            this.textBox_outputInfo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_TimeEvent = new System.Windows.Forms.CheckBox();
            this.richTextBox_MCInfos = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "合约:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "手数:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "类型:";
            // 
            // textBox_ins
            // 
            this.textBox_ins.Location = new System.Drawing.Point(48, 20);
            this.textBox_ins.Name = "textBox_ins";
            this.textBox_ins.Size = new System.Drawing.Size(120, 21);
            this.textBox_ins.TabIndex = 3;
            this.textBox_ins.Text = "IF2009";
            // 
            // textBox_shares
            // 
            this.textBox_shares.Location = new System.Drawing.Point(48, 61);
            this.textBox_shares.Name = "textBox_shares";
            this.textBox_shares.ReadOnly = true;
            this.textBox_shares.Size = new System.Drawing.Size(120, 21);
            this.textBox_shares.TabIndex = 4;
            this.textBox_shares.Text = "1";
            // 
            // textBox_jiageTypes
            // 
            this.textBox_jiageTypes.Location = new System.Drawing.Point(48, 100);
            this.textBox_jiageTypes.Name = "textBox_jiageTypes";
            this.textBox_jiageTypes.ReadOnly = true;
            this.textBox_jiageTypes.Size = new System.Drawing.Size(120, 21);
            this.textBox_jiageTypes.TabIndex = 5;
            this.textBox_jiageTypes.Text = "对手价";
            // 
            // button_Buy
            // 
            this.button_Buy.BackColor = System.Drawing.Color.Red;
            this.button_Buy.Location = new System.Drawing.Point(9, 130);
            this.button_Buy.Name = "button_Buy";
            this.button_Buy.Size = new System.Drawing.Size(66, 23);
            this.button_Buy.TabIndex = 6;
            this.button_Buy.Text = "买多";
            this.button_Buy.UseVisualStyleBackColor = false;
            this.button_Buy.Click += new System.EventHandler(this.Button_Buy_Click);
            // 
            // button_Cover
            // 
            this.button_Cover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Cover.Location = new System.Drawing.Point(9, 188);
            this.button_Cover.Name = "button_Cover";
            this.button_Cover.Size = new System.Drawing.Size(66, 23);
            this.button_Cover.TabIndex = 7;
            this.button_Cover.Text = "平仓";
            this.button_Cover.UseVisualStyleBackColor = false;
            this.button_Cover.Click += new System.EventHandler(this.Button_Cover_Click);
            // 
            // button_Sellshort
            // 
            this.button_Sellshort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Sellshort.Location = new System.Drawing.Point(9, 159);
            this.button_Sellshort.Name = "button_Sellshort";
            this.button_Sellshort.Size = new System.Drawing.Size(66, 23);
            this.button_Sellshort.TabIndex = 8;
            this.button_Sellshort.Text = "卖空";
            this.button_Sellshort.UseVisualStyleBackColor = false;
            this.button_Sellshort.Click += new System.EventHandler(this.Button_Sellshort_Click);
            // 
            // textBox_handleBuy
            // 
            this.textBox_handleBuy.Location = new System.Drawing.Point(81, 132);
            this.textBox_handleBuy.Name = "textBox_handleBuy";
            this.textBox_handleBuy.Size = new System.Drawing.Size(106, 21);
            this.textBox_handleBuy.TabIndex = 9;
            // 
            // textBox_handleSellshort
            // 
            this.textBox_handleSellshort.Location = new System.Drawing.Point(81, 161);
            this.textBox_handleSellshort.Name = "textBox_handleSellshort";
            this.textBox_handleSellshort.Size = new System.Drawing.Size(106, 21);
            this.textBox_handleSellshort.TabIndex = 10;
            // 
            // textBox_handleCover
            // 
            this.textBox_handleCover.Location = new System.Drawing.Point(81, 188);
            this.textBox_handleCover.Name = "textBox_handleCover";
            this.textBox_handleCover.Size = new System.Drawing.Size(106, 21);
            this.textBox_handleCover.TabIndex = 11;
            // 
            // textBox_handleIns
            // 
            this.textBox_handleIns.Location = new System.Drawing.Point(186, 19);
            this.textBox_handleIns.Name = "textBox_handleIns";
            this.textBox_handleIns.Size = new System.Drawing.Size(106, 21);
            this.textBox_handleIns.TabIndex = 12;
            // 
            // textBox_handleShares
            // 
            this.textBox_handleShares.Location = new System.Drawing.Point(186, 59);
            this.textBox_handleShares.Name = "textBox_handleShares";
            this.textBox_handleShares.ReadOnly = true;
            this.textBox_handleShares.Size = new System.Drawing.Size(106, 21);
            this.textBox_handleShares.TabIndex = 13;
            // 
            // textBox_handletypes
            // 
            this.textBox_handletypes.Location = new System.Drawing.Point(186, 99);
            this.textBox_handletypes.Name = "textBox_handletypes";
            this.textBox_handletypes.ReadOnly = true;
            this.textBox_handletypes.Size = new System.Drawing.Size(106, 21);
            this.textBox_handletypes.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Wholecover);
            this.groupBox1.Controls.Add(this.button_WholeSellshort);
            this.groupBox1.Controls.Add(this.button_WholeBuy);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button_TestIns);
            this.groupBox1.Controls.Add(this.button_testSha);
            this.groupBox1.Controls.Add(this.button_TestCov);
            this.groupBox1.Controls.Add(this.textBox_handletypes);
            this.groupBox1.Controls.Add(this.textBox_handleCover);
            this.groupBox1.Controls.Add(this.textBox_handleShares);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_handleIns);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_handleSellshort);
            this.groupBox1.Controls.Add(this.textBox_ins);
            this.groupBox1.Controls.Add(this.textBox_handleBuy);
            this.groupBox1.Controls.Add(this.textBox_shares);
            this.groupBox1.Controls.Add(this.button_Sellshort);
            this.groupBox1.Controls.Add(this.textBox_jiageTypes);
            this.groupBox1.Controls.Add(this.button_Cover);
            this.groupBox1.Controls.Add(this.button_Buy);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 226);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文华财经下单版映射";
            // 
            // button_TestIns
            // 
            this.button_TestIns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_TestIns.Location = new System.Drawing.Point(298, 18);
            this.button_TestIns.Name = "button_TestIns";
            this.button_TestIns.Size = new System.Drawing.Size(66, 23);
            this.button_TestIns.TabIndex = 17;
            this.button_TestIns.Text = "测试Ins";
            this.button_TestIns.UseVisualStyleBackColor = false;
            this.button_TestIns.Click += new System.EventHandler(this.Button_TestIns_Click);
            // 
            // button_testSha
            // 
            this.button_testSha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_testSha.Location = new System.Drawing.Point(298, 56);
            this.button_testSha.Name = "button_testSha";
            this.button_testSha.Size = new System.Drawing.Size(66, 23);
            this.button_testSha.TabIndex = 16;
            this.button_testSha.Text = "测试Sha";
            this.button_testSha.UseVisualStyleBackColor = false;
            this.button_testSha.Click += new System.EventHandler(this.Button_testSha_Click);
            // 
            // button_TestCov
            // 
            this.button_TestCov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_TestCov.Location = new System.Drawing.Point(298, 97);
            this.button_TestCov.Name = "button_TestCov";
            this.button_TestCov.Size = new System.Drawing.Size(66, 23);
            this.button_TestCov.TabIndex = 15;
            this.button_TestCov.Text = "测试Cov";
            this.button_TestCov.UseVisualStyleBackColor = false;
            this.button_TestCov.Click += new System.EventHandler(this.Button_TestCov_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.textBox_outputInfo);
            this.groupBox2.Controls.Add(this.button_OutPut);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_OutputHandle);
            this.groupBox2.Location = new System.Drawing.Point(461, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 226);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Multicharts下单信号获取";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(701, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "备注:手数和类型暂时全部为文华默认的1/对手价,Handle也可以暂时不做映射(MC只需要打印时间，品种，方向，股指其他默认即可)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "按合约,买多完整测试:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "按合约,平仓完整测试:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "按合约,卖空完整测试:";
            // 
            // button_WholeBuy
            // 
            this.button_WholeBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_WholeBuy.Location = new System.Drawing.Point(341, 126);
            this.button_WholeBuy.Name = "button_WholeBuy";
            this.button_WholeBuy.Size = new System.Drawing.Size(66, 23);
            this.button_WholeBuy.TabIndex = 21;
            this.button_WholeBuy.Text = "买入";
            this.button_WholeBuy.UseVisualStyleBackColor = false;
            this.button_WholeBuy.Click += new System.EventHandler(this.Button_WholeBuy_Click);
            // 
            // button_WholeSellshort
            // 
            this.button_WholeSellshort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_WholeSellshort.Location = new System.Drawing.Point(341, 157);
            this.button_WholeSellshort.Name = "button_WholeSellshort";
            this.button_WholeSellshort.Size = new System.Drawing.Size(66, 23);
            this.button_WholeSellshort.TabIndex = 22;
            this.button_WholeSellshort.Text = "卖空";
            this.button_WholeSellshort.UseVisualStyleBackColor = false;
            this.button_WholeSellshort.Click += new System.EventHandler(this.Button_WholeSellshort_Click);
            // 
            // button_Wholecover
            // 
            this.button_Wholecover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Wholecover.Location = new System.Drawing.Point(341, 186);
            this.button_Wholecover.Name = "button_Wholecover";
            this.button_Wholecover.Size = new System.Drawing.Size(66, 23);
            this.button_Wholecover.TabIndex = 23;
            this.button_Wholecover.Text = "平仓";
            this.button_Wholecover.UseVisualStyleBackColor = false;
            this.button_Wholecover.Click += new System.EventHandler(this.Button_Wholecover_Click);
            // 
            // button_OutPut
            // 
            this.button_OutPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_OutPut.Location = new System.Drawing.Point(5, 78);
            this.button_OutPut.Name = "button_OutPut";
            this.button_OutPut.Size = new System.Drawing.Size(257, 23);
            this.button_OutPut.TabIndex = 20;
            this.button_OutPut.Text = "获取输出内容并清空输出窗口";
            this.button_OutPut.UseVisualStyleBackColor = false;
            this.button_OutPut.Click += new System.EventHandler(this.Button_OutPut_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "输出窗口句柄:";
            // 
            // textBox_OutputHandle
            // 
            this.textBox_OutputHandle.Location = new System.Drawing.Point(104, 26);
            this.textBox_OutputHandle.Name = "textBox_OutputHandle";
            this.textBox_OutputHandle.Size = new System.Drawing.Size(158, 21);
            this.textBox_OutputHandle.TabIndex = 19;
            // 
            // textBox_outputInfo
            // 
            this.textBox_outputInfo.Location = new System.Drawing.Point(6, 53);
            this.textBox_outputInfo.Name = "textBox_outputInfo";
            this.textBox_outputInfo.Size = new System.Drawing.Size(256, 21);
            this.textBox_outputInfo.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox_MCInfos);
            this.groupBox3.Controls.Add(this.checkBox_TimeEvent);
            this.groupBox3.Location = new System.Drawing.Point(5, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 112);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "时钟定时器扫描并下单";
            // 
            // checkBox_TimeEvent
            // 
            this.checkBox_TimeEvent.AutoSize = true;
            this.checkBox_TimeEvent.Location = new System.Drawing.Point(7, 21);
            this.checkBox_TimeEvent.Name = "checkBox_TimeEvent";
            this.checkBox_TimeEvent.Size = new System.Drawing.Size(216, 16);
            this.checkBox_TimeEvent.TabIndex = 0;
            this.checkBox_TimeEvent.Text = "是否开启定时器并扫描满足条件下单";
            this.checkBox_TimeEvent.UseVisualStyleBackColor = true;
            this.checkBox_TimeEvent.CheckedChanged += new System.EventHandler(this.ChenckChanged_IsTmer);
            // 
            // richTextBox_MCInfos
            // 
            this.richTextBox_MCInfos.Location = new System.Drawing.Point(7, 44);
            this.richTextBox_MCInfos.Name = "richTextBox_MCInfos";
            this.richTextBox_MCInfos.Size = new System.Drawing.Size(311, 53);
            this.richTextBox_MCInfos.TabIndex = 1;
            this.richTextBox_MCInfos.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.TimerEvent_MCOutput);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 277);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Multicharts映射到文华财经下单工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ins;
        private System.Windows.Forms.TextBox textBox_shares;
        private System.Windows.Forms.TextBox textBox_jiageTypes;
        private System.Windows.Forms.Button button_Buy;
        private System.Windows.Forms.Button button_Cover;
        private System.Windows.Forms.Button button_Sellshort;
        private System.Windows.Forms.TextBox textBox_handleBuy;
        private System.Windows.Forms.TextBox textBox_handleSellshort;
        private System.Windows.Forms.TextBox textBox_handleCover;
        private System.Windows.Forms.TextBox textBox_handleIns;
        private System.Windows.Forms.TextBox textBox_handleShares;
        private System.Windows.Forms.TextBox textBox_handletypes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_TestIns;
        private System.Windows.Forms.Button button_testSha;
        private System.Windows.Forms.Button button_TestCov;
        private System.Windows.Forms.Button button_Wholecover;
        private System.Windows.Forms.Button button_WholeSellshort;
        private System.Windows.Forms.Button button_WholeBuy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_outputInfo;
        private System.Windows.Forms.Button button_OutPut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_OutputHandle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox_MCInfos;
        private System.Windows.Forms.CheckBox checkBox_TimeEvent;
        private System.Windows.Forms.Timer timer1;
    }
}

