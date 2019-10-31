using System;

namespace DotNetGraphQL.Common
{
    public class DogImagesModel : ImagesModel
    {
        public string Breed { get; set; } = string.Empty;
        public DateTime? BirthDate { get; set; }
        public string CoatColor { get; set; } = string.Empty;
    }
}
