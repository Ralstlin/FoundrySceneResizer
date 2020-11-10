using CommandLine;

namespace FoundrySceneResize
{
    internal class Options
    {
        [Option('s', "scene", Required = true, HelpText = "Scene name to resize.")]
        public string SceneName { get; set; }

        [Option('w', "width", Required = false, HelpText = "New Width.")]
        public int? Width { get; set; }

        [Option('h', "height", Required = false, HelpText = "New Height.")]
        public int? Height { get; set; }

        [Option("scale", Required = false, HelpText = "Factor to scale the scene. 2 for double, 0.5 for half, etc")]
        public decimal? Scale { get; set; }

        [Option('f', "file", Required = false, HelpText = "Path to scenes.db (should include file name). If not provided will use the root path and scenes.db filename")]
        public string FilePath { get; set; }

        [Option('o', "output", Required = false, HelpText = "File name for the new scenes.db")]
        public string Output { get; set; }
    }
}