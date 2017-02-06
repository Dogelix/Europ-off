using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Europ_off
{ 

    class Province
    {
        List<Coordinate> _coordinates;
        uint _id = 1;

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

        public List<Coordinate> GetCoordinates( )
        {
            return _coordinates;
        }
    }
}
