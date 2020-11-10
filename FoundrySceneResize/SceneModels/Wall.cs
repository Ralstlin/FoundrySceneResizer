namespace FoundrySceneResize.SceneModels
{
    public class Wall
    {
        public string _id { get; set; }
        public Flags2 flags { get; set; }
        public int[] c { get; set; }
        public int move { get; set; }
        public int sense { get; set; }
        public int door { get; set; }
        public int ds { get; set; }
        public int dir { get; set; }
    }
}