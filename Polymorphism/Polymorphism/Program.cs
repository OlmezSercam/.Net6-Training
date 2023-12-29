namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cars olan bir değişken(list) oluşturduk ve bu list iki farklı classtan datalara sahip 
            //Bu durumun adı PolyMorphism
            var cars = new List<Car>
            {
                new Audi(200,"Blue","A4"),
                new BMW(250,"Black","M5")
            };
            foreach (var car in cars)
            {
                car.Repair();
            }

            // Car classının içinde oluşturduğumuz için car içinde bulunan showdetails methodu çalışıyor
            Car bmwZ3 = new BMW(220, "White", "Z3");
            Car AudiA3 = new Audi(180, "Green", "A3");
            bmwZ3.ShowDetails(220,"White");
            AudiA3.ShowDetails(180,"Green");

            bmwZ3.SetCarID(1234, "Sercan ölmez");
            AudiA3.SetCarID(1235, "Ercan Ölmez");

            bmwZ3.GetCarIDInfo();
            AudiA3.GetCarIDInfo();

            //BMW classının içinde oluşturursak Bmw class'ında bulunan ShowDetails methodu çalışıyor
            // Methodun new haline getirilmiş olması gerekiyor override etmeden kullanılabiliyor
            BMW bmwM4 = new BMW(330, "White", "M4");
            bmwM4.ShowDetails(330,"White");

            Car carB = (Car)bmwM4;
            carB.ShowDetails(330, "White");

            M3 myM3 = new M3(260, "Red", "M3Super Turbo");
            myM3.Repair();


            Console.ReadKey();
        }
    }
}
