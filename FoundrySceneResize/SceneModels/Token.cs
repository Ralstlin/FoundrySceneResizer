namespace FoundrySceneResize.SceneModels
{
    public class Token
    {
        public string _id { get; set; }
        public Flags1 flags { get; set; }
        public string name { get; set; }
        public int displayName { get; set; }
        public string img { get; set; }
        public string tint { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int scale { get; set; }
        public float x { get; set; }
        public float y { get; set; }
        public int elevation { get; set; }
        public bool lockRotation { get; set; }
        public int rotation { get; set; }
        public object[] effects { get; set; }
        public bool hidden { get; set; }
        public bool vision { get; set; }
        public int dimSight { get; set; }
        public int brightSight { get; set; }
        public int dimLight { get; set; }
        public int brightLight { get; set; }
        public int sightAngle { get; set; }
        public int lightAngle { get; set; }
        public int lightAlpha { get; set; }
        public Lightanimation lightAnimation { get; set; }
        public string actorId { get; set; }
        public bool actorLink { get; set; }
        public Actordata actorData { get; set; }
        public int disposition { get; set; }
        public int displayBars { get; set; }
        public Bar1 bar1 { get; set; }
        public Bar2 bar2 { get; set; }
        public bool mirrorX { get; set; }
        public bool mirrorY { get; set; }
        public string lightColor { get; set; }
    }
}