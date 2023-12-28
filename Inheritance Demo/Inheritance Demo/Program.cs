using System.Diagnostics;

namespace Inheritance_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {   //parantezin içini boş bıraksam default olan post constructor çalışacaktı
            Post Post1 = new Post("Thanks for the birthday wishes", true, "Sercan Ölmez");
            Console.WriteLine(Post1.ToString());
            Image_Post imagePost1 = new Image_Post("Check out my new shoes", "Sercan Ölmez",
                "https://images.com/shoes", true);

            Console.WriteLine(imagePost1.ToString());

            VideoPost myVideoPost = new VideoPost("FailVideo","Seco",
                "https://video.com/failvideo",  true,5);

            Console.WriteLine(myVideoPost.ToString());

            myVideoPost.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            myVideoPost.Stop();

            Console.ReadLine();
        }
    }
}
