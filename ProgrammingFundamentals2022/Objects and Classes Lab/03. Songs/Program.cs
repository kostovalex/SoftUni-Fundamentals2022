using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int songsCount = int.Parse(Console.ReadLine());
            
            List<Song> playList = new List<Song>();

            for (int i = 0; i < songsCount; i++)
            {
                string[] command = Console.ReadLine().Split("_");

                Song song = new Song(command[0], command[1], command[2]);
                playList.Add(song);
            }
           
            string typeList = Console.ReadLine();
            
            if (typeList == "all")
            {
                foreach (Song elemnt in playList)
                {
                    Console.WriteLine(elemnt.Name);
                }
            }
            else
            {
                foreach (Song element in playList)
                {
                    if (element.TypeList == typeList)
                    {
                        Console.WriteLine(element.Name);
                    }
                }
            }
        }
    }

    class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
