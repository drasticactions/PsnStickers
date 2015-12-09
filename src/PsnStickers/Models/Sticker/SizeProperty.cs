using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PsnStickers.Tools;

namespace PsnStickers.Models.Sticker
{
    public class SizeProperty
    {
        public string Size { get; set; }

        [JsonProperty("zip")]
        public Zip Zip { get; set; }

        [JsonProperty("urls")]
        public string[] Urls { get; set; }
    }
}
