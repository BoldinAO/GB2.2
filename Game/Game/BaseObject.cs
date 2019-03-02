using System.Drawing;

namespace MyGame
{
    abstract class BaseObject : ICollision
    {
        protected Point Pos;
        protected Point Dir;
        protected Size Size;

        protected BaseObject(Point pos, Point dir, Size size)
        {
            if (size.Height > 10 && this is Asteroid) throw new GameException("Высота астероида должна быть < 10");
            Pos = pos;
            Dir = dir;
            Size = size;
        }

        public abstract void Draw();
        public abstract void Update();

        public Rectangle Rect => new Rectangle(Pos, Size);

        public bool Collision(ICollision o) => o.Rect.IntersectsWith(this.Rect);

        public void Repaint() => Pos.X = this is Asteroid ? Game.Width : 0;
    }
}
