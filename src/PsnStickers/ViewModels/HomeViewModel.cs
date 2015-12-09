using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsnStickers.ViewModels
{
    public class HomeViewModel
    {
        public List<StickerMeta> Stickers { get; set; } = new List<StickerMeta>();

        public void Initialize()
        {
            Stickers = new List<StickerMeta>
            {
                new StickerMeta
                {
                    Thumbnail = "http://psn-rsc.prod.dl.playstation.net/psn-rsc/sticker/preset/PRESET0000000001_149FABD8D394A6DBE1A3/thumbnail.png",
                    Id = "PRESET0000000001_149FABD8D394A6DBE1A3"
                },
                new StickerMeta
                {
                    Thumbnail = "http://psn-rsc.prod.dl.playstation.net/psn-rsc/sticker/preset/PRESET0000000002_514DB3A4FB993D12EBF3/thumbnail.png",
                    Id = "PRESET0000000002_514DB3A4FB993D12EBF3"
                },
                new StickerMeta
                {
                    Thumbnail = "http://psn-rsc.prod.dl.playstation.net/psn-rsc/sticker/preset/PRESET0000000003_EDF28F1D6344BBFB155D/thumbnail.png",
                    Id = "PRESET0000000003_EDF28F1D6344BBFB155D"
                },
                new StickerMeta
                {
                    Thumbnail = "http://psn-rsc.prod.dl.playstation.net/psn-rsc/sticker/preset/PRESET0000000004_0D6BF0697ED61BEF2B0F/thumbnail.png",
                    Id = "PRESET0000000004_0D6BF0697ED61BEF2B0F"
                },
                new StickerMeta
                {
                    Thumbnail = "http://psn-rsc.prod.dl.playstation.net/psn-rsc/sticker/preset/PRESET0000000005_0599C3691945F8EA44BC/thumbnail.png",
                    Id = "PRESET0000000005_0599C3691945F8EA44BC"
                },
                new StickerMeta
                {
                    Thumbnail = "http://psn-rsc.prod.dl.playstation.net/psn-rsc/sticker/preset/PRESET0000000006_AB9424086FCD7815F56A/thumbnail.png",
                    Id = "PRESET0000000006_AB9424086FCD7815F56A"
                },
                new StickerMeta
                {
                    Thumbnail = "http://psn-rsc.prod.dl.playstation.net/psn-rsc/sticker/preset/PRESET0000000007_61E52D5BC4C58D2B54DD/thumbnail.png",
                    Id = "PRESET0000000007_61E52D5BC4C58D2B54DD"
                },
                new StickerMeta
                {
                    Thumbnail = "http://psn-rsc.prod.dl.playstation.net/psn-rsc/sticker/preset/PRESET0000000008_747C7A189510B0E46019/thumbnail.png",
                    Id = "PRESET0000000008_747C7A189510B0E46019"
                },
                new StickerMeta
                {
                    Thumbnail = "http://psn-rsc.prod.dl.playstation.net/psn-rsc/sticker/preset/PRESET0000000009_F02BDD218592D60CBF83/thumbnail.png",
                    Id = "PRESET0000000009_F02BDD218592D60CBF83"
                },
                new StickerMeta
                {
                    Thumbnail = "http://psn-rsc.prod.dl.playstation.net/psn-rsc/sticker/preset/PRESET0000000010_3FB2CAC9E4B2A87923BA/thumbnail.png",
                    Id = "PRESET0000000010_3FB2CAC9E4B2A87923BA"
                },
                new StickerMeta
                {
                    Thumbnail = "http://psn-rsc.prod.dl.playstation.net/psn-rsc/sticker/preset/PRESET0000000011_5C8D37467040C36137EE/thumbnail.png",
                    Id = "PRESET0000000011_5C8D37467040C36137EE"
                },
                new StickerMeta
                {
                    Thumbnail = "http://psn-rsc.prod.dl.playstation.net/psn-rsc/sticker/preset/PRESET0000000012_24782706171261FBB2DD/thumbnail.png",
                    Id = "PRESET0000000012_24782706171261FBB2DD"
                },
                new StickerMeta
                {
                    Thumbnail = "http://psn-rsc.prod.dl.playstation.net/psn-rsc/sticker/preset/PRESET0000000013_4E07CEADEA273D7F9702/thumbnail.png",
                    Id = "PRESET0000000013_4E07CEADEA273D7F9702"
                },
                new StickerMeta
                {
                    Thumbnail = "http://psn-rsc.prod.dl.playstation.net/psn-rsc/sticker/preset/PRESET0000000014_A704F22DCDC916193EA0/thumbnail.png",
                    Id = "PRESET0000000014_A704F22DCDC916193EA0"
                },
            };
        }
    }

    public class StickerMeta
    {
        public string Thumbnail { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }
    }
}
