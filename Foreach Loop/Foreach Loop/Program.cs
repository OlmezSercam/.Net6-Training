namespace Foreach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for döngüsü ile array içini doldurduk
            int[] nums = new int[10];
            for (int i = 0; i<10; i++)
            {
                nums[i] = i+10;
            }

            // for döngüsü ile array içini yazdırdık
            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element {0} = {1}", j, nums[j]);
            }

            int counter = 0;
            foreach (int k in nums)
            {
                Console.WriteLine("Element {0} = {1}", counter, k); counter++;
            }

            

            string[] orospuDevrelerim = new string[5] { "Ercan", "Enes", "Ata", "Alp", "Oğuz" };
            
            foreach(string name in orospuDevrelerim)
            {
                Console.WriteLine("Merhaba {0} orospusu", name);
            }
            Console.ReadKey();
        }
    }
}
