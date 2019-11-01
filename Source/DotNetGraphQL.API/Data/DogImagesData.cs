using System;
using System.Collections.Generic;
using DotNetGraphQL.Common;

namespace DotNetGraphQL.API
{
    public static class DogImagesData
    {
        readonly static Lazy<List<DogImagesModel>> _dogImagesHolder = new Lazy<List<DogImagesModel>>(CreateDogImageList);

        public static List<DogImagesModel> DogImages => _dogImagesHolder.Value;

        static List<DogImagesModel> CreateDogImageList() => new List<DogImagesModel>
        {
            GenerateKirbyModel(),
            GenerateWafflesModel(),
            GenerateWhiskeyModel(),
            GenerateTobyModel(),
            GenerateMozzieModel(),
            GenerateMiloModel(),
            GeneratePiperModel()
        };

        static DogImagesModel GenerateKirbyModel()
        {
            var avatarUrl = "https://scontent-sjc3-1.cdninstagram.com/vp/0771b98c003d215ddf47d2c560424b6d/5E513A47/t51.2885-19/s320x320/19624561_1291655384266700_5712255956209893376_a.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com";
            var websiteUrl = "https://www.instagram.com/kirbygoldendoodle/";
            var name = "Kirby";

            var photosList = new List<string>
            {
                "https://scontent-sjc3-1.cdninstagram.com/vp/c191bde43f30d153a0e6f14d268899d7/5E3E5E59/t51.2885-15/e35/16906877_256386878145018_3660463037103472640_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=106",
                "https://scontent-sjc3-1.cdninstagram.com/vp/c41a8852ad9f767142023c3aee0b2bc2/5E64935C/t51.2885-15/e35/15258568_1837703606502348_6968759831339466752_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=100",
                "https://scontent-sjc3-1.cdninstagram.com/vp/bdbdd86ae01663b0f2682e5188235bd5/5E5BE931/t51.2885-15/e35/40022236_2195986720641841_3833817043975536640_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=101",
                "https://scontent-sjc3-1.cdninstagram.com/vp/3f4fc8c9a519398ed564dd4b39075a2a/5E546C7D/t51.2885-15/e35/13743278_1069261413162264_576463155_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=100",
                "https://scontent-sjc3-1.cdninstagram.com/vp/78c245bfd5afc9f0d9a21d5ed86acc91/5E5C5E95/t51.2885-15/e35/13706978_577881049040730_1166627530_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=106"
            };

            var breed = "Goldendoodle";
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

            var breed = "Australian Labradoodle";
            var coatColor = "Brown";
            var birthDate = new DateTime(2016, 9, 25);

            return new DogImagesModel(avatarUrl, websiteUrl, name, photosList, breed, coatColor, birthDate);
        }

        static DogImagesModel GenerateWhiskeyModel()
        {
            var avatarUrl = "https://scontent-sjc3-1.cdninstagram.com/vp/dec8edaafd32ef4f16ce77c2b65eea32/5E62D3AA/t51.2885-19/s320x320/67436293_862189824165677_126933068328992768_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com";
            var websiteUrl = "https://www.whiskeythegoldendoodle.com/";
            var name = "Whiskey";

            var photosList = new List<string>
            {
                "https://scontent-sjc3-1.cdninstagram.com/vp/4211f0fdf9b914a86b17f4cc77b06f38/5E407FAB/t51.2885-15/e35/p1080x1080/73455973_135066861231297_3894223610871841316_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=109",
                "https://scontent-sjc3-1.cdninstagram.com/vp/005559b904601259ce1277f655c90d04/5E520550/t51.2885-15/e35/s1080x1080/71699399_105498964122420_3067354989714568803_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=100",
                "https://scontent-sjc3-1.cdninstagram.com/vp/20e3b70a89332e8828f174a4e667118b/5E64AB82/t51.2885-15/e35/s1080x1080/73470571_1174481369427819_896524531300036982_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=103",
                "https://scontent-sjc3-1.cdninstagram.com/vp/dcf154912d88601ce4634ad2aaacc9d2/5E5C5529/t51.2885-15/e35/s1080x1080/73385907_416773049249260_5284448024311527390_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=104",
                "https://scontent-sjc3-1.cdninstagram.com/vp/ea9209ece298646348c41c6842a07838/5E4D5E4A/t51.2885-15/e35/s1080x1080/71520955_426072908105789_4729723680327501608_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=105"
            };

            var breed = "Goldendoodle";
            var coatColor = "Brown";
            var birthDate = new DateTime(2014, 9, 27);

            return new DogImagesModel(avatarUrl, websiteUrl, name, photosList, breed, coatColor, birthDate);
        }

        static DogImagesModel GenerateTobyModel()
        {
            var avatarUrl = "https://scontent-sjc3-1.cdninstagram.com/vp/7f6f7ede40df897e18c1d3e06d674e23/5E5AA2DA/t51.2885-15/e35/50014838_229200484627028_1458746312945381154_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=108";
            var websiteUrl = "https://www.instagram.com/tobytheyorki/";
            var name = "Toby";

            var photosList = new List<string>
            {
                "https://scontent-sjc3-1.cdninstagram.com/vp/026b0cdcd5316f7724c46a661d5fcfe3/5E4D8090/t51.2885-15/e35/s1080x1080/73512708_217192415937172_3862082126193392957_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=104",
                "https://scontent-sjc3-1.cdninstagram.com/vp/846fc56318141ed874e32703783526ef/5E55226D/t51.2885-15/e35/46638136_1004411036396080_6556008126338603743_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=104",
                "https://scontent-sjc3-1.cdninstagram.com/vp/ddb14f03ec8d761a230129ff0f2105a1/5E40541E/t51.2885-15/e35/44670242_379346979477654_7945422659005600483_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=106",
                "https://scontent-sjc3-1.cdninstagram.com/vp/198181b447c366631b05345deeed1a42/5E54BE2A/t51.2885-15/e35/41757764_1706672939443534_7883211221366895205_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=110",
                "https://scontent-sjc3-1.cdninstagram.com/vp/eba203221dfc2192c5ab1fad00390d04/5E4E9A23/t51.2885-15/e35/41361237_466468830510817_2675091403118276335_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=101"
            };

            var breed = "Yorki";
            var coatColor = "Brown";
            var birthDate = new DateTime(2015, 2, 11);

            return new DogImagesModel(avatarUrl, websiteUrl, name, photosList, breed, coatColor, birthDate);
        }

        static DogImagesModel GenerateMozzieModel()
        {
            var avatarUrl = "https://scontent-sjc3-1.cdninstagram.com/vp/5913ba9dc337bec65d32b336462dfa20/5E58A945/t51.2885-15/e35/33640369_226264147961207_7765603421549232128_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=111";
            var websiteUrl = "https://www.instagram.com/mozziethepuppy/";
            var name = "Mozzie";

            var photosList = new List<string>
            {
                "https://scontent-sjc3-1.cdninstagram.com/vp/fc3b9167bdf9b9bb2596a56c9fbd6bbc/5E4C8D4C/t51.2885-15/e35/44788461_585502225220134_1741283381522447371_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=110",
                "https://scontent-sjc3-1.cdninstagram.com/vp/fe77df3e656cc2cc47e705bcc9b62491/5E5F8648/t51.2885-15/e35/20759134_1905007816418883_8680830969160138752_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=103",
                "https://scontent-sjc3-1.cdninstagram.com/vp/600852e58f21929c227b42a444b90e0d/5E58ACB1/t51.2885-15/e35/19425309_280400619034639_7395849394978816000_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=107",
                "https://scontent-sjc3-1.cdninstagram.com/vp/d5c3553c84fdd9a0dd066215292f789c/5E5C9C1E/t51.2885-15/e35/19379883_1916079598630295_6981673084306587648_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=111",
                "https://scontent-sjc3-1.cdninstagram.com/vp/5fa735a9f014218d43ff18ce5934e017/5E40E7EF/t51.2885-15/e35/17663597_1751930025118061_7905305431944200192_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=105"
            };

            var breed = "Mix";
            var coatColor = "Brown";
            var birthDate = new DateTime(2016, 10, 28);

            return new DogImagesModel(avatarUrl, websiteUrl, name, photosList, breed, coatColor, birthDate);
        }

        static DogImagesModel GeneratePiperModel()
        {
            var avatarUrl = "https://scontent-sjc3-1.cdninstagram.com/vp/87132851249bbe49a1e363f5c640fbaa/5E56508F/t51.2885-19/s320x320/13734519_132392700533008_236125809_a.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com";
            var websiteUrl = "https://www.instagram.com/piper.bt/";
            var name = "Piper";

            var photosList = new List<string>
            {
                "https://scontent-sjc3-1.cdninstagram.com/vp/3f8fe47bb1c7a7c2d736276055cd6c87/5E5B126D/t51.2885-15/e35/57377602_878432729165265_5451422134633129153_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=109",
                "https://scontent-sjc3-1.cdninstagram.com/vp/b8b5dbcfcfeb37df1e93521c4fbf165f/5E458BE9/t51.2885-15/e35/14498894_246013109150758_7047888118367649792_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=110",
                "https://scontent-sjc3-1.cdninstagram.com/vp/d608136a5adef62f488b614690716cd5/5E490240/t51.2885-15/e35/13696797_754628597974092_928639078_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=100",
                "https://scontent-sjc3-1.cdninstagram.com/vp/9a3fe9cb0d2bd8a2268ea24f8f4b7ce0/5E47F579/t51.2885-15/e35/13636072_516768001858171_1831331040_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=107",
                "https://scontent-sjc3-1.cdninstagram.com/vp/2d80bcae51410106e3e24b3e42019f57/5E6164C7/t51.2885-15/e35/13671684_574529282754717_589202646_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=109"
            };

            var breed = "Bull Dog";
            var coatColor = "Black";

            return new DogImagesModel(avatarUrl, websiteUrl, name, photosList, breed, coatColor);
        }

        static DogImagesModel GenerateMiloModel()
        {
            var avatarUrl = "https://scontent-sjc3-1.cdninstagram.com/vp/6a0024b89ed2548ecbb6ef50964479c0/5E639DFB/t51.2885-15/e35/57468059_604190606716273_5699381031045146998_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=101";
            var websiteUrl = "https://www.instagram.com/frenchton.milo/";
            var name = "Milo";

            var photosList = new List<string>
            {
                "https://scontent-sjc3-1.cdninstagram.com/vp/8374bbf2c74521ace371c394ac6e70bc/5E4941B7/t51.2885-15/e35/56997710_2131534730276762_1880919774551388605_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=102",
                "https://scontent-sjc3-1.cdninstagram.com/vp/876930081aab45c31f4f292c5faf928d/5E5D86F9/t51.2885-15/e35/56749582_282780475992859_5518627445828391985_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=107",
                "https://scontent-sjc3-1.cdninstagram.com/vp/11788b4b4328b52e186263cd428a1486/5E4069DB/t51.2885-15/e35/58410888_2241646182762355_3360640618704941668_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=107",
                "https://scontent-sjc3-1.cdninstagram.com/vp/4f154f228259d9866a2c3341001bafc7/5E4B8BE6/t51.2885-15/e35/60233054_2323665944620016_5770986023083779017_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=108"
           };

            var breed = "Bull Dog";
            var coatColor = "Black";

            return new DogImagesModel(avatarUrl, websiteUrl, name, photosList, breed, coatColor);
        }
    }
}
