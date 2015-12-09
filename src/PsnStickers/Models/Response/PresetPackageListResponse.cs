using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PsnStickers.Models.Preset;

namespace PsnStickers.Models.Response
{
    public class PresetPackageListResponse
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("presetPackageList")]
        public PresetPackageList[] PresetPackageList { get; set; }
    }
}
