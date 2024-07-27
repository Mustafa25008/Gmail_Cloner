namespace Gmail
{
    partial class Form9
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 46);
            label1.Name = "label1";
            label1.Size = new Size(158, 23);
            label1.TabIndex = 6;
            label1.Text = "Notification sounds";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 69);
            label3.Name = "label3";
            label3.Size = new Size(105, 17);
            label3.TabIndex = 7;
            label3.Text = "Default (xp start)";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 104);
            label4.Name = "label4";
            label4.Size = new Size(405, 28);
            label4.TabIndex = 8;
            label4.Text = "Menu where you can choose different sounds";
            label4.Click += label4_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Segoe UI", 10.2F);
            checkBox1.Location = new Point(3, 142);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 27);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "xp start";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 10.2F);
            checkBox2.Location = new Point(3, 172);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(90, 27);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "car lock";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 10.2F);
            checkBox3.Location = new Point(3, 202);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(82, 27);
            checkBox3.TabIndex = 11;
            checkBox3.Text = "Bongo";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 10.2F);
            checkBox4.Location = new Point(3, 232);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(76, 27);
            checkBox4.TabIndex = 12;
            checkBox4.Text = "Chess";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Segoe UI", 10.2F);
            checkBox5.Location = new Point(3, 262);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(75, 27);
            checkBox5.TabIndex = 13;
            checkBox5.Text = "Joyful";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form9";
            Text = "Notification sounds";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
    }
}