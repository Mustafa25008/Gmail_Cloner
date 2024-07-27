namespace Gmail
{
    partial class ReplyFollow
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
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 0;
            label1.Text = "Reply and follow up";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(114, 86);
            checkBox1.Margin = new Padding(2, 2, 2, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(353, 64);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Suggest emails to reply to\r\nEmails that you might have forgotten to respond\r\nto will appear at top of your inbox\r\n";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(114, 196);
            checkBox2.Margin = new Padding(2, 2, 2, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(301, 64);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Suggest emails to follow up on\r\nEmails that you might need to follow up \r\nwill appear at top of your inbox\r\n";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
        //    button1.Image = Properties.Resources.back__1_;
            button1.Location = new Point(1, 25);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(65, 20);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
        //    button2.Image = Properties.Resources.three_dots_vertical_1__1_;
            button2.Location = new Point(578, 21);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(11, 28);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            // 
            // ReplyFollow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ReplyFollow";
            Text = "Reply and Follow Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
        private Button button2;
    }
}