using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Europ_off
{
    class FileReader
    { 
        StreamReader _save;
        List<Province> _proviences;

        public FileReader(String save)
        {
            _save = new StreamReader(save);
            List<Province> _proviences = ReadProvinceCodes();
            _save.Close();
        }

        public List<Province> Proviences
        {
            get
            {
                return _proviences;
            }
        }

        private List<Province> ReadProvinceCodes( )
        {
            List<Province> _list = new List<Province>();
            uint numberOfProviences = uint.Parse(_save.ReadLine());
            for (int i = 0; i < numberOfProviences; i++)
            {
                _list.Add(getProvience());
            }
            return _list;
        }

        private Province getProvience()
        {
            uint _id = 0;
            uint _tax = 0;
            uint _manpower = 0;
            uint _production = 0;
            List<Coordinate> _coordinates = new List<Coordinate>();

            _id = uint.Parse(_save.ReadLine().Remove(0, 4));
            _tax = uint.Parse(_save.ReadLine().Remove(0, 5));
            _manpower = uint.Parse(_save.ReadLine().Remove(0, 5));
            _production = uint.Parse(_save.ReadLine().Remove(0, 5));
            _coordinates = ParseCoordinates((_save.ReadLine().Remove(0, 5)));

            Province _provience = new Province(_coordinates,_id, _tax, _production, _manpower);
            return _provience;
        }
        private List<Coordinate> ParseCoordinates(string t )
        {
            List<Coordinate> x = new List<Coordinate>();

            //Splits the input line and parses each cooridnate
            string[] coordinates = t.Split( '-' );
            foreach(string coordinate in coordinates)
            {
                x.Add(ParseCoordinate(coordinate));
            }

            return x;
        }

        private Coordinate ParseCoordinate(string line)
        {
            Coordinate c = new Coordinate( );
            string[] parameters = line.Substring(1, line.Length - 2).Split(',');

            c.x = uint.Parse( parameters[0]);
            c.y = uint.Parse( parameters[1]);
            return c;
        }
    }
}
