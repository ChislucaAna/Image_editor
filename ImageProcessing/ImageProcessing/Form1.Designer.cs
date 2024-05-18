namespace ImageProcessing
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
            pictureBox1 = new PictureBox();
            trackBar1 = new TrackBar();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            tabPage3 = new TabPage();
            button8 = new Button();
            textBox3 = new TextBox();
            label5 = new Label();
            button5 = new Button();
            button3 = new Button();
            CropImage = new TabPage();
            button7 = new Button();
            button6 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            button4 = new Button();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            CropImage.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightCyan;
            pictureBox1.Location = new Point(12, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(543, 403);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(31, 35);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(332, 45);
            trackBar1.TabIndex = 2;
            trackBar1.Value = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Location = new Point(944, 25);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 3;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Thistle;
            button2.Enabled = false;
            button2.Location = new Point(31, 114);
            button2.Name = "button2";
            button2.Size = new Size(82, 29);
            button2.TabIndex = 4;
            button2.Text = "Zoom in";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(41, 31);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 5;
            label1.Text = "Original image width:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(41, 58);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 6;
            label2.Text = "Original image height:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(41, 97);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 7;
            label3.Text = "New width:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(41, 132);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 8;
            label4.Text = "New height:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightCyan;
            textBox1.Location = new Point(137, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightCyan;
            textBox2.Location = new Point(137, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(131, 23);
            textBox2.TabIndex = 10;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(CropImage);
            tabControl1.Location = new Point(597, 54);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(543, 548);
            tabControl1.TabIndex = 12;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(trackBar1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(535, 520);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Zoom";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(535, 520);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Resize";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(button3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(535, 520);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Draw";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.BackColor = Color.Thistle;
            button8.Location = new Point(32, 155);
            button8.Name = "button8";
            button8.Size = new Size(119, 23);
            button8.TabIndex = 4;
            button8.Text = "Clear all strokes";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightCyan;
            textBox3.Location = new Point(132, 68);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            textBox3.Text = "3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 69);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 2;
            label5.Text = "Brush thickness:";
            // 
            // button5
            // 
            button5.BackColor = Color.Thistle;
            button5.Location = new Point(31, 117);
            button5.Name = "button5";
            button5.Size = new Size(124, 26);
            button5.TabIndex = 1;
            button5.Text = "Clear brush";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Thistle;
            button3.Location = new Point(27, 26);
            button3.Name = "button3";
            button3.Size = new Size(124, 23);
            button3.TabIndex = 0;
            button3.Text = "Select Color";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // CropImage
            // 
            CropImage.Controls.Add(button7);
            CropImage.Controls.Add(button6);
            CropImage.Controls.Add(textBox5);
            CropImage.Controls.Add(textBox4);
            CropImage.Controls.Add(label7);
            CropImage.Controls.Add(label6);
            CropImage.Location = new Point(4, 24);
            CropImage.Name = "CropImage";
            CropImage.Size = new Size(535, 520);
            CropImage.TabIndex = 3;
            CropImage.Text = "Crop Image";
            CropImage.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackColor = Color.Thistle;
            button7.Location = new Point(217, 49);
            button7.Name = "button7";
            button7.Size = new Size(122, 23);
            button7.TabIndex = 5;
            button7.Text = "Generate selection";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Thistle;
            button6.Location = new Point(15, 108);
            button6.Name = "button6";
            button6.Size = new Size(168, 23);
            button6.TabIndex = 4;
            button6.Text = "Crop selected area and save";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.LightCyan;
            textBox5.Location = new Point(97, 67);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightCyan;
            textBox4.Location = new Point(97, 26);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 70);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 1;
            label7.Text = "Crop height:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 29);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 0;
            label6.Text = "Crop width:";
            // 
            // button4
            // 
            button4.BackColor = Color.Thistle;
            button4.Location = new Point(1053, 25);
            button4.Name = "button4";
            button4.Size = new Size(87, 23);
            button4.TabIndex = 13;
            button4.Text = "Save Image";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1172, 628);
            Controls.Add(button4);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "New Project";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            CropImage.ResumeLayout(false);
            CropImage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TrackBar trackBar1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private Button button4;
        private ColorDialog colorDialog1;
        private Button button3;
        private TextBox textBox3;
        private Label label5;
        private Button button5;
        private TabPage CropImage;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label7;
        private Label label6;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}
