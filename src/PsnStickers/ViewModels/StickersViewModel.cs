using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PsnStickers.Models.Response;
using PsnStickers.Tools;

namespace PsnStickers.ViewModels
{
    public class StickersViewModel
    {
        public MetadataResponse Metadata { get; set; }

        public StickerResponse Stickers { get; set; }

        public async Task Initialize(string id)
        {
            var client = new HttpClient();
            var manifestResponse =
                await client.GetAsync(
                    $"http://psn-rsc.prod.dl.playstation.net/psn-rsc/sticker/preset/{id}/metadata.json");
            var manifestResponseString = await manifestResponse.Content.ReadAsStringAsync();
            Metadata = JsonConvert.DeserializeObject<MetadataResponse>(manifestResponseString);

            var stickerResponse =
                await client.GetAsync(
                    $"http://psn-rsc.prod.dl.playstation.net/psn-rsc/sticker/preset/{id}/manifest.json");

            var result = await stickerResponse.Content.ReadAsStringAsync();
            var stickerObject = JsonConvert.DeserializeObject<StickerResponse>(result);
            var newList = SizetypeConverter.ConvertStringToSizeProperty(result);
            stickerObject.StickerImagesBySize.Sizes = newList;
            Stickers = stickerObject;
        }
    }
}
