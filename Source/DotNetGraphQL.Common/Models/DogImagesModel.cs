using System;
using System.Collections.Generic;

namespace DotNetGraphQL.Common
{
    public class DogImagesModel : ImagesModel
    {
        public DogImagesModel(string avatarUrl, string websiteUrl, string title, IEnumerable<string> imagesList, string breed, string coatColor, DateTime? birthDate = null)
            : base(avatarUrl, websiteUrl, title, imagesList)
        {
            (Breed, BirthDate, CoatColor) = (breed, birthDate, coatColor);
        }

        public string Breed { get; }
        public DateTime? BirthDate { get; }
        public string CoatColor { get; }
    }
}
