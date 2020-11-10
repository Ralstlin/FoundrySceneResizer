using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CommandLine;
using FoundrySceneResize.SceneModels;
using Newtonsoft.Json;

namespace FoundrySceneResize
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(Run);
        }

        static void Run(Options options)
        {
            var scenes = new List<Scene>();

            using (var sr = new StreamReader(options.FilePath ?? "scenes.db"))
                while (sr.Peek() >= 0)
                    scenes.Add(JsonConvert.DeserializeObject<Scene>(sr.ReadLine()));
            

            var selectedScene = scenes.SingleOrDefault(t => t.name.Equals(options.SceneName, StringComparison.OrdinalIgnoreCase));

            if (selectedScene is null)
            {
                Console.WriteLine("Scene not found!");
                return;
            }


            if (!options.Scale.HasValue && (!options.Width.HasValue || !options.Height.HasValue))
            {
                Console.WriteLine("Need to provide scale, or width and height");
                return;
            }

            if (!options.Scale.HasValue)
            {
                var modWidth = (decimal) options.Width / selectedScene.width;
                var modHeight = (decimal) options.Height / selectedScene.height;

                if (modWidth != modHeight)
                {
                    Console.WriteLine("Need to keep Aspect Ratio! try use -scale instead");
                    return;
                }

                options.Scale = modWidth;
            }

            foreach (var sceneWall in selectedScene.walls)
            {
                var x1 = Convert.ToInt32(sceneWall.c.First() * options.Scale);
                var y1 = Convert.ToInt32(sceneWall.c.Skip(1).First() * options.Scale);
                var x2 = Convert.ToInt32(sceneWall.c.Skip(2).First() * options.Scale);
                var y2 = Convert.ToInt32(sceneWall.c.Skip(3).First() * options.Scale);

                sceneWall.c = new[] {x1, y1, x2, y2};
            }

            foreach (var token in selectedScene.tokens)
            {
                token.x = token.x * (float) options.Scale;
                token.y = token.y * (float) options.Scale;
            }

            foreach (var light in selectedScene.lights)
            {
                light.x = Convert.ToInt32(light.x * options.Scale);
                light.y = Convert.ToInt32(light.y * options.Scale);
            }

            foreach (var drawing in selectedScene.drawings)
            {
                drawing.x = Convert.ToInt32(drawing.x * options.Scale);
                drawing.y = Convert.ToInt32(drawing.y * options.Scale);
            }

            foreach (var note in selectedScene.notes)
            {
                note.x = Convert.ToInt32(note.x * options.Scale);
                note.y = Convert.ToInt32(note.y * options.Scale);
            }

            foreach (var sound in selectedScene.sounds)
            {
                sound.x = Convert.ToInt32(sound.x * options.Scale);
                sound.y = Convert.ToInt32(sound.y * options.Scale);
            }

            foreach (var template in selectedScene.templates)
            {
                template.x = Convert.ToInt32(template.x * options.Scale);
                template.y = Convert.ToInt32(template.y * options.Scale);
            }

            foreach (var tile in selectedScene.tiles)
            {
                tile.x = Convert.ToInt32(tile.x * options.Scale);
                tile.y = Convert.ToInt32(tile.y * options.Scale);
            }

            selectedScene.width = Convert.ToInt32(selectedScene.width * options.Scale);
            selectedScene.height = Convert.ToInt32(selectedScene.height * options.Scale);
            selectedScene.grid = Convert.ToInt32(selectedScene.grid * options.Scale);

            File.Copy(options.FilePath ?? "scenes.db", $"scenes.bkp{DateTime.UtcNow:yyyyMMddTHHmmss}.db");

            using (var sw = new StreamWriter(options.FilePath ?? "scenes.db"))
                foreach (var scene in scenes)   
                    sw.WriteLine(JsonConvert.SerializeObject(scene));
            
        }
    }
}