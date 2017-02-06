using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Europ_off
{
    public struct Coordinate
    {
        private uint _x;
        private uint _y;

        public uint x
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public uint y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
    }

    public struct DevelopmentStatistics
    {
        uint _tax;
        uint _manpower;
        uint _production;
    }
}
