using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Developer_Test_ThaiDucLoi
{
    public class Position
    {
        private float x;
        private float y;

        public Position(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
    }
}
