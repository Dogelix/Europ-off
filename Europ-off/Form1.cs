using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Europ_off
{
    public partial class Form1 : Form
    {
        List<Province> provinceList = new List<Province>( );
        List<Coordinate> coordHolder = new List<Coordinate>( );
        FileReader fileReader = new FileReader( );
        Pen pen = new Pen( Color.Black );      

        public Form1( )
        {
            InitializeComponent( );
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            provinceList = fileReader.GetProvinceCodes( );
        }

        private void GamePanel_Paint( object sender, PaintEventArgs e )
        {
            Graphics g = e.Graphics;
            DrawProvinces( g );
        }        

        private void DrawProvinces( Graphics g )
        {
            int j = 1;
            foreach(Province element in provinceList)
            {
                coordHolder = element.GetCoordinates();
                for(int i = 0; i <= coordHolder.Count; i++)
                {
                    if(i == coordHolder.Count)
                    {
                        j = 0;
                    }

                    paintLine( coordHolder[i], coordHolder[i + j] , g);
                }
            }
        }

        private void paintLine( Coordinate start , Coordinate end , Graphics g)
        {
            g.DrawLine( pen , start.x , start.y , end.x , end.y );
        }
    }
}
