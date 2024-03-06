using System;
using System.Diagnostics.Metrics;
using System.Reflection;




namespace WinFormsApp8

{
    public partial class Form1 : Form
    {
        int i = 0;
        private List<string> metinListesi = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private int Tekrar(string metin, string arananIfade)
        {
            int sayac = 0;
            int index = metin.IndexOf(arananIfade);

            while (index != -1)
            {
                sayac++;
                index = metin.IndexOf(arananIfade, index + 1);
            }

            return sayac;
        }
        private int MetinUzunlugu(RichTextBox richTextBox)
        {
            string metin = richTextBox.Text;
            int uzunluk = metin.Length;
            return uzunluk;
        }

        private int Index(string richTextBox, string TextBox2)
        {
            int index = richTextBox.IndexOf(TextBox2);


            if (index >= 0)
            {
                MessageBox.Show("Aranan ifade " + index + " indeksinde bulundu.");


            }
            else
            {
                MessageBox.Show("Aranan ifade bulunamadý.");
            }

            return index;


        }
        static bool kontrol1(string ifade)
        {

            return !string.IsNullOrWhiteSpace(ifade) && ifade.All(char.IsLetter);
        }

        static bool kontrol2(string ifade)
        {

            return !string.IsNullOrWhiteSpace(ifade) && ifade.All(char.IsDigit);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;

            int uzunluk = richTextBox1.Text.Length;
            i = i + 1;
            int index = richTextBox1.Text.IndexOf(textBox1.Text);
            if (index >= 0)
            {
                richTextBox2.Text = "Metin numarasý: " + i.ToString() + Environment.NewLine +
                                    "Metin uzunluðu: " + uzunluk.ToString() + Environment.NewLine +
                                    "Ýndexi: " + richTextBox1.Text.IndexOf(textBox1.Text).ToString() + Environment.NewLine +
                                    "Metindeki tekrar sayýsý: " + Tekrar(richTextBox1.Text, textBox1.Text).ToString() + Environment.NewLine +
                                    "Metnin uzunluðu: " + richTextBox1.Text.Length.ToString() + " Aranan ifadenin uzunluðu: " + textBox1.Text.Length.ToString();

            }
            else
            {
                richTextBox2.Text = "Aradýðýnýz ifade metinde bulunmadý";
            }
            string[] row = { i.ToString() + ".metinde " + textBox1.Text.ToString() +
                            " Ýfadesi aranmýþ ve " + Tekrar(richTextBox1.Text, textBox1.Text).ToString() +
                            " kadar bulunmuþtur.Metnin uzunluðu " + richTextBox1.Text.Length.ToString() };
            var satir = new ListViewItem(row);
            listView1.Items.Add(satir);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int mevcutTabPageIndex = tabControl1.SelectedIndex;
            int sonrakiTabPageIndex = mevcutTabPageIndex + 1;
            tabControl1.SelectedIndex = sonrakiTabPageIndex;
        }
        private void button3_Click(object sender, EventArgs e)
        {

            int mevcutTabPageIndex = tabControl1.SelectedIndex;
            int sonrakiTabPageIndex = mevcutTabPageIndex - 1;
            tabControl1.SelectedIndex = sonrakiTabPageIndex;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int mevcutTabPageIndex = tabControl1.SelectedIndex;
            int sonrakiTabPageIndex = mevcutTabPageIndex - 1;
            tabControl1.SelectedIndex = sonrakiTabPageIndex;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int mevcutTabPageIndex = tabControl1.SelectedIndex;
            int sonrakiTabPageIndex = mevcutTabPageIndex - 2;
            tabControl1.SelectedIndex = sonrakiTabPageIndex;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("", 700);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string ifade = textBox1.Text;
            if (kontrol1(ifade) == false)
            {
                MessageBox.Show("Girilen ifade metin deðildir. Lütfen doðru iþaretleyiniz. ");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string ifade = textBox1.Text;
            if (kontrol2(ifade) == false)
            {
                MessageBox.Show("Girilen ifade bir sayý deðildir. Lütfen doðru iþaretleyiniz.");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            string ifade = textBox1.Text;
            if (kontrol2(ifade) && kontrol1(ifade) == false)
            {
                MessageBox.Show("Girilen ifade özel karakter deðildir. Lütfen doðru iþaretleyiniz.");
            }
        }
    }
}