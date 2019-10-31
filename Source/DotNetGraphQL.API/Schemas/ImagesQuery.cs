using System;
using System.Collections.Generic;
using System.Linq;
using DotNetGraphQL.Common;
using GraphQL.Types;

namespace DotNetGraphQL.API
{
    public class ImagesQuery : ObjectGraphType
    {
        public ImagesQuery()
        {
            Name = "Query";

            Field<DogImagesGraphType>("dog", "Query a specific dog",
                    new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "name", Description = "Dog Name" }),
                    context => DogImagesData.DogImages.Single(dog => dog.Title.Equals(context.GetArgument<string>("name"), StringComparison.OrdinalIgnoreCase)));
        }
    }
}
