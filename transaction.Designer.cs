namespace CsharpApi
{
    partial class transaction
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
            this.typeComb = new System.Windows.Forms.ComboBox();
            this.branchTxtbox = new System.Windows.Forms.TextBox();
            this.laptopTxtbox = new System.Windows.Forms.TextBox();
            this.peripheralTxtbox = new System.Windows.Forms.TextBox();
            this.totalTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.getBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 166);
            this.dataGridView1.TabIndex = 0;
            // 
            // typeComb
            // 
            this.typeComb.FormattingEnabled = true;
            this.typeComb.Items.AddRange(new object[] {
            "laptop_sale",
            "peripheral_sale"});
            this.typeComb.Location = new System.Drawing.Point(178, 280);
            this.typeComb.Name = "typeComb";
            this.typeComb.Size = new System.Drawing.Size(202, 24);
            this.typeComb.TabIndex = 1;
            // 
            // branchTxtbox
            // 
            this.branchTxtbox.Location = new System.Drawing.Point(178, 339);
            this.branchTxtbox.Name = "branchTxtbox";
            this.branchTxtbox.Size = new System.Drawing.Size(201, 22);
            this.branchTxtbox.TabIndex = 2;
            // 
            // laptopTxtbox
            // 
            this.laptopTxtbox.Location = new System.Drawing.Point(177, 396);
            this.laptopTxtbox.Name = "laptopTxtbox";
            this.laptopTxtbox.Size = new System.Drawing.Size(202, 22);
            this.laptopTxtbox.TabIndex = 3;
            // 
            // peripheralTxtbox
            // 
            this.peripheralTxtbox.Location = new System.Drawing.Point(593, 282);
            this.peripheralTxtbox.Name = "peripheralTxtbox";
            this.peripheralTxtbox.Size = new System.Drawing.Size(181, 22);
            this.peripheralTxtbox.TabIndex = 4;
            // 
            // totalTxtbox
            // 
            this.totalTxtbox.Location = new System.Drawing.Point(593, 339);
            this.totalTxtbox.Name = "totalTxtbox";
            this.totalTxtbox.Size = new System.Drawing.Size(180, 22);
            this.totalTxtbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sale Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Branch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Laptop ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Peripheral ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total";
            // 
            // getBtn
            // 
            this.getBtn.Location = new System.Drawing.Point(62, 210);
            this.getBtn.Name = "getBtn";
            this.getBtn.Size = new System.Drawing.Size(175, 57);
            this.getBtn.TabIndex = 12;
            this.getBtn.Text = "Get Transactions";
            this.getBtn.UseVisualStyleBackColor = true;
            this.getBtn.Click += new System.EventHandler(this.getBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(599, 379);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(175, 57);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add Transaction";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 478);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.getBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalTxtbox);
            this.Controls.Add(this.peripheralTxtbox);
            this.Controls.Add(this.laptopTxtbox);
            this.Controls.Add(this.branchTxtbox);
            this.Controls.Add(this.typeComb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "transaction";
            this.Text = "transaction";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox typeComb;
        private System.Windows.Forms.TextBox branchTxtbox;
        private System.Windows.Forms.TextBox laptopTxtbox;
        private System.Windows.Forms.TextBox peripheralTxtbox;
        private System.Windows.Forms.TextBox totalTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button getBtn;
        private System.Windows.Forms.Button addBtn;
    }
}