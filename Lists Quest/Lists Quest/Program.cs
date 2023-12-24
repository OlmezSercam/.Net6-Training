using System;
using System.Collections;
using System.Collections.Generic;
namespace Lists_Quest
{
    internal class Program
    {
        public static List<int> Solution()
        {
            List<int> myList = new List<int>();
            
            for (int i=100; i<170; i++)
            {
                if (i % 2 == 0)
                {
                    myList.Add(i);
                }
                
            }
            return myList;
        }
        
    }
}
