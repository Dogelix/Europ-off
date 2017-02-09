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
        StreamReader file = new StreamReader( "C:\\Users\\Jake Yeatman\\Desktop\\Europ-off\\Europ-off\\Europ-off\\ProvinceCodes.txt" );
        List<Province> provList = new List<Province>( );

        string line;
        List<Coordinate> _coord;
        uint _id;
        uint _tax;
        uint _man;
        uint _pro;

        public List<Province> GetProvinceCodes( )
        {
            while ((line = file.ReadLine( )) != null)
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
                else if (line == "-----")
                {
                    provList.Add( new Province( _coord, _id, _tax, _pro, _man ) );
                }
            }
            return provList;
        }

        private List<Coordinate> ParseCoordinates(string t )
        {
            string[ ] coordinates = t.Split( ',' );
            List<Coordinate> x = new List<Coordinate>();
            for(int i = 0; Math.Ceiling((double)(coordinates.Length / 2)) > i; i++)
            {
                x.Add( ParseCoordinate( coordinates[i * 2 - 1] ) );
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
