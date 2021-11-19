using System;
using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;

namespace cse210_batter_csharp.Scripting
{
    public class HandleOffScreenAction : Action
    {
        AudioService _audioService;
        Director _director;
        public HandleOffScreenAction(AudioService audioService)
        {
            _audioService = audioService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            List<Actor> balls = cast["balls"];

            //if ball position is off the screen, change its velocity.
            foreach (Actor ball in balls)
            {
                int ballx = ball.GetX();

                int bally = ball.GetY();
                
                if(ball.GetRightEdge() >= Constants.MAX_X || ball.GetLeftEdge() <= 0)
                {
                    _audioService.PlaySound(Constants.SOUND_BOUNCE);
                    ball.ChangeVelocityX();
                }
                if(ball.GetTopEdge() <= 0)
                {
                    _audioService.PlaySound(Constants.SOUND_BOUNCE);
                    ball.ChangeVelocityY();
                }
                if(ball.GetBottomEdge() >= Constants.MAX_Y)
                {
                    _audioService.PlaySound(Constants.SOUND_OVER);
                    Raylib_cs.Raylib.CloseWindow();
                }
                
                
            }
        }
    }
}