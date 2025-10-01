namespace CalculatorV2
{
    public partial class Form1 : Form
    {

        double sayi1;
        string islemtipi = "";
        bool yeniGiris = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (yeniGiris)
            {
                txtsonuc.Text = "5";
                yeniGiris = false;
            }
            else
            {
                txtsonuc.Text += 5;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (yeniGiris)
            {
                txtsonuc.Text = "1";
                yeniGiris = false;
            }
            else
            {
                txtsonuc.Text += 1;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (yeniGiris)
            {
                txtsonuc.Text = "2";
                yeniGiris = false;
            }
            else
            {
                txtsonuc.Text += 2;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (yeniGiris)
            {
                txtsonuc.Text = "3";
                yeniGiris = false;
            }
            else
            {
                txtsonuc.Text += 3;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (yeniGiris)
            {
                txtsonuc.Text = "4";
                yeniGiris = false;
            }
            else
            {
                txtsonuc.Text += 4;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (yeniGiris)
            {
                txtsonuc.Text = "6";
                yeniGiris = false;
            }
            else
            {
                txtsonuc.Text += 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (yeniGiris)
            {
                txtsonuc.Text = "7";
                yeniGiris = false;
            }
            else
            {
                txtsonuc.Text += 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (yeniGiris)
            {
                txtsonuc.Text = "8";
                yeniGiris = false;
            }
            else
            {
                txtsonuc.Text += 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (yeniGiris)
            {
                txtsonuc.Text = "9";
                yeniGiris = false;
            }
            else
            {
                txtsonuc.Text += 9;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (yeniGiris)
            {
                txtsonuc.Text = "0";
                yeniGiris = false;
            }
            else
            {
                txtsonuc.Text += 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Yaln�zca ekran bo� de�ilse ve ekranda bir say� varsa i�leme ba�la
            if (!string.IsNullOrEmpty(txtsonuc.Text) && txtsonuc.Text != "HATA")
            {
                // �nceki bir i�lem beklemede mi kontrol et (Zincirleme i�in)
                if (islemtipi != "")
                {
                   
                }

                // Ekrandaki g�ncel say�y� sayi1 olarak kaydet
                sayi1 = Convert.ToDouble(txtsonuc.Text);

                // ��lem t�r�n� kaydet
                islemtipi = "+";

                

                // Sonu� ekran�n� temizleme sinyali ver
                yeniGiris = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtsonuc.Text))
            {
                sayi1 = Convert.ToDouble(txtsonuc.Text);
                islemtipi = "-";
                yeniGiris = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtsonuc.Text))
            {
                sayi1 = Convert.ToDouble(txtsonuc.Text);
                islemtipi = "*";
                yeniGiris = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtsonuc.Text))
            {
                sayi1 = Convert.ToDouble(txtsonuc.Text);
                islemtipi = "/";
                yeniGiris = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                double sayi2 = Convert.ToDouble(txtsonuc.Text);
                double sonuc = 0;

                switch (islemtipi)
                {
                    case "+":
                        sonuc = sayi1 + sayi2;
                        break;
                    case "-":
                        sonuc = sayi1 - sayi2;
                        break;
                    case "*":
                        sonuc = sayi1 * sayi2;
                        break;
                    case "/":
                        if (sayi2 != 0)
                        {
                            sonuc = sayi1 / sayi2;
                        }
                        else
                        {
                            MessageBox.Show("S�f�ra b�lme yap�lamaz!", "Hata");
                            txtsonuc.Text = "0";
                            return;
                        }
                        break;
                }

                txtsonuc.Text = sonuc.ToString();
                sayi1 = sonuc; // Zincirleme i�lem i�in
                islemtipi = "";
                yeniGiris = true;

            }
            catch (Exception)
            {
                txtsonuc.Text = "HATA";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // 1. Ekran� s�f�rla
            txtsonuc.Text = "0";

            yeniGiris = true;
        }
    }
}
