using System.Runtime.ConstrainedExecution;

namespace Regular_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ControlF yapıp açılan sekmeden yıldızı yani RegEx seçilir.
            //\d\d\d-\d\d\d-\d\d\d telefon numarası bulmak için kullanılabilecek bir yöntem incelenirse onlarca yöntem mevcut durumda
            //https://(www)? bu arama https:// ardından www gelse de gelmese de olur demek oluyor

            // Alman telefon numaralarında 3 farklı şekilde ekrana düşme durumu oluyor
            //0175/12345678
            //+49165/12312347
            //0049165/12312347
            //(\+49)|0049|0?1(6|7)\d/\d{8} bu arama yöntemi ile 3 ihtimal de kriterleniyor
            //soru işareti kendisinden önce gelen element olsa da olur olmasa da olur anlmaında kullanılıyor

            //+905305148826
            //00905305148826
            //(\+)|(00)?\d{12}  üstteki 2 tr numarası için kendim yaptım

            //https://www.tutorials.eu
            //https://tutorials.eu
            //http://www.tutorials.eu
            //http://tutorials.eu
            //https?://(www)?\.?tutorials.eu
            //https?://(www)?\.?\w{9}\.\w\w   
            //https?://(www)?\.?(\w+)\.\w\w         aynı işlev üçü


            //(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|"(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])
            // bu üstteki tüm emailleri marklayabilen bir kod
            //test@test.com
            //info @test.com
            //ser.olmez @hotmail.com
            //olmez.s @gmail.com


        }
    }
}
