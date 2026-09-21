using LearnOpenTK;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using System;
using System.Diagnostics;


internal class Program
{

    static void Main(string[] args)
    {

        var nativeWindowSettings = new NativeWindowSettings()
        {
            ClientSize = new Vector2i(800, 600),
            Title = "LearnOpenTK - Element Buffer Objects",
            // This is needed to run on macos
            Flags = ContextFlags.ForwardCompatible,

        };

        using (Window game = new Window(GameWindowSettings.Default, nativeWindowSettings))
        {
            game.Run();
        }
    }
}