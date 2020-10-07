using System;

namespace Geometria
{
    public class Rettangolo
    {
        private int x, y, width, height;

        public Rettangolo(int x, int y,int width,int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public int CalcolaArea()
        {
            return width * height;
        }

        public int CalcolaPerimetro()
        {
            return (width + height) * 2;
        }

        public bool Contiene(Rettangolo r)
        {
            if (x <= r.x && y <= r.y && x + width >= r.x + r.width && y + height >= r.y + r.height)
                return true;
            return false;
        }
    }
}
