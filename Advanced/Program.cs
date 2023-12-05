// Advanced program that implements a music playlist using a linkedlist
//By Max Shepherd

using System;
public class Song{
    public string SongName {get; set;}
    public string SongAuthor {get; set;}
    public Song(string songName, string songAuthor)
    {
        SongName = songName;
        SongAuthor = songAuthor;
    }

    public override string ToString()
    {
        return SongName + " By " + SongAuthor;
    }

}

public class SongNode{
    public Song SongData;
    public SongNode Next;
    public SongNode Prev;
    public SongNode(Song song)
    {
        SongData = song;
        Next = null;
    }

}

public class Playlist{
    public List<Song> Songs {get; set;}
    private SongNode DummyHead;
    private SongNode DummyTail;
    public Playlist()
    {
        Songs = new List<Song>();
        Song NullSong = new Song("","");
        DummyHead = new SongNode(NullSong);
        DummyTail = new SongNode(NullSong);
        DummyHead.Next = DummyTail;
        DummyTail.Prev = DummyHead;
    }

    public void AddSong(Song song){
        SongNode Temp = new SongNode(song);
        if(Tail.SongData.SongName == null)
        {
            Tail = Temp;
            Console.WriteLine("done");
        }
        else{
            Tail.Next = Temp;
            Tail = Temp;
        }

        
    }

    public void PlayNext()
    {
        
        if(DummyHead.Next.Next != null)
        {
        DummyHead.Next = DummyHead.Next.Next;
        DummyHead = DummyHead.Next;
        }
        else{
            Tail = new SongNode(new Song("",""));
            DummyHead.Next = Tail;
        }
    }

    public void RemoveSong(string name, string author)
    {
        SongNode? Iter = DummyHead;
        SongNode? LastIter = null;
        while(Iter?.Next != null)
        {
             
            if(Iter.Next.SongData.SongName.Equals(name) && Iter.Next.SongData.SongAuthor.Equals(author))
            {
                Iter.Next = Iter.Next.Next;
            }
            if(Iter.Next == null)
            {
                LastIter = Iter;
            }
            Iter = Iter.Next;
        }
        if(LastIter != null)
        {
            LastIter.Next = null;
        }
    }


    public override string ToString()
    {
        string Ret = "\n";
        if(DummyHead.Next == Tail)
        {
            return "Empty!\n";
        }
        SongNode? Iter = DummyHead.Next;
        Ret += "Playing Now - ";
        while(Iter != null)
        {
            Ret += Iter.SongData.SongName + "By " + Iter.SongData.SongAuthor + "\n";
            Iter = Iter.Next;
        }
        return Ret + "\n\n";
    }

}

class Program
{
    static void Main(string[] args)
    {

        Playlist pl = new Playlist();
        List<Song> StartingSongs = new List<Song>();

        StartingSongs.Add(new Song("Cruel Summer","Taylor Swift"));
        StartingSongs.Add(new Song("Paint the Town Red", "Doja Cat"));
        StartingSongs.Add(new Song("All I Want For Christmas Is You","Mariah Carey"));
        StartingSongs.Add(new Song("Snooze","SZA"));
        StartingSongs.Add(new Song("I Remember Everything","Zack Bryan"));
        StartingSongs.Add(new Song("Greedy","Tate McRae"));
        StartingSongs.Add(new Song("Rockin' Around The Christmas Tree","Brenda Lee"));
        StartingSongs.Add(new Song("Is It Over Now?","Taylor Swift"));
        StartingSongs.Add(new Song("Water","Tyla"));
        pl.Songs = StartingSongs;
        pl.AddSong(new Song("You Broke My Heart", "Drake"));
        pl.AddSong(new Song("Jingle Bell Rock", "Bobby Helms"));
        pl.AddSong(new Song("Cruel Summer","Taylor Swift"));

        string? input = "-1";
        while(!input.Equals("4"))
        {
            Console.WriteLine("Welcome to your music playlist!\nThe current playlist is: " + pl.ToString() +"What do you want to do\n1 - Add a song\n2 - Play next\n3 - Remove a song\n4 - Exit");
            input = Console.ReadLine();
            if(input != null){
                
            //Add song
            if(input.Equals("1"))
            {   
                List<Song> SongList = pl.Songs;
                Console.WriteLine("The Song List contains: ");
                int Count = 1;
                foreach(Song Song in SongList)
                    {
                        Console.WriteLine(Count + "- " + Song.SongName + " By " + Song.SongAuthor);
                        Count++;
                    }
                Console.WriteLine(Count + "- Add none of these");
                int SongInput = -1;
                while(SongInput < 0 || SongInput > SongList.Count())
                {
                    string? UserIn = Console.ReadLine();
                    if(int.TryParse(UserIn, out SongInput))
                    {
                    
                    if(SongInput < 0 || SongInput > SongList.Count())
                        {
                            Song temp = SongList[SongInput -1];
                            Console.WriteLine(temp);
                            pl.AddSong(temp);
                        }
                        else if(SongInput == SongList.Count + 1)
                        {
                            SongInput = 1;
                            //break out
                        }
                        else{
                            Console.WriteLine("Invalid Input Please Try Again.");
                        }
                    }
                    else{
                        Console.WriteLine("Invalid Input Please Try Again.");
                    }
                }
                    
            }
            //Play Next
            else if(input.Equals("2"))
            {
                pl.PlayNext();
            }
            //Remove Song
            else if(input.Equals("3"))
            {
            
            }
            else if(input.Equals("4"))
            {
                ;
            }
            else{
                Console.WriteLine("Invalid Input Please Try Again");
            }
            }
            else{
                input = "-1";
            }
        }
    }
}
