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
using System.Drawing.Drawing2D;

namespace Europ_off
{
    public partial class Form1 : Form
    {
        List<Province> provinces = new List<Province>();
        FileReader saveReader;
        FileWriter newFile = new FileWriter();
        RenderProvince provinceRenderer = new RenderProvince();
        List<Region> provinceRegions = new List<Region>();

        public Form1( )
        {
            InitializeComponent( );
        }

        private void GamePanel_Paint( object sender, PaintEventArgs e )
        {
            Graphics g = e.Graphics;
            provinceRegions = new List<Region>();
            foreach(Province province in provinces)
            {
                provinceRegions.Add(provinceRenderer.renderShape(province, g, Color.LightBlue));
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
                newFile.SaveFile( saveFileDialog1.FileName );
            }
            newFile.PopulateNewFile( provinces );
        }

        private void loadMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Lets the user open a save file (only files with ems extension)
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveReader = new FileReader(openFileDialog1.FileName);
                provinces = saveReader.Provinces;
                ProvinceEditorListUpdate();
                GamePanel.Invalidate();
            }
        }

        private void provinceEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProvinceEditorPanel.Visible = true;
            ProvinceEditorListUpdate();
        }

        private void ProvinceEditorListUpdate()
        {
            ProvinceList.Items.Clear();
            foreach (Province province in provinces)
            {
                ProvinceList.Items.Add(province.ID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProvinceEditorPanel.Visible = false;
        }

        private void ProvinceColorPicker_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ProvinceColorPicker.BackColor = colorDialog1.Color;
            }
        }

        private void ProvinceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProvinceEditorUpdate(ProvinceList.SelectedIndex);
        }

        private void PanelClick(object sender, EventArgs e)
        {
            //Checks Hitboxes backwards as the hitboxes overlap and this will find the latest hitbox at a location
            int i = provinceRegions.Count - 1;
            bool hit = false;
            var mouseEventArgs = e as MouseEventArgs;
            while(i >= 0 && hit == false)
            {
                if (provinceRegions[i].IsVisible(mouseEventArgs.X, mouseEventArgs.Y))
                {
                    ProvinceEditorUpdate(i);
                    hit = true;
                }
                i--;
            }
        }

        private void ProvinceEditorUpdate(int i)
        {
            //Fills text fields
            ProvinceNameTextbox.Text = provinces[i].Name.ToString();
            ProvinceIDTextbox.Text = provinces[i].ID.ToString();
            ProvinceTaxTextbox.Text = provinces[i].Tax.ToString();
            ProvinceProductionTextbox.Text = provinces[i].Production.ToString();
            ProvinceManpowerTextbox.Text = provinces[i].Manpower.ToString();

            //Updates list selection
            ProvinceList.SelectedIndex = i;

            //Updates color picker
            ProvinceColorPicker.BackColor = provinces[i].Color;
        }
    }
}
