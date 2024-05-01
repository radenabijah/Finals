namespace Finals
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label14 = new Label();
            UnameTb = new TextBox();
            label9 = new Label();
            PasswordTb = new TextBox();
            label1 = new Label();
            LoginBtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox9 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Georgia", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(125, 43);
            label14.Name = "label14";
            label14.Size = new Size(220, 29);
            label14.TabIndex = 43;
            label14.Text = "Expense Tracker";
            // 
            // UnameTb
            // 
            UnameTb.Location = new Point(188, 122);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(172, 23);
            UnameTb.TabIndex = 45;
            UnameTb.TextChanged += UnameTb_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(28, 122);
            label9.Name = "label9";
            label9.Size = new Size(127, 23);
            label9.TabIndex = 44;
            label9.Text = "User Name:";
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(188, 205);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(172, 23);
            PasswordTb.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(30, 205);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 46;
            label1.Text = "Password:";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.MintCream;
            LoginBtn.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.Location = new Point(206, 291);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(139, 36);
            LoginBtn.TabIndex = 48;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(348, 12);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(32, 30);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 50;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MintCream;
            button2.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(30, 291);
            button2.Name = "button2";
            button2.Size = new Size(139, 36);
            button2.TabIndex = 51;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(392, 433);
            Controls.Add(button2);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox1);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTb);
            Controls.Add(label1);
            Controls.Add(UnameTb);
            Controls.Add(label9);
            Controls.Add(label14);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label14;
        private TextBox UnameTb;
        private Label label9;
        private TextBox PasswordTb;
        private Label label1;
        private Button LoginBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox9;
        private Button button2;
    }
}