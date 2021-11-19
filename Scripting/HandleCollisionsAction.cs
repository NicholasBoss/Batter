using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;

namespace cse210_batter_csharp.Scripting
{
    public class HandleCollisionsAction : Action
    {
        PhysicsService _physicsService;
        AudioService _audioService;

        public HandleCollisionsAction(PhysicsService physicsService, AudioService audioService)
        {
            _physicsService = physicsService;
            _audioService = audioService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Actor ball = cast["balls"][0];

            List<Actor> paddles = cast["paddle"];
            List<Actor> bricks = cast["bricks"];

            List<Actor> bricksToRemove = new List<Actor>();

            foreach(Actor actor in paddles)
            {
                Paddle paddle = (Paddle)actor;
                if(_physicsService.IsCollision(ball,paddle))
                {
                    _audioService.PlaySound(Constants.SOUND_BOUNCE);
                    ball.ChangeVelocityY();
                }
            }

            foreach(Actor actor in bricks)
            {
                Brick brick = (Brick)actor;
                if(_physicsService.IsCollision(ball,brick))
                {
                    _audioService.PlaySound(Constants.SOUND_BOUNCE);
                    ball.ChangeVelocityY();

                    bricksToRemove.Add(brick);

                }
            }

            foreach(Actor brick in bricksToRemove)
            {
                cast["bricks"].Remove(brick);
            }
        }
    }
}