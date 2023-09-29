namespace YilanOyunu
{

    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<Point> yilan;
        Point yem;
        int boyut = 9;
        int xYon = 1, yYon = 0;
        int yemeAdet = 0;

        public Form1()
        {
            InitializeComponent();
            YilaniOlustur();
            YemOlustur();
        }

        private void YemOlustur()
        {
            Point yeniYem;
            do
            {
                yeniYem = new Point(rnd.Next(boyut), rnd.Next(boyut));
            }
            while (YilaninUzerindeMi(yeniYem));
            yem = yeniYem;
        }

        private bool YilaninUzerindeMi(Point yeniYem)
        {
            foreach (Point bogum in yilan)
                if (bogum == yeniYem)
                    return true;
            return false;
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
            YemiBoya(e.Graphics);
        }

        private void YemiBoya(Graphics graphics)
        {
            BogumCiz(graphics, yem, Color.Gold);
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


            // Oyun Bitti mi?
            if (YilaninUzerindeMi(yeniBas) || SahaDisindaMi(yeniBas))
            {
                timer1.Stop();
                MessageBox.Show("Oyun Bitti! Puanýnýz: " + yemeAdet * 100);
                return;
            }




            bool yemiYuttuMu = yeniBas == yem;
            yilan.Insert(0, yeniBas);


            if (yemiYuttuMu)
            {
                yemeAdet++;
                YemOlustur();
                lblPuan.Text = "Puan: " + (yemeAdet * 100);
            }
            else
            {
                yilan.RemoveAt(yilan.Count - 1);
            }
        }

        private bool SahaDisindaMi(Point bogum)
        {
            return bogum.X < 0 || bogum.Y < 0 || bogum.X >= boyut || bogum.Y >= boyut;
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    xYon = 0; yYon = -1;
                    timer1.Interval = 200;
                    break;
                case Keys.Right:
                    xYon = 1; yYon = 0;
                    timer1.Interval = 200;
                    break;
                case Keys.Down:
                    xYon = 0; yYon = 1;
                    timer1.Interval = 200;
                    break;
                case Keys.Left:
                    xYon = -1; yYon = 0;
                    timer1.Interval = 200;
                    break;



            }


            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}