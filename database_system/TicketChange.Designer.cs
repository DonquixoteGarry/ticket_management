namespace 票务交易系统
{
    partial class TicketChange
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
            this.BtnChange = new System.Windows.Forms.Button();
            this.TxtChange_Ticketid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtChange_EndTime = new System.Windows.Forms.TextBox();
            this.TxtChange_StartTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnChange
            // 
            this.BtnChange.Font = new System.Drawing.Font("宋体", 25F);
            this.BtnChange.Location = new System.Drawing.Point(395, 358);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(201, 79);
            this.BtnChange.TabIndex = 0;
            this.BtnChange.Text = "改签该车票";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtChange_Ticketid
            // 
            this.TxtChange_Ticketid.Font = new System.Drawing.Font("宋体", 25F);
            this.TxtChange_Ticketid.Location = new System.Drawing.Point(531, 65);
            this.TxtChange_Ticketid.Name = "TxtChange_Ticketid";
            this.TxtChange_Ticketid.Size = new System.Drawing.Size(137, 46);
            this.TxtChange_Ticketid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 25F);
            this.label1.Location = new System.Drawing.Point(238, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "车票编号:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 25F);
            this.label2.Location = new System.Drawing.Point(170, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "到站时间:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 25F);
            this.label4.Location = new System.Drawing.Point(170, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "出发时间:";
            // 
            // TxtChange_EndTime
            // 
            this.TxtChange_EndTime.Font = new System.Drawing.Font("宋体", 25F);
            this.TxtChange_EndTime.Location = new System.Drawing.Point(412, 239);
            this.TxtChange_EndTime.Name = "TxtChange_EndTime";
            this.TxtChange_EndTime.Size = new System.Drawing.Size(462, 46);
            this.TxtChange_EndTime.TabIndex = 9;
            // 
            // TxtChange_StartTime
            // 
            this.TxtChange_StartTime.Font = new System.Drawing.Font("宋体", 25F);
            this.TxtChange_StartTime.Location = new System.Drawing.Point(412, 153);
            this.TxtChange_StartTime.Name = "TxtChange_StartTime";
            this.TxtChange_StartTime.Size = new System.Drawing.Size(462, 46);
            this.TxtChange_StartTime.TabIndex = 10;
            // 
            // TicketChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 519);
            this.Controls.Add(this.TxtChange_StartTime);
            this.Controls.Add(this.TxtChange_EndTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtChange_Ticketid);
            this.Controls.Add(this.BtnChange);
            this.Name = "TicketChange";
            this.Text = "TicketChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.TextBox TxtChange_Ticketid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtChange_EndTime;
        private System.Windows.Forms.TextBox TxtChange_StartTime;
    }
}