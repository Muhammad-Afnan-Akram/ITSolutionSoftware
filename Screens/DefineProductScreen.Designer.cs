using System;

namespace ITSolutionSoftware.Screens
{
    partial class DefineProductScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ProductName_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.ProductCategory_Textbox = new MetroFramework.Controls.MetroComboBox();
            this.SaveButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.ProductSupplier_Textbox = new MetroFramework.Controls.MetroComboBox();
            this.PurchasePrice_Textbox = new MetroFramework.Controls.MetroTextBox();
            this.SalePrice_Textbox = new MetroFramework.Controls.MetroTextBox();
            this.CloseButton = new MetroFramework.Controls.MetroButton();
            this.DefineNew_Button = new MetroFramework.Controls.MetroButton();
            this.ProductSize_Gridbox = new MetroFramework.Controls.MetroGrid();
            this.SelecttheProductSize = new MetroFramework.Controls.MetroLabel();
            this.Selectallsizes_Button = new MetroFramework.Controls.MetroButton();
            this.Deselectallsizes_Button = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSize_Gridbox)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(32, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Product Name";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // ProductName_TextBox
            // 
            // 
            // 
            // 
            this.ProductName_TextBox.CustomButton.Image = null;
            this.ProductName_TextBox.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.ProductName_TextBox.CustomButton.Name = "";
            this.ProductName_TextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ProductName_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProductName_TextBox.CustomButton.TabIndex = 1;
            this.ProductName_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ProductName_TextBox.CustomButton.UseSelectable = true;
            this.ProductName_TextBox.CustomButton.Visible = false;
            this.ProductName_TextBox.Lines = new string[0];
            this.ProductName_TextBox.Location = new System.Drawing.Point(182, 73);
            this.ProductName_TextBox.MaxLength = 32767;
            this.ProductName_TextBox.Name = "ProductName_TextBox";
            this.ProductName_TextBox.PasswordChar = '\0';
            this.ProductName_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ProductName_TextBox.SelectedText = "";
            this.ProductName_TextBox.SelectionLength = 0;
            this.ProductName_TextBox.SelectionStart = 0;
            this.ProductName_TextBox.ShortcutsEnabled = true;
            this.ProductName_TextBox.Size = new System.Drawing.Size(233, 29);
            this.ProductName_TextBox.TabIndex = 0;
            this.ProductName_TextBox.UseSelectable = true;
            this.ProductName_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProductName_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ProductName_TextBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // ProductCategory_Textbox
            // 
            this.ProductCategory_Textbox.FormattingEnabled = true;
            this.ProductCategory_Textbox.ItemHeight = 23;
            this.ProductCategory_Textbox.Location = new System.Drawing.Point(182, 121);
            this.ProductCategory_Textbox.Name = "ProductCategory_Textbox";
            this.ProductCategory_Textbox.Size = new System.Drawing.Size(233, 29);
            this.ProductCategory_Textbox.TabIndex = 1;
            this.ProductCategory_Textbox.UseSelectable = true;
            this.ProductCategory_Textbox.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Cyan;
            this.SaveButton.Location = new System.Drawing.Point(32, 323);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(315, 37);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(32, 121);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(117, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Product Category";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(32, 207);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Purchase Price";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(32, 163);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(110, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Product Supplier";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(32, 254);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(66, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Sale Price";
            // 
            // ProductSupplier_Textbox
            // 
            this.ProductSupplier_Textbox.FormattingEnabled = true;
            this.ProductSupplier_Textbox.ItemHeight = 23;
            this.ProductSupplier_Textbox.Location = new System.Drawing.Point(182, 163);
            this.ProductSupplier_Textbox.Name = "ProductSupplier_Textbox";
            this.ProductSupplier_Textbox.Size = new System.Drawing.Size(233, 29);
            this.ProductSupplier_Textbox.TabIndex = 2;
            this.ProductSupplier_Textbox.UseSelectable = true;
            // 
            // PurchasePrice_Textbox
            // 
            // 
            // 
            // 
            this.PurchasePrice_Textbox.CustomButton.Image = null;
            this.PurchasePrice_Textbox.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.PurchasePrice_Textbox.CustomButton.Name = "";
            this.PurchasePrice_Textbox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.PurchasePrice_Textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PurchasePrice_Textbox.CustomButton.TabIndex = 1;
            this.PurchasePrice_Textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PurchasePrice_Textbox.CustomButton.UseSelectable = true;
            this.PurchasePrice_Textbox.CustomButton.Visible = false;
            this.PurchasePrice_Textbox.Lines = new string[0];
            this.PurchasePrice_Textbox.Location = new System.Drawing.Point(182, 207);
            this.PurchasePrice_Textbox.MaxLength = 32767;
            this.PurchasePrice_Textbox.Name = "PurchasePrice_Textbox";
            this.PurchasePrice_Textbox.PasswordChar = '\0';
            this.PurchasePrice_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PurchasePrice_Textbox.SelectedText = "";
            this.PurchasePrice_Textbox.SelectionLength = 0;
            this.PurchasePrice_Textbox.SelectionStart = 0;
            this.PurchasePrice_Textbox.ShortcutsEnabled = true;
            this.PurchasePrice_Textbox.Size = new System.Drawing.Size(165, 29);
            this.PurchasePrice_Textbox.TabIndex = 3;
            this.PurchasePrice_Textbox.UseSelectable = true;
            this.PurchasePrice_Textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PurchasePrice_Textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SalePrice_Textbox
            // 
            // 
            // 
            // 
            this.SalePrice_Textbox.CustomButton.Image = null;
            this.SalePrice_Textbox.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.SalePrice_Textbox.CustomButton.Name = "";
            this.SalePrice_Textbox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.SalePrice_Textbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SalePrice_Textbox.CustomButton.TabIndex = 1;
            this.SalePrice_Textbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SalePrice_Textbox.CustomButton.UseSelectable = true;
            this.SalePrice_Textbox.CustomButton.Visible = false;
            this.SalePrice_Textbox.Lines = new string[0];
            this.SalePrice_Textbox.Location = new System.Drawing.Point(182, 254);
            this.SalePrice_Textbox.MaxLength = 32767;
            this.SalePrice_Textbox.Name = "SalePrice_Textbox";
            this.SalePrice_Textbox.PasswordChar = '\0';
            this.SalePrice_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SalePrice_Textbox.SelectedText = "";
            this.SalePrice_Textbox.SelectionLength = 0;
            this.SalePrice_Textbox.SelectionStart = 0;
            this.SalePrice_Textbox.ShortcutsEnabled = true;
            this.SalePrice_Textbox.Size = new System.Drawing.Size(165, 29);
            this.SalePrice_Textbox.TabIndex = 4;
            this.SalePrice_Textbox.UseSelectable = true;
            this.SalePrice_Textbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SalePrice_Textbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Cyan;
            this.CloseButton.Location = new System.Drawing.Point(32, 377);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(315, 37);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseSelectable = true;
            // 
            // DefineNew_Button
            // 
            this.DefineNew_Button.BackColor = System.Drawing.Color.Cyan;
            this.DefineNew_Button.Location = new System.Drawing.Point(520, 377);
            this.DefineNew_Button.Name = "DefineNew_Button";
            this.DefineNew_Button.Size = new System.Drawing.Size(257, 37);
            this.DefineNew_Button.TabIndex = 8;
            this.DefineNew_Button.Text = "Define New";
            this.DefineNew_Button.UseSelectable = true;
            // 
            // ProductSize_Gridbox
            // 
            this.ProductSize_Gridbox.AllowUserToResizeRows = false;
            this.ProductSize_Gridbox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProductSize_Gridbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProductSize_Gridbox.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductSize_Gridbox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductSize_Gridbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductSize_Gridbox.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductSize_Gridbox.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductSize_Gridbox.EnableHeadersVisualStyles = false;
            this.ProductSize_Gridbox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductSize_Gridbox.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductSize_Gridbox.Location = new System.Drawing.Point(509, 103);
            this.ProductSize_Gridbox.Name = "ProductSize_Gridbox";
            this.ProductSize_Gridbox.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductSize_Gridbox.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProductSize_Gridbox.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductSize_Gridbox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductSize_Gridbox.Size = new System.Drawing.Size(268, 257);
            this.ProductSize_Gridbox.TabIndex = 5;
            this.ProductSize_Gridbox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductSize_Gridbox_CellContentClick);
            // 
            // SelecttheProductSize
            // 
            this.SelecttheProductSize.AutoSize = true;
            this.SelecttheProductSize.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SelecttheProductSize.Location = new System.Drawing.Point(571, 73);
            this.SelecttheProductSize.Name = "SelecttheProductSize";
            this.SelecttheProductSize.Size = new System.Drawing.Size(147, 19);
            this.SelecttheProductSize.TabIndex = 9;
            this.SelecttheProductSize.Text = "Select the Product Size";
            // 
            // Selectallsizes_Button
            // 
            this.Selectallsizes_Button.Location = new System.Drawing.Point(475, 103);
            this.Selectallsizes_Button.Name = "Selectallsizes_Button";
            this.Selectallsizes_Button.Size = new System.Drawing.Size(28, 23);
            this.Selectallsizes_Button.TabIndex = 10;
            this.Selectallsizes_Button.Text = "S";
            this.Selectallsizes_Button.UseSelectable = true;
            // 
            // Deselectallsizes_Button
            // 
            this.Deselectallsizes_Button.Location = new System.Drawing.Point(475, 141);
            this.Deselectallsizes_Button.Name = "Deselectallsizes_Button";
            this.Deselectallsizes_Button.Size = new System.Drawing.Size(28, 23);
            this.Deselectallsizes_Button.TabIndex = 11;
            this.Deselectallsizes_Button.Text = "D";
            this.Deselectallsizes_Button.UseSelectable = true;
            // 
            // DefineProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Deselectallsizes_Button);
            this.Controls.Add(this.Selectallsizes_Button);
            this.Controls.Add(this.SelecttheProductSize);
            this.Controls.Add(this.ProductSize_Gridbox);
            this.Controls.Add(this.DefineNew_Button);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SalePrice_Textbox);
            this.Controls.Add(this.PurchasePrice_Textbox);
            this.Controls.Add(this.ProductSupplier_Textbox);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ProductCategory_Textbox);
            this.Controls.Add(this.ProductName_TextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "DefineProductScreen";
            this.Text = "Product Definition";
            this.Load += new System.EventHandler(this.DefineProductScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductSize_Gridbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox ProductName_TextBox;
        private MetroFramework.Controls.MetroComboBox ProductCategory_Textbox;
        private MetroFramework.Controls.MetroButton SaveButton;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox ProductSupplier_Textbox;
        private MetroFramework.Controls.MetroTextBox PurchasePrice_Textbox;
        private MetroFramework.Controls.MetroTextBox SalePrice_Textbox;
        private MetroFramework.Controls.MetroButton CloseButton;
        private MetroFramework.Controls.MetroButton DefineNew_Button;
        private MetroFramework.Controls.MetroGrid ProductSize_Gridbox;
        private MetroFramework.Controls.MetroLabel SelecttheProductSize;
        private MetroFramework.Controls.MetroButton Selectallsizes_Button;
        private MetroFramework.Controls.MetroButton Deselectallsizes_Button;
    }
}