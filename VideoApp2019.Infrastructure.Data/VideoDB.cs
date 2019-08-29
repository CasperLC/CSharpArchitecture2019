using System.Collections.Generic;
using VideoApp2019.Core.Entity;

namespace VideoApp2019.Infrastructure.Data
{
    public class VideoDB
    {
        public List<Video> VideoList { get; set; }
        public int availableID { get; set; }

        public VideoDB()
        {
            VideoList = new List<Video>();
            VideoList = initializeVList();
            availableID = VideoList.Count + 1;

        }

        public void CreateVideo(string name, string genre)
        {
            var tempVideo = new Video()
            {
                id = availableID,
                name = name,
                genre = genre
            };
            availableID++;

            VideoList.Add(tempVideo);
        }

        public void UpdateVideo(int ID, string newName, string newGenre)
        {
            foreach (var video in VideoList)
            {
                if (video.id == ID)
                {
                    video.name = newName;
                    video.genre = newGenre;
                }
            }
        }

        public void RemoveVideo(int ID)
        {
            bool vidFound = false;
            int index = -1;
            foreach (var video in VideoList)
            {
                if (video.id == ID)
                {
                    index = VideoList.IndexOf(video);
                    vidFound = true;
                    break;
                }
            }

            if (vidFound)
            {
                VideoList.RemoveAt(index);
            }
        }


        public List<Video> initializeVList()
        {
            List<Video> temp = new List<Video>();
            var Video1 = new Video
            {
                id = 1,
                name = "Title of Video 1",
                genre = "Action"
            };
            var Video2 = new Video
            {
                id = 2,
                name = "Title of Video 2",
                genre = "Horror"
            };
            var Video3 = new Video
            {
                id = 3,
                name = "Title of Video 3",
                genre = "Action"
            };
            var Video4 = new Video
            {
                id = 4,
                name = "Title of Video 4",
                genre = "Horror"
            };
            var Video5 = new Video
            {
                id = 5,
                name = "Title of Video 5",
                genre = "Action"
            };
            var Video6 = new Video
            {
                id = 6,
                name = "Title of Video 6",
                genre = "Horror"
            };

            temp.Add(Video1);
            temp.Add(Video2);
            temp.Add(Video3);
            temp.Add(Video4);
            temp.Add(Video5);
            temp.Add(Video6);

            return temp;
        }
    }
}