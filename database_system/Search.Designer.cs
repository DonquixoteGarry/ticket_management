namespace 票务交易系统
{
    partial class Search
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
            this.LblSearch_Ticketid = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.View1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.View1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSearch_Ticketid
            // 
            this.LblSearch_Ticketid.Font = new System.Drawing.Font("宋体", 25F);
            this.LblSearch_Ticketid.Location = new System.Drawing.Point(204, 40);
            this.LblSearch_Ticketid.Name = "LblSearch_Ticketid";
            this.LblSearch_Ticketid.Size = new System.Drawing.Size(176, 40);
            this.LblSearch_Ticketid.TabIndex = 0;
            this.LblSearch_Ticketid.Text = "车票编号:";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("宋体", 25F);
            this.TxtSearch.Location = new System.Drawing.Point(475, 37);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(154, 46);
            this.TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("宋体", 30F);
            this.BtnSearch.Location = new System.Drawing.Point(262, 264);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(384, 66);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "查询该票信息";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // View1
            // 
            this.View1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.View1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.View1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.View1.Location = new System.Drawing.Point(92, 129);
            this.View1.Name = "View1";
            this.View1.RowTemplate.Height = 23;
            this.View1.Size = new System.Drawing.Size(722, 94);
            this.View1.TabIndex = 3;
            this.View1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.View1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "购买者";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "始发站";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "终点站";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "出发时间";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "到站时间";
            this.Column5.Name = "Column5";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 423);
            this.Controls.Add(this.View1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.LblSearch_Ticketid);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSearch_Ticketid;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView View1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}