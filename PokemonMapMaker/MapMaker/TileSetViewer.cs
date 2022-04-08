using System.Drawing;
using System.Windows.Forms;
using PokemonMapMaker.Model;

namespace PokemonMapMaker
{
    public class TileSetViewer : TileSet
    {
        private PictureBox _pbTileSetViewer;

        public TileSetViewer(PictureBox pbTileSetViewer)
        {
            _pbTileSetViewer = pbTileSetViewer;
        }

        public void LoadTileSet(string filePath)
        {
            var tileset = Image.FromFile(filePath);
            _pbTileSetViewer.Width = tileset.Width;
            _pbTileSetViewer.Height = tileset.Height;
            _pbTileSetViewer.Image = tileset;
        }

        public Tile CropTileSet(int x, int y)
        {
            var tileCoordenates = GetSelectedTileCoordenates(x, y);

            var tile = new Bitmap(Settings.TILE_WIDTH, Settings.TILE_HEIGHT);
            using (var g = Graphics.FromImage(tile)) {
                var section = new Rectangle(new Point(tileCoordenates.X, tileCoordenates.Y), new Size(Settings.TILE_WIDTH, Settings.TILE_HEIGHT));

                g.DrawImage(_pbTileSetViewer.Image, 0, 0, section, GraphicsUnit.Pixel);
                return new Tile() { 
                    X = tileCoordenates.X,
                    Y = tileCoordenates.Y,
                    TileBitmap = tile
                };
            }
        }
    }
}
