// See https://aka.ms/new-console-template for more information

using modul5_1302204035;

Console.WriteLine("Hello, World!");
SayaTubeVideo vid1 = new SayaTubeVideo("Scum wish", 0);
SayaTubeVideo vid2 = new SayaTubeVideo("I will eat your pancreas", 0);
SayaTubeVideo vid3 = new SayaTubeVideo("Date my daugther", 0);
SayaTubeVideo vid4 = new SayaTubeVideo("Your Name", 0);
SayaTubeVideo vid5 = new SayaTubeVideo("Memory of Alhambra", 0);
SayaTubeVideo vid6 = new SayaTubeVideo("Strangers From Hell", 0);
SayaTubeVideo vid7 = new SayaTubeVideo("The Last Song", 0);
SayaTubeVideo vid8 = new SayaTubeVideo("The Maze Runner Series", 0);
SayaTubeVideo vid9 = new SayaTubeVideo("Us", 0);
SayaTubeVideo vid10 = new SayaTubeVideo("Alice in Wonderland", 0);

SayaTubeUser user = new SayaTubeUser("Muhammad Real Andri Faqih", new List<SayaTubeVideo> {});
user.addVideo(vid1);
user.addVideo(vid2);
user.addVideo(vid3);
user.addVideo(vid4);
user.addVideo(vid5);
user.addVideo(vid6);
user.addVideo(vid7);
user.addVideo(vid8);
user.addVideo(vid9);
user.addVideo(vid10);

Console.WriteLine("Review film : ");
user.printAllVideoPlayCount();