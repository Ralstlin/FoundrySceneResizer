namespace FoundrySceneResize.SceneModels
{
    public class Template
    {
        public string _id { get; set; }
        public Flags5 flags { get; set; }
        public string t { get; set; }
        public string user { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int direction { get; set; }
        public int distance { get; set; }
        public string borderColor { get; set; }
        public string fillColor { get; set; }
    }
}