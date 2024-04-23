namespace EmlakciLib
{
    public class Ev
    {
        private static int count=0;
        public static int Count { get => count;  }
        public Ev(int odasayisi, int katno,string semt, double alan) // geri dönüş tipi yok
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = semt;
            this.Alan = alan;
            count++;
        }
        public Ev()
        {
            count++;
        }
        public Ev(int odasayisi, int katno,  double alan) // geri dönüş tipi yok
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Alan = alan;
            this.Semt = "Gazi";
            count++;
        }


        private int odasayisi;
        private int katno;
        //private double alan;
        private string semt;
        private string buyukluk;


        
        public int Katno { get => katno; set => katno = value; }//property 
        public string Semt { get => semt; set => semt = value.ToUpper(); }
        //public double Alan { get => alan; set => alan = Math.Abs(value); }

        public int Odasayisi { get => odasayisi; set => odasayisi = Math.Abs(value); }

        //propfull tab tab
        private double alan;

        public double Alan
        {
            get 
            {
                string buyukluk;
                buyukluk= this.buyukluk;
                return alan;
            }

            set
            {
                alan = alan;
                if (alan < 100)
                {
                    this.buyukluk = "Küçük Ev";
                }
                else if (100 <= alan && alan < 150)
                {
                    this.buyukluk = "Orta Ev";
                }
                else
                {
                    this.buyukluk = "Büyük Ev";
                }
            }
        }




        //public void SetAlan(double alan)
        //{
        //    this.alan = alan;
        //    if (alan < 100)
        //    {
        //        this.buyukluk = "Küçük Ev";
        //    }
        //    else if (100 <= alan && alan < 150)
        //    {
        //        this.buyukluk = "Orta Ev";
        //    }
        //    else
        //    {
        //        this.buyukluk = "Büyük Ev";
        //    }
        //}
        public string Buyukluk { get => buyukluk; }
       


        //public void SetSemt(string semt)
        //{
        //    this.semt = semt.ToUpper();
        //}

        //public string GetSemt()
        //{
        //    return this.semt;
        //}


        public void SetOdaSayisi(int odasayisi)
        {
            this.Odasayisi = Math.Abs(odasayisi);
        }

        public int GetOdaSayisi(int odasayisi)
        {
            return this.Odasayisi;
        }


        public string EvBilgi(Ev ev)
        {
                return "Oda sayısı:" + this.Odasayisi + "\nKat no:" + this.Katno + "\nAlan:" + this.Alan + "\nSemt:" + this.Semt;
           
        }
    }
}
//Default CONSTRUCTOR : Class içerisinde bulunan fieldlara varsaılan değerleri atayarak kullanıma hazır hale getirir.
// Constructor ların geri dönüş tipi olmaz. Class ile aynıdır.