namespace SAdder
{
    partial class MainForm
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
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.BoxA = new System.Windows.Forms.TextBox();
            this.BoxB = new System.Windows.Forms.TextBox();
            this.BoxC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(100, 119);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(75, 23);
            this.CalculateBtn.TabIndex = 4;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click_1);
            // 
            // BoxA
            // 
            this.BoxA.Location = new System.Drawing.Point(75, 12);
            this.BoxA.Name = "BoxA";
            this.BoxA.Size = new System.Drawing.Size(100, 20);
            this.BoxA.TabIndex = 0;
            this.BoxA.Enter += new System.EventHandler(this.ClearA);
            // 
            // BoxB
            // 
            this.BoxB.Location = new System.Drawing.Point(75, 38);
            this.BoxB.Name = "BoxB";
            this.BoxB.Size = new System.Drawing.Size(100, 20);
            this.BoxB.TabIndex = 1;
            this.BoxB.Enter += new System.EventHandler(this.ClearB);
            // 
            // BoxC
            // 
            this.BoxC.Location = new System.Drawing.Point(75, 83);
            this.BoxC.Name = "BoxC";
            this.BoxC.Size = new System.Drawing.Size(100, 20);
            this.BoxC.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "A =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "B =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "A + B =";
            // 
            // MainForm
            // 
            this.AcceptButton = this.CalculateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 154);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxC);
            this.Controls.Add(this.BoxB);
            this.Controls.Add(this.BoxA);
            this.Controls.Add(this.CalculateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Adder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.TextBox BoxA;
        private System.Windows.Forms.TextBox BoxB;
        private System.Windows.Forms.TextBox BoxC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

