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
        List<Province> proviences = new List<Province>();
        FileReader saveReader;
        FileWriter newFile = new FileWriter();
        RenderProvience provienceRenderer = new RenderProvience(); 

        public Form1( )
        {
            InitializeComponent( );
        }

        private void GamePanel_Paint( object sender, PaintEventArgs e )
        {
            Graphics g = e.Graphics;
            foreach(Province provience in proviences)
            {
                provienceRenderer.renderShape(provience, g, Color.LightBlue);
            }
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create empty map file
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                newFile.WriteFile( saveFileDialog1.FileName );
            }
            newFile.PopulateNewFile( proviences );
        }

        private void loadMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Lets the user open a save file (only files with ems extension)
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveReader = new FileReader(openFileDialog1.FileName);
                proviences = saveReader.Proviences;
                GamePanel.Invalidate();
            }
        }
    }
}
