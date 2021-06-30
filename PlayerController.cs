using SFML.Graphics;
using SFML.System;
using System;

namespace Snake
{
    public class PlayerController
    {
        private float speed = 1.75f;
        
        void MoveHeadUp(CircleShape head)
        {
            head.Position += new Vector2f(0, -speed);
        }
        
        void MoveHeadDown(CircleShape head)
        {
            head.Position += new Vector2f(0, speed);
        }
        
        void MoveHeadRight(CircleShape head)
        {
            head.Position += new Vector2f(speed, 0);
        }
        
        void MoveHeadLeft(CircleShape head)
        {
            head.Position += new Vector2f(-speed, 0);
        }

        void MoveHead(CircleShape head, int curDirection)
        {
            if (curDirection == 1)
            {
                MoveHeadUp(head);
            }
            
            else if (curDirection == 2)
            {
                MoveHeadDown(head);
            }
            
            else if (curDirection == 3)
            {
                MoveHeadRight(head);
            }
            
            else if (curDirection == 4)
            {
                MoveHeadLeft(head);
            }
        }

        void MoveBody(CircleShape[] body, CircleShape head)
        {
            Vector2f nextNewPos = head.Position;
            
            for (int i = 0; i < body.Length; i++)
            {
                Vector2f curNewPos = nextNewPos;
                nextNewPos = body[i].Position;
                body[i].Position = curNewPos;
            }
        }

        public void Move(CircleShape[] body, CircleShape head, int curDirection)
        {
            MoveBody(body, head);
            MoveHead(head, curDirection);
        }
    }
}