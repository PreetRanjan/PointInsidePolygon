using InsidePolygon.Models;

namespace InsidePolygon.Services
{
    public class IsoHelper
    {
        public static bool Inside(Point point, List<Point> Polygon)
        {
            var x = point.X; var y = point.Y;

            var inside = false;
            for (int i = 0, j = Polygon.Count - 1; i < Polygon.Count; i++)
            {
                var xi = Polygon[i].X; var yi = Polygon[i].Y;
                var xj = Polygon[j].X; var yj = Polygon[j].Y;

                var intersect = yi > y != yj > y && x < (xj - xi) * (y - yi) / (yj - yi) + xi;
                if (intersect) inside = !inside;
            }

            return inside;
        }
    }
}
