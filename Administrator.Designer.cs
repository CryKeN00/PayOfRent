namespace PayOfRent
{
    partial class Administrator
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
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(606, 313);
            dataGridView1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(667, 129);
            button3.Name = "button3";
            button3.Size = new Size(121, 40);
            button3.TabIndex = 3;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDelete_Click;
            // 
            // button1
            // 
            button1.Location = new Point(667, 37);
            button1.Name = "button1";
            button1.Size = new Size(121, 40);
            button1.TabIndex = 10;
            button1.Text = "Редактировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnEdit_Click;
            // 
            // button2
            // 
            button2.Location = new Point(667, 83);
            button2.Name = "button2";
            button2.Size = new Size(121, 40);
            button2.TabIndex = 11;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(671, 249);
            label1.Name = "label1";
            label1.Size = new Size(116, 39);
            label1.TabIndex = 12;
            label1.Text = "Изменить формулу\r\nрасчета квартплаты\r\n\r\n";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(671, 291);
            button4.Name = "button4";
            button4.Size = new Size(117, 55);
            button4.TabIndex = 13;
            button4.Text = "Изменить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnChangeFormula_Click;
            // 
            // button5
            // 
            button5.ForeColor = Color.Red;
            button5.Location = new Point(712, 415);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 14;
            button5.Text = "Выйти";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnExit_Click;
            // 
            // Administrator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._9lqvhKKSkptM0mtkzz7dH9lCjqU_960;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Name = "Administrator";
            Text = "Администрирование";
            Load += Administrator_Load;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administrator_FormClosing);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button3;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button4;
        private Button button5;
    }
}