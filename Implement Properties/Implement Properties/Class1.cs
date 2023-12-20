using System;
namespace Implement_Properties
{
    public class Book
    {
        private string _title;
        private int _pages;
        public string Title
        {

            get
            {
                return _title;
            }
            set
            {
                if (Title == "")
                {
                    _title = "Unknown";
                }
                else
                {
                    _title = Title;
                }
            }
        }
        public int Pages
        {
            get
            {
                return _pages;
            }
            set
            {
                if (Pages < 1)
                {
                    _pages = 1;
                }
                else
                {
                    _pages = value;
                }
            }
        }

    }
}