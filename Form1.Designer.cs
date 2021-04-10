
namespace MyFirstProj
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
            this.showBtn = new System.Windows.Forms.Button();
            this.tubil = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transactions = new System.Windows.Forms.DataGridView();
            this.ShowRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transactions)).BeginInit();
            this.SuspendLayout();
            // 
            // showBtn
            // 
            this.showBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.showBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showBtn.Location = new System.Drawing.Point(366, 231);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(114, 50);
            this.showBtn.TabIndex = 0;
            this.showBtn.Text = "CLICK ME";
            this.showBtn.UseVisualStyleBackColor = false;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // tubil
            // 
            this.tubil.Location = new System.Drawing.Point(38, 22);
            this.tubil.Name = "tubil";
            this.tubil.Size = new System.Drawing.Size(159, 23);
            this.tubil.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(38, 76);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(162, 23);
            this.price.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "PILAY TUBIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "PRESYO";
            // 
            // transactions
            // 
            this.transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactions.Location = new System.Drawing.Point(211, 22);
            this.transactions.Name = "transactions";
            this.transactions.RowTemplate.Height = 25;
            this.transactions.Size = new System.Drawing.Size(371, 133);
            this.transactions.TabIndex = 6;
            // 
            // ShowRecord
            // 
            this.ShowRecord.Location = new System.Drawing.Point(423, 161);
            this.ShowRecord.Name = "ShowRecord";
            this.ShowRecord.Size = new System.Drawing.Size(159, 41);
            this.ShowRecord.TabIndex = 7;
            this.ShowRecord.Text = "SHOW RECORD";
            this.ShowRecord.UseVisualStyleBackColor = true;
            this.ShowRecord.Click += new System.EventHandler(this.ShowRecord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 293);
            this.Controls.Add(this.ShowRecord);
            this.Controls.Add(this.transactions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tubil);
            this.Controls.Add(this.showBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.transactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.TextBox tubil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView transactions;
        private System.Windows.Forms.Button ShowRecord;
    }
}

