namespace FoundrySceneResize.SceneModels
{
    public class Light
    {
        public string _id { get; set; }
        public Flags3 flags { get; set; }
        public string t { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public bool hidden { get; set; }
        public int rotation { get; set; }
        public float dim { get; set; }
        public float bright { get; set; }
        public int angle { get; set; }
        public int darknessThreshold { get; set; }
        public string tintColor { get; set; }
        public float tintAlpha { get; set; }
        public Lightanimation1 lightAnimation { get; set; }
    }
}