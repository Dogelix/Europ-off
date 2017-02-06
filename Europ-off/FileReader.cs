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
        StreamReader file = new StreamReader( "..\\Europ-off\\ProvinceCodes.txt" );

        string line;
        List<Coordinate> _coord;
        uint _id;
        uint _tax;
        uint _man;
        uint _pro;

        public void GetProvinceCodes( )
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
                    provinceList.Add( new Province( _coord, _id, _tax, _pro, _man ) );
                }
            }
        }
    }
}
