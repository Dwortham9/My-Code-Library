namespace Homework_7
{
    partial class hourly_pay
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Rate = new System.Windows.Forms.TextBox();
            this.textBox_Hours = new System.Windows.Forms.TextBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate Me! ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = " Hourly pay rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of hours worked";
            // 
            // textBox_Rate
            // 
            this.textBox_Rate.Location = new System.Drawing.Point(101, 66);
            this.textBox_Rate.Name = "textBox_Rate";
            this.textBox_Rate.Size = new System.Drawing.Size(150, 31);
            this.textBox_Rate.TabIndex = 3;
            // 
            // textBox_Hours
            // 
            this.textBox_Hours.Location = new System.Drawing.Point(101, 174);
            this.textBox_Hours.Name = "textBox_Hours";
            this.textBox_Hours.Size = new System.Drawing.Size(150, 31);
            this.textBox_Hours.TabIndex = 4;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(101, 360);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(150, 31);
            this.textBox_Result.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.textBox_Hours);
            this.Controls.Add(this.textBox_Rate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox_Rate;
        private TextBox textBox_Hours;
        private TextBox textBox_Result;
        private Label label3;
    }
}