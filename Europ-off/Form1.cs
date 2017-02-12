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
        List<Province> provinces = new List<Province>();
        FileReader saveReader;
        FileWriter newFile = new FileWriter();
        RenderProvince provinceRenderer = new RenderProvince(); 

        public Form1( )
        {
            InitializeComponent( );
        }

        private void GamePanel_Paint( object sender, PaintEventArgs e )
        {
            Graphics g = e.Graphics;
            foreach(Province province in provinces)
            {
                provinceRenderer.renderShape(province, g, Color.LightBlue);
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
            ProvinceNameTextbox.Text = provinces[ProvinceList.SelectedIndex].Name.ToString();
            ProvinceIDTextbox.Text = provinces[ProvinceList.SelectedIndex].ID.ToString();
            ProvinceTaxTextbox.Text = provinces[ProvinceList.SelectedIndex].Tax.ToString();
            ProvinceProductionTextbox.Text = provinces[ProvinceList.SelectedIndex].Production.ToString();
            ProvinceManpowerTextbox.Text = provinces[ProvinceList.SelectedIndex].Manpower.ToString();
        }
    }
}
