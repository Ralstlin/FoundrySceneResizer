namespace FoundrySceneResize.SceneModels
{
    public class Drawing
    {
        public string _id { get; set; }
        public string type { get; set; }
        public string author { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int rotation { get; set; }
        public int z { get; set; }
        public bool hidden { get; set; }
        public bool locked { get; set; }
        public float[][] points { get; set; }
        public float bezierFactor { get; set; }
        public int fillType { get; set; }
        public string fillColor { get; set; }
        public int fillAlpha { get; set; }
        public int strokeWidth { get; set; }
        public string strokeColor { get; set; }
        public int strokeAlpha { get; set; }
        public string texture { get; set; }
        public string text { get; set; }
        public string fontFamily { get; set; }
        public int fontSize { get; set; }
        public string textColor { get; set; }
        public int textAlpha { get; set; }
    }
}