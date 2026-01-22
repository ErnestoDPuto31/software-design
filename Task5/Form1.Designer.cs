namespace Task5
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
            txtInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSort.Location = new Point(341, 167);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(121, 48);
            btnSort.TabIndex = 1;
            btnSort.Text = "SORT";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(255, 124);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(281, 27);
            txtInput.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(350, 88);
            label1.Name = "label1";
            label1.Size = new Size(123, 24);
            label1.TabIndex = 3;
            label1.Text = "BUBBLE SORT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(255, 246);
            label2.Name = "label2";
            label2.Size = new Size(83, 24);
            label2.TabIndex = 4;
            label2.Text = "SORTED:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(255, 285);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 24);
            lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtInput);
            Controls.Add(btnSort);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSort;
        private TextBox txtInput;
        private Label label1;
        private Label label2;
        private Label lblResult;
    }
}
