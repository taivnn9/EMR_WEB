using Newtonsoft.Json;

namespace EMR_MAIN.DATABASE
{
    [JsonObject]
    public class ThongTinBenhAn
    {
        [JsonProperty(PropertyName = "HanhChinhBenhNhan")]
        public HanhChinhBenhNhan HanhChinhBenhNhan { get; set; }
        [JsonProperty(PropertyName = "ThongTinDieuTri")]
        public ThongTinDieuTri ThongTinDieuTri { get; set; }
        [JsonProperty(PropertyName = "BenhAn")]
        public object BenhAn { get; set; }
    }
}
