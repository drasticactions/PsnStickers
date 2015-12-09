using Newtonsoft.Json;

namespace PsnStickers.Models.Preset
{

    public class PresetPackageList
    {

        [JsonProperty("stickerPackageId")]
        public string StickerPackageId { get; set; }

        [JsonProperty("manifestUrl")]
        public string ManifestUrl { get; set; }
    }

}
