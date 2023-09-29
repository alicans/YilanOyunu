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
            Point birNokta = new Point(3,4);
            BogumCiz(e.Graphics, birNokta, Color.Orange);

            Point baskaNokta = new Point(6,7);
            BogumCiz(e.Graphics, baskaNokta, Color.Orange);
            //e.Graphics.FillRectangle(Brushes.MidnightBlue, rnd.Next(300), rnd.Next(300), 40, 40);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlSaha.Refresh();
        }

        void BogumCiz(Graphics g, Point bogum, Color renk)
        {
            Brush firca = new SolidBrush(renk);
            int gen = pnlSaha.Width / boyut;
            int yuk = pnlSaha.Height / boyut;
            int x = bogum.X * gen;
            int y = bogum.Y * yuk;
            g.FillRectangle(firca,x,y,gen,yuk);

        }
    }
}