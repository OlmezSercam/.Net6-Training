using System;
using System.Collections;
namespace Debugging
{
    internal class Program // 9.44
    {
        static void Main(string[] args)
        {//F9 a basarak durak noktası oluşturulur sonra runlanır
            // yukarıda runlama sekmesinin yanında tuşlarla satırlar incelenebilir
            var friends = new List<string> {"Frank", "Joe", "Michelle", "Andy", "Maria", "Carlos","Angelina" };
            var partyFriends = GetPartyFriends(friends, 3);

            foreach (var name in partyFriends)
                Console.WriteLine(name);  // ilerleme tuşuna bastıkça foreach looptan
                                          // isimlerin tek tek yazdırıldığı name üzerine
                                          //gelip okunabilir
        }

        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            var partyFriends = new List<string>();

            while(partyFriends.Count < count) 
            {
                var currentFriend = GetPartyFriend(list);
                partyFriends.Add(currentFriend);
                list.Remove(currentFriend);
            }
            return partyFriends;
        }

        public static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for (var i =0; i<list.Count; i++) 
            {
                if (list[i].Length < shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
            return shortestName;
        }
    }
}
