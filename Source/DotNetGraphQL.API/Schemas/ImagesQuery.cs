using System.Linq;
using GraphQL.Types;

namespace DotNetGraphQL.API
{
    public class ImagesQuery : ObjectGraphType<object>  
    {
        public ImagesQuery()
        {
            Name = "Query";

            Field<ListGraphType<DogImagesGraphType>>("dogs", resolve: context => DogImagesData.DogImages);
            Field<DogImagesGraphType>("dog", "Query a specific dog",
                                    new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "name", Description = "Dog Name" }),
                                    context => DogImagesData.DogImages.Single(x => x.Title.Equals(context.GetArgument<string>("name"))));
        }
    }
}
