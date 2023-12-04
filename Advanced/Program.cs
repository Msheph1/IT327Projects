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
    private SongNode DummyTail;
    

}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your music playlist!\nThe current playlist is " + "playlist.toString()" +"\n\nWhat do you want to do\n1 - Add a song\n2 - Play next\n3 - Remove a song\n4 - Exit");
    }
}
