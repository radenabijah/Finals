namespace Finals
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            pictureBox9 = new PictureBox();
            btnAdd = new Button();
            PhoneTb = new TextBox();
            label1 = new Label();
            UnameTb = new TextBox();
            label9 = new Label();
            label14 = new Label();
            PasswordTb = new TextBox();
            label2 = new Label();
            AddressTb = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            DOB = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(348, 12);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(32, 30);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 58;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MintCream;
            btnAdd.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(113, 350);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 36);
            btnAdd.TabIndex = 56;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // PhoneTb
            // 
            PhoneTb.Location = new Point(188, 202);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(172, 23);
            PhoneTb.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(30, 202);
            label1.Name = "label1";
            label1.Size = new Size(79, 23);
            label1.TabIndex = 54;
            label1.Text = "Phone:";
            // 
            // UnameTb
            // 
            UnameTb.Location = new Point(188, 87);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(172, 23);
            UnameTb.TabIndex = 53;
            UnameTb.TextChanged += UnameTb_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(30, 87);
            label9.Name = "label9";
            label9.Size = new Size(127, 23);
            label9.TabIndex = 52;
            label9.Text = "User Name:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Georgia", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(139, 28);
            label14.Name = "label14";
            label14.Size = new Size(113, 25);
            label14.TabIndex = 51;
            label14.Text = "Add User";
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(188, 130);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(172, 23);
            PasswordTb.TabIndex = 60;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(30, 126);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 59;
            label2.Text = "Password:";
            // 
            // AddressTb
            // 
            AddressTb.Location = new Point(188, 244);
            AddressTb.Multiline = true;
            AddressTb.Name = "AddressTb";
            AddressTb.Size = new Size(172, 59);
            AddressTb.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(30, 244);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 61;
            label3.Text = "Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(161, 389);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 65;
            label5.Text = "Back";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(30, 164);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 66;
            label4.Text = "Date:";
            // 
            // DOB
            // 
            DOB.Location = new Point(188, 164);
            DOB.Name = "DOB";
            DOB.Size = new Size(172, 23);
            DOB.TabIndex = 67;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(392, 433);
            Controls.Add(DOB);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(AddressTb);
            Controls.Add(label3);
            Controls.Add(PasswordTb);
            Controls.Add(label2);
            Controls.Add(pictureBox9);
            Controls.Add(btnAdd);
            Controls.Add(PhoneTb);
            Controls.Add(label1);
            Controls.Add(UnameTb);
            Controls.Add(label9);
            Controls.Add(label14);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox9;
        private Button btnAdd;
        private TextBox PhoneTb;
        private Label label1;
        private TextBox UnameTb;
        private Label label9;
        private Label label14;
        private TextBox PasswordTb;
        private Label label2;
        private TextBox AddressTb;
        private Label label3;
        private Label label5;
        private Label label4;
        private DateTimePicker DOB;
    }
}