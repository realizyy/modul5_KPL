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
        this.title = title;
        this.playCount = playCount;
    }
    
    //increasePlayCount
    public void increasePlayCount(int count)
    {
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