
namespace Lab5_Serchenko
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
            this.add = new System.Windows.Forms.Button();
            this.matrix_1 = new System.Windows.Forms.TextBox();
            this.matrix_2 = new System.Windows.Forms.TextBox();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.matrix_3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.det_1 = new System.Windows.Forms.Button();
            this.tra_1 = new System.Windows.Forms.Button();
            this.det_res_1 = new System.Windows.Forms.Label();
            this.det_res_2 = new System.Windows.Forms.Label();
            this.det_2 = new System.Windows.Forms.Button();
            this.tra_2 = new System.Windows.Forms.Button();
            this.errorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(378, 158);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(30, 30);
            this.add.TabIndex = 0;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // matrix_1
            // 
            this.matrix_1.Location = new System.Drawing.Point(77, 110);
            this.matrix_1.Multiline = true;
            this.matrix_1.Name = "matrix_1";
            this.matrix_1.Size = new System.Drawing.Size(200, 200);
            this.matrix_1.TabIndex = 1;
            // 
            // matrix_2
            // 
            this.matrix_2.Location = new System.Drawing.Point(517, 110);
            this.matrix_2.Multiline = true;
            this.matrix_2.Name = "matrix_2";
            this.matrix_2.Size = new System.Drawing.Size(200, 200);
            this.matrix_2.TabIndex = 2;
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(378, 194);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(30, 30);
            this.sub.TabIndex = 3;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // mul
            // 
            this.mul.Location = new System.Drawing.Point(378, 230);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(30, 30);
            this.mul.TabIndex = 4;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // matrix_3
            // 
            this.matrix_3.Location = new System.Drawing.Point(823, 110);
            this.matrix_3.Multiline = true;
            this.matrix_3.Name = "matrix_3";
            this.matrix_3.Size = new System.Drawing.Size(200, 200);
            this.matrix_3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(758, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "=";
            // 
            // det_1
            // 
            this.det_1.AutoSize = true;
            this.det_1.Location = new System.Drawing.Point(112, 338);
            this.det_1.Name = "det_1";
            this.det_1.Size = new System.Drawing.Size(42, 30);
            this.det_1.TabIndex = 10;
            this.det_1.Text = "det";
            this.det_1.UseVisualStyleBackColor = true;
            this.det_1.Click += new System.EventHandler(this.det_1_Click);
            // 
            // tra_1
            // 
            this.tra_1.AutoSize = true;
            this.tra_1.Location = new System.Drawing.Point(21, 199);
            this.tra_1.Name = "tra_1";
            this.tra_1.Size = new System.Drawing.Size(42, 30);
            this.tra_1.TabIndex = 9;
            this.tra_1.Text = "~";
            this.tra_1.UseVisualStyleBackColor = true;
            this.tra_1.Click += new System.EventHandler(this.tra_1_Click);
            // 
            // det_res_1
            // 
            this.det_res_1.AutoSize = true;
            this.det_res_1.Location = new System.Drawing.Point(201, 343);
            this.det_res_1.Name = "det_res_1";
            this.det_res_1.Size = new System.Drawing.Size(18, 20);
            this.det_res_1.TabIndex = 11;
            this.det_res_1.Text = "0";
            // 
            // det_res_2
            // 
            this.det_res_2.AutoSize = true;
            this.det_res_2.Location = new System.Drawing.Point(644, 343);
            this.det_res_2.Name = "det_res_2";
            this.det_res_2.Size = new System.Drawing.Size(18, 20);
            this.det_res_2.TabIndex = 15;
            this.det_res_2.Text = "0";
            // 
            // det_2
            // 
            this.det_2.AutoSize = true;
            this.det_2.Location = new System.Drawing.Point(555, 338);
            this.det_2.Name = "det_2";
            this.det_2.Size = new System.Drawing.Size(42, 30);
            this.det_2.TabIndex = 14;
            this.det_2.Text = "det";
            this.det_2.UseVisualStyleBackColor = true;
            this.det_2.Click += new System.EventHandler(this.det_2_Click);
            // 
            // tra_2
            // 
            this.tra_2.AutoSize = true;
            this.tra_2.Location = new System.Drawing.Point(458, 194);
            this.tra_2.Name = "tra_2";
            this.tra_2.Size = new System.Drawing.Size(42, 30);
            this.tra_2.TabIndex = 16;
            this.tra_2.Text = "~";
            this.tra_2.UseVisualStyleBackColor = true;
            this.tra_2.Click += new System.EventHandler(this.tra_2_Click);
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Location = new System.Drawing.Point(73, 491);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(0, 20);
            this.errorText.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 677);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.tra_2);
            this.Controls.Add(this.det_res_2);
            this.Controls.Add(this.det_2);
            this.Controls.Add(this.det_res_1);
            this.Controls.Add(this.det_1);
            this.Controls.Add(this.tra_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matrix_3);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.matrix_2);
            this.Controls.Add(this.matrix_1);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "Matrix calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox matrix_1;
        private System.Windows.Forms.TextBox matrix_2;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.TextBox matrix_3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button det_1;
        private System.Windows.Forms.Button tra_1;
        private System.Windows.Forms.Label det_res_1;
        private System.Windows.Forms.Label det_res_2;
        private System.Windows.Forms.Button det_2;
        private System.Windows.Forms.Button tra_2;
        public System.Windows.Forms.Label errorText;
    }
}

