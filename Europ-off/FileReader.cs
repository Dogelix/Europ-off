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
        List<Province> provList = new List<Province>( );

        string line;
        List<Coordinate> _coord;
        uint _id;
        uint _tax;
        uint _man;
        uint _pro;

        public FileReader(String save)
        {
            _save = new StreamReader(save);
        }

        public List<Province> GetProvinceCodes( )
        {
            while ((line = _save.ReadLine( )) != null)
            {
                if (line.StartsWith( "ID:" ))
                {
                    line.Remove( 0, 4 );
                    _id = uint.Parse( line );
                }
                else if (line.StartsWith( "Sha:" ))
                {
                    line.Remove( 0, 5 );
                    _coord =  ParseCoordinates( line );
                }
                else if (line.StartsWith( "Tax:" ))
                {
                    line.Remove( 0, 5 );
                    _tax = uint.Parse( line );
                }
                else if (line.StartsWith( "Man:" ))
                {
                    line.Remove( 0, 5 );
                    _man = uint.Parse( line );
                }
                else if (line.StartsWith( "Pro:" ))
                {
                    line.Remove( 0, 5 );
                    _pro = uint.Parse( line );
                }
                else
                {
                    provList.Add( new Province( _coord, _id, _tax, _pro, _man ) );
                }
            }
            return provList;
        }

        private List<Coordinate> ParseCoordinates(string t )
        {
            List<Coordinate> x = new List<Coordinate>();

            //Splits the input line and parses each cooridnate
            string[] coordinates = t.Split( ',' );
            foreach(string coordinate in coordinates)
            {
                x.Add(ParseCoordinate(coordinate));
            }

            return x;
        }

        private Coordinate ParseCoordinate(string line)
        {
            Coordinate c = new Coordinate( );
            c.x = uint.Parse( line.Split( ',' )[0].Substring(1));
            c.y = uint.Parse( line.Split( ',' )[1].Substring( 0, line.Length - 1));
            return c;
        }
    }
}
