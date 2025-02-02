//Application development in popular integrated development environments. © 2023 by Myrsini Stasinou is licensed under CC BY-SA 4.0

namespace Calculator
{
    partial class Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addition = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.resultTB = new System.Windows.Forms.TextBox();
            this.firstNumberTB = new System.Windows.Forms.TextBox();
            this.secondNumberTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(45, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(45, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result :";
            // 
            // addition
            // 
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addition.Location = new System.Drawing.Point(45, 180);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(80, 40);
            this.addition.TabIndex = 6;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // subtraction
            // 
            this.subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.subtraction.Location = new System.Drawing.Point(180, 180);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(80, 40);
            this.subtraction.TabIndex = 7;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // multiplication
            // 
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.multiplication.Location = new System.Drawing.Point(45, 250);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(80, 40);
            this.multiplication.TabIndex = 8;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.division.Location = new System.Drawing.Point(180, 250);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(80, 40);
            this.division.TabIndex = 9;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // resultTB
            // 
            this.resultTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.resultTB.Location = new System.Drawing.Point(180, 340);
            this.resultTB.Name = "resultTB";
            this.resultTB.ReadOnly = true;
            this.resultTB.Size = new System.Drawing.Size(140, 24);
            this.resultTB.TabIndex = 12;
            // 
            // firstNumberTB
            // 
            this.firstNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstNumberTB.Location = new System.Drawing.Point(180, 45);
            this.firstNumberTB.Name = "firstNumberTB";
            this.firstNumberTB.Size = new System.Drawing.Size(140, 24);
            this.firstNumberTB.TabIndex = 13;
            // 
            // secondNumberTB
            // 
            this.secondNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.secondNumberTB.Location = new System.Drawing.Point(180, 110);
            this.secondNumberTB.Name = "secondNumberTB";
            this.secondNumberTB.Size = new System.Drawing.Size(140, 24);
            this.secondNumberTB.TabIndex = 14;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.secondNumberTB);
            this.Controls.Add(this.firstNumberTB);
            this.Controls.Add(this.resultTB);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.TextBox resultTB;
        private System.Windows.Forms.TextBox firstNumberTB;
        private System.Windows.Forms.TextBox secondNumberTB;
    }
}

