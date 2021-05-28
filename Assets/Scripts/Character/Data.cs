using System;

namespace Character
{
    //class model/data yang digunakan untuk menampung data player
    [Serializable]
    public class Data
    {
        public static string Name { get; set; }
        public static int Score { get; set; }
        public static int Health { get; set; }
        
    }
}