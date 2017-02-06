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
        Pen pen = new Pen( Color.Black );      

        public Form1( )
        {
            InitializeComponent( );
        }

        private void Form1_Load( object sender, EventArgs e )
        {

        }

        private void GamePanel_Paint( object sender, PaintEventArgs e )
        {
            Graphics g = e.Graphics;
        }        

        private void paintLine( Coordinate start , Coordinate end , Graphics g)
        {
            g.DrawLine( pen , start.x , start.y , end.x , end.y );
        }
    }
}
