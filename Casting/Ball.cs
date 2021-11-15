namespace cse210_batter_csharp.Casting
{
    public class Ball : Actor
    {
        private string _image = Constants.IMAGE_BALL;
        private int _height = Constants.BALL_HEIGHT;
        private int _width = Constants.BALL_WIDTH;
        private int _ballDX = Constants.BALL_DX;
        private int _ballDY = Constants.BALL_DY;
        public Ball()
        {
            SetHeight(_height);
            SetWidth(_width);
            SetImage(_image);
            SetVelocity(new Point(_ballDX,_ballDY));
        }

        
    }
}