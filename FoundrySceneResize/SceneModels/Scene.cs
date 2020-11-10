namespace FoundrySceneResize.SceneModels
{
    public class Scene
    {
        public string _id { get; set; }
        public string name { get; set; }
        public Permission permission { get; set; }
        public int sort { get; set; }
        public Flags flags { get; set; }
        public string description { get; set; }
        public bool navigation { get; set; }
        public int navOrder { get; set; }
        public string navName { get; set; }
        public bool active { get; set; }
        public object initial { get; set; }
        public string img { get; set; }
        public string thumb { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public float padding { get; set; }
        public string backgroundColor { get; set; }
        public Tile[] tiles { get; set; }
        public int gridType { get; set; }
        public int grid { get; set; }
        public int shiftX { get; set; }
        public int shiftY { get; set; }
        public string gridColor { get; set; }
        public float gridAlpha { get; set; }
        public int gridDistance { get; set; }
        public string gridUnits { get; set; }
        public Token[] tokens { get; set; }
        public Wall[] walls { get; set; }
        public bool tokenVision { get; set; }
        public bool fogExploration { get; set; }
        public Light[] lights { get; set; }
        public bool globalLight { get; set; }
        public object globalLightThreshold { get; set; }
        public int darkness { get; set; }
        public string playlist { get; set; }
        public Sound[] sounds { get; set; }
        public Template[] templates { get; set; }
        public string journal { get; set; }
        public Note[] notes { get; set; }
        public string weather { get; set; }
        public Drawing[] drawings { get; set; }
    }
}
