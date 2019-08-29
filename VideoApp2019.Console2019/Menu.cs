using System;
using VideoApp2019.Core;

namespace VideoApp2019.Console2019
{
    public class Menu
    {
        public void Run()
        {
            var vm = new VideoManager();
            int menuSelection = 0;
            int exit = 6;
            while (menuSelection != 6)
            {
                menuMain();
                while (!int.TryParse(Console.ReadLine(), out menuSelection) || menuSelection <= 0 || menuSelection > exit)
                {
                    Console.WriteLine("\nPlease enter a number from 1-5 to select a menu item");
                }

                switch (menuSelection)
                {
                    case 1:
                        //List All Videos Function
                        Console.Clear();
                        Console.WriteLine("List of all Videos: \n");
                        foreach (var video in vm.vdb.VideoList)
                        {
                            Console.WriteLine(video.ToString());
                        }
                        Console.WriteLine("\nPress enter to return to the main menu.");
                        Console.ReadLine();
                        break;
                    case 2:
                        //Create Video Function
                        Console.Clear();
                        Console.WriteLine("Create new Video: ");
                        string vidName;
                        string vidGenre;
                        Console.WriteLine("Please enter the name/title of the video: ");
                        vidName = Console.ReadLine();

                        while (vidName.Length < 2)
                        {
                            Console.WriteLine("The video name have to contain at least 2 characters");
                            vidName = Console.ReadLine();
                        }

                        Console.WriteLine("Please enter the main genre of the video: ");
                        vidGenre = Console.ReadLine();

                        while (vidGenre.Length < 2)
                        {
                            Console.WriteLine("The video genre have to contain at least 2 characters");
                            vidGenre = Console.ReadLine();
                        }

                        vm.CreateVideo(vidName, vidGenre);

                        Console.WriteLine("\nPress enter to return to the main menu.");
                        Console.ReadLine();
                        break;
                    case 3:
                        //Read Video By Id Function
                        Console.WriteLine("Enter an ID to find a video");
                        int vidID;
                        while (!int.TryParse(Console.ReadLine(), out vidID) || vm.IdVerifier(vidID) == false)
                        {
                            Console.WriteLine("Please enter a valid id: ");
                        }

                        Console.WriteLine(vm.getVideoById(vidID).ToString());


                        Console.WriteLine("\nPress enter to return to the main menu.");
                        Console.ReadLine();
                        break;
                    case 4:
                        //Update Video Function
                        Console.Clear();
                        Console.WriteLine("Video update");

                        foreach (var video in vm.vdb.VideoList)
                        {
                            Console.WriteLine(video.ToString());
                        }

                        Console.WriteLine("\n\nEnter the ID of the video you wish to update:");
                        int selected;
                        string name;
                        string genre;
                        while (!int.TryParse(Console.ReadLine(), out selected) && vm.IdVerifier(selected) == false)
                        {
                            Console.WriteLine("Please enter an existing ID");
                        }

                        Console.WriteLine("Please enter a new name/title for the video(left blank = no change)");
                        name = Console.ReadLine();

                        Console.WriteLine("Please enter the new genre for the selected video(left blank = no change)");
                        genre = Console.ReadLine();

                        vm.UpdateVideo(selected, name, genre);

                        Console.WriteLine("\nPress enter to return to the main menu.");
                        Console.ReadLine();
                        break;
                    case 5:
                        //Remove Video Function
                        Console.Clear();
                        Console.WriteLine("Please enter the ID of the video you wish to remove");

                        int removeID;
                        while (!int.TryParse(Console.ReadLine(), out removeID) || !vm.IdVerifier(removeID))
                        {
                            Console.WriteLine("Please enter a valid ID");
                        }

                        vm.RemoveVideo(removeID);
                        Console.WriteLine("The video with an ID of " + removeID + " has been removed.");

                        Console.WriteLine("\nPress enter to return to the main menu.");
                        Console.ReadLine();
                        break;
                }
            }

            if (menuSelection == exit)
            {
                Console.WriteLine("Bye.");
            }

        }

        public void menuMain()
        {
            Console.Clear();
            Console.WriteLine("   Video Menu");
            Console.WriteLine("1: List all videos");
            Console.WriteLine("2: Create a new video");
            Console.WriteLine("3: Read from ID");
            Console.WriteLine("4: Update video");
            Console.WriteLine("5: Delete a video");
            Console.WriteLine("6: Exit");
        }

    }
}