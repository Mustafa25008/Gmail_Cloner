namespace GMAIL_Clone
{
    partial class meet
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(95, 77);
            button1.Name = "button1";
            button1.Size = new Size(247, 34);
            button1.TabIndex = 0;
            button1.Text = "New Meeting";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(460, 77);
            button2.Name = "button2";
            button2.Size = new Size(247, 34);
            button2.TabIndex = 1;
            button2.Text = "Join with a code";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 18);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 2;
            label1.Text = "Meet";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Image = Properties.Resources.images_1_19;
            button3.Location = new Point(95, 18);
            button3.Name = "button3";
            button3.Size = new Size(44, 43);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Image = Properties.Resources.pngtree_avatar_icon_profile_icon_member_login_vector_isolated_png_image_1978396_223;
            button4.Location = new Point(660, 18);
            button4.Name = "button4";
            button4.Size = new Size(47, 43);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(74, 196);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 150);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(432, 196);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 150);
            panel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(267, 25);
            label2.TabIndex = 0;
            label2.Text = "Tap \"New Meeting\" to get a link ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 36);
            label3.Name = "label3";
            label3.Size = new Size(282, 25);
            label3.TabIndex = 7;
            label3.Text = "you  can send to people you want";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 61);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 8;
            label4.Text = " to meet with";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 23);
            label5.Name = "label5";
            label5.Size = new Size(280, 25);
            label5.TabIndex = 7;
            label5.Text = "No one can join a meeting  unless";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 48);
            label6.Name = "label6";
            label6.Size = new Size(229, 25);
            label6.TabIndex = 7;
            label6.Text = "invited or admitted by host";
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form14";
            Text = "MEET";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private Label label6;
        private Label label5;
    }
}