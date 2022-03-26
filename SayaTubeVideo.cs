using System.Diagnostics;

namespace modul5_1302204035;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;
    
    //constructor
    public SayaTubeVideo(string title, int playCount)
    {
        //generate id random 5 digit
        this.id = new System.Random().Next(99999);
        try
        {
            if (title.Length > 200 || title.Length == 0)
            {
                throw new System.ArgumentException("Judul video tidak boleh lebih dari 200 karakter dan tidak NULL");
            }

            if (playCount < 0 || playCount > 25000000)
            {
                throw new System.ArgumentException("PlayCount tidak boleh NULL dan tidak lebih dari 25.000.000");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        this.title = title;
        this.playCount = playCount;
    }
    
    //increasePlayCount
    public void increasePlayCount(int count)
    {
        Debug.Assert(count > nint.MaxValue, "Video tidak boleh lebih dari maximal int value");
        this.playCount += count;
    }
    
    //printVideoDetails
    public void printVideoDetails()
    {
        Console.WriteLine("ID: {0}", this.id);
        Console.WriteLine("Title: {0}", this.title);
        Console.WriteLine("Play Count: {0}", this.playCount);
    }
    
    //getter
    public int getId()
    {
        return this.id;
    }
    
    public string getTitle()
    {
        return this.title;
    }
    
    public int getPlayCount()
    {
        return this.playCount;
    }
}