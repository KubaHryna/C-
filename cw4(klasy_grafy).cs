namespace Project2_classes_
{
    public partial class Form1 : Form
    {
        string s = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            
            Węzeł w1 = new Węzeł(5);
            Węzeł w2 = new Węzeł(3);
            Węzeł w3 = new Węzeł(1);
            Węzeł w4 = new Węzeł(2);
            Węzeł w5 = new Węzeł(4);
            Węzeł w6 = new Węzeł(6);

            w1.dzieci.Add(w2);
            w1.dzieci.Add(w3);
            w1.dzieci.Add(w4);
            w2.dzieci.Add(w5);
            w2.dzieci.Add(w6);
            A(w1);
            MessageBox.Show(s);
            s = "";

        }
        void A(Węzeł w)
        {
            foreach(var el in w.dzieci)
            {
                A(el);

            }
            s  += " " + w.wartosc.ToString();
          

        }
    }
    class Węzeł
    {
        public int wartosc;
        public List<Węzeł> dzieci = new List<Węzeł>();
        public Węzeł(int liczba)
        {
            this.wartosc = liczba;
        }

    }
}
