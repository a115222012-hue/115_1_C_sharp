namespace Tutorial2_3
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
            button1 = new Button();
            showlabel = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("華康細明體外字集", 28F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(-25, 25);
            label1.Name = "label1";
            label1.Size = new Size(1384, 128);
            label1.TabIndex = 0;
            label1.Text = "選擇一個語言，我告訴你怎麼說「早安」";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("華康新特圓體", 16F, FontStyle.Bold);
            button1.Location = new Point(134, 328);
            button1.Name = "button1";
            button1.Size = new Size(248, 84);
            button1.TabIndex = 1;
            button1.Text = "西班牙";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // showlabel
            // 
            showlabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showlabel.Font = new Font("Rage Italic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showlabel.Location = new Point(415, 560);
            showlabel.Name = "showlabel";
            showlabel.Size = new Size(455, 212);
            showlabel.TabIndex = 2;
            showlabel.Text = "點擊按鈕";
            showlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Font = new Font("華康新特圓體", 16F, FontStyle.Bold);
            button2.Location = new Point(533, 328);
            button2.Name = "button2";
            button2.Size = new Size(248, 84);
            button2.TabIndex = 3;
            button2.Text = "德國";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("華康新特圓體", 16F, FontStyle.Bold);
            button3.Location = new Point(949, 328);
            button3.Name = "button3";
            button3.Size = new Size(248, 84);
            button3.TabIndex = 4;
            button3.Text = "義大利";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 811);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(showlabel);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label showlabel;
        private Button button2;
        private Button button3;
    }
}
