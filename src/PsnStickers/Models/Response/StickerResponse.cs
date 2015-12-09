using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PsnStickers.Models.Sticker;

namespace PsnStickers.Models.Response
{
    public class StickerResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("stickerPackageId")]
        public string StickerPackageId { get; set; }

        [JsonProperty("metadataUrl")]
        public string MetadataUrl { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("stickerImagesBySize")]
        public StickerImagesBySize StickerImagesBySize { get; set; }
    }
}
