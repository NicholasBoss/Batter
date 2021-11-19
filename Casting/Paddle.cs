using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;

namespace cse210_batter_csharp.Casting
{
    public class Paddle : Actor
    {
        private string _image = Constants.IMAGE_PADDLE;
        private int _height = Constants.PADDLE_HEIGHT;
        private int _width = Constants.PADDLE_WIDTH;
        private int _PaddleX = Constants.PADDLE_X;
        private int _PaddleY = Constants.PADDLE_Y;


        public Paddle()
        {
            SetHeight(_height);
            SetWidth(_width);
            SetImage(_image);
            SetPosition(new Point(_PaddleX,_PaddleY));
        }
    }
}