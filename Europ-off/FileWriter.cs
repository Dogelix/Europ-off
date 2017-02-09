using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Europ_off
{
    class FileWriter
    {
        StreamWriter file;
        
        private uint _numberOfProvinces = 0;
        private string _filePath;

        public void WriteFile( string filename )
        {
            _filePath = filename;
            File.Create( filename );
        }

        public void PopulateNewFile( List<Province> provinces )
        {
            file = new StreamWriter( _filePath );

            file.WriteLine( "Error: Incomplete file save" );

            foreach(Province provience in provinces)
            {
                AddProvince( file, provience );
            }



            file.Close( );
        }
        
        private uint NumberOfProvinces( )
        {
            return _numberOfProvinces;
        }

        private void AddProvince( StreamWriter file, Province provience)
        {
            file.WriteLine("" + provience.ss);
        }
    }
}
