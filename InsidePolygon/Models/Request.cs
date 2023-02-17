using InsidePolygon.Services.Validators;

namespace InsidePolygon.Models
{
    public class Request
    {
        public Point InputPoint { get; set; }

        [ValidateVertice]
        public Point[] Polygon { get; set; }
    }


}
