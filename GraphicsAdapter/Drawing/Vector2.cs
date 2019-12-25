using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAdapter.Drawing
{
    public struct Vector2
    {
        public static Vector2 zero = new Vector2(0, 0);
        public static Vector2 one = new Vector2(1, 1);
        public static Vector2 left = new Vector2(-1, 0);
        public static Vector2 up = new Vector2(0, 1);
        public static Vector2 right = new Vector2(1, 0);
        public static Vector2 down = new Vector2(0, -1);

        public float x;
        public float y;
        public Vector2 normalized
        {
            get
            {
                float max = Math.Max(x, y);
                return new Vector2(x / max, y / max);
            }
        }

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x + b.x, a.y + b.y);
        }

        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x - b.x, a.y - b.y);
        }

        public static Vector2 operator /(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x / b.x, a.y / b.y);
        }

        public static Vector2 operator /(Vector2 a, float b)
        {
            return new Vector2(a.x / b, a.y / b);
        }

        public override string ToString()
        {
            string s = x + ";" + y;
            return s;
        }
    }
}
