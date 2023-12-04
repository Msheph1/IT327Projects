// Advanced program that implements a music playlist using a linkedlist
//By Max Shepherd

using System;
public class Song{
    private string SongName {get; set;}
    private string SongAuthor {get; set;}
    public Person(string songName, songAuthor)
    {
        SongName = songName;
        SongAuthor = songAuthor;
    }

}

public class SongNode{
    public Song SongData;
    public SongNodeNext;
    public SongNode(Song song = null)
    {
        SongData = song;
        Next = null;
    }

}

public class Playlist{
    private List<Song> Songs {get; set;}
    private SongNode DummyHead;
    private SongNode Tail;
    public Playlist()
    {
        Songs = new List<>();
        Head = new SongNode();
        Tail = new SongNode();
        Head.Next = Tail
    }

    public void AddSong(Song song){
        SongNode temp = new SongNode(song);
        if(Tail.SongData == null)
        {
            Tail = temp;
        }
        else{
            Tail.Next = temp;
            Tail = temp;
        }
        
    }

    public void PlayNext(Song song)
    {
        SongNode temp = DummyHead.Next;
        DummyHead.Next = new SongNode(song);
        DummyHead.Next.Next = temp;
    }

    public void RemoveSong(string name, string author)
    {
        SongNode iter = DummyHead;
        SongNode lastIter = null;
        while(iter.Next != null)
        {
            if(iter.Next.SongData.SongName.get().equals(name) && iter.Next.SongData.SongAuthor.get().equals(autho))
            {
                iter.Next = iter.Next.Next;
            }
            if(iter.Next == null)
            {
                lastIter = iter;
            }
            iter = iter.next;
        }
        if(lastIter != null)
        {
            lastIter.Next = null;
        }
    }

    public override string ToString()
    {
        return "";
    }

}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your music playlist!\nThe current playlist is " + "playlist.toString()" +"\n\nWhat do you want to do\n1 - Add a song\n2 - Play next\n3 - Remove a song\n4 - Exit");
    }
}
