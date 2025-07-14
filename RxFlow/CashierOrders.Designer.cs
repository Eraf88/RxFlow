namespace RxFlow
{
    partial class CashierOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrders));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orders_clearBtn = new System.Windows.Forms.Button();
            this.orders_addBtn = new System.Windows.Forms.Button();
            this.orders_regPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.orders_prodName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.orders_quantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.orders_prodID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orders_category = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.orders_removeBtn = new System.Windows.Forms.Button();
            this.orders_receiptBtn = new System.Windows.Forms.Button();
            this.orders_payBtn = new System.Windows.Forms.Button();
            this.orders_change = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.orders_amount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.orders_totalPrice = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_quantity)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 220);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available Products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(402, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.orders_clearBtn);
            this.panel2.Controls.Add(this.orders_addBtn);
            this.panel2.Controls.Add(this.orders_regPrice);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.orders_prodName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.orders_quantity);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.orders_prodID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.orders_category);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(3, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 193);
            this.panel2.TabIndex = 1;
            // 
            // orders_clearBtn
            // 
            this.orders_clearBtn.BackColor = System.Drawing.Color.Gray;
            this.orders_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_clearBtn.Location = new System.Drawing.Point(203, 158);
            this.orders_clearBtn.Name = "orders_clearBtn";
            this.orders_clearBtn.Size = new System.Drawing.Size(93, 23);
            this.orders_clearBtn.TabIndex = 20;
            this.orders_clearBtn.Text = "CLEAR";
            this.orders_clearBtn.UseVisualStyleBackColor = false;
            // 
            // orders_addBtn
            // 
            this.orders_addBtn.BackColor = System.Drawing.Color.Gray;
            this.orders_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_addBtn.Location = new System.Drawing.Point(91, 158);
            this.orders_addBtn.Name = "orders_addBtn";
            this.orders_addBtn.Size = new System.Drawing.Size(93, 23);
            this.orders_addBtn.TabIndex = 19;
            this.orders_addBtn.Text = "ADD";
            this.orders_addBtn.UseVisualStyleBackColor = false;
            this.orders_addBtn.Click += new System.EventHandler(this.orders_addBtn_Click);
            // 
            // orders_regPrice
            // 
            this.orders_regPrice.AutoSize = true;
            this.orders_regPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_regPrice.Location = new System.Drawing.Point(106, 110);
            this.orders_regPrice.Name = "orders_regPrice";
            this.orders_regPrice.Size = new System.Drawing.Size(84, 16);
            this.orders_regPrice.TabIndex = 18;
            this.orders_regPrice.Text = "___________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Regular Price:";
            // 
            // orders_prodName
            // 
            this.orders_prodName.AutoSize = true;
            this.orders_prodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_prodName.Location = new System.Drawing.Point(106, 80);
            this.orders_prodName.Name = "orders_prodName";
            this.orders_prodName.Size = new System.Drawing.Size(84, 16);
            this.orders_prodName.TabIndex = 16;
            this.orders_prodName.Text = "___________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Product Name:";
            // 
            // orders_quantity
            // 
            this.orders_quantity.Location = new System.Drawing.Point(270, 52);
            this.orders_quantity.Name = "orders_quantity";
            this.orders_quantity.Size = new System.Drawing.Size(120, 20);
            this.orders_quantity.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantity:";
            // 
            // orders_prodID
            // 
            this.orders_prodID.FormattingEnabled = true;
            this.orders_prodID.Location = new System.Drawing.Point(270, 11);
            this.orders_prodID.Name = "orders_prodID";
            this.orders_prodID.Size = new System.Drawing.Size(135, 21);
            this.orders_prodID.TabIndex = 12;
            this.orders_prodID.SelectedIndexChanged += new System.EventHandler(this.orders_prodID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Product ID:";
            // 
            // orders_category
            // 
            this.orders_category.FormattingEnabled = true;
            this.orders_category.Location = new System.Drawing.Point(75, 12);
            this.orders_category.Name = "orders_category";
            this.orders_category.Size = new System.Drawing.Size(109, 21);
            this.orders_category.TabIndex = 10;
            this.orders_category.SelectedIndexChanged += new System.EventHandler(this.orders_category_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.orders_removeBtn);
            this.panel3.Controls.Add(this.orders_receiptBtn);
            this.panel3.Controls.Add(this.orders_payBtn);
            this.panel3.Controls.Add(this.orders_change);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.orders_amount);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.orders_totalPrice);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(417, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 416);
            this.panel3.TabIndex = 1;
            // 
            // orders_removeBtn
            // 
            this.orders_removeBtn.BackColor = System.Drawing.Color.Gray;
            this.orders_removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_removeBtn.Location = new System.Drawing.Point(41, 384);
            this.orders_removeBtn.Name = "orders_removeBtn";
            this.orders_removeBtn.Size = new System.Drawing.Size(93, 23);
            this.orders_removeBtn.TabIndex = 25;
            this.orders_removeBtn.Text = "REMOVE";
            this.orders_removeBtn.UseVisualStyleBackColor = false;
            this.orders_removeBtn.Click += new System.EventHandler(this.orders_removeBtn_Click);
            // 
            // orders_receiptBtn
            // 
            this.orders_receiptBtn.BackColor = System.Drawing.Color.Gray;
            this.orders_receiptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_receiptBtn.Location = new System.Drawing.Point(41, 355);
            this.orders_receiptBtn.Name = "orders_receiptBtn";
            this.orders_receiptBtn.Size = new System.Drawing.Size(93, 23);
            this.orders_receiptBtn.TabIndex = 24;
            this.orders_receiptBtn.Text = "RECEIPT";
            this.orders_receiptBtn.UseVisualStyleBackColor = false;
            this.orders_receiptBtn.Click += new System.EventHandler(this.orders_receiptBtn_Click);
            // 
            // orders_payBtn
            // 
            this.orders_payBtn.BackColor = System.Drawing.Color.Gray;
            this.orders_payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_payBtn.Location = new System.Drawing.Point(41, 326);
            this.orders_payBtn.Name = "orders_payBtn";
            this.orders_payBtn.Size = new System.Drawing.Size(93, 23);
            this.orders_payBtn.TabIndex = 23;
            this.orders_payBtn.Text = "PAY";
            this.orders_payBtn.UseVisualStyleBackColor = false;
            this.orders_payBtn.Click += new System.EventHandler(this.orders_payBtn_Click);
            // 
            // orders_change
            // 
            this.orders_change.AutoSize = true;
            this.orders_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_change.Location = new System.Drawing.Point(96, 292);
            this.orders_change.Name = "orders_change";
            this.orders_change.Size = new System.Drawing.Size(38, 16);
            this.orders_change.TabIndex = 22;
            this.orders_change.Text = "$0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 292);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Change:";
            // 
            // orders_amount
            // 
            this.orders_amount.Location = new System.Drawing.Point(82, 260);
            this.orders_amount.Name = "orders_amount";
            this.orders_amount.Size = new System.Drawing.Size(100, 20);
            this.orders_amount.TabIndex = 20;
            this.orders_amount.TextChanged += new System.EventHandler(this.orders_amount_TextChanged);
            this.orders_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.orders_amount_KeyDown_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Amount:";
            // 
            // orders_totalPrice
            // 
            this.orders_totalPrice.AutoSize = true;
            this.orders_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_totalPrice.Location = new System.Drawing.Point(105, 234);
            this.orders_totalPrice.Name = "orders_totalPrice";
            this.orders_totalPrice.Size = new System.Drawing.Size(38, 16);
            this.orders_totalPrice.TabIndex = 18;
            this.orders_totalPrice.Text = "$0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Total Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "All Orders";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(188, 188);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CashierOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CashierOrders";
            this.Size = new System.Drawing.Size(612, 425);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orders_quantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox orders_prodID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox orders_category;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label orders_regPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label orders_prodName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown orders_quantity;
        private System.Windows.Forms.Button orders_clearBtn;
        private System.Windows.Forms.Button orders_addBtn;
        private System.Windows.Forms.Label orders_totalPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button orders_removeBtn;
        private System.Windows.Forms.Button orders_receiptBtn;
        private System.Windows.Forms.Button orders_payBtn;
        private System.Windows.Forms.Label orders_change;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox orders_amount;
        private System.Windows.Forms.Label label12;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
