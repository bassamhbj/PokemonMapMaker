using System.Drawing;

namespace PokemonMapMaker
{
    public class TileSet
    {
        public TileSet()
        {

        }

        protected Point GetSelectedTileCoordenates(int x, int y)
        {
            int columnNumber = (int)(x / Settings.TILE_WIDTH);
            int rowNumber = (int)(y / Settings.TILE_HEIGHT);

            int targetTileX = columnNumber * Settings.TILE_WIDTH;
            int targetTileY = rowNumber * Settings.TILE_HEIGHT;

            return new Point(targetTileX, targetTileY);
        }
    }
}
