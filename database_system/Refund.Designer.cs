namespace 票务交易系统
{
    partial class Refund
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
            this.LblRefund = new System.Windows.Forms.Label();
            this.TxtRefund = new System.Windows.Forms.TextBox();
            this.BtnRefund = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblRefund
            // 
            this.LblRefund.Font = new System.Drawing.Font("宋体", 25F);
            this.LblRefund.Location = new System.Drawing.Point(178, 156);
            this.LblRefund.Name = "LblRefund";
            this.LblRefund.Size = new System.Drawing.Size(159, 41);
            this.LblRefund.TabIndex = 0;
            this.LblRefund.Text = "车票编号";
            // 
            // TxtRefund
            // 
            this.TxtRefund.Font = new System.Drawing.Font("宋体", 25F);
            this.TxtRefund.Location = new System.Drawing.Point(399, 151);
            this.TxtRefund.Name = "TxtRefund";
            this.TxtRefund.Size = new System.Drawing.Size(236, 46);
            this.TxtRefund.TabIndex = 1;
            // 
            // BtnRefund
            // 
            this.BtnRefund.Font = new System.Drawing.Font("宋体", 30F);
            this.BtnRefund.Location = new System.Drawing.Point(304, 337);
            this.BtnRefund.Name = "BtnRefund";
            this.BtnRefund.Size = new System.Drawing.Size(193, 53);
            this.BtnRefund.TabIndex = 6;
            this.BtnRefund.Text = "确认退票";
            this.BtnRefund.UseVisualStyleBackColor = true;
            this.BtnRefund.Click += new System.EventHandler(this.BtnRefund_Click);
            // 
            // Refund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRefund);
            this.Controls.Add(this.TxtRefund);
            this.Controls.Add(this.LblRefund);
            this.Name = "Refund";
            this.Text = "Refund";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRefund;
        private System.Windows.Forms.TextBox TxtRefund;
        private System.Windows.Forms.Button BtnRefund;
    }
}