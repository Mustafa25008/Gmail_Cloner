namespace GMAIL_Clone
{
    partial class Form15
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
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Image = Properties.Resources.a_131;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(273, 63);
            button1.Name = "button1";
            button1.Size = new Size(298, 34);
            button1.TabIndex = 0;
            button1.Text = "Get a meeting link to share";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Image = Properties.Resources.calendar_icon_free_vector_9_2_23;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(273, 235);
            button2.Name = "button2";
            button2.Size = new Size(298, 34);
            button2.TabIndex = 1;
            button2.Text = "Schedule in Google Calendar";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Image = Properties.Resources.video_109_22_1_231;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(273, 149);
            button3.Name = "button3";
            button3.Size = new Size(298, 34);
            button3.TabIndex = 2;
            button3.Text = "Start an instant meeting";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            // 
            // Form15
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form15";
            Text = "New Meeting";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}