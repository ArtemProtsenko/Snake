using SFML.Window;
using SFML.Graphics;
 
namespace Snake
{
    class Game
    {
        public static RenderWindow window = new RenderWindow(new VideoMode(1600, 900), "Game window");

        private int curDirection = 1;

        private CircleShape head;
        private CircleShape[] body;

        private Player player = new Player();
        private PlayerController controller = new PlayerController();
        public void GameLoop()
        {
            window.SetActive();
            player.CreateSnake();
            head = player.snake[0];
            
            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear(Color.Green);
                player.DrawSnake();
                CheckForClick();
                GetBody();
                controller.Move(body, head, curDirection);
                window.Display();
            }
        }

        void CheckForClick()
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.W))
            {
                curDirection = 1;
            }

            else if(Keyboard.IsKeyPressed(Keyboard.Key.S))
            {
                curDirection = 2;
            }
            
            else if (Keyboard.IsKeyPressed(Keyboard.Key.D))
            {
                curDirection = 3;
            }
            
            else if (Keyboard.IsKeyPressed(Keyboard.Key.A))
            {
                curDirection = 4;
            }
        }

        void GetBody()
        {
            body = new CircleShape[player.snake.Length - 1];
            for (int i = 0; i < body.Length; i++)
            {
                body[i] = player.snake[i + 1];
            }
        }
    }
}