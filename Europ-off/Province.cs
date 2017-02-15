using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Europ_off
{ 

    class Province
    {
        List<Coordinate> _coordinates;
        uint _id;
        string _name = "N/A";
        Color _color = Color.Purple;
        

        //Development Statistics
        uint _tax = 1;
        uint _production = 1;
        uint _manpower = 1;

        public Province( List<Coordinate> coords, uint id )
        {
            _coordinates = coords;
            _id = id;
        }

        public Province( List<Coordinate> coords, uint id, uint tax, uint production, uint manpower )
        {
            _coordinates = coords;
            _id = id;
            _tax = tax;
            _production = production;
            _manpower = manpower;
        }

        public List<Coordinate> GetCoordinates
        {
            get
            {
                return _coordinates;
            }
        }

        public uint ID
        {
            get
            {
                return _id;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public uint Tax
        {
            get
            {
                return _tax;
            }
            set
            {
                _tax = value;
            }
        }

        public uint Production
        {
            get
            {
                return _production;
            }
            set
            {
                _production = value;
            }
        }

        public uint Manpower
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

        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
    }
}
