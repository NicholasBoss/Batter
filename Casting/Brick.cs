using System;
using System.Collections.Generic;
namespace cse210_batter_csharp.Casting
{
    public class Brick : Actor
    {
        private List<Point> _bricks = new List<Point>();
        private string image = Constants.IMAGE_BRICK;
        private int height = Constants.BRICK_HEIGHT;
        private int width = Constants.BRICK_WIDTH;
        public Brick()
        {
            Brick1();
            // CreateBrick();
            foreach (Point brick in _bricks)
            {
                Console.WriteLine($"{brick.GetX().ToString()},{brick.GetY().ToString()}");
            }
            
        }

        public void CreateBrick()
        {
            
            foreach(Point brick in _bricks)
            {
                
                _bricks.Add(brick);
            }
        }

        public void Brick1()
        {
            Random rnd = new Random();
            int x = 10;
            int y = 10;
            Point position = new Point(x,y);
            _bricks.Add(position);
            SetPosition(position);
            SetHeight(height);
            SetWidth(width);
            SetImage(image);
        }

        public void Brick2()
        {
            int x = 100;
            int y = 10;
            Point position = new Point(x,y);
            _bricks.Add(position);
            SetPosition(position);
            SetHeight(height);
            SetWidth(width);
            SetImage(image);
        }

        public void Brick3()
        {
            int x = 200;
            int y = 10;
            Point position = new Point(x,y);
            _bricks.Add(position);
            SetPosition(position);
            SetHeight(height);
            SetWidth(width);
            SetImage(image);
        }
    }
}