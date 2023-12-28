using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo
{
    internal class Image_Post : Post
    {
        //bu iki constructor için : base yapmıyoruz çünkü post class'ında property olarak tüm değişkenleri oluşturduk
        public string ImageURL { get; set; }
        public Image_Post()
        {

        }
        public Image_Post(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            // propert imageurl is a member of imagepost, but not of post
            this.ImageURL = imageURL;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}- by {3}", this.ID, this.Title, 
                this.ImageURL, this.SendByUsername);
        }
    }
}
