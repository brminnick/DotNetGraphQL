using System;
using GraphQL.Types;

namespace DotNetGraphQL.API
{
    public class ImagesSchema : Schema
    {
        static readonly Lazy<ImagesQuery> _imagesQueryHolder = new Lazy<ImagesQuery>(new ImagesQuery());

        public ImagesSchema()
        {
            Query = _imagesQueryHolder.Value;
        }
    }
}
