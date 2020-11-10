namespace FoundrySceneResize.SceneModels
{
    public class Note
    {
        public string _id { get; set; }
        public Flags6 flags { get; set; }
        public string entryId { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string icon { get; set; }
        public int iconSize { get; set; }
        public string iconTint { get; set; }
        public string text { get; set; }
        public string fontFamily { get; set; }
        public int fontSize { get; set; }
        public int textAnchor { get; set; }
        public string textColor { get; set; }
    }
}