using System;
using System.Collections.Generic;
using DotNetGraphQL.Common;

namespace DotNetGraphQL.API
{
    public static class DogImagesData
    {
        readonly static Lazy<IEnumerable<DogImagesModel>> _dogImagesHolder = new Lazy<IEnumerable<DogImagesModel>>(CreateDogImageList);

        public static IEnumerable<DogImagesModel> DogImages => _dogImagesHolder.Value;

        static IEnumerable<DogImagesModel> CreateDogImageList()
        {
            yield return GenerateKirbyModel();
            yield return GenerateWafflesModel();
            yield return GenerateWhiskeyModel();
            yield return GenerateTobyModel();
            yield return GenerateMozzieModel();
            yield return GenerateMiloModel();
            yield return GeneratePiperModel();
            yield return GenerateMagicModel();
            yield return GenerateHermesModel();
        }

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
                "https://scontent-sjc3-1.cdninstagram.com/vp/4a5977fc6da543a3580dc65bec020f72/5E420BE3/t51.2885-15/e35/p1080x1080/60306434_315395119395230_9143171722741474046_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com&_nc_cat=102"
            };

            var breed = "Australian Labradoodle";
            var coatColor = "Brown";
            var birthDate = new DateTime(2016, 9, 25);

            return new DogImagesModel(avatarUrl, websiteUrl, name, photosList, breed, coatColor, birthDate);
        }

        static DogImagesModel GenerateWhiskeyModel()
        {
            var avatarUrl = "https://scontent-sjc3-1.cdninstagram.com/vp/d0cc41e4c2f2fad7e41ed5f9462421f4/5E6FDB22/t51.2885-19/s320x320/75487930_545788479570130_7341431923115294720_n.jpg?_nc_ht=scontent-sjc3-1.cdninstagram.com";
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

        static DogImagesModel GenerateMagicModel()
        {
            var avatarUrl = "https://lh3.googleusercontent.com/8B2KQsTtG1nraAD8oE6N2wjNbK-EFEiZMOd3aJkg_Dqf_Wf34MRXjbs8VDIn8w7DTTmz16BbhIQ7hfE-5Xkuruj1lPVgOcZxY3hpGbn483jpnrmW-WfAcC5jg1wsFZ02-Pt5x7tUGCDbl7BfrH0zdaBaxOk3uyOs_zUKHExpSRb125oV7IgBhI9WYuyxSPbZsQVlBCh_NP-yb3B34vZx1IE5D4uHkc960c5V00C_AEllgX5rjMBEyRW9KhDt7gfmvYcssP6VwOH_WtY9gpyNaYihYCubRPtJDX_XnS6mOLMaI3n6i2f8dTo6hJEuCAP-wpybOXCwvBIq0QcmJJUorCH8_Z1-bocfwIZjDNfxVoQ9DC2_N2ZlWAT7eBVRnGSlAXTO4gpFZ9Pj2RYgWqmj1I98_3NWMPKMvlR_-DTAAKX4bkptZ86vsx1Z1e_62l7e7f-3XD9Eg8i_6AZzSOTEOvifOY9mZe8I_VXiYriAOujsIs3sdKeCDNuoLU91cVK9ZdnqJG_ppUkkEGC3V_oMTkE2gXvej6Dvl1vBrVXyoyT9jYjJVUzLZVj4kE9oltojy11ssvUzUs0_RZv_MS1h0Yp645NbyeKdNtDRgyoBPTGhsJj8eMtO_ljjmwqjndwv3M7Wm3Vwl7xfJdSLSmyaAYYauieu3uYbXBPRizLg0jkeWJ8ZvjaKQ2UlD4UqQWAukAtrbcgtsKqPgYCAFU8o6HGXS8bx4JLcZY5BG_8SZhcYlWyP=w989-h742-no";
            var websiteUrl = "";
            var name = "Magic";

            var photosList = new List<string>
            {
                "https://lh3.googleusercontent.com/5tmTxxwo95s7a1XOCCoTtxcgyXpi4ZR20Y-GEwiQuAN9ODyCu9pwTcIfvY5_B4hHP7wnKN9RNh4X7quAA8vPIE87lO09Ox8PprvtIpynRwoAfN32mM_KIMqS_N00TB44_68LuNGYHXLJ5MpRyYMzDuAXXCfti719US2mA4RdDU-SvFJKhXhiwJOGK5iBtFbKTuiSrc4fc46NIYQfKn1mR70Z574H1NaZnE2WFh1JCyVpw6mH3yEz7wb5_SmKQ-qLwxA3vyJgGPk7lvad6sxT1DBWfBkIgNIwEWaF8TzHa56BN0YrT5VBOJgYgev0cnxuVsYV2-ig4yGXBl4-NDsYFcMxFmElFqh4d5z_FhMQrtMWUbOccv5758obWBZ2LuevTZP2u2Q8coUUSmbSE0yFAD4hniIqlINRmBuDoXy7ySt7amEYUIYBSmUGYkUxU8qeboUFSx-B8iAj6swsw3SiIjfKnVOar6zPTvCzxehzUH1CU_-isIaBxvd6n5wUzRr0_aIQ7TLENxu8F4ow_r0ma7wU5UE3-nL2EE76Dt09rBqWLwrDUFSkbtLGR8RUWuY3FBPhk1S4rdZApI7fgj-6ESsw44da9VDJBEi26eN8EeiIjjBBkV47uE8KxPWT3oApArJe5Ia_0bQWTjbIOHW1oPThvpTxDQ3siofRiK5cSWO2zboGvzU1nWxnsCsnyntpL0o5e8prscSM2YfTX-S4uBQ3EGJ_TDIH3bnFEPuueCCSBjHi=w989-h742-no",
                "https://lh3.googleusercontent.com/ngayLnnbyDUp10Zf7C2ggJn15dvDQzHQwr5baBYTmI_SXinhLT5HwqraLIBh3wyqpAOdy5Twe96r2My08R9Kew03P074ymAfLF0Jp4BqikY14wn3_aMObPvOMyKTAxtVyqIxPg4AkKQPWAzE780Qk9dmHk46vImTM7rHby0nZLLLJQ2vL-Q7FzlPTVISQ2Scf6eY5pXZ3LNj79wYkzvAg06aFfRaYL2CFRlsWqEb_2C8ZlUNS_kckzHbWqtVJOAl-5tJFACGfVBySdwLUBPfu0Atw9DLPQ6EBuSFz1aVTZ1ynkyzRAqFrMrT_LAHUWFXGLfFJ4M0iKcJHjBtwxzye5O3rchRj3SQtJAO5b9EiwC3xhVUBPgZYd7X88pLt1wxXHUmSjFgVP0IkbyIbvsfIARWHqDflTnYvlPt8xCFirAfefEtQTXDn6cOoBjtWgsPd8PP3JIm1xy3PUNOVxKIzD5FrnLxfD5UkN_3m6u11RhDeytKrQJtC8wnE8955SpEKHzqcHy6l0rwx6XN-TddJjdQwixBrtugkPBQwwhNv_uErMMQhacEMvdIvv6lA6WqKbSEntN2WSqt9RI-0lucd3yFAc1pu_-zMX27jhYVRFR1QzEFFs7NWWMWyGF-25xviuNNnTk3-2_kchSTAIigf_NtRGGF36k8X81VDpmLBK7BGDgTHJjqLWWglSQcJBf_GREm32fRrCioP0ti9HUGQDGfcLwDZvoZ9qshh-m4eaNxa-0k=w716-h382-no",
                "https://lh3.googleusercontent.com/KBRjG274i0Iq7-JAQTz_MgSsRfSBtcsGMkMqjWcL374x_Q41y6sBVamm4Vu27J4NYpVgLT4y8tDH3H8RsRWTclb2MCZCyLmEFZrFoOVa2otd8OvyoJxXzeBV6Wu7Z4F0RkXs9sYZtQsJxWjPJvEe9kymqiL1PnndDYEMirMpyfTfDHAp1uKBdxRbhmgoof28Yu_7OHVJKhGJQzEMPCliApKju8WfsSbmROdgs-cRuMfLddoVaN_r2HWEYMqcbsf_XK7LVSII4JmJ6RwBN9YUqRVqyco0n3Nx2aCPlVg47NAcrE3RCQB5okbFCTGGzn0Evjx5rF4DPPM14GXqUstoRvgc5g1omC-_7Wq7fl6SvIf7pnaUuNZ5INRTIsep-Pqqt6Lv2BZSYNeE4PhkkjjNk4CVz9YcTGxOjdWxd67CD2tYpD29TEN2C6soPO9R0IW3XIgWnV411ZCfAwg_f6k-XbeX8Ig1VJ_STJ0p1gM24Z-NlSSKthpoGls7sNuexstr4SY9FLvmQDT_AyShjLZ_2wS20RsFYG5YLhYLPGgStA6pKl5l2oCtFERM_gAyz_x5Twf68qUh50z8lELrD8s7s7UCKV3qGnjGCSuAYIbgjy_J-cVTOUYxkVLJOPwQ-eQGGSMr_IDFrnhIThZsA7_HfmN2w-ilUsL7iSPTB-jtueWX5C_egAF8w8f-e4aZ1xiYNmAPq-o8UVqRlQJUQBRdaQJGmRuxCfFpBWqeAgJygayQduSU=w509-h382-no"
            };

            var breed = "Golden Retriever";
            var coatColor = "Yellow";
            var birthDate = new DateTime(2012, 04, 01);

            return new DogImagesModel(avatarUrl, websiteUrl, name, photosList, breed, coatColor, birthDate);
        }

        static DogImagesModel GenerateHermesModel()
        {
            var avatarUrl = "https://lh3.googleusercontent.com/9kWTrt54igZZj2pEb0y7WVjvosu8PGmT2YFtLg9bTO_-U4NqKkdPZ2i15n2nRCWN-bmyOjFTC4sf0vtK7HqBxLzqzn1_JHn0nptex-GyA7KCfvI2Lli2i1Y5gMbrcaKU_dWTTFxPvcWZEKEiOfGkXYFk8DfWas3uvrGsjE2SQs2dRMndcSttu-SaUuNBDoQROq0IEgnpFx6MS0H5GxlZFCKyDll2CsJfBPYMp2iFBQbKcBNc45Z7UFJDyJx8DxuHT3JYUIabdCFqSKzPXt6ibnlGTs4GFsBA77RIKsivEF2kDT-HXoTGY9M4vxwzgt-6M9-UCjuL-QM_Rci0jyRh08WnpqlkF1MemXIu6kKc7pA-e0gOkVMsoODJ6E1d9Wl95v2bc4FrgJzibHrIyh7LoIKWgV9ImXRXd7i2ZVAiMekbJwRWQUDu9VgvMjBpSW1Qtn6T55_XvA1WZiYamZ33FbDyDzxzYNXwyOAap7U593CDY-b_h2_6IBhVX8tW0WRQgB2igzM7dXtWgIdf2wSfK-7UvWzX9bOfYplIVjXbzxWQF_VYjb6nItW9T7NFXNkx6aipdymb_Cgv-_jbSVfWLYESuMy490DIO_NIvSXqwcAz8r7NOTBvnSp0wYZugdH2v7KKT7v2KZ1_rFi7JTbMof4KFHkFlwQ23aI81VfDls4YRkrikyO1Uf6qUlzJXeOSrAi1BlZXrMcfZJyYmOCDfRUVofMxnTtUiB5Gi9oeswl8-4uX=w509-h382-no";
            var websiteUrl = "";
            var name = "Hermes";

            var photosList = new List<string>
            {
                "https://lh3.googleusercontent.com/Dj9eGzTuwvkpGtoS3YlHU4UHrtE1s3cyYmkWIbIzktU0OkxT21rveMJTf8P5lm3bI-qOidbPxZgRvt2BqjzxBL5yYUcKuJTBQxt7GoqpPTWSmc0kLAGKCAgsm7o7GRp-E1gnaOTYTliFilkcUy1S9X_Q6jXA_VuhVYj04mm41ofEE00FUzYz3FqAoUPHie7nyVfkow3qyQVHoGW7CSAHk0Ock6cXGKP9rJpcp-1FNlABRmeMNUrCBU70Sg5m5wHLeKiMOZLOyUILydD4yfKPWK29jo8zJoaNYV2KAWzhU0mA_scuRcbQ5eYCLdJGoBN9o0lZdDCc0tu84KpSDF7K_FWSh1FkModIE-oz_MkGqngiQrVgU9NXq-XHwTI4J1SNjt7wOitaq7s1Bat9P6T6_5ifPToypak8B-RI3NGU82UDOB4MnmplvQk7773eDH4O097wd-AvoDVQkSroaBGR0GMH1WKcC8horuKP_I0AbaOf4Fqk8d1MqaM3dQPPRMusVhghvwsSAYcr51Xt7INqZtxa0xANCC6SOcG6AMOk7H-W_iDWAbsC8ZGhtV6SPnPKPsGFUic07UpPGxq7a5djTQPSj1-7UjFsWICrMGcropksRQFp8ptsSmndiRRWzYhhasxZCdWUo1wEegaCCu8jXYUvXyYxwP1_zji74tOf9yspoCm3oIOb0nQrHOMe83KtxaPwE4z_0icKr7qJzkBSB3o3LaeLL7NnvfK5TIn0aUFJ3A4c=w509-h382-no",
                "https://lh3.googleusercontent.com/Q1jGh32k1Lq4wrAq0LWinVJforrWcPcCIcbDEnbdQ-7hBiKWckPoCB6OLSGEsCpIi1YKj_M7SsHf84ygReXTS89_azsLXS4C6Ijs7IhD6umSqHPhICZj5wavZS-RnsXTZMX-iZb7Ebgkh7yC0pV1Bp5ghUW48EFervfv6E4gs_kNywdQpCwCl6CGTT1FywebKTChzihjdhoxtCEy4oxsPXFRSVg34vOYhJtU5cEBJZ6nwbW-elZ5iq3D4pgNlX4ey2EJtXRedcxVuyBW78FgjrGjix000_PGd2TkaOBs5wNGLYerdUdNSCexT05jZ-aD0_JIy10rqq4ffsIhV585Euf3S5sUYVYYa62dwnjWtDLesR8G1MuNwZdThQmxnxkU5E2jHPfKXKkBpDsPsoUyqUAxTYdEL7qF1bqLRi-td_ahycwBivK3EeMoNxiC74EOQo5DbdahqWqqOnX4qyFxEjfGs36fV483FoeOvps9NyaCxb_ag9tdZAbOuTS6ChQs0s8ZpCmTzzNti-Zw33fuc7CWLTmTGku-9byXZNsCjUIsp-oZVmHoqMmgSvffnQqjvOecNdwHYIbtXZzfzhRCTVGxgDMaQSPp48cguoBAe7geawwUqCy-0U0vVSvH-4HFCIF8p2Y6UfzKo3Vhakwrp0b5fIG77xNDvJW-GfhG_Gk_zKK62czlTFQ_4LCL1xD50VF_mvryfHWou0_vo8xeK2BP_2JkuRvzQ5ZVWhVbDAxtUjxP=w509-h382-no",
                "https://lh3.googleusercontent.com/Htsg5lZJOfX0f8rKOwfbqU89ZJQslf8DWYiam0dHsMxb3-hq023Wcf03FCfXfDE-jSWbKr44SIdb9eoVSUloPlAH3XKg1aCPfCLFPweyBm3LLft1L3LtMj3UYQd7zlpHh6kLyp6EoxnOU_n1qe12wF1JjxCFtxw0GTu8wxJqnXIU_vz9LMbI8ggfm4tw-miNoizBGxFzrkrklK0lxWayhEpswUl9KaQa2YTWRTnVGLl00AdjpStHMkvUL3jE8B6zbCxZASr7I3DeHpGOyl0nE0OPK_PxwRblvUyT45PEYLBi4pYaxWOxI-gLEdYh7X025JLMzfJW-k7fmYtQWORLR1Vx38E-yga9WA_DAhtw_M2GnbK_ZXfuFD_cNlV1qaOdEg9rbnAiHsZGulu4EfuN03P4JyK30fQI4au5cjdVZKhhq3ln67fKShPWoHKFCSyCfSzJ7fhFS3Vj3jRIp06kG0RKPyBDnTSaNphPvKNQqpSTKJIRZZy_Ll_b1SxNg0HZ216CBzzZ4JCrlX11C_FNs50zAH-gPxwslTs1KgP397WmwAvqRtnDBueyJzauCz-yxU-NCzEdYDzDa6-SnGSDdeAD3lctilopRvogJ7sGOKkvuyjVl4XDs9RV3JjbpINHSLZIZ49MzBNlWGmyOlr7aSTzMAKLpU_fRhkwdODPt_5EuQ8CpqnT2rDJjIl9p9NjPB44hUcotUvXrlDIDYIdAyPHvr9wJehRfadyOf2-Ih9dE4t5=w287-h382-no"
            };

            var breed = "Shorkie";
            var coatColor = "Brown";
            var birthDate = new DateTime(2017, 05, 30);

            return new DogImagesModel(avatarUrl, websiteUrl, name, photosList, breed, coatColor, birthDate);
        }
    }
}
