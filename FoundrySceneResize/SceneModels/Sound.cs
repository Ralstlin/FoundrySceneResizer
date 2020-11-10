namespace FoundrySceneResize.SceneModels
{
    public class Sound
    {
        public string _id { get; set; }
        public Flags4 flags { get; set; }
        public string path { get; set; }
        public bool repeat { get; set; }
        public int volume { get; set; }
        public string type { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int radius { get; set; }
        public bool easing { get; set; }
    }
}