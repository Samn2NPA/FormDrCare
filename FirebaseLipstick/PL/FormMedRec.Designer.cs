namespace FirebaseLipstick
{
    partial class FormMedRec
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
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.dataGridMedRec = new System.Windows.Forms.DataGridView();
            this.txtLoading = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.labelDate = new System.Windows.Forms.TextBox();
            this.labelStt = new System.Windows.Forms.TextBox();
            this.labelDoctorName = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.labelPatientName = new System.Windows.Forms.Label();
            this.txtSpecial = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelDoctorSpecial = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedRec)).BeginInit();
            this.groupBoxControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.dataGridMedRec);
            this.groupBoxInfo.Controls.Add(this.txtLoading);
            this.groupBoxInfo.Location = new System.Drawing.Point(13, 42);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(635, 235);
            this.groupBoxInfo.TabIndex = 3;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Medical Records - Waiting";
            // 
            // dataGridMedRec
            // 
            this.dataGridMedRec.AllowUserToAddRows = false;
            this.dataGridMedRec.AllowUserToDeleteRows = false;
            this.dataGridMedRec.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridMedRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedRec.Location = new System.Drawing.Point(13, 22);
            this.dataGridMedRec.Name = "dataGridMedRec";
            this.dataGridMedRec.Size = new System.Drawing.Size(604, 196);
            this.dataGridMedRec.TabIndex = 4;
            this.dataGridMedRec.Visible = false;
            this.dataGridMedRec.SelectionChanged += new System.EventHandler(this.dataGridLipstick_SelectedChanged);
            // 
            // txtLoading
            // 
            this.txtLoading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoading.Location = new System.Drawing.Point(263, 85);
            this.txtLoading.Name = "txtLoading";
            this.txtLoading.Size = new System.Drawing.Size(100, 16);
            this.txtLoading.TabIndex = 5;
            this.txtLoading.Text = "Loading....";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(16, 15);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(101, 16);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Search by name";
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.labelDate);
            this.groupBoxControl.Controls.Add(this.labelStt);
            this.groupBoxControl.Controls.Add(this.labelDoctorName);
            this.groupBoxControl.Controls.Add(this.txtDoctorName);
            this.groupBoxControl.Controls.Add(this.labelPatientName);
            this.groupBoxControl.Controls.Add(this.txtSpecial);
            this.groupBoxControl.Controls.Add(this.btnReset);
            this.groupBoxControl.Controls.Add(this.btnDelete);
            this.groupBoxControl.Controls.Add(this.btnUpdate);
            this.groupBoxControl.Controls.Add(this.btnAdd);
            this.groupBoxControl.Controls.Add(this.labelDoctorSpecial);
            this.groupBoxControl.Controls.Add(this.txtPatientName);
            this.groupBoxControl.Location = new System.Drawing.Point(13, 293);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(635, 186);
            this.groupBoxControl.TabIndex = 0;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "Controls";
            // 
            // labelDate
            // 
            this.labelDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelDate.Enabled = false;
            this.labelDate.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(498, 19);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(125, 20);
            this.labelDate.TabIndex = 14;
            this.labelDate.Text = "Date: 06/01/2018";
            // 
            // labelStt
            // 
            this.labelStt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelStt.Enabled = false;
            this.labelStt.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStt.Location = new System.Drawing.Point(110, 19);
            this.labelStt.Name = "labelStt";
            this.labelStt.Size = new System.Drawing.Size(113, 56);
            this.labelStt.TabIndex = 0;
            this.labelStt.Text = "123";
            // 
            // labelDoctorName
            // 
            this.labelDoctorName.AutoSize = true;
            this.labelDoctorName.Location = new System.Drawing.Point(10, 159);
            this.labelDoctorName.Name = "labelDoctorName";
            this.labelDoctorName.Size = new System.Drawing.Size(82, 16);
            this.labelDoctorName.TabIndex = 9;
            this.labelDoctorName.Text = "Doctor Name";
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(110, 156);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(425, 23);
            this.txtDoctorName.TabIndex = 7;
            // 
            // labelPatientName
            // 
            this.labelPatientName.AutoSize = true;
            this.labelPatientName.Location = new System.Drawing.Point(10, 97);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(84, 16);
            this.labelPatientName.TabIndex = 10;
            this.labelPatientName.Text = "Patient Name";
            // 
            // txtSpecial
            // 
            this.txtSpecial.Location = new System.Drawing.Point(110, 124);
            this.txtSpecial.Name = "txtSpecial";
            this.txtSpecial.Size = new System.Drawing.Size(425, 23);
            this.txtSpecial.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(422, 62);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(51, 26);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDelete.Location = new System.Drawing.Point(479, 63);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 25);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(541, 93);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 25);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(541, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 53);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelDoctorSpecial
            // 
            this.labelDoctorSpecial.AutoSize = true;
            this.labelDoctorSpecial.Location = new System.Drawing.Point(9, 126);
            this.labelDoctorSpecial.Name = "labelDoctorSpecial";
            this.labelDoctorSpecial.Size = new System.Drawing.Size(90, 16);
            this.labelDoctorSpecial.TabIndex = 13;
            this.labelDoctorSpecial.Text = "Doctor Special";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(110, 94);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(425, 23);
            this.txtPatientName.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(478, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(123, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(345, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // FormMedRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 498);
            this.Controls.Add(this.groupBoxControl);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormMedRec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medical Records";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedRec)).EndInit();
            this.groupBoxControl.ResumeLayout(false);
            this.groupBoxControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.DataGridView dataGridMedRec;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelDoctorSpecial;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label labelPatientName;
        private System.Windows.Forms.TextBox txtSpecial;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtLoading;
        private System.Windows.Forms.Label labelDoctorName;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.TextBox labelStt;
        private System.Windows.Forms.TextBox labelDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

