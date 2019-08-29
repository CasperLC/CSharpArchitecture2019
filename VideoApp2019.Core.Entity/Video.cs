namespace VideoApp2019.Core.Entity
{
    public class Video
    {
        public Video()
        {

        }

        public int id { get; set; }
        public string name { get; set; }
        public string genre { get; set; }


        public override string ToString()
        {
            return "ID: " + this.id + " Title: " + this.name + " genre: " + this.genre;
        }
    }
}