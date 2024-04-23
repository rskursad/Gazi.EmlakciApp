using EmlakciLib;
using System.Threading.Channels;

namespace EmlakciApp
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            Ev evim; // ev tipinde evim isminde referans
            evim = new Ev();// ev tipinde yeni bir nesne
            //evim.alan = 120;
            //evim.odasayisi = 3;
            //evim.katno = 1;
            //evim.semt = "Gazi";
            //Console.WriteLine(EvBilgi(evim));

            //Console.WriteLine();

            //Ev evim2 = new Ev();
            //evim2.alan = 100;
            //evim2.katno = 2;
            //evim2.odasayisi = 3;
            //evim2.semt = "Kazan";
            //Console.WriteLine(EvBilgi(evim2));

            //Console.WriteLine();

            //try
            //{
            //    Ev evim3=null;
            //    Console.WriteLine(EvBilgi(evim3));
            //}
            //catch (NullReferenceException)
            //{
            //    Console.WriteLine("Referans null geldi.");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Bir hata oluştu.");
            //}

            //Console.WriteLine("Oda sayısı giriniz:");
            //evim.SetOdaSayisi(int.Parse(Console.ReadLine()));
            //Console.WriteLine("kat no giriniz:");
            //evim.Katno = int.Parse(Console.ReadLine());
            //Console.WriteLine("Semt giriniz:");
            //evim.Semt=Console.ReadLine();
            //Console.WriteLine("alan giriniz:");
            //evim.alan=double.Parse(Console.ReadLine());

            //Console.WriteLine($"Girilen ev bilgileri:\n{evim.EvBilgi(evim)}");
            //Console.WriteLine("Oda sayısı:"+evim.GetOdaSayisi);
            //Console.WriteLine("Semt:" + evim.Semt);

            //int sayi = 5; //set
            //Console.WriteLine(sayi); //get

            //double alan;
            //Console.WriteLine("Evin alanını giriniz:");
            //alan = double.Parse(Console.ReadLine());
            //var evim= new Ev(3,2,"Gazi",alan);
            //Console.WriteLine(evim.Alan);


            Ev evim2 = new Ev(3,2,100);
            Console.WriteLine(evim2.EvBilgi(evim2));

            Console.WriteLine("Bellekteki ev sayısı: "+Ev.Count);



        }
        //static string EvBilgi(Ev ev)
        //{
        //    //if (ev != null)
        //    //{
        //    //    return "Oda sayısı:" + ev.odasayisi + "\nKat no:" + ev.katno + "\nAlan:" + ev.alan + "\nSemt:" + ev.semt;
        //    //}
        //    //else
        //    //{
        //    //    return "Referans null geldi!";
        //    //}
        //    try
        //    {
        //        return "Oda sayısı:" + ev.odasayisi + "\nKat no:" + ev.katno + "\nAlan:" + ev.alan + "\nSemt:" + ev.semt;
        //    }
        //    catch (NullReferenceException ex)
        //    {
        //        throw ex;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //}


    }

    //class Ev
    //{
    //    public int odasayisi;  //field
    //    public int katno;
    //    public double alan;
    //    public string semt;

    //}
}
//Kapsülleme ilkesi (Encapsulation):Bir class içerisinde yapılan işlemlerin, diğer classlardan gizlenmesi ilkesidir.
//Property: Private yapılara ulaşmak için kullanılan yapılardır. Get ve  opsiyonel olarak set yapıları içerir.

// Referanslar belleğin stack bölgesinde tutulur.
// Referanslar, heap bölgesindeki nesnenin adresini tutar.
//Nesneler belleğin heap bölgesinde tutulur.
// Nesne oluşturulurken kullanılan new anahtar sözcüğü, heap bölgesinde alan ayırma işlemi yaparken nesne içerisinde bulunan fieldlara
//varsayılan değerlerin de atamasını yapar.* (Constructor method)
// new; hesap bölgesinde tutulan yeni bir nesne oluşturmaya yarar.
//Bir class oluşturduğumuzda aslında "int" gibi yeni bir tür oluşturuyoruz. Bu türü daha sonra "int" gibi kullanabiliyoruz.
//Metodlarda tanımladığımız class ları kullanabilmek için class türünde parametre veriyoruz.