namespace Gmail
{
    partial class Form6
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
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(-1, 21);
            button1.Name = "button1";
            button1.Size = new Size(475, 58);
            button1.TabIndex = 0;
            button1.Text = "Sync messages\r\nThe previous 30 days of messages will download when connected";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, 105);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 1;
            label1.Text = "Notifications";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("Segoe UI", 10.2F);
            checkBox1.Location = new Point(12, 145);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(170, 27);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Label notifications";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 10.2F);
            checkBox2.Location = new Point(12, 190);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(425, 50);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Notify for every message\r\nplay sound/Vibrate when each new message arrives";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form6";
            Text = "Inbox notifications";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}