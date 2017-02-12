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

        public void SaveFile( string filename )
        {
            _filePath = filename;
            FileStream w = File.Create( filename );
            w.Dispose();
        }

        public void PopulateNewFile( List<Province> provinces )
        {
            file = new StreamWriter( _filePath );

            file.WriteLine( provinces.Count());

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
            file.WriteLine("ID: " + provience.ID);
            file.WriteLine("Tax: " + provience.Tax );
            file.WriteLine("Man: " + provience.Manpower);
            file.WriteLine("Pro: " + provience.Production );
            file.WriteLine("Sha: " + FormatShapeData(provience.GetCoordinates));
        }

        private string FormatShapeData(List<Coordinate> points)
        {
            string _s = "";
            for(int i = 0; i < points.Count(); i++)
            {
                _s += string.Format("({0},{1})-", points[i].x, points[i].y);
            }
            _s = _s.Substring(0, _s.Length - 1);
            return _s;
        }
    }
}
