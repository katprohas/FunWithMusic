using System;
namespace FunWithMusic
{
    class Program
    {
        enum MusicGenre
        {
            Pop,
            Indie,
            Emo,
            Folk,
            Rock,
            Country
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private double Length;
            private MusicGenre? MusicGenre;

            //parameterized constructor
            public Music(string title, string artist, string album, double length, MusicGenre musicgenre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                MusicGenre = musicgenre;
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setLength(double length)
            {
                Length = length;
            }
            //display method
            public string Display()
            {
                return "Song Title: " + Title + "\n Artist " + Artist +
                    "\n Album: " + Album + "\n Song Length: " + Length + "\n Music Genre: "  + MusicGenre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("What is the artist's name?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What album is the song from?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("What is the song length in minutes?");
            double tempLength = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the music genre?");
            Console.WriteLine("P - Pop\nI - Indie\nE - Emo\nF - Folk\nR - Rock\nC - Country");
            MusicGenre tempMusicGenre = MusicGenre.Pop;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'P':
                    tempMusicGenre = MusicGenre.Pop;
                    break;
                case 'I':
                    tempMusicGenre = MusicGenre.Indie;
                    break;
                case 'E':
                    tempMusicGenre = MusicGenre.Emo;
                    break;
                case 'F':
                    tempMusicGenre = MusicGenre.Folk;
                    break;
                case 'R':
                    tempMusicGenre = MusicGenre.Rock;
                    break;
                case 'C':
                    tempMusicGenre = MusicGenre.Country;
                    break;
            }
            //set structure variable and use parameterized constructor to set the values
            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempMusicGenre);
            Console.WriteLine($"Song 1:\n {music.Display()}\n");

            Music moreMusic = music;
            moreMusic.setTitle("Yellow Submarine");
            moreMusic.setLength(2.40);
            Console.WriteLine($"Song 2:\n {moreMusic.Display()}");
        }
    }
}