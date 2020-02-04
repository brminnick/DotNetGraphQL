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

        public DogImagesModel()
        {

        }

        public string Breed { get; set; } = string.Empty;
        public DateTime? BirthDate { get; set; }
        public string CoatColor { get; set; } = string.Empty;
    }
}
