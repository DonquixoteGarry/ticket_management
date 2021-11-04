namespace 票务交易系统
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnBuy = new System.Windows.Forms.Button();
            this.BtnRefund = new System.Windows.Forms.Button();
            this.BtnRecord = new System.Windows.Forms.Button();
            this.BtnChange = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblBuyInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(270, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnBuy
            // 
            this.BtnBuy.Font = new System.Drawing.Font("宋体", 15F);
            this.BtnBuy.Location = new System.Drawing.Point(81, 192);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(150, 73);
            this.BtnBuy.TabIndex = 1;
            this.BtnBuy.Text = "购票";
            this.BtnBuy.UseVisualStyleBackColor = true;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // BtnRefund
            // 
            this.BtnRefund.Font = new System.Drawing.Font("宋体", 15F);
            this.BtnRefund.Location = new System.Drawing.Point(81, 503);
            this.BtnRefund.Name = "BtnRefund";
            this.BtnRefund.Size = new System.Drawing.Size(150, 71);
            this.BtnRefund.TabIndex = 2;
            this.BtnRefund.Text = "退票(VIP功能)";
            this.BtnRefund.UseVisualStyleBackColor = true;
            this.BtnRefund.Click += new System.EventHandler(this.BtnRefund_Click);
            // 
            // BtnRecord
            // 
            this.BtnRecord.Font = new System.Drawing.Font("宋体", 15F);
            this.BtnRecord.Location = new System.Drawing.Point(1002, 212);
            this.BtnRecord.Name = "BtnRecord";
            this.BtnRecord.Size = new System.Drawing.Size(145, 40);
            this.BtnRecord.TabIndex = 3;
            this.BtnRecord.Text = "查询票务记录";
            this.BtnRecord.UseVisualStyleBackColor = true;
            this.BtnRecord.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnChange
            // 
            this.BtnChange.Font = new System.Drawing.Font("宋体", 15F);
            this.BtnChange.Location = new System.Drawing.Point(1002, 518);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(145, 40);
            this.BtnChange.TabIndex = 4;
            this.BtnChange.Text = "票面资料改签";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("宋体", 20F);
            this.BtnExit.Location = new System.Drawing.Point(511, 376);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(187, 65);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "退出程序";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblBuyInfo
            // 
            this.LblBuyInfo.Font = new System.Drawing.Font("楷体", 20F);
            this.LblBuyInfo.Location = new System.Drawing.Point(12, 41);
            this.LblBuyInfo.Name = "LblBuyInfo";
            this.LblBuyInfo.Size = new System.Drawing.Size(312, 125);
            this.LblBuyInfo.TabIndex = 6;
            this.LblBuyInfo.Text = "前往购票需要提交:用户名,时间与路线安排(不得重复购买同一车票,已退的车票不得再次购买)";
            this.LblBuyInfo.Click += new System.EventHandler(this.LblBuyInfo_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("楷体", 20F);
            this.label1.Location = new System.Drawing.Point(30, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 88);
            this.label1.TabIndex = 7;
            this.label1.Text = "前往退票需要提交:车票编号(购买者需要拥有VIP资格)";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("楷体", 20F);
            this.label2.Location = new System.Drawing.Point(959, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 140);
            this.label2.TabIndex = 8;
            this.label2.Text = "查询票务记录需要提交:用户ID,车票编号";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("楷体", 20F);
            this.label3.Location = new System.Drawing.Point(959, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 140);
            this.label3.TabIndex = 9;
            this.label3.Text = "改签需要提交:用户ID,以及车票编号,以及新的时间安排";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 632);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblBuyInfo);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.BtnRecord);
            this.Controls.Add(this.BtnRefund);
            this.Controls.Add(this.BtnBuy);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnBuy;
        private System.Windows.Forms.Button BtnRefund;
        private System.Windows.Forms.Button BtnRecord;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblBuyInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}