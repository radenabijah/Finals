namespace Finals
{
    partial class Expense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expense));
            CatCb = new ComboBox();
            ExpDescTb = new TextBox();
            label13 = new Label();
            label12 = new Label();
            ExpDate = new DateTimePicker();
            label11 = new Label();
            label14 = new Label();
            SaveBtn = new Button();
            ExpAmtTb = new TextBox();
            label10 = new Label();
            ExpNameTb = new TextBox();
            label9 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox7 = new PictureBox();
            label2 = new Label();
            label5 = new Label();
            Inclbl = new Label();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            pictureBox6 = new PictureBox();
            label8 = new Label();
            pictureBox9 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // CatCb
            // 
            CatCb.FormattingEnabled = true;
            CatCb.Items.AddRange(new object[] { "Food", "Shopping", "Medical", "Household", "Travel", "Vehicle", "Others" });
            CatCb.Location = new Point(831, 273);
            CatCb.Name = "CatCb";
            CatCb.Size = new Size(172, 23);
            CatCb.TabIndex = 50;
            // 
            // ExpDescTb
            // 
            ExpDescTb.Location = new Point(831, 423);
            ExpDescTb.Multiline = true;
            ExpDescTb.Name = "ExpDescTb";
            ExpDescTb.Size = new Size(172, 82);
            ExpDescTb.TabIndex = 55;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(568, 423);
            label13.Name = "label13";
            label13.Size = new Size(133, 23);
            label13.TabIndex = 54;
            label13.Text = "Description:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(568, 345);
            label12.Name = "label12";
            label12.Size = new Size(64, 23);
            label12.TabIndex = 53;
            label12.Text = "Date:";
            // 
            // ExpDate
            // 
            ExpDate.CalendarFont = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExpDate.Location = new Point(831, 345);
            ExpDate.Name = "ExpDate";
            ExpDate.Size = new Size(172, 23);
            ExpDate.TabIndex = 52;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(568, 273);
            label11.Name = "label11";
            label11.Size = new Size(109, 23);
            label11.TabIndex = 51;
            label11.Text = "Category:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Georgia", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(313, 271);
            label14.Name = "label14";
            label14.Size = new Size(194, 25);
            label14.TabIndex = 57;
            label14.Text = "Expense Details:";
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.MintCream;
            SaveBtn.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SaveBtn.Location = new Point(685, 541);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(165, 45);
            SaveBtn.TabIndex = 56;
            SaveBtn.Text = "Save Expense";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // ExpAmtTb
            // 
            ExpAmtTb.Location = new Point(831, 210);
            ExpAmtTb.Name = "ExpAmtTb";
            ExpAmtTb.Size = new Size(172, 23);
            ExpAmtTb.TabIndex = 49;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(568, 206);
            label10.Name = "label10";
            label10.Size = new Size(96, 23);
            label10.TabIndex = 48;
            label10.Text = "Amount:";
            // 
            // ExpNameTb
            // 
            ExpNameTb.Location = new Point(831, 136);
            ExpNameTb.Name = "ExpNameTb";
            ExpNameTb.Size = new Size(172, 23);
            ExpNameTb.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(568, 136);
            label9.Name = "label9";
            label9.Size = new Size(162, 23);
            label9.TabIndex = 43;
            label9.Text = "Expense Name:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Inclbl);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox6);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 638);
            panel1.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(70, 523);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 71;
            label1.Text = "Chat With Us";
            label1.Click += label1_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 31);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(52, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 65;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 502);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 70;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 209);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(70, 589);
            label7.Name = "label7";
            label7.Size = new Size(85, 23);
            label7.TabIndex = 69;
            label7.Text = "Log out";
            label7.Click += label7_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 121);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 59;
            pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 568);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(52, 54);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 68;
            pictureBox7.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(70, 52);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 60;
            label2.Text = "Dashboard";
            label2.Click += label2_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(70, 401);
            label5.Name = "label5";
            label5.Size = new Size(147, 23);
            label5.TabIndex = 67;
            label5.Text = "View Expense";
            label5.Click += label5_Click_1;
            // 
            // Inclbl
            // 
            Inclbl.AutoSize = true;
            Inclbl.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Inclbl.ForeColor = Color.Black;
            Inclbl.Location = new Point(70, 143);
            Inclbl.Name = "Inclbl";
            Inclbl.Size = new Size(84, 23);
            Inclbl.TabIndex = 61;
            Inclbl.Text = "Income";
            Inclbl.Click += Inclbl_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(70, 314);
            label6.Name = "label6";
            label6.Size = new Size(139, 23);
            label6.TabIndex = 66;
            label6.Text = "View Income";
            label6.Click += label6_Click_1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 294);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 62;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(70, 230);
            label4.Name = "label4";
            label4.Size = new Size(92, 23);
            label4.TabIndex = 63;
            label4.Text = "Expense";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 380);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(52, 54);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 64;
            pictureBox6.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(313, 31);
            label8.Name = "label8";
            label8.Size = new Size(204, 25);
            label8.TabIndex = 45;
            label8.Text = "Personal Expense";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(1211, 12);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(52, 54);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 46;
            pictureBox9.TabStop = false;
            pictureBox9.Click += pictureBox9_Click;
            // 
            // Expense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(1266, 638);
            Controls.Add(CatCb);
            Controls.Add(ExpDescTb);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(ExpDate);
            Controls.Add(label11);
            Controls.Add(label14);
            Controls.Add(SaveBtn);
            Controls.Add(ExpAmtTb);
            Controls.Add(label10);
            Controls.Add(ExpNameTb);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(pictureBox9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Expense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expense";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CatCb;
        private TextBox ExpDescTb;
        private Label label13;
        private Label label12;
        private DateTimePicker ExpDate;
        private Label label11;
        private Label label14;
        private Button SaveBtn;
        private TextBox ExpAmtTb;
        private Label label10;
        private TextBox ExpNameTb;
        private Label label9;
        private Panel panel1;
        private Label label8;
        private PictureBox pictureBox9;
        private Label label1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label7;
        private PictureBox pictureBox3;
        private PictureBox pictureBox7;
        private Label label2;
        private Label label5;
        private Label Inclbl;
        private Label label6;
        private PictureBox pictureBox4;
        private Label label4;
        private PictureBox pictureBox6;
    }
}