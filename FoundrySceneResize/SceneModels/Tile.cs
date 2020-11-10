namespace FoundrySceneResize.SceneModels
{
    public class Tile
    {
        public string _id { get; set; }
        public string img { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int scale { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public int rotation { get; set; }
        public bool hidden { get; set; }
        public bool locked { get; set; }
    }
}