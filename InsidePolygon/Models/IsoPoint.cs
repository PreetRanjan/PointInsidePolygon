using System.Text.Json;

namespace InsidePolygon.Models
{
    public class IsoPoint
    {
        public IsoPoint(string postcode, int drive_time, int store_id, float latitude, float longitude)
        {
            Postcode = postcode;
            Drive_Time = drive_time;
            Store_Id = store_id;
            Latitude = latitude;
            Longitude = longitude;
        }

        public string Postcode { get; }
        public int Drive_Time { get; }
        public int Store_Id { get; }
        public float Latitude { get; }
        public float Longitude { get; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
