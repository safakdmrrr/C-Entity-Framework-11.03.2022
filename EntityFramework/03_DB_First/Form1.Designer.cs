namespace _03_DB_First
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_orders = new System.Windows.Forms.Button();
            this.txt_empId = new System.Windows.Forms.TextBox();
            this.btn_EmpToOrd = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.btn_DateOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1252, 243);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_orders
            // 
            this.btn_orders.Location = new System.Drawing.Point(13, 49);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(154, 34);
            this.btn_orders.TabIndex = 1;
            this.btn_orders.Text = "GetOrders";
            this.btn_orders.UseVisualStyleBackColor = true;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // txt_empId
            // 
            this.txt_empId.Location = new System.Drawing.Point(290, 13);
            this.txt_empId.Name = "txt_empId";
            this.txt_empId.Size = new System.Drawing.Size(149, 20);
            this.txt_empId.TabIndex = 2;
            // 
            // btn_EmpToOrd
            // 
            this.btn_EmpToOrd.Location = new System.Drawing.Point(290, 49);
            this.btn_EmpToOrd.Name = "btn_EmpToOrd";
            this.btn_EmpToOrd.Size = new System.Drawing.Size(149, 34);
            this.btn_EmpToOrd.TabIndex = 3;
            this.btn_EmpToOrd.Text = "GetByIdOrders";
            this.btn_EmpToOrd.UseVisualStyleBackColor = true;
            this.btn_EmpToOrd.Click += new System.EventHandler(this.btn_EmpToOrd_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 413);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(374, 368);
            this.listBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(521, 13);
            this.dateTimePicker1.MaxDate = new System.DateTime(1997, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1996, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(1997, 12, 31, 0, 0, 0, 0);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(756, 12);
            this.dateTimePicker3.MaxDate = new System.DateTime(1997, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker3.MinDate = new System.DateTime(1996, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker3.TabIndex = 7;
            this.dateTimePicker3.Value = new System.DateTime(1997, 12, 31, 0, 0, 0, 0);
            // 
            // btn_DateOrders
            // 
            this.btn_DateOrders.Location = new System.Drawing.Point(670, 49);
            this.btn_DateOrders.Name = "btn_DateOrders";
            this.btn_DateOrders.Size = new System.Drawing.Size(149, 34);
            this.btn_DateOrders.TabIndex = 8;
            this.btn_DateOrders.Text = "GetByDateOrders";
            this.btn_DateOrders.UseVisualStyleBackColor = true;
            this.btn_DateOrders.Click += new System.EventHandler(this.btn_DateOrders_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 822);
            this.Controls.Add(this.btn_DateOrders);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_EmpToOrd);
            this.Controls.Add(this.txt_empId);
            this.Controls.Add(this.btn_orders);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_orders;
        private System.Windows.Forms.TextBox txt_empId;
        private System.Windows.Forms.Button btn_EmpToOrd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button btn_DateOrders;
    }
}

