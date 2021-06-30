using SFML.Graphics;
using SFML.System;

namespace Snake
{
    public class Player
    {
        private int length = 50;

        public CircleShape[] snake;

        private int radius = 40;
        
        private RenderWindow window = Game.window;

        void CreateCircle(out CircleShape circle)
        {
            circle = new CircleShape();
            circle.FillColor = Color.Red;
            circle.OutlineColor = Color.Black;
            circle.OutlineThickness = 3;
            circle.Radius = radius;
        }

        public void CreateSnake()
        {
            snake = new CircleShape[length];
            
            for (int i = 0; i < length; i++)
            {
                CreateCircle(out snake[i]);
                snake[i].Position = new Vector2f(800, 450 - i * radius);
            }
        }

        public void DrawSnake()
        {
            snake[0].FillColor = Color.Magenta;

            for (int i = length - 1; i >= 0; i--)
            {
                window.Draw(snake[i]);
            }
        }
    }
}