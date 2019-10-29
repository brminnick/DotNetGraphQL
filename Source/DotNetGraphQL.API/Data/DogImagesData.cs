using System;
using System.Collections.Generic;
using DotNetGraphQL.Common;

namespace DotNetGraphQL.API
{
    public static class DogImagesData
    {
        readonly static Lazy<List<DogImagesModel>> _dogImagesHolder = new Lazy<List<DogImagesModel>>(CreateDogImageModels);

        public static List<DogImagesModel> DogImages => _dogImagesHolder.Value;

        static List<DogImagesModel> CreateDogImageModels() => new List<DogImagesModel>
        {
            GenerateKirbyModel(),
            GenerateWafflesModel(),
        };

        static DogImagesModel GenerateKirbyModel()
        {
            var avatarUrl = "https://scontent-sjc3-1.cdninstagram.com/vp/0771b98c003d215ddf47d2c560424b6d/5E513A47/t51.2885-19/s320x320/19624561_1291655384266700_5712255956209893376_a.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com";
            var websiteUrl = "https://www.instagram.com/kirbygoldendoodle/";
            var name = "Kirby";

            var photosList = new List<string>
            {
                "https://scontent-sjc3-1.cdninstagram.com/vp/787be42ce318c9d7765adb2990fc74c4/5E487588/t51.2885-15/sh0.08/e35/s640x640/73372153_2592246320828883_830613847567368174_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=103",
                "https://scontent-sjc3-1.cdninstagram.com/vp/7dc7f71a26152d0fe0dfc1260b9cd89c/5E5B8C4D/t51.2885-15/sh0.08/e35/s750x750/56619906_2259486890992190_8081895007514680504_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=102",
                "https://scontent-sjc3-1.cdninstagram.com/vp/84b9abf586714af26aa7a3dc5449e4ee/5E4644FD/t51.2885-15/sh0.08/e35/p750x750/46252247_345830652815597_366371020653368487_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=105",
                "https://scontent-sjc3-1.cdninstagram.com/vp/557d04b5e9d0fda7b16b763ae154ab31/5E468B4F/t51.2885-15/sh0.08/e35/s750x750/40022236_2195986720641841_3833817043975536640_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=101",
                "https://scontent-sjc3-1.cdninstagram.com/vp/31219d4bffde230c3f443753541068dc/5E43709E/t51.2885-15/sh0.08/e35/p750x750/37719878_1655035381290328_2281852859496529920_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=104",
            };

            var breed = "Golden Doodle";
            var coatColor = "Brown";
            var birthDate = new DateTime(2014, 03, 26);

            return new DogImagesModel(avatarUrl, websiteUrl, name, photosList, breed, coatColor, birthDate);
        }

        static DogImagesModel GenerateWafflesModel()
        {
            var avatarUrl = "https://scontent-sjc3-1.cdninstagram.com/vp/a87618792f3f54bb2cd5de467c17bfda/5E4DDFDF/t51.2885-19/s320x320/46352155_1525523697551015_4631879936745930752_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com";
            var websiteUrl = "https://www.instagram.com/hisnameiswaffles/";
            var name = "Waffles";

            var photosList = new List<string>
            {
                "https://scontent-sjc3-1.cdninstagram.com/vp/62735ce73ed50f10b083e63ee67777fd/5E469C5B/t51.2885-15/e35/s1080x1080/70594613_472808650109566_9086049796094395007_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=110",
                "https://scontent-sjc3-1.cdninstagram.com/vp/463d2f790dad456aa7f907fbc5c4f2d5/5E5E4DA2/t51.2885-15/e35/p1080x1080/68904319_153662302373174_5867607915252717949_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=102",
                "https://scontent-sjc3-1.cdninstagram.com/vp/6f094e68dcea3ce76025bc9a3aae1d10/5E4B5760/t51.2885-15/e35/p1080x1080/61615381_142948983481771_3906781618639463667_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=107",
                "https://scontent-sjc3-1.cdninstagram.com/vp/df20cab484e3fdce8e7b93be068cd955/5E5F68F4/t51.2885-15/e35/p1080x1080/60983676_671182750019423_8627416967785409822_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=111",
                "https://scontent-sjc3-1.cdninstagram.com/vp/4a5977fc6da543a3580dc65bec020f72/5E420BE3/t51.2885-15/e35/p1080x1080/60306434_315395119395230_9143171722741474046_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=102",
            };

            var breed = "Golden Doodle";
            var coatColor = "Brown";
            var birthDate = new DateTime(2016, 9, 25);

            return new DogImagesModel(avatarUrl, websiteUrl, name, photosList, breed, coatColor, birthDate);
        }
    }
}
