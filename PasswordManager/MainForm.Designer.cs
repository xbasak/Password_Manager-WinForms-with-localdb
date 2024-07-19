namespace PasswordManager
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textMail = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConfirmEdit = new System.Windows.Forms.Button();
            this.editPassword = new System.Windows.Forms.TextBox();
            this.editMail = new System.Windows.Forms.TextBox();
            this.editUsername = new System.Windows.Forms.TextBox();
            this.editDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.profile_delete = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnEye = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.textPassword);
            this.groupBox1.Controls.Add(this.textMail);
            this.groupBox1.Controls.Add(this.textUsername);
            this.groupBox1.Controls.Add(this.textDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(112, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new account";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(200, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(88, 104);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(100, 22);
            this.textPassword.TabIndex = 7;
            this.textPassword.UseSystemPasswordChar = true;
            this.textPassword.TextChanged += new System.EventHandler(this.Activate_addButton);
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(88, 80);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(100, 22);
            this.textMail.TabIndex = 6;
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(88, 56);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(100, 22);
            this.textUsername.TabIndex = 5;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(88, 32);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(100, 22);
            this.textDescription.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(133, 251);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(923, 371);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 28;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 218;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Username";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 218;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mail";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 218;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Password";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 220;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConfirmEdit);
            this.groupBox2.Controls.Add(this.editPassword);
            this.groupBox2.Controls.Add(this.editMail);
            this.groupBox2.Controls.Add(this.editUsername);
            this.groupBox2.Controls.Add(this.editDescription);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(424, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 138);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit selected account";
            this.groupBox2.Visible = false;
            // 
            // btnConfirmEdit
            // 
            this.btnConfirmEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmEdit.Enabled = false;
            this.btnConfirmEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirmEdit.Location = new System.Drawing.Point(200, 64);
            this.btnConfirmEdit.Name = "btnConfirmEdit";
            this.btnConfirmEdit.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmEdit.TabIndex = 8;
            this.btnConfirmEdit.Text = "Confirm Edit";
            this.btnConfirmEdit.UseVisualStyleBackColor = true;
            this.btnConfirmEdit.Click += new System.EventHandler(this.BtnConfirmEdit_Click);
            // 
            // editPassword
            // 
            this.editPassword.Location = new System.Drawing.Point(88, 104);
            this.editPassword.Name = "editPassword";
            this.editPassword.Size = new System.Drawing.Size(100, 22);
            this.editPassword.TabIndex = 7;
            this.editPassword.TextChanged += new System.EventHandler(this.Activate_confirmEditButton);
            // 
            // editMail
            // 
            this.editMail.Location = new System.Drawing.Point(88, 80);
            this.editMail.Name = "editMail";
            this.editMail.Size = new System.Drawing.Size(100, 22);
            this.editMail.TabIndex = 6;
            // 
            // editUsername
            // 
            this.editUsername.Location = new System.Drawing.Point(88, 56);
            this.editUsername.Name = "editUsername";
            this.editUsername.Size = new System.Drawing.Size(100, 22);
            this.editUsername.TabIndex = 5;
            // 
            // editDescription
            // 
            this.editDescription.Location = new System.Drawing.Point(88, 32);
            this.editDescription.Name = "editDescription";
            this.editDescription.Size = new System.Drawing.Size(100, 22);
            this.editDescription.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 14);
            this.label7.TabIndex = 1;
            this.label7.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Description";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveData);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(24, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 552);
            this.panel1.TabIndex = 10;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveData.Location = new System.Drawing.Point(944, 72);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(88, 39);
            this.btnSaveData.TabIndex = 2;
            this.btnSaveData.Text = "Save changes";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.BtnSaveData_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Brown;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTip1_Popup);
            // 
            // profile_delete
            // 
            this.profile_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile_delete.Image = global::PasswordManager.Properties.Resources.delete_profile;
            this.profile_delete.Location = new System.Drawing.Point(1112, 32);
            this.profile_delete.Name = "profile_delete";
            this.profile_delete.Size = new System.Drawing.Size(40, 40);
            this.profile_delete.TabIndex = 11;
            this.profile_delete.UseVisualStyleBackColor = true;
            this.profile_delete.Click += new System.EventHandler(this.Profile_delete_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.Image = global::PasswordManager.Properties.Resources.copy;
            this.btnCopy.Location = new System.Drawing.Point(776, 208);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(40, 40);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Visible = false;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // btnEye
            // 
            this.btnEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEye.Image = global::PasswordManager.Properties.Resources.eye_visible;
            this.btnEye.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEye.Location = new System.Drawing.Point(824, 208);
            this.btnEye.Name = "btnEye";
            this.btnEye.Size = new System.Drawing.Size(40, 40);
            this.btnEye.TabIndex = 8;
            this.btnEye.UseVisualStyleBackColor = true;
            this.btnEye.Visible = false;
            this.btnEye.Click += new System.EventHandler(this.BtnEye_Click);
            // 
            // btnDown
            // 
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.Image = global::PasswordManager.Properties.Resources.down;
            this.btnDown.Location = new System.Drawing.Point(920, 208);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(40, 40);
            this.btnDown.TabIndex = 6;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Visible = false;
            this.btnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.Image = global::PasswordManager.Properties.Resources.up;
            this.btnUp.Location = new System.Drawing.Point(872, 208);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(40, 40);
            this.btnUp.TabIndex = 7;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Visible = false;
            this.btnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Image = global::PasswordManager.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(1016, 208);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Image = global::PasswordManager.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(968, 208);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("ROG Fonts", 47.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Image = global::PasswordManager.Properties.Resources.main_form;
            this.title.Location = new System.Drawing.Point(128, 8);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(936, 77);
            this.title.TabIndex = 0;
            this.title.Text = "                                           ";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1180, 657);
            this.Controls.Add(this.profile_delete);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnEye);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConfirmEdit;
        private System.Windows.Forms.TextBox editPassword;
        private System.Windows.Forms.TextBox editMail;
        private System.Windows.Forms.TextBox editUsername;
        private System.Windows.Forms.TextBox editDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnEye;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button profile_delete;
    }
}

