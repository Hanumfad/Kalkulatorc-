namespace Kalkulator2
{
    public partial class Hanum : Form
    {
        public Hanum()
        {
            InitializeComponent();
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            double bil1, bil2, hasil = 0;
            bool isNumeric1 = double.TryParse(txtbil1.Text, out bil1);
            bool isNumeric2 = double.TryParse(txtbil2.Text, out bil2);
            if (isNumeric1 && isNumeric2)
            {
                hasil = bil1 + bil2;
                txthasil.Text = hasil.ToString();
            }
            else
            {
                MessageBox.Show("Harap memasukkan angka bukan huruf!");
            }
        }

        private void btnkurang_Click(object sender, EventArgs e)
        {
            double bil1, bil2, hasil = 0;
            bool isNumeric1 = double.TryParse(txtbil1.Text, out bil1);
            bool isNumeric2 = double.TryParse(txtbil2.Text, out bil2);
            if (isNumeric1 && isNumeric2)
            {
                hasil = bil1 - bil2;
                txthasil.Text = hasil.ToString();
            }
            else
            {
                MessageBox.Show("Harap memasukkan angka bukan huruf!");
            }
        }

        private void btnbagi_Click(object sender, EventArgs e)
        {
            double bil1, bil2, hasil = 0;
            bool isNumeric1 = double.TryParse(txtbil1.Text, out bil1);
            bool isNumeric2 = double.TryParse(txtbil2.Text, out bil2);
            if (isNumeric1 && isNumeric2)
            {
                hasil = bil1 / bil2;
                txthasil.Text = hasil.ToString();
            }
            else
            {
                MessageBox.Show("Harap memasukkan angka bukan huruf!");
            }
        
    }

        private void btnkali_Click(object sender, EventArgs e)
        {
            double bil1, bil2, hasil = 0;
            bool isNumeric1 = double.TryParse(txtbil1.Text, out bil1);
            bool isNumeric2 = double.TryParse(txtbil2.Text, out bil2);
            if (isNumeric1 && isNumeric2)
            {
                hasil = bil1 * bil2;
                txthasil.Text = hasil.ToString();
            }
            else
            {
                MessageBox.Show("Harap memasukkan angka bukan huruf!");
            }
        }
    

        private void btnmodulus_Click(object sender, EventArgs e)
        {
            double bil1, bil2, hasil = 0;
            bool isNumeric1 = double.TryParse(txtbil1.Text, out bil1);
            bool isNumeric2 = double.TryParse(txtbil2.Text, out bil2);
            if (isNumeric1 && isNumeric2)
            {
                hasil = bil1 % bil2;
                txthasil.Text = hasil.ToString();
            }
            else
            {
                MessageBox.Show("Harap memasukkan angka bukan huruf!");
            }
        }
    

        private void btnpangkat_Click(object sender, EventArgs e)
        {
            double bil1, bil2, hasil = 0;
            bool isNumeric1 = double.TryParse(txtbil1.Text, out bil1);
            bool isNumeric2 = double.TryParse(txtbil2.Text, out bil2);
            if (isNumeric1 && isNumeric2)
            {
                hasil = Math.Pow(bil1, bil2);
                txthasil.Text = hasil.ToString();
            }
            else
            {
                MessageBox.Show("Harap memasukkan angka bukan huruf!");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtbil1.Text = "";
            txtbil2.Text = "";
            txthasil.Text = "";
        }

        private void Hanum_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    
