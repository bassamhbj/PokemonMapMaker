using System.Drawing;
using System.Windows.Forms;
using PokemonMapMaker.Model;

namespace PokemonMapMaker
{
    public class MapCanvas: TileSet
    {
        private PictureBox _pbMapCanvas;

        public MapCanvas(PictureBox pbMapCanvas)
        {
            _pbMapCanvas = pbMapCanvas;
        }

        public void GenerateCanvas(int columns, int rows)
        {
            int mapWidth = columns * Settings.TILE_WIDTH;
            int mapHeight = rows * Settings.TILE_HEIGHT;

            var mapCanvasBitmap = new Bitmap(mapWidth, mapHeight);

            using (var g = Graphics.FromImage(mapCanvasBitmap))
            using (var brush = new SolidBrush(Color.White)) {
                g.FillRectangle(brush, 0, 0, mapWidth, mapHeight);
            }

            _pbMapCanvas.Width = mapWidth;
            _pbMapCanvas.Height = mapHeight;
            _pbMapCanvas.Image = mapCanvasBitmap;
        }

        public void DrawTile(Tile tile, int x, int y)
        {
            var tileCoordinates = GetSelectedTileCoordenates(x, y);

            var mapCanvas = _pbMapCanvas.Image;

            using (var g = Graphics.FromImage(mapCanvas)) {
                var section = new Rectangle(new Point(0, 0), new Size(Settings.TILE_WIDTH, Settings.TILE_HEIGHT));

                g.DrawImage(tile.TileBitmap, tileCoordinates.X, tileCoordinates.Y, section, GraphicsUnit.Pixel);
                _pbMapCanvas.Image = mapCanvas;
            }
        }
    }
}
