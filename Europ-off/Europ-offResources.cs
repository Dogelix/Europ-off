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

    public struct ArmyStats
    {        
        double _upkeep;
        uint _manpower;
        double _supply;
        double _firepower;
        double _defense;

        public double upkeep
        {
            get
            {
                return _upkeep;
            }
            set
            {
                _upkeep = value;
            }
        }

        public uint manpower
        {
            get
            {
                return _manpower;
            }
            set
            {
                _manpower = value;
            }
        }

        public double supply
        {
            get
            {
                return _supply;
            }
            set
            {
                _supply = value;
            }
        }

        public double firepower
        {
            get
            {
                return _firepower;
            }
            set
            {
                _firepower = value;
            }
        }

        public double defense
        {
            get
            {
                return _defense;
            }
            set
            {
                _defense = value;
            }
        }
    }
}
