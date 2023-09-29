namespace YilanOyunu
{

    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int boyut = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void pnlSaha_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.FillRectangle(Brushes.MidnightBlue, rnd.Next(300), rnd.Next(300), 40, 40);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlSaha.Refresh();
        }

        void BogumCiz(Point bogum)
        {
            int gen = pnlSaha.Width / boyut;
            int yuh = pnlSaha.Height / boyut;
        }
    }
}