namespace WinFormsApp8
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            tabPage2 = new TabPage();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            richTextBox2 = new RichTextBox();
            tabPage3 = new TabPage();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            listView1 = new ListView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(788, 438);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(checkBox3);
            tabPage1.Controls.Add(checkBox2);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(780, 405);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ana Ekran";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(352, 347);
            button2.Name = "button2";
            button2.Size = new Size(143, 29);
            button2.TabIndex = 8;
            button2.Text = "İleri >";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(352, 303);
            button1.Name = "button1";
            button1.Size = new Size(143, 29);
            button1.TabIndex = 7;
            button1.Text = "Çalıştır";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(482, 245);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(86, 24);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Karakter";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(398, 245);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(58, 24);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Sayı";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(297, 245);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(69, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Metin";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(251, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(380, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 176);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 2;
            label2.Text = "Aranacak ifade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 62);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 1;
            label1.Text = "Metni giriniz:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(251, 62);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(380, 108);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(richTextBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(780, 405);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Analiz Sonuçları";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(508, 338);
            button5.Name = "button5";
            button5.Size = new Size(156, 29);
            button5.TabIndex = 3;
            button5.Text = "İleri";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(320, 338);
            button4.Name = "button4";
            button4.Size = new Size(145, 29);
            button4.TabIndex = 2;
            button4.Text = "Temizle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(120, 338);
            button3.Name = "button3";
            button3.Size = new Size(154, 29);
            button3.TabIndex = 1;
            button3.Text = "Geri";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(59, 30);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(677, 271);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(listView1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(780, 405);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Loglama";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(523, 344);
            button8.Name = "button8";
            button8.Size = new Size(186, 29);
            button8.TabIndex = 3;
            button8.Text = "Temizle";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(298, 344);
            button7.Name = "button7";
            button7.Size = new Size(207, 29);
            button7.TabIndex = 2;
            button7.Text = "<Geri";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(84, 344);
            button6.Name = "button6";
            button6.Size = new Size(195, 29);
            button6.TabIndex = 1;
            button6.Text = "Ana Ekran";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(36, 20);
            listView1.Name = "listView1";
            listView1.Size = new Size(700, 291);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Ödev 1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private RichTextBox richTextBox1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label2;
        private Label label1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Button button3;
        private RichTextBox richTextBox2;
        private Button button5;
        private Button button4;
        private Button button8;
        private Button button7;
        private Button button6;
        private ListView listView1;
    }
}