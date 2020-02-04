using System.Collections.Generic;
using System.Linq;

namespace DotNetGraphQL.Common
{
    public abstract class ImagesModel
    {
        protected ImagesModel(string avatarUrl, string websiteUrl, string title, IEnumerable<string> imagesList) =>
            (AvatarUrl, WebsiteUrl, Title, ImagesList) = (avatarUrl, websiteUrl, title, imagesList.ToList());

        protected ImagesModel()
        {

        }

        public string AvatarUrl { get; set; } = string.Empty;
        public string WebsiteUrl { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public IReadOnlyList<string> ImagesList { get; set; } = Enumerable.Empty<string>().ToList();
    }
}
