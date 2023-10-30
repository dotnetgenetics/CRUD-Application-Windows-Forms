namespace CRUDApplicationWindowsForms
{
   partial class FStudents
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
         SuspendLayout();
         this.dgvStudents = new System.Windows.Forms.DataGridView();
         this.txtName = new System.Windows.Forms.TextBox();
         this.txtAge = new System.Windows.Forms.TextBox();
         this.txtContact = new System.Windows.Forms.TextBox();
         this.txtAddress = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.btnSave = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
         this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
         ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // dgvStudents
         // 
         this.dgvStudents.AllowUserToAddRows = false;
         this.dgvStudents.AllowUserToDeleteRows = false;
         this.dgvStudents.AllowUserToResizeColumns = false;
         this.dgvStudents.AllowUserToResizeRows = false;
         this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colAge,
            this.colAddress,
            this.colContact,
            this.colEdit,
            this.colDelete});
         this.dgvStudents.Location = new System.Drawing.Point(12, 180);
         this.dgvStudents.Name = "dgvStudents";
         this.dgvStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
         this.dgvStudents.Size = new System.Drawing.Size(551, 229);
         this.dgvStudents.TabIndex = 0;
         this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
         // 
         // txtName
         // 
         this.txtName.Location = new System.Drawing.Point(78, 19);
         this.txtName.Name = "txtName";
         this.txtName.Size = new System.Drawing.Size(273, 20);
         this.txtName.TabIndex = 1;
         // 
         // txtAge
         // 
         this.txtAge.Location = new System.Drawing.Point(78, 44);
         this.txtAge.Name = "txtAge";
         this.txtAge.Size = new System.Drawing.Size(79, 20);
         this.txtAge.TabIndex = 2;
         // 
         // txtContact
         // 
         this.txtContact.Location = new System.Drawing.Point(78, 95);
         this.txtContact.Name = "txtContact";
         this.txtContact.Size = new System.Drawing.Size(273, 20);
         this.txtContact.TabIndex = 4;
         // 
         // txtAddress
         // 
         this.txtAddress.Location = new System.Drawing.Point(78, 69);
         this.txtAddress.Name = "txtAddress";
         this.txtAddress.Size = new System.Drawing.Size(273, 20);
         this.txtAddress.TabIndex = 3;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(25, 23);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(35, 13);
         this.label1.TabIndex = 5;
         this.label1.Text = "Name";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(25, 48);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(26, 13);
         this.label2.TabIndex = 6;
         this.label2.Text = "Age";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(25, 77);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(45, 13);
         this.label3.TabIndex = 7;
         this.label3.Text = "Address";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(25, 100);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(44, 13);
         this.label4.TabIndex = 8;
         this.label4.Text = "Contact";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.txtName);
         this.groupBox1.Controls.Add(this.label4);
         this.groupBox1.Controls.Add(this.txtAge);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.txtAddress);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.txtContact);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Location = new System.Drawing.Point(12, 12);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(552, 128);
         this.groupBox1.TabIndex = 9;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Student Details";
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(391, 145);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(83, 25);
         this.btnSave.TabIndex = 10;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.Location = new System.Drawing.Point(478, 145);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(85, 25);
         this.btnCancel.TabIndex = 11;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // colID
         // 
         this.colID.DataPropertyName = "ID";
         this.colID.Frozen = true;
         this.colID.HeaderText = "ID";
         this.colID.Name = "colID";
         this.colID.ReadOnly = true;
         this.colID.Visible = false;
         // 
         // colName
         // 
         this.colName.DataPropertyName = "Name";
         this.colName.Frozen = true;
         this.colName.HeaderText = "Name";
         this.colName.Name = "colName";
         this.colName.ReadOnly = true;
         // 
         // colAge
         // 
         this.colAge.DataPropertyName = "Age";
         this.colAge.Frozen = true;
         this.colAge.HeaderText = "Age";
         this.colAge.Name = "colAge";
         this.colAge.ReadOnly = true;
         // 
         // colAddress
         // 
         this.colAddress.DataPropertyName = "Address";
         this.colAddress.Frozen = true;
         this.colAddress.HeaderText = "Address";
         this.colAddress.Name = "colAddress";
         this.colAddress.ReadOnly = true;
         // 
         // colContact
         // 
         this.colContact.DataPropertyName = "Contact";
         this.colContact.Frozen = true;
         this.colContact.HeaderText = "Contact";
         this.colContact.Name = "colContact";
         // 
         // colEdit
         // 
         this.colEdit.Frozen = true;
         this.colEdit.HeaderText = "Edit";
         this.colEdit.Name = "colEdit";
         this.colEdit.Text = "Edit";
         this.colEdit.UseColumnTextForButtonValue = true;
         this.colEdit.Width = 50;
         // 
         // colDelete
         // 
         this.colDelete.Frozen = true;
         this.colDelete.HeaderText = "Delete";
         this.colDelete.Name = "colDelete";
         this.colDelete.Text = "Delete";
         this.colDelete.UseColumnTextForButtonValue = true;
         this.colDelete.Width = 50;
         // 
         // FStudents
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(578, 428);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.dgvStudents);
         FormBorderStyle = FormBorderStyle.FixedToolWindow;
         Name = "FStudents";
         StartPosition = FormStartPosition.CenterScreen;
         Text = "Student Entry Form";
         this.Load += new System.EventHandler(this.FStudents_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         ResumeLayout(false);
      }

      #endregion

      private System.Windows.Forms.DataGridView dgvStudents;
      private System.Windows.Forms.TextBox txtName;
      private System.Windows.Forms.TextBox txtAge;
      private System.Windows.Forms.TextBox txtContact;
      private System.Windows.Forms.TextBox txtAddress;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.DataGridViewTextBoxColumn colID;
      private System.Windows.Forms.DataGridViewTextBoxColumn colName;
      private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
      private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
      private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
      private System.Windows.Forms.DataGridViewButtonColumn colEdit;
      private System.Windows.Forms.DataGridViewButtonColumn colDelete;
   }
}