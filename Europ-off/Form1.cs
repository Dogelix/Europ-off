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
        List<Province> provinceList;
        List<Coordinate> coordinates;
        FileReader saveReader;
        Pen pen = new Pen( Color.Black );      

        public Form1( )
        {
            InitializeComponent( );
        }

        private void GamePanel_Paint( object sender, PaintEventArgs e )
        {
            Graphics g = e.Graphics;
            DrawProvinces( g );
        }

        private void DrawProvinces( Graphics g )
        {
            if(provinceList != null)
            {
                foreach (Province provience in provinceList)
                {
                    coordinates = provience.GetCoordinates();
                    for(int i = 0; i + 1 < coordinates.Count; i++)
                    {
                        paintLine(coordinates[i], coordinates[i + 1], g);
                    }
                    //Draws the final connecting line
                    paintLine(coordinates.First(), coordinates.Last(), g);
                }
            }
        }

        private void paintLine( Coordinate start , Coordinate end , Graphics g)
        {
            g.DrawLine( pen , start.x , start.y , end.x , end.y );
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create empty map file
        }

        private void loadMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Lets the user open a save file (only files with ems extension)
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveReader = new FileReader(openFileDialog1.FileName);
                provinceList = saveReader.Proviences;
                GamePanel.Invalidate();
            }
        }
    }
}
