
namespace TipCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Bill = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bill_Text = new System.Windows.Forms.TextBox();
            this.Tip_Percent_Text = new System.Windows.Forms.TextBox();
            this.Tip_Sub = new System.Windows.Forms.Button();
            this.Tip_Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Num_Of_People_Text = new System.Windows.Forms.TextBox();
            this.People_Add = new System.Windows.Forms.Button();
            this.People_Sub = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Tip_Per_Person_Text = new System.Windows.Forms.TextBox();
            this.Total_Text = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Bill
            // 
            this.Bill.AutoSize = true;
            this.Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill.ForeColor = System.Drawing.Color.DarkGray;
            this.Bill.Location = new System.Drawing.Point(12, 26);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(38, 24);
            this.Bill.TabIndex = 0;
            this.Bill.Text = "Bill";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tip %";
            // 
            // Bill_Text
            // 
            this.Bill_Text.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bill_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_Text.ForeColor = System.Drawing.Color.Black;
            this.Bill_Text.Location = new System.Drawing.Point(16, 53);
            this.Bill_Text.Multiline = true;
            this.Bill_Text.Name = "Bill_Text";
            this.Bill_Text.Size = new System.Drawing.Size(216, 36);
            this.Bill_Text.TabIndex = 2;
            this.Bill_Text.Text = "0.00";
            this.Bill_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Bill_Text.TextChanged += new System.EventHandler(this.Bill_Text_TextChanged);
            this.Bill_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bill_Text_KeyPress);
            // 
            // Tip_Percent_Text
            // 
            this.Tip_Percent_Text.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tip_Percent_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip_Percent_Text.ForeColor = System.Drawing.Color.Black;
            this.Tip_Percent_Text.Location = new System.Drawing.Point(57, 132);
            this.Tip_Percent_Text.Multiline = true;
            this.Tip_Percent_Text.Name = "Tip_Percent_Text";
            this.Tip_Percent_Text.Size = new System.Drawing.Size(133, 35);
            this.Tip_Percent_Text.TabIndex = 3;
            this.Tip_Percent_Text.Text = "10%";
            this.Tip_Percent_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tip_Percent_Text.TextChanged += new System.EventHandler(this.Tip_Percent_Text_TextChanged);
            this.Tip_Percent_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tip_Percent_Text_KeyPress);
            // 
            // Tip_Sub
            // 
            this.Tip_Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip_Sub.ForeColor = System.Drawing.Color.Gray;
            this.Tip_Sub.Location = new System.Drawing.Point(16, 131);
            this.Tip_Sub.Name = "Tip_Sub";
            this.Tip_Sub.Size = new System.Drawing.Size(47, 37);
            this.Tip_Sub.TabIndex = 4;
            this.Tip_Sub.Text = "-";
            this.Tip_Sub.UseVisualStyleBackColor = true;
            this.Tip_Sub.Click += new System.EventHandler(this.Tip_Dec_Button);
            // 
            // Tip_Add
            // 
            this.Tip_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip_Add.ForeColor = System.Drawing.Color.Gray;
            this.Tip_Add.Location = new System.Drawing.Point(185, 132);
            this.Tip_Add.Name = "Tip_Add";
            this.Tip_Add.Size = new System.Drawing.Size(47, 37);
            this.Tip_Add.TabIndex = 6;
            this.Tip_Add.Text = "+";
            this.Tip_Add.UseVisualStyleBackColor = true;
            this.Tip_Add.Click += new System.EventHandler(this.Tip_Inc_Button);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of people";
            // 
            // Num_Of_People_Text
            // 
            this.Num_Of_People_Text.Cursor = System.Windows.Forms.Cursors.Default;
            this.Num_Of_People_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Of_People_Text.ForeColor = System.Drawing.Color.Black;
            this.Num_Of_People_Text.Location = new System.Drawing.Point(57, 215);
            this.Num_Of_People_Text.Multiline = true;
            this.Num_Of_People_Text.Name = "Num_Of_People_Text";
            this.Num_Of_People_Text.Size = new System.Drawing.Size(133, 36);
            this.Num_Of_People_Text.TabIndex = 8;
            this.Num_Of_People_Text.Text = "1";
            this.Num_Of_People_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Num_Of_People_Text.TextChanged += new System.EventHandler(this.Num_Of_People_Text_TextChanged);
            this.Num_Of_People_Text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num_Of_People_Text_KeyPress);
            // 
            // People_Add
            // 
            this.People_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.People_Add.ForeColor = System.Drawing.Color.Gray;
            this.People_Add.Location = new System.Drawing.Point(185, 214);
            this.People_Add.Name = "People_Add";
            this.People_Add.Size = new System.Drawing.Size(47, 37);
            this.People_Add.TabIndex = 9;
            this.People_Add.Text = "+";
            this.People_Add.UseVisualStyleBackColor = true;
            this.People_Add.Click += new System.EventHandler(this.People_Inc_Button);
            // 
            // People_Sub
            // 
            this.People_Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.People_Sub.ForeColor = System.Drawing.Color.Gray;
            this.People_Sub.Location = new System.Drawing.Point(16, 215);
            this.People_Sub.Name = "People_Sub";
            this.People_Sub.Size = new System.Drawing.Size(47, 37);
            this.People_Sub.TabIndex = 10;
            this.People_Sub.Text = "-";
            this.People_Sub.UseVisualStyleBackColor = true;
            this.People_Sub.Click += new System.EventHandler(this.People_Dec_Button);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(319, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "per person";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(319, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "per person";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(317, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 33);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tip";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.DimGray;
            this.Total.Location = new System.Drawing.Point(317, 155);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(80, 33);
            this.Total.TabIndex = 15;
            this.Total.Text = "Total";
            // 
            // Tip_Per_Person_Text
            // 
            this.Tip_Per_Person_Text.BackColor = System.Drawing.SystemColors.Window;
            this.Tip_Per_Person_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tip_Per_Person_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip_Per_Person_Text.Location = new System.Drawing.Point(420, 72);
            this.Tip_Per_Person_Text.Multiline = true;
            this.Tip_Per_Person_Text.Name = "Tip_Per_Person_Text";
            this.Tip_Per_Person_Text.ReadOnly = true;
            this.Tip_Per_Person_Text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Tip_Per_Person_Text.Size = new System.Drawing.Size(254, 70);
            this.Tip_Per_Person_Text.TabIndex = 16;
            this.Tip_Per_Person_Text.Text = "$0.00";
            // 
            // Total_Text
            // 
            this.Total_Text.BackColor = System.Drawing.SystemColors.Window;
            this.Total_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Total_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Text.Location = new System.Drawing.Point(420, 165);
            this.Total_Text.Multiline = true;
            this.Total_Text.Name = "Total_Text";
            this.Total_Text.ReadOnly = true;
            this.Total_Text.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Total_Text.Size = new System.Drawing.Size(254, 86);
            this.Total_Text.TabIndex = 17;
            this.Total_Text.Text = "$0.00";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(276, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(2, 287);
            this.flowLayoutPanel1.TabIndex = 19;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(687, 274);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Total_Text);
            this.Controls.Add(this.Tip_Per_Person_Text);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.People_Sub);
            this.Controls.Add(this.People_Add);
            this.Controls.Add(this.Num_Of_People_Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tip_Add);
            this.Controls.Add(this.Tip_Sub);
            this.Controls.Add(this.Tip_Percent_Text);
            this.Controls.Add(this.Bill_Text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bill);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tip Calculator";
            this.Click += new System.EventHandler(this.Click_Outside);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Bill_Text;
        private System.Windows.Forms.TextBox Tip_Percent_Text;
        private System.Windows.Forms.Button Tip_Sub;
        private System.Windows.Forms.Button Tip_Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Num_Of_People_Text;
        private System.Windows.Forms.Button People_Add;
        private System.Windows.Forms.Button People_Sub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox Tip_Per_Person_Text;
        private System.Windows.Forms.TextBox Total_Text;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

