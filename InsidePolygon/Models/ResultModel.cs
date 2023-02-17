namespace InsidePolygon.Models
{
    public class ResultModel
    {
        public ResultModel(int id, string originPostcode, float originLatitude, float originLongitude, int storeId, string storePostcode, float storeLatitude, float storeLongitude, int driveTime)
        {
            Id = id;
            OriginPostcode = originPostcode;
            OriginLatitude = originLatitude;
            OriginLongitude = originLongitude;
            StoreId = storeId;
            StorePostcode = storePostcode;
            StoreLatitude = storeLatitude;
            StoreLongitude = storeLongitude;
            DriveTime = driveTime;
        }

        public int Id { get; set; }
        public string OriginPostcode { get; set; }
        public float OriginLatitude { get; set; }
        public float OriginLongitude { get; set; }
        public int StoreId { get; set; }
        public string StorePostcode { get; set; }
        public float StoreLatitude { get; set; }
        public float StoreLongitude { get; set; }
        public int DriveTime { get; set; }
    }
}
