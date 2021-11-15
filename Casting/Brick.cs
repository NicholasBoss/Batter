namespace cse210_batter_csharp.Casting
{
    public class Brick : Actor
    {
        private string _image = Constants.IMAGE_BRICK;
        private int _height = Constants.BRICK_HEIGHT;
        private int _width = Constants.BRICK_WIDTH;
        public Brick()
        {
            SetHeight(_height);
            SetWidth(_width);
            SetImage(_image);            
        }
    }
}