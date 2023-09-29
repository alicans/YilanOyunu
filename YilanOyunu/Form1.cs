namespace YilanOyunu
{

    public partial class Form1 : Form
    {
        List<Point> yilan;
        Random rnd = new Random();
        int boyut = 9;
        int xYon = +1;
        int yYon = 0;

        public Form1()
        {
            InitializeComponent();
            YilaniOlustur();
        }

        private void YilaniOlustur()
        {
            yilan = new List<Point>()
            {
                new Point(boyut/2, boyut/2), // baþ boðum
                new Point(boyut/2-1, boyut/2), // gövde boðum
                new Point(boyut/2-2, boyut/2) // gövde boðum (kuyruk)
            };
        }

        private void pnlSaha_Paint(object sender, PaintEventArgs e)
        {
            YilaniBoya(e.Graphics);
        }

        private void YilaniBoya(Graphics graphics)
        {
            for (int i = 0; i < yilan.Count; i++)
            {
                Point bogum = yilan[i];
                BogumCiz(graphics, bogum, i == 0 ? Color.IndianRed : Color.RoyalBlue);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HareketEt();


            pnlSaha.Refresh();
        }

        private void HareketEt()
        {
            Point mevcutBas = yilan[0];
            Point yeniBas = new Point(mevcutBas.X + xYon, mevcutBas.Y + yYon);
            yilan.Insert(0, yeniBas);
            yilan.RemoveAt(yilan.Count - 1);
        }

        void BogumCiz(Graphics g, Point bogum, Color renk)
        {
            Brush firca = new SolidBrush(renk);
            int gen = pnlSaha.Width / boyut;
            int yuk = pnlSaha.Height / boyut;
            int x = bogum.X * gen;
            int y = bogum.Y * yuk;
            g.FillRectangle(firca, x, y, gen, yuk);

        }
    }
}