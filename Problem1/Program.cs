namespace Problem1
{
    internal class Program
    {
        static void Main()
        {
            List<Song> songList = new List<Song>();
            int numberOfSongs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] inputParams = Console.ReadLine().Split("_");
                string songTypeList = inputParams[0];
                string songName = inputParams[1];
                string songTime = inputParams[2];

                Song currentSong = new Song();
                currentSong.TypeList = songTypeList;
                currentSong.Name = songName;
                currentSong.Time = songTime;

                songList.Add(currentSong);
            }

            string currentTypeList = Console.ReadLine();

            if (currentTypeList == "all")
            {
                foreach (Song song in songList)
                {
                    Console.WriteLine(song.Name);
                }
            }
           else
            {
                List<Song> filteredSongs = songList.Where(s => s.TypeList == currentTypeList).ToList();
            }
            
        }
    }
}

class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}