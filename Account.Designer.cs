namespace PayOfRent
{
    partial class Account
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
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            button2 = new Button();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            textBox6 = new TextBox();
            linkLabel1 = new LinkLabel();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(288, 1);
            label1.Name = "label1";
            label1.Size = new Size(213, 32);
            label1.TabIndex = 0;
            label1.Text = "Личный кабинет";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(277, 36);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(241, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(524, 36);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(15, 367);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 3;
            label2.Text = "Гор.Вода";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(259, 367);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 5;
            label4.Text = "Хол.Вода";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(157, 367);
            label6.Name = "label6";
            label6.Size = new Size(41, 28);
            label6.TabIndex = 7;
            label6.Text = "Газ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(406, 367);
            label8.Name = "label8";
            label8.Size = new Size(56, 28);
            label8.TabIndex = 9;
            label8.Text = "Свет";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 196);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(157, 136);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(157, 196);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(12, 120);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 22;
            label10.Text = "Гор.Вода";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(12, 178);
            label11.Name = "label11";
            label11.Size = new Size(60, 15);
            label11.TabIndex = 23;
            label11.Text = "Хол.Вода";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(157, 120);
            label12.Name = "label12";
            label12.Size = new Size(24, 15);
            label12.TabIndex = 24;
            label12.Text = "Газ";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(157, 178);
            label13.Name = "label13";
            label13.Size = new Size(33, 15);
            label13.TabIndex = 25;
            label13.Text = "Свет";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.Location = new Point(12, 88);
            label14.Name = "label14";
            label14.Size = new Size(229, 21);
            label14.TabIndex = 26;
            label14.Text = "Введите данные счетчиков:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(583, 196);
            label15.Name = "label15";
            label15.Size = new Size(105, 25);
            label15.TabIndex = 27;
            label15.Text = "Результат:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.Green;
            button2.Location = new Point(592, 149);
            button2.Name = "button2";
            button2.Size = new Size(196, 44);
            button2.TabIndex = 28;
            button2.Text = "Рассчитать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonCalculate_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label16.Location = new Point(583, 120);
            label16.Name = "label16";
            label16.Size = new Size(205, 15);
            label16.TabIndex = 29;
            label16.Text = "Нажмите для расчета квартплаты:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label17.Location = new Point(592, 230);
            label17.Name = "label17";
            label17.Size = new Size(40, 25);
            label17.TabIndex = 30;
            label17.Text = "____";
            label17.Click += label17_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label18.Location = new Point(12, 9);
            label18.Name = "label18";
            label18.Size = new Size(147, 15);
            label18.TabIndex = 31;
            label18.Text = "Номер вашей квартиры";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 36);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(57, 23);
            textBox6.TabIndex = 32;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.LawnGreen;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 12F);
            linkLabel1.Location = new Point(640, 403);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(148, 21);
            linkLabel1.TabIndex = 33;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "История платежей ";
            linkLabel1.LinkClicked += linkLabelHistory_LinkClicked;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(15, 403);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 34;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(130, 403);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 35;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(261, 401);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 36;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(390, 401);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 329);
            label3.Name = "label3";
            label3.Size = new Size(267, 21);
            label3.TabIndex = 38;
            label3.Text = "Введите данные вашего тарифа:";
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_153781638_LoZeeq8vCvS2aShXN3KvOwNzdodi5rjG;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(linkLabel1);
            Controls.Add(textBox6);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(button2);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Account";
            Text = "8";
            FormClosing += Account_FormClosing;
            Load += Account_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label8;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button button2;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox textBox6;
        private LinkLabel linkLabel1;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label3;
    }
}