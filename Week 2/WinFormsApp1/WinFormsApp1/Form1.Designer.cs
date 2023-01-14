namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtIndexNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chkBoxSports = new System.Windows.Forms.CheckBox();
            this.chkBoxReading = new System.Windows.Forms.CheckBox();
            this.cmboBoxProvince = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radBtnMale = new System.Windows.Forms.RadioButton();
            this.radBtnFemale = new System.Windows.Forms.RadioButton();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(191, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program for Student\'s data";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(200, 147);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(210, 27);
            this.txtBoxName.TabIndex = 1;
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(200, 215);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(210, 27);
            this.txtBoxAge.TabIndex = 2;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(200, 278);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(210, 27);
            this.txtBoxAddress.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(203, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Age: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address: ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.Color.Snow;
            this.btnSubmit.Location = new System.Drawing.Point(200, 388);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(207, 50);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetails.Location = new System.Drawing.Point(459, 118);
            this.lblDetails.MaximumSize = new System.Drawing.Size(340, 28);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(0, 28);
            this.lblDetails.TabIndex = 9;
            // 
            // txtIndexNo
            // 
            this.txtIndexNo.Location = new System.Drawing.Point(481, 326);
            this.txtIndexNo.Name = "txtIndexNo";
            this.txtIndexNo.Size = new System.Drawing.Size(198, 27);
            this.txtIndexNo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Index No: ";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.Cyan;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.Snow;
            this.btnSearch.Location = new System.Drawing.Point(481, 388);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(207, 50);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chkBoxSports
            // 
            this.chkBoxSports.AutoSize = true;
            this.chkBoxSports.Location = new System.Drawing.Point(200, 329);
            this.chkBoxSports.Name = "chkBoxSports";
            this.chkBoxSports.Size = new System.Drawing.Size(73, 24);
            this.chkBoxSports.TabIndex = 13;
            this.chkBoxSports.Text = "Sports";
            this.chkBoxSports.UseVisualStyleBackColor = true;
            // 
            // chkBoxReading
            // 
            this.chkBoxReading.AutoSize = true;
            this.chkBoxReading.Location = new System.Drawing.Point(334, 329);
            this.chkBoxReading.Name = "chkBoxReading";
            this.chkBoxReading.Size = new System.Drawing.Size(86, 24);
            this.chkBoxReading.TabIndex = 14;
            this.chkBoxReading.Text = "Reading";
            this.chkBoxReading.UseVisualStyleBackColor = true;
            // 
            // cmboBoxProvince
            // 
            this.cmboBoxProvince.FormattingEnabled = true;
            this.cmboBoxProvince.Items.AddRange(new object[] {
            "Province 1",
            "Bagmati",
            "Madesh",
            "Gandaki",
            "Province 5",
            "Sudur Paschim",
            "Province 7"});
            this.cmboBoxProvince.Location = new System.Drawing.Point(481, 214);
            this.cmboBoxProvince.Name = "cmboBoxProvince";
            this.cmboBoxProvince.Size = new System.Drawing.Size(207, 28);
            this.cmboBoxProvince.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Province: ";
            // 
            // radBtnMale
            // 
            this.radBtnMale.AutoSize = true;
            this.radBtnMale.Location = new System.Drawing.Point(481, 255);
            this.radBtnMale.Name = "radBtnMale";
            this.radBtnMale.Size = new System.Drawing.Size(63, 24);
            this.radBtnMale.TabIndex = 17;
            this.radBtnMale.TabStop = true;
            this.radBtnMale.Text = "Male";
            this.radBtnMale.UseVisualStyleBackColor = true;
            // 
            // radBtnFemale
            // 
            this.radBtnFemale.AutoSize = true;
            this.radBtnFemale.Location = new System.Drawing.Point(610, 255);
            this.radBtnFemale.Name = "radBtnFemale";
            this.radBtnFemale.Size = new System.Drawing.Size(78, 24);
            this.radBtnFemale.TabIndex = 18;
            this.radBtnFemale.TabStop = true;
            this.radBtnFemale.Text = "Female";
            this.radBtnFemale.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radBtnFemale.UseVisualStyleBackColor = true;
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Address,
            this.Age});
            this.gridView.Location = new System.Drawing.Point(719, 120);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersWidth = 51;
            this.gridView.RowTemplate.Height = 29;
            this.gridView.Size = new System.Drawing.Size(420, 188);
            this.gridView.TabIndex = 19;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 450);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.radBtnFemale);
            this.Controls.Add(this.radBtnMale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmboBoxProvince);
            this.Controls.Add(this.chkBoxReading);
            this.Controls.Add(this.chkBoxSports);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIndexNo);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label1);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtBoxName;
        private TextBox txtBoxAge;
        private TextBox txtBoxAddress;
        private Label lblName;
        private Label label2;
        private Label label3;
        private Button btnSubmit;
        private Label lblDetails;
        private TextBox txtIndexNo;
        private Label label4;
        private Button btnSearch;
        private CheckBox chkBoxSports;
        private CheckBox chkBoxReading;
        private ComboBox cmboBoxProvince;
        private Label label5;
        private RadioButton radBtnMale;
        private RadioButton radBtnFemale;
        private DataGridView gridView;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Age;
    }
}