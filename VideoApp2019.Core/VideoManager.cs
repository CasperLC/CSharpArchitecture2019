using System;
using VideoApp2019.Core.Entity;

namespace VideoApp2019.Core
{
    public class VideoManager
    {
        public VideoDB vdb;
        public VideoManager()
        {
            this.vdb = new VideoDB();
        }

        public bool IdVerifier(int idcheck)
        {
            foreach (var video in vdb.VideoList)
            {
                if (video.id == idcheck)
                {
                    return true;
                }
            }

            return false;
        }

        public Video getVideoById(int id)
        {
            foreach (var video in vdb.VideoList)
            {
                if (video.id == id)
                {
                    return video;
                }
            }

            return null;
        }
        public void RemoveVideo(int ID)
        {
            vdb.RemoveVideo(ID);
        }
        public void UpdateVideo(int selectedID, string name, string genre)
        {
            string newName = "";
            string newGenre = "";
            foreach (var video in vdb.VideoList)
            {
                if (video.id == selectedID)
                {
                    if (!string.IsNullOrEmpty(name))
                    {
                        newName = name;
                    }
                    else
                    {
                        newName = video.name;
                    }

                    if (!string.IsNullOrEmpty(genre))
                    {
                        newGenre = genre;
                    }
                    else
                    {
                        newGenre = video.genre;
                    }

                    break;
                }
            }
            vdb.UpdateVideo(selectedID, newName, newGenre);
        }

        public void CreateVideo(string vidName, string vidGenre)
        {
            if (vidName.Length > 2 && vidGenre.Length > 2)
            {
                vdb.CreateVideo(vidName, vidGenre);
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}