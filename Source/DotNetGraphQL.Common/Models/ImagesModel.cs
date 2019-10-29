using System.Linq;
using System.Collections.Generic;

namespace DotNetGraphQL.Common
{
    public abstract class ImagesModel
    {
        protected ImagesModel(string avatarUrl, string websiteUrl, string title, IEnumerable<string> imagesList) =>
            (AvatarUrl, WebsiteUrl, Title, ImagesList) = (avatarUrl, websiteUrl, title, imagesList.ToList());

        public string AvatarUrl { get; }
        public string WebsiteUrl { get; }
        public string Title { get; }
        public IReadOnlyList<string> ImagesList { get; }
    }
}
