namespace SMS.WinApp
{
    partial class SearchUI
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
            this.companyCombo = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.searchItemDataGrid = new System.Windows.Forms.DataGridView();
            this.serialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchItemDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category";
            // 
            // companyCombo
            // 
            this.companyCombo.DataSource = this.companyBindingSource;
            this.companyCombo.DisplayMember = "Name";
            this.companyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companyCombo.FormattingEnabled = true;
            this.companyCombo.Location = new System.Drawing.Point(268, 68);
            this.companyCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.companyCombo.Name = "companyCombo";
            this.companyCombo.Size = new System.Drawing.Size(277, 28);
            this.companyCombo.TabIndex = 1;
            this.companyCombo.ValueMember = "Id";
            this.companyCombo.TextChanged += new System.EventHandler(this.companyCombo_TextChanged);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(SMS.Models.Company);
            // 
            // categoryCombo
            // 
            this.categoryCombo.DataSource = this.categoryBindingSource;
            this.categoryCombo.DisplayMember = "Name";
            this.categoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Location = new System.Drawing.Point(268, 110);
            this.categoryCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(277, 28);
            this.categoryCombo.TabIndex = 1;
            this.categoryCombo.ValueMember = "Id";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(SMS.Models.Category);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.searchButton.Image = global::SMS.WinApp.Properties.Resources.search60x70;
            this.searchButton.Location = new System.Drawing.Point(577, 85);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(81, 53);
            this.searchButton.TabIndex = 2;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchItemDataGrid
            // 
            this.searchItemDataGrid.AllowUserToAddRows = false;
            this.searchItemDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.searchItemDataGrid.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.searchItemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchItemDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNo});
            this.searchItemDataGrid.Location = new System.Drawing.Point(112, 166);
            this.searchItemDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchItemDataGrid.MaximumSize = new System.Drawing.Size(590, 300);
            this.searchItemDataGrid.MinimumSize = new System.Drawing.Size(590, 100);
            this.searchItemDataGrid.Name = "searchItemDataGrid";
            this.searchItemDataGrid.Size = new System.Drawing.Size(590, 300);
            this.searchItemDataGrid.TabIndex = 3;
            // 
            // serialNo
            // 
            this.serialNo.HeaderText = "S/N";
            this.serialNo.Name = "serialNo";
            this.serialNo.Width = 50;
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.exportButton.Image = global::SMS.WinApp.Properties.Resources.pdf;
            this.exportButton.Location = new System.Drawing.Point(652, 482);
            this.exportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(58, 58);
            this.exportButton.TabIndex = 4;
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.searchItemDataGrid);
            this.groupBox1.Controls.Add(this.exportButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.companyCombo);
            this.groupBox1.Controls.Add(this.categoryCombo);
            this.groupBox1.Location = new System.Drawing.Point(118, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(802, 588);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search and View Item Summery";
            // 
            // SearchUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1016, 616);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchUI";
            this.Text = "Search  Company , Category and View Item Summery ";
            this.Load += new System.EventHandler(this.SearchUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchItemDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox companyCombo;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView searchItemDataGrid;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNo;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}