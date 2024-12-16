namespace WinFormMethodF123
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            lblResult = new Label();
            btnBMI = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 21);
            label1.Name = "label1";
            label1.Size = new Size(325, 94);
            label1.TabIndex = 0;
            label1.Text = "โปรแกรมคำนวณค่า BMI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.AppWorkspace;
            label2.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(28, 147);
            label2.Name = "label2";
            label2.Size = new Size(227, 51);
            label2.TabIndex = 1;
            label2.Text = "ชื่อ-นามสกุล";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 208);
            label3.Name = "label3";
            label3.Size = new Size(227, 41);
            label3.TabIndex = 2;
            label3.Text = "อายุ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveBorder;
            label4.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 265);
            label4.Name = "label4";
            label4.Size = new Size(227, 47);
            label4.TabIndex = 3;
            label4.Text = "ส่วนสูง (cm)";
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveBorder;
            label5.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 329);
            label5.Name = "label5";
            label5.Size = new Size(227, 46);
            label5.TabIndex = 4;
            label5.Text = "น้ำหนัก (kg)";
            // 
            // txtName
            // 
            txtName.Location = new Point(284, 150);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(238, 48);
            txtName.TabIndex = 5;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(296, 208);
            txtAge.Multiline = true;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(140, 41);
            txtAge.TabIndex = 6;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(296, 265);
            txtHeight.Multiline = true;
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(140, 47);
            txtHeight.TabIndex = 7;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(296, 329);
            txtWeight.Multiline = true;
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(140, 46);
            txtWeight.TabIndex = 8;
            // 
            // lblResult
            // 
            lblResult.BackColor = SystemColors.Info;
            lblResult.Location = new Point(603, 135);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(293, 278);
            lblResult.TabIndex = 9;
            // 
            // btnBMI
            // 
            btnBMI.BackColor = SystemColors.ActiveCaption;
            btnBMI.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBMI.ForeColor = SystemColors.ControlText;
            btnBMI.Location = new Point(327, 452);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(137, 80);
            btnBMI.TabIndex = 10;
            btnBMI.Text = "ค่า BMI";
            btnBMI.UseVisualStyleBackColor = false;
            btnBMI.Click += btnBMI_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaption;
            btnClear.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(546, 452);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(137, 80);
            btnClear.TabIndex = 11;
            btnClear.Text = "เริ่มต้นใหม่";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 556);
            Controls.Add(btnClear);
            Controls.Add(btnBMI);
            Controls.Add(lblResult);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Label lblResult;
        private Button btnBMI;
        private Button btnClear;
    }
}
