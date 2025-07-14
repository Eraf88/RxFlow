namespace RxFlow
{
    partial class adminAddUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addUsers_username = new System.Windows.Forms.TextBox();
            this.addUsers_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addUsers_role = new System.Windows.Forms.ComboBox();
            this.addUsers_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addUsers_addBtn = new System.Windows.Forms.Button();
            this.addUsers_updateBtn = new System.Windows.Forms.Button();
            this.addUsers_deleteBtn = new System.Windows.Forms.Button();
            this.addUsers_clearBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.addUsers_clearBtn);
            this.panel1.Controls.Add(this.addUsers_deleteBtn);
            this.panel1.Controls.Add(this.addUsers_updateBtn);
            this.panel1.Controls.Add(this.addUsers_addBtn);
            this.panel1.Controls.Add(this.addUsers_status);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.addUsers_role);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addUsers_password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addUsers_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 458);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(179, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 458);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RxFlow.Properties.Resources.icons8_doctor_96;
            this.pictureBox1.Location = new System.Drawing.Point(32, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 89);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // addUsers_username
            // 
            this.addUsers_username.Location = new System.Drawing.Point(6, 119);
            this.addUsers_username.Name = "addUsers_username";
            this.addUsers_username.Size = new System.Drawing.Size(154, 20);
            this.addUsers_username.TabIndex = 3;
            // 
            // addUsers_password
            // 
            this.addUsers_password.Location = new System.Drawing.Point(6, 167);
            this.addUsers_password.Name = "addUsers_password";
            this.addUsers_password.Size = new System.Drawing.Size(154, 20);
            this.addUsers_password.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Role";
            // 
            // addUsers_role
            // 
            this.addUsers_role.FormattingEnabled = true;
            this.addUsers_role.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.addUsers_role.Location = new System.Drawing.Point(6, 219);
            this.addUsers_role.Name = "addUsers_role";
            this.addUsers_role.Size = new System.Drawing.Size(154, 21);
            this.addUsers_role.TabIndex = 7;
            // 
            // addUsers_status
            // 
            this.addUsers_status.FormattingEnabled = true;
            this.addUsers_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.addUsers_status.Location = new System.Drawing.Point(6, 267);
            this.addUsers_status.Name = "addUsers_status";
            this.addUsers_status.Size = new System.Drawing.Size(154, 21);
            this.addUsers_status.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // addUsers_addBtn
            // 
            this.addUsers_addBtn.BackColor = System.Drawing.Color.Gray;
            this.addUsers_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUsers_addBtn.Location = new System.Drawing.Point(6, 307);
            this.addUsers_addBtn.Name = "addUsers_addBtn";
            this.addUsers_addBtn.Size = new System.Drawing.Size(154, 23);
            this.addUsers_addBtn.TabIndex = 10;
            this.addUsers_addBtn.Text = "ADD";
            this.addUsers_addBtn.UseVisualStyleBackColor = false;
            this.addUsers_addBtn.Click += new System.EventHandler(this.addUsers_addBtn_Click);
            // 
            // addUsers_updateBtn
            // 
            this.addUsers_updateBtn.BackColor = System.Drawing.Color.Gray;
            this.addUsers_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUsers_updateBtn.Location = new System.Drawing.Point(6, 336);
            this.addUsers_updateBtn.Name = "addUsers_updateBtn";
            this.addUsers_updateBtn.Size = new System.Drawing.Size(154, 23);
            this.addUsers_updateBtn.TabIndex = 11;
            this.addUsers_updateBtn.Text = "UPDATE";
            this.addUsers_updateBtn.UseVisualStyleBackColor = false;
            this.addUsers_updateBtn.Click += new System.EventHandler(this.addUsers_updateBtn_Click);
            // 
            // addUsers_deleteBtn
            // 
            this.addUsers_deleteBtn.BackColor = System.Drawing.Color.Gray;
            this.addUsers_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUsers_deleteBtn.Location = new System.Drawing.Point(6, 365);
            this.addUsers_deleteBtn.Name = "addUsers_deleteBtn";
            this.addUsers_deleteBtn.Size = new System.Drawing.Size(154, 23);
            this.addUsers_deleteBtn.TabIndex = 12;
            this.addUsers_deleteBtn.Text = "DELETE";
            this.addUsers_deleteBtn.UseVisualStyleBackColor = false;
            this.addUsers_deleteBtn.Click += new System.EventHandler(this.addUsers_deleteBtn_Click);
            // 
            // addUsers_clearBtn
            // 
            this.addUsers_clearBtn.BackColor = System.Drawing.Color.Gray;
            this.addUsers_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUsers_clearBtn.Location = new System.Drawing.Point(6, 394);
            this.addUsers_clearBtn.Name = "addUsers_clearBtn";
            this.addUsers_clearBtn.Size = new System.Drawing.Size(154, 23);
            this.addUsers_clearBtn.TabIndex = 13;
            this.addUsers_clearBtn.Text = "CLEAR";
            this.addUsers_clearBtn.UseVisualStyleBackColor = false;
            this.addUsers_clearBtn.Click += new System.EventHandler(this.addUsers_clearBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "User\'s Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(440, 420);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // adminAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "adminAddUsers";
            this.Size = new System.Drawing.Size(628, 464);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addUsers_addBtn;
        private System.Windows.Forms.ComboBox addUsers_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox addUsers_role;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addUsers_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addUsers_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addUsers_clearBtn;
        private System.Windows.Forms.Button addUsers_deleteBtn;
        private System.Windows.Forms.Button addUsers_updateBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
    }
}
