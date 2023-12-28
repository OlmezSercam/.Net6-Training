using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo
{
    internal class VideoPost : Post
    {
        //member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        //properties
        public string VideoURL { get; set; }
        public int Length { get; set; }

        public VideoPost()
        {

        }
        public VideoPost(string title, string sendByUsername, string VideoURL,
            bool isPublic, int Length)
        {
            //the following properties and the getnextID method are inherited from post.
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            // property videourl and length is a member of videopost but not of post
            this.VideoURL = VideoURL;
            this.Length = Length;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - by {4}", 
                this.ID, this.Title, this.VideoURL, this.Length, this.SendByUsername);
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallBack, null, 0, 1000);
            }
        }

        private void TimerCallBack(Object O)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}s", currDuration);
                currDuration = 0;
                timer.Dispose();
            }

        }

    }
}
