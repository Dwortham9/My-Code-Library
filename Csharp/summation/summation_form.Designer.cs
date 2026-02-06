namespace Homework_12
{
    partial class summation_form
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
            this.calculate_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.start_label = new System.Windows.Forms.Label();
            this.stop_label = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.textBox_start = new System.Windows.Forms.TextBox();
            this.textBox_stop = new System.Windows.Forms.TextBox();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculate_btn
            // 
            this.calculate_btn.Location = new System.Drawing.Point(440, 182);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(112, 34);
            this.calculate_btn.TabIndex = 0;
            this.calculate_btn.Text = "Calculate";
            this.calculate_btn.UseVisualStyleBackColor = true;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculate the summation between start and stop";
            // 
            // start_label
            // 
            this.start_label.AutoSize = true;
            this.start_label.Location = new System.Drawing.Point(81, 124);
            this.start_label.Name = "start_label";
            this.start_label.Size = new System.Drawing.Size(48, 25);
            this.start_label.TabIndex = 2;
            this.start_label.Text = "Start";
            // 
            // stop_label
            // 
            this.stop_label.AutoSize = true;
            this.stop_label.Location = new System.Drawing.Point(81, 191);
            this.stop_label.Name = "stop_label";
            this.stop_label.Size = new System.Drawing.Size(49, 25);
            this.stop_label.TabIndex = 3;
            this.stop_label.Text = "Stop";
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Location = new System.Drawing.Point(81, 265);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(49, 25);
            this.total_label.TabIndex = 4;
            this.total_label.Text = "Total";
            // 
            // textBox_start
            // 
            this.textBox_start.Location = new System.Drawing.Point(198, 118);
            this.textBox_start.Name = "textBox_start";
            this.textBox_start.Size = new System.Drawing.Size(150, 31);
            this.textBox_start.TabIndex = 5;
            // 
            // textBox_stop
            // 
            this.textBox_stop.Location = new System.Drawing.Point(198, 185);
            this.textBox_stop.Name = "textBox_stop";
            this.textBox_stop.Size = new System.Drawing.Size(150, 31);
            this.textBox_stop.TabIndex = 6;
            // 
            // textBox_total
            // 
            this.textBox_total.Location = new System.Drawing.Point(198, 265);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(150, 31);
            this.textBox_total.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.textBox_stop);
            this.Controls.Add(this.textBox_start);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.stop_label);
            this.Controls.Add(this.start_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculate_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button calculate_btn;
        private Label label1;
        private Label start_label;
        private Label stop_label;
        private Label total_label;
        private TextBox textBox_start;
        private TextBox textBox_stop;
        private TextBox textBox_total;
    }
}