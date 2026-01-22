using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Task5._2
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
            btnSort = new Button();
            label1 = new Label();
            label2 = new Label();
            lblResult = new Label();
            label3 = new Label();
            originalNums = new Label();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.Font = new System.Drawing.Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSort.Location = new Point(344, 212);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(121, 48);
            btnSort.TabIndex = 1;
            btnSort.Text = "SORT";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 84);
            label1.Name = "label1";
            label1.Size = new Size(184, 24);
            label1.TabIndex = 3;
            label1.Text = "DESCENDING ORDER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(255, 270);
            label2.Name = "label2";
            label2.Size = new Size(83, 24);
            label2.TabIndex = 4;
            label2.Text = "SORTED:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new System.Drawing.Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(283, 320);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 24);
            lblResult.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(255, 118);
            label3.Name = "label3";
            label3.Size = new Size(97, 24);
            label3.TabIndex = 6;
            label3.Text = "ORIGINAL:";
            label3.Click += label3_Click;
            // 
            // originalNums
            // 
            originalNums.AutoSize = true;
            originalNums.Font = new System.Drawing.Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            originalNums.Location = new Point(283, 159);
            originalNums.Name = "originalNums";
            originalNums.Size = new Size(0, 24);
            originalNums.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(originalNums);
            Controls.Add(label3);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSort);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSort;
        private Label label1;
        private Label label2;
        private Label lblResult;
        private Label label3;
        private Label originalNums;
    }
}
