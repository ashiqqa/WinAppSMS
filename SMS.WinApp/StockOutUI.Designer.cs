namespace SMS.WinApp
{
    partial class StockOutUI
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
            this.addItemDataGrid = new System.Windows.Forms.DataGridView();
            this.serialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lostButton = new System.Windows.Forms.Button();
            this.damageButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.showAvailableQuantity = new System.Windows.Forms.TextBox();
            this.showReorderLevel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itemCombo = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyCombo = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityBox = new System.Windows.Forms.NumericUpDown();
            this.notAvailableMsgLabel = new System.Windows.Forms.Label();
            this.qntyErrMsgLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.addItemDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addItemDataGrid
            // 
            this.addItemDataGrid.AllowUserToAddRows = false;
            this.addItemDataGrid.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.addItemDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addItemDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNo});
            this.addItemDataGrid.Location = new System.Drawing.Point(147, 362);
            this.addItemDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addItemDataGrid.Name = "addItemDataGrid";
            this.addItemDataGrid.Size = new System.Drawing.Size(393, 216);
            this.addItemDataGrid.TabIndex = 9;
            // 
            // serialNo
            // 
            this.serialNo.HeaderText = "S/N";
            this.serialNo.Name = "serialNo";
            this.serialNo.Width = 50;
            // 
            // lostButton
            // 
            this.lostButton.Image = global::SMS.WinApp.Properties.Resources.lost;
            this.lostButton.Location = new System.Drawing.Point(552, 513);
            this.lostButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lostButton.Name = "lostButton";
            this.lostButton.Size = new System.Drawing.Size(66, 53);
            this.lostButton.TabIndex = 6;
            this.lostButton.UseVisualStyleBackColor = true;
            this.lostButton.Click += new System.EventHandler(this.lostButton_Click);
            // 
            // damageButton
            // 
            this.damageButton.Image = global::SMS.WinApp.Properties.Resources.damage1;
            this.damageButton.Location = new System.Drawing.Point(552, 440);
            this.damageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.damageButton.Name = "damageButton";
            this.damageButton.Size = new System.Drawing.Size(65, 63);
            this.damageButton.TabIndex = 7;
            this.damageButton.UseVisualStyleBackColor = true;
            this.damageButton.Click += new System.EventHandler(this.damageButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Image = global::SMS.WinApp.Properties.Resources.sale;
            this.sellButton.Location = new System.Drawing.Point(552, 367);
            this.sellButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(65, 63);
            this.sellButton.TabIndex = 8;
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.ForestGreen;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(445, 306);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 46);
            this.addButton.TabIndex = 22;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // showAvailableQuantity
            // 
            this.showAvailableQuantity.Location = new System.Drawing.Point(276, 240);
            this.showAvailableQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showAvailableQuantity.Name = "showAvailableQuantity";
            this.showAvailableQuantity.ReadOnly = true;
            this.showAvailableQuantity.Size = new System.Drawing.Size(148, 26);
            this.showAvailableQuantity.TabIndex = 20;
            // 
            // showReorderLevel
            // 
            this.showReorderLevel.Location = new System.Drawing.Point(276, 195);
            this.showReorderLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showReorderLevel.Name = "showReorderLevel";
            this.showReorderLevel.ReadOnly = true;
            this.showReorderLevel.Size = new System.Drawing.Size(148, 26);
            this.showReorderLevel.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 276);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Available Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Reorder Level";
            // 
            // itemCombo
            // 
            this.itemCombo.DataSource = this.itemBindingSource;
            this.itemCombo.DisplayMember = "Name";
            this.itemCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemCombo.FormattingEnabled = true;
            this.itemCombo.Location = new System.Drawing.Point(278, 157);
            this.itemCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemCombo.Name = "itemCombo";
            this.itemCombo.Size = new System.Drawing.Size(283, 28);
            this.itemCombo.TabIndex = 14;
            this.itemCombo.ValueMember = "Id";
            this.itemCombo.SelectedValueChanged += new System.EventHandler(this.itemCombo_SelectedValueChanged);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(SMS.Models.Item);
            // 
            // companyCombo
            // 
            this.companyCombo.DataSource = this.companyBindingSource;
            this.companyCombo.DisplayMember = "Name";
            this.companyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companyCombo.FormattingEnabled = true;
            this.companyCombo.Location = new System.Drawing.Point(276, 119);
            this.companyCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.companyCombo.Name = "companyCombo";
            this.companyCombo.Size = new System.Drawing.Size(283, 28);
            this.companyCombo.TabIndex = 15;
            this.companyCombo.ValueMember = "Id";
            this.companyCombo.TextChanged += new System.EventHandler(this.companyCombo_TextChanged);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(SMS.Models.Company);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Company";
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(276, 276);
            this.quantityBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(150, 26);
            this.quantityBox.TabIndex = 23;
            this.quantityBox.ValueChanged += new System.EventHandler(this.quantityBox_ValueChanged);
            // 
            // notAvailableMsgLabel
            // 
            this.notAvailableMsgLabel.AutoSize = true;
            this.notAvailableMsgLabel.ForeColor = System.Drawing.Color.Red;
            this.notAvailableMsgLabel.Location = new System.Drawing.Point(437, 243);
            this.notAvailableMsgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.notAvailableMsgLabel.Name = "notAvailableMsgLabel";
            this.notAvailableMsgLabel.Size = new System.Drawing.Size(0, 20);
            this.notAvailableMsgLabel.TabIndex = 25;
            // 
            // qntyErrMsgLabel
            // 
            this.qntyErrMsgLabel.AutoSize = true;
            this.qntyErrMsgLabel.ForeColor = System.Drawing.Color.Red;
            this.qntyErrMsgLabel.Location = new System.Drawing.Point(437, 281);
            this.qntyErrMsgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qntyErrMsgLabel.Name = "qntyErrMsgLabel";
            this.qntyErrMsgLabel.Size = new System.Drawing.Size(0, 20);
            this.qntyErrMsgLabel.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.addItemDataGrid);
            this.groupBox1.Controls.Add(this.lostButton);
            this.groupBox1.Controls.Add(this.damageButton);
            this.groupBox1.Controls.Add(this.qntyErrMsgLabel);
            this.groupBox1.Controls.Add(this.sellButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.notAvailableMsgLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.quantityBox);
            this.groupBox1.Controls.Add(this.companyCombo);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.itemCombo);
            this.groupBox1.Controls.Add(this.showAvailableQuantity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.showReorderLevel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(154, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 596);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Out";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::SMS.WinApp.Properties.Resources.stock1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // StockOutUI
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
            this.Name = "StockOutUI";
            this.Text = "Stock Out Item";
            this.Load += new System.EventHandler(this.StockOutUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addItemDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView addItemDataGrid;
        private System.Windows.Forms.Button lostButton;
        private System.Windows.Forms.Button damageButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox showAvailableQuantity;
        private System.Windows.Forms.TextBox showReorderLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox itemCombo;
        private System.Windows.Forms.ComboBox companyCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.NumericUpDown quantityBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNo;
        private System.Windows.Forms.Label notAvailableMsgLabel;
        private System.Windows.Forms.Label qntyErrMsgLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}