namespace RxFlow
{
    partial class adminAddCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addcategories_clearBtn = new System.Windows.Forms.Button();
            this.addcategories_deleteBtn = new System.Windows.Forms.Button();
            this.addcategories_updateBtn = new System.Windows.Forms.Button();
            this.addcategories_addBtn = new System.Windows.Forms.Button();
            this.addcategories_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addcategories_category = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(179, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 458);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Category\'s Data";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.addcategories_clearBtn);
            this.panel1.Controls.Add(this.addcategories_deleteBtn);
            this.panel1.Controls.Add(this.addcategories_updateBtn);
            this.panel1.Controls.Add(this.addcategories_addBtn);
            this.panel1.Controls.Add(this.addcategories_status);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.addcategories_category);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 458);
            this.panel1.TabIndex = 2;
            // 
            // addcategories_clearBtn
            // 
            this.addcategories_clearBtn.BackColor = System.Drawing.Color.Gray;
            this.addcategories_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcategories_clearBtn.Location = new System.Drawing.Point(6, 357);
            this.addcategories_clearBtn.Name = "addcategories_clearBtn";
            this.addcategories_clearBtn.Size = new System.Drawing.Size(154, 23);
            this.addcategories_clearBtn.TabIndex = 13;
            this.addcategories_clearBtn.Text = "CLEAR";
            this.addcategories_clearBtn.UseVisualStyleBackColor = false;
            this.addcategories_clearBtn.Click += new System.EventHandler(this.addcategories_clearBtn_Click);
            // 
            // addcategories_deleteBtn
            // 
            this.addcategories_deleteBtn.BackColor = System.Drawing.Color.Gray;
            this.addcategories_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcategories_deleteBtn.Location = new System.Drawing.Point(6, 318);
            this.addcategories_deleteBtn.Name = "addcategories_deleteBtn";
            this.addcategories_deleteBtn.Size = new System.Drawing.Size(154, 23);
            this.addcategories_deleteBtn.TabIndex = 12;
            this.addcategories_deleteBtn.Text = "DELETE";
            this.addcategories_deleteBtn.UseVisualStyleBackColor = false;
            this.addcategories_deleteBtn.Click += new System.EventHandler(this.addcategories_deleteBtn_Click);
            // 
            // addcategories_updateBtn
            // 
            this.addcategories_updateBtn.BackColor = System.Drawing.Color.Gray;
            this.addcategories_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcategories_updateBtn.Location = new System.Drawing.Point(6, 279);
            this.addcategories_updateBtn.Name = "addcategories_updateBtn";
            this.addcategories_updateBtn.Size = new System.Drawing.Size(154, 23);
            this.addcategories_updateBtn.TabIndex = 11;
            this.addcategories_updateBtn.Text = "UPDATE";
            this.addcategories_updateBtn.UseVisualStyleBackColor = false;
            this.addcategories_updateBtn.Click += new System.EventHandler(this.addcategories_updateBtn_Click);
            // 
            // addcategories_addBtn
            // 
            this.addcategories_addBtn.BackColor = System.Drawing.Color.Gray;
            this.addcategories_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcategories_addBtn.Location = new System.Drawing.Point(6, 237);
            this.addcategories_addBtn.Name = "addcategories_addBtn";
            this.addcategories_addBtn.Size = new System.Drawing.Size(154, 23);
            this.addcategories_addBtn.TabIndex = 10;
            this.addcategories_addBtn.Text = "ADD";
            this.addcategories_addBtn.UseVisualStyleBackColor = false;
            this.addcategories_addBtn.Click += new System.EventHandler(this.addcategories_addBtn_Click);
            // 
            // addcategories_status
            // 
            this.addcategories_status.FormattingEnabled = true;
            this.addcategories_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.addcategories_status.Location = new System.Drawing.Point(6, 142);
            this.addcategories_status.Name = "addcategories_status";
            this.addcategories_status.Size = new System.Drawing.Size(154, 21);
            this.addcategories_status.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // addcategories_category
            // 
            this.addcategories_category.Location = new System.Drawing.Point(6, 87);
            this.addcategories_category.Name = "addcategories_category";
            this.addcategories_category.Size = new System.Drawing.Size(154, 20);
            this.addcategories_category.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RxFlow.Properties.Resources.icons8_opened_folder_50;
            this.pictureBox1.Location = new System.Drawing.Point(50, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 51);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // adminAddCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "adminAddCategories";
            this.Size = new System.Drawing.Size(628, 464);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addcategories_clearBtn;
        private System.Windows.Forms.Button addcategories_deleteBtn;
        private System.Windows.Forms.Button addcategories_updateBtn;
        private System.Windows.Forms.Button addcategories_addBtn;
        private System.Windows.Forms.ComboBox addcategories_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addcategories_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
