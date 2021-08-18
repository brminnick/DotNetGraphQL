using DotNetGraphQL.Common;
using GraphQL.Types;

namespace DotNetGraphQL.API
{
    abstract class ImagesGraphType<T> : ObjectGraphType<T> where T : ImagesModel
    {
        protected ImagesGraphType(string name)
        {
            Name = name;

            Field(x => x.AvatarUrl, false);
            Field<ListGraphType<NonNullGraphType<StringGraphType>>>("imagesList", resolve: x => x.Source?.ImagesList);
            Field(x => x.Title, false);
            Field(x => x.WebsiteUrl, false);
        }
    }
}
