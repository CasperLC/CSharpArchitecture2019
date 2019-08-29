using System.Collections.Generic;
using System.Dynamic;
using VideoApp2019.Core.Entity;

namespace VideoApp2019.Core.DomainService
{
    public interface IVideoRepository
    {
        //Create a video from the given name and genre
        //and give the video an id
        Video Create(string name, string genre);
        Video ReadById(int id);
        List<Video> ListAllVideos();
        Video UpdateVideo(string name, string genre);
        Video RemoveVideo(int id);
    }
}