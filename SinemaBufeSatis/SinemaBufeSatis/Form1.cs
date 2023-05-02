namespace SinemaBufeSatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        public void temizle()
        {
            txt_bilet.Text = "";
            txt_cay.Text = "";
            txt_misir.Text = "";
            txt_su.Text = "";
            txt_misir.Focus();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, toplam;
            misir = Convert.ToInt16(txt_misir.Text);
            bilet = Convert.ToInt16(txt_bilet.Text);
            su = Convert.ToInt16(txt_su.Text);
            cay = Convert.ToInt16(txt_cay.Text);
            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            lbl_toplam.Text = "Toplam: " + toplam.ToString() + " TL";
            kasatutar += toplam;
            lbl_kasa.Text = "Kasa: " + kasatutar.ToString() + " TL";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}