using System;
using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;

namespace cse210_batter_csharp.Scripting
{
    public class HandleOffScreenAction : Action
    {
        public HandleOffScreenAction()
        {
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            List<Actor> balls = cast["balls"];

            foreach (Actor ball in balls)
            {
                int ballx = ball.GetX();

                int bally = ball.GetY();
                // Console.WriteLine($"{ball.GetX()}, {ball.GetY()}");
                //if ball position is off the screen, change its velocity.
                if(ballx > 780)
                {
                    Console.WriteLine("true");
                    ball.ChangeVelocityX();
                }
                if (ballx < 2)
                {
                    Console.WriteLine("True");
                    ball.ChangeVelocityY();
                }
                if(bally > 580)
                {
                    Console.WriteLine("True");
                    ball.ChangeVelocityNegX();
                }
                if(bally < 10)
                {
                    ball.ChangeVelocityNegY();
                }
                
            }
        }
    }
}