using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach
{
    public struct coordinate {
        public int x;
        public int y;
        public coordinate(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
    public class room
    {
        public void Resize(coordinate leftbottom,coordinate topright)
        {
            coord[0] = leftbottom;
            coord[1] = topright;

        }
        public  void serealize()
        {
        }
        public void deserealize()
        {

        }
        public coordinate[] coord = new coordinate[2];
        

        
    }
    public class roombilder
    {

    }
}
