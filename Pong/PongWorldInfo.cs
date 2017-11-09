using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    // "static" means you can not instantiate this class as an object,
    // this class is just meant to store global data.
    public static class PongWorldInfo
    {
        // Forum size = 1080 X 645
        // bottomOfWorld had to be decreased by 40 pixels to take into account the
        // text box at the top of the screen.
        public const int movementSpeed = 5, topOfWorld = 0, bottomOfWorld = 605, leftOfWorld = 0, rightOfWorld = 1080;
    }
}
