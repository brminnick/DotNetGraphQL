using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace DotNetGraphQL.Mobile
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public class DogImage
        : IDogImage
    {
        public DogImage(
            string avatarUrl, 
            System.DateTimeOffset? birthDate, 
            string breed, 
            string coatColor, 
            IReadOnlyList<string> imagesList, 
            string title, 
            string websiteUrl)
        {
            AvatarUrl = avatarUrl;
            BirthDate = birthDate;
            Breed = breed;
            CoatColor = coatColor;
            ImagesList = imagesList;
            Title = title;
            WebsiteUrl = websiteUrl;
        }

        public string AvatarUrl { get; }

        public System.DateTimeOffset? BirthDate { get; }

        public string Breed { get; }

        public string CoatColor { get; }

        public IReadOnlyList<string> ImagesList { get; }

        public string Title { get; }

        public string WebsiteUrl { get; }
    }
}
