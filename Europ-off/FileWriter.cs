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
        StreamWriter streamWriter;
        
        private uint _numberOfProvinces = 0;
        private string _filePath;

        public void WriteFile( string filename )
        {
            _filePath = filename;
            File.Create( filename );

            File.AppendText( _filePath );
        }
        
        private uint NumberOfProvinces( string filename)
        {
            return _numberOfProvinces;
        }
        private void AddProvince( string filename )
        {

        }
    }
}
