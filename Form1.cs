namespace Bufe_Satis_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int kasaTutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, cay, bilet, su;
            int toplam;
            misir = Convert.ToInt16(txtMisir.Text);
            bilet = Convert.ToInt16(textBilet.Text);
            cay = Convert.ToInt16(textCay.Text);
            su = Convert.ToInt16(textSu.Text);

            toplam = misir * 50 + cay * 35 + su * 15 + bilet * 300;
            lblToplamTutar.Text = toplam.ToString() + " Tl";

            kasaTutar += toplam;

            lblKasaTutar.Text = kasaTutar.ToString() + " Tl";

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBilet.Text = " ";
            textCay.Text = " ";
            textSu.Text = " ";
            txtMisir.Text = " ";
            txtMisir.Focus();

            lblToplamTutar.Text = " Tl";
        }
    }
}
