namespace Calisma
{
    public partial class Proje : Form
    {
     
        public Proje()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //KARE
            int alanKare = Convert.ToInt32( textBox1.Text);
            alanKare = alanKare * 2;
            labelKare.Text = alanKare.ToString();

            // D�KD�RTGEN
            int alanK�sa = Convert.ToInt32(textBox2.Text);
            int alanUzun = Convert.ToInt32(textBox4.Text);
            int alan = alanK�sa * alanUzun;
            label10.Text = alan.ToString();

            //DA�RE
            double alanDaire = Convert.ToInt32(textBox3.Text);
            double cap = Math.PI * (alanDaire * alanDaire);
            label9.Text = cap.ToString("F4");
        }
    }
}
