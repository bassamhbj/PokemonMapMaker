using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonMapMaker.Model;

namespace PokemonMapMaker
{
    public partial class Form1 : Form
    {
        private Tile _selectedTile;

        private OpenFileDialog _openFileDialog;
        private TileSetViewer _tileSetViewer;
        private MapCanvas _mapCanvas;

        public Form1()
        {
            InitializeComponent();
            _openFileDialog = new OpenFileDialog();
            _tileSetViewer = new TileSetViewer(this.pictureBoxTileset);
            _mapCanvas = new MapCanvas(this.pictureBox1);
        }

        #region Event Handler
        private void Form1_Load(object sender, EventArgs e)
        {
            _mapCanvas.GenerateCanvas(10, 10);
        }

        private void pictureBoxTileset_Click(object sender, EventArgs e)
        {
            var mouseEvent = e as MouseEventArgs;
            if (mouseEvent != null) {

                _selectedTile = _tileSetViewer.CropTileSet(mouseEvent.X, mouseEvent.Y);
                this.pictureBoxSelectedTile.Image = _selectedTile.TileBitmap;


                label1.Text = $"TileSetW={this.pictureBoxTileset.Width} TileSetH={this.pictureBoxTileset.Height} --- X={mouseEvent.X} Y={mouseEvent.Y} --- TileX={_selectedTile.X} TileY={_selectedTile.Y}";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (_selectedTile != null) {
                var mouseEvent = e as MouseEventArgs;
                if(mouseEvent != null) {
                    _mapCanvas.DrawTile(_selectedTile, mouseEvent.X, mouseEvent.Y);

                    label2.Text = $"--- X={mouseEvent.X} Y={mouseEvent.Y} --- TileX={_selectedTile.X} TileY={_selectedTile.Y}";
                }
            }
        }

        private void buttonFileBrowse_Click(object sender, EventArgs e)
        {
            if(_openFileDialog.ShowDialog() == DialogResult.OK) {
                _tileSetViewer.LoadTileSet(_openFileDialog.FileName);
            }
        }
        #endregion
    }
}
