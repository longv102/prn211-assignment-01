namespace ProjectManagementWinApp_VuLong
{
    partial class frmProjectMgmt
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
            dgvResult = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();
            txtEstValue = new System.Windows.Forms.TextBox();
            txtContact = new System.Windows.Forms.TextBox();
            txtSponsor = new System.Windows.Forms.TextBox();
            txtCity = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            dtpEstStart = new System.Windows.Forms.DateTimePicker();
            dtpEstEnd = new System.Windows.Forms.DateTimePicker();
            groupBox1 = new System.Windows.Forms.GroupBox();
            cbName = new System.Windows.Forms.CheckBox();
            cbId = new System.Windows.Forms.CheckBox();
            btSearch = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            cboCity = new System.Windows.Forms.ComboBox();
            btDelete = new System.Windows.Forms.Button();
            btAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new System.Drawing.Point(11, 389);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.RowTemplate.Height = 29;
            dgvResult.Size = new System.Drawing.Size(911, 138);
            dgvResult.TabIndex = 0;
            dgvResult.CellDoubleClick += dgvResult_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(119, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(108, 74);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(91, 117);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(85, 20);
            label3.TabIndex = 3;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(108, 160);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(60, 20);
            label4.TabIndex = 4;
            label4.Text = "Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(61, 203);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(115, 20);
            label5.TabIndex = 5;
            label5.Text = "Estimated Value";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(514, 33);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(94, 20);
            label6.TabIndex = 6;
            label6.Text = "Est.StartDate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(514, 74);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(88, 20);
            label7.TabIndex = 7;
            label7.Text = "Est.EndDate";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(538, 117);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(62, 20);
            label8.TabIndex = 8;
            label8.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(554, 160);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(34, 20);
            label9.TabIndex = 9;
            label9.Text = "City";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(539, 203);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(63, 20);
            label10.TabIndex = 10;
            label10.Text = "Sponsor";
            // 
            // txtId
            // 
            txtId.Location = new System.Drawing.Point(182, 30);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(163, 27);
            txtId.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(182, 71);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(163, 27);
            txtName.TabIndex = 12;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(182, 114);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(163, 27);
            txtDescription.TabIndex = 13;
            // 
            // txtEstValue
            // 
            txtEstValue.Location = new System.Drawing.Point(182, 200);
            txtEstValue.Name = "txtEstValue";
            txtEstValue.Size = new System.Drawing.Size(163, 27);
            txtEstValue.TabIndex = 14;
            // 
            // txtContact
            // 
            txtContact.Location = new System.Drawing.Point(182, 157);
            txtContact.Name = "txtContact";
            txtContact.Size = new System.Drawing.Size(163, 27);
            txtContact.TabIndex = 15;
            // 
            // txtSponsor
            // 
            txtSponsor.Location = new System.Drawing.Point(614, 196);
            txtSponsor.Name = "txtSponsor";
            txtSponsor.Size = new System.Drawing.Size(163, 27);
            txtSponsor.TabIndex = 16;
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(614, 157);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(163, 27);
            txtCity.TabIndex = 17;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(614, 114);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(163, 27);
            txtAddress.TabIndex = 18;
            // 
            // dtpEstStart
            // 
            dtpEstStart.Location = new System.Drawing.Point(614, 31);
            dtpEstStart.Name = "dtpEstStart";
            dtpEstStart.Size = new System.Drawing.Size(233, 27);
            dtpEstStart.TabIndex = 19;
            // 
            // dtpEstEnd
            // 
            dtpEstEnd.Location = new System.Drawing.Point(614, 72);
            dtpEstEnd.Name = "dtpEstEnd";
            dtpEstEnd.Size = new System.Drawing.Size(233, 27);
            dtpEstEnd.TabIndex = 20;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbName);
            groupBox1.Controls.Add(cbId);
            groupBox1.Controls.Add(btSearch);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Location = new System.Drawing.Point(29, 266);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(316, 92);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Box";
            // 
            // cbName
            // 
            cbName.AutoSize = true;
            cbName.Location = new System.Drawing.Point(209, 62);
            cbName.Name = "cbName";
            cbName.Size = new System.Drawing.Size(71, 24);
            cbName.TabIndex = 3;
            cbName.Text = "Name";
            cbName.UseVisualStyleBackColor = true;
            // 
            // cbId
            // 
            cbId.AutoSize = true;
            cbId.Location = new System.Drawing.Point(209, 16);
            cbId.Name = "cbId";
            cbId.Size = new System.Drawing.Size(46, 24);
            cbId.TabIndex = 2;
            cbId.Text = "ID";
            cbId.UseVisualStyleBackColor = true;
            // 
            // btSearch
            // 
            btSearch.Location = new System.Drawing.Point(120, 41);
            btSearch.Name = "btSearch";
            btSearch.Size = new System.Drawing.Size(77, 29);
            btSearch.TabIndex = 1;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(6, 43);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(108, 27);
            txtSearch.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboCity);
            groupBox2.Location = new System.Drawing.Point(614, 266);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(270, 92);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filter";
            // 
            // cboCity
            // 
            cboCity.FormattingEnabled = true;
            cboCity.Location = new System.Drawing.Point(64, 39);
            cboCity.Name = "cboCity";
            cboCity.Size = new System.Drawing.Size(151, 28);
            cboCity.TabIndex = 0;
            cboCity.SelectedIndexChanged += cboCity_SelectedIndexChanged;
            // 
            // btDelete
            // 
            btDelete.DialogResult = System.Windows.Forms.DialogResult.Yes;
            btDelete.Location = new System.Drawing.Point(367, 305);
            btDelete.Name = "btDelete";
            btDelete.Size = new System.Drawing.Size(94, 29);
            btDelete.TabIndex = 23;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btAdd
            // 
            btAdd.Location = new System.Drawing.Point(485, 305);
            btAdd.Name = "btAdd";
            btAdd.Size = new System.Drawing.Size(90, 29);
            btAdd.TabIndex = 24;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // frmProjectMgmt
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(934, 539);
            Controls.Add(btAdd);
            Controls.Add(btDelete);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dtpEstEnd);
            Controls.Add(dtpEstStart);
            Controls.Add(txtAddress);
            Controls.Add(txtCity);
            Controls.Add(txtSponsor);
            Controls.Add(txtContact);
            Controls.Add(txtEstValue);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvResult);
            Name = "frmProjectMgmt";
            Text = "Project Management";
            Load += frmProjectMgmt_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtEstValue;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtSponsor;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtpEstStart;
        private System.Windows.Forms.DateTimePicker dtpEstEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox cbId;
        private System.Windows.Forms.CheckBox cbName;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Button btAdd;
    }
}