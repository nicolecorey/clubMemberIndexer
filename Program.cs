using System.Drawing;

class Program
{
    public const int Size = 15;  // global variable
    class ClubMembers
    {
        private string[] Members = new string[Size];
        public string ClubType { get; set; }
        public string ClubLocation { get; set; }
        public string MeetingDate { get; set; }

        // constructor
        public ClubMembers()
        {
            for (int i = 0; i < Size; i++)
            {
                Members[i] = string.Empty;
            }

            ClubType = string.Empty;
            ClubLocation = string.Empty;
            MeetingDate = string.Empty;
        }

        //indexer get and set methods
        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= Size - 1)
                {
                    tmp = Members[index];
                }
                else
                {
                    tmp = "";
                }

                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= Size - 1)
                {
                    Members[index] = value;
                }


            }
        }
    }
    static void Main(string[] args)
    {
        ClubMembers Members = new ClubMembers();

        Console.WriteLine("Club Information");
        Console.WriteLine();
        Console.WriteLine("Club Members:");

        Members[0] = "1. Spider Man";
        Members[1] = "2. Iron Man";
        Members[2] = "3. The Incredible Hulk";
        Members[3] = "4. Captain America";
        Members[4] = "5. Thor";
        Members[5] = "6. Black Panther";
        Members[6] = "7. Doctor Strange";
        Members[7] = "8. Ant Man";
        Members[8] = "9. Wolverine";
        Members[9] = "10. Thanos";

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(Members[i]);
        }

        Console.WriteLine();

        Members.ClubType = "Avengers";
        Members.ClubLocation = "Stark Tower";
        Members.MeetingDate = "June 30th, 2018";

        
        Console.WriteLine($"Club Type: {Members.ClubType}");
        Console.WriteLine($"Club Location: {Members.ClubLocation}");
        Console.WriteLine($"Meeting Date: {Members.MeetingDate}");

    }
}
