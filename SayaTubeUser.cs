using System.Diagnostics;

namespace modul5_1302204035;

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string Username;
    
    //constructor
    public SayaTubeUser(string username, List<SayaTubeVideo> uploadedVideos)
    {
        try
        {
            if (username.Length == 0 || username.Length > 100)
            {
                throw new Exception("Nama username tidak boleh lebih dari 100 karakter dan tidak berupa NULL");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
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
        Debug.Assert(video != null, "Video yang ditambahkan tidak boleh NULL");
        uploadedVideos.Add(video);
    }
    
    //printAllVideoPlayCount
    public void printAllVideoPlayCount()
    {
        int i = 1;
        //prekondisi print 8 video
        
        Console.WriteLine("User : " + Username);
        foreach (SayaTubeVideo playCount in uploadedVideos)
        {
            Console.WriteLine("Video " + i + " Judul : " + playCount.getTitle(), i++);
            if (i > 8)
            {
                break;
            }
        }
    }

}