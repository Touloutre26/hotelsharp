namespace hotelcsharpL3
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
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            dateTimePicker3 = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            numericUpDown2 = new NumericUpDown();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(32, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(902, 275);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Booking Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 54);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Nom /";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 54);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Prénom /";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(330, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(518, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(321, 27);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 100);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 4;
            label3.Text = "Tel /";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 100);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 5;
            label4.Text = "Email /";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(585, 100);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 6;
            label5.Text = "Adresse /";
            label5.Click += label5_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(103, 97);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(88, 27);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(295, 97);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(260, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(661, 97);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(178, 27);
            textBox5.TabIndex = 9;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 148);
            label6.Name = "label6";
            label6.Size = new Size(142, 20);
            label6.TabIndex = 10;
            label6.Text = "Date de Naissance /";
            label6.Click += label6_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(181, 144);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(596, 146);
            numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(43, 27);
            numericUpDown1.TabIndex = 12;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(446, 148);
            label7.Name = "label7";
            label7.Size = new Size(141, 20);
            label7.TabIndex = 13;
            label7.Text = "Nb de personne(s) /";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(181, 193);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 197);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 14;
            label8.Text = "Début séjour /";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(596, 193);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(243, 27);
            dateTimePicker3.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(448, 198);
            label9.Name = "label9";
            label9.Size = new Size(82, 20);
            label9.TabIndex = 16;
            label9.Text = "Fin séjour /";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(661, 148);
            label10.Name = "label10";
            label10.Size = new Size(97, 20);
            label10.TabIndex = 19;
            label10.Text = "Chambre n° /";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(764, 144);
            numericUpDown2.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(75, 27);
            numericUpDown2.TabIndex = 18;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBox6
            // 
            textBox6.Location = new Point(32, 330);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(431, 27);
            textBox6.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Location = new Point(480, 323);
            button1.Name = "button1";
            button1.Size = new Size(94, 41);
            button1.TabIndex = 2;
            button1.Text = "Rechercher";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Location = new Point(617, 323);
            button2.Name = "button2";
            button2.Size = new Size(94, 41);
            button2.TabIndex = 3;
            button2.Text = "Insérer";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 192);
            button3.Location = new Point(728, 323);
            button3.Name = "button3";
            button3.Size = new Size(94, 41);
            button3.TabIndex = 4;
            button3.Text = "Updater";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Location = new Point(840, 323);
            button4.Name = "button4";
            button4.Size = new Size(94, 41);
            button4.TabIndex = 5;
            button4.Text = "Supprimer";
            button4.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 375);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(902, 295);
            dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(193, 164, 192);
            ClientSize = new Size(963, 693);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label5;
        private Label label4;
        private TextBox textBox5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker3;
        private Label label9;
        private DateTimePicker dateTimePicker2;
        private Label label8;
        private Label label10;
        private NumericUpDown numericUpDown2;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
    }
}
