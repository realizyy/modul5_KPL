namespace modul5_1302204035;

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string Username;
    
    //constructor
    public SayaTubeUser(string username, List<SayaTubeVideo> uploadedVideos)
    {
        this.id = new System.Random().Next(99999);
        this.Username = username;
        this.uploadedVideos = uploadedVideos;
    }
    
    //getTotalVideoPlayCount
    public int getTotalVideoPlayCount()
    {
        int total = 0;
        foreach (SayaTubeVideo playCount in uploadedVideos)
        {
            total += playCount.getPlayCount();
        }
        return total;
    }
    
    //addVideo
    public void addVideo(SayaTubeVideo video)
    {
        uploadedVideos.Add(video);
    }
    
    //printAllVideoPlayCount
    public void printAllVideoPlayCount()
    {
        int i = 1;
        Console.WriteLine("User : " + Username);
        foreach (SayaTubeVideo playCount in uploadedVideos)
        {
            Console.WriteLine("Video " + i + " Judul : " + playCount.getTitle(), i++);
        }
    }

}