using Pixie;
using Silk.NET.Input;

namespace PixieExample
{
    internal class Game : Scene
    {
        public override void OnStart(in Renderer renderer)
        {
            // Camera centered to 64x64 coordinate
            renderer.CameraX = 64;
            renderer.CameraY = 64;
        }

        public override Scene? OnUpdate(in GameState state, in Renderer renderer, in Input input, float deltaTime)
        {
            if (input.KeyPressed(Key.Escape))
            {
                state.ShutDown();
            }
            
            // Return new scene object to switch between scenes
            return null;
        }

        public override void OnRender(in Renderer renderer, in Input input, float deltaTime)
        {
            renderer.ClearFrameBuffer();

            renderer.Text("Hello world!", 42, 64, PixieColor.White);
        }

        public override void OnDestroy()
        {

        }
    }
}
