namespace Math_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ceiling:" + Math.Ceiling(15.3));
            // Math. yazıp tüm operatörler görüntülenebilir
            Math.Floor(15.3);
            ConvertToRadians(200);
            Console.Read();
        }
        public static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        public static void Run(string line)
        {

            int angle;

            if (Int32.TryParse(line, out angle) == false || (angle < 0 || angle > 180))
            {
                System.Console.WriteLine("Check the input!");
                return;
            }

            System.Console.WriteLine("Cos = {0}", Math.Cos(ConvertToRadians(angle)));
            System.Console.WriteLine("Sin = {0}", Math.Sin(ConvertToRadians(angle)));
            System.Console.WriteLine("Tg = {0}", Math.Tan(ConvertToRadians(angle)));

        }
    }
}
