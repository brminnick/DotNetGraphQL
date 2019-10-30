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

            Field<ListGraphType<DogImagesGraphType>>("dogs", resolve: context => DogImagesData.DogImages);
            Field<DogImagesGraphType>("dog", "Query a specific dog",
                    new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "name", Description = "Dog Name" }),
                    context => DogImagesData.DogImages.Single(x => x.Title.Equals(context.GetArgument<string>("name"), StringComparison.OrdinalIgnoreCase)));
            Field<ListGraphType<DogImagesGraphType>>("dogsByCoatColorOrBreed", "Query dogs",
                    new QueryArguments(
                        new QueryArgument<StringGraphType> { Name = "coatColor", Description = "Dog Coat Color" },
                        new QueryArgument<StringGraphType> { Name = "breed", Description = "Dog Breed" }
                    ),
                    context => GetDogImagesByNameOrBreed(context.GetArgument<string>("coatColor"), context.GetArgument<string>("breed")));

        }

        IEnumerable<DogImagesModel> GetDogImagesByNameOrBreed(string? coatColor, string? breed)
        {
            bool doesCoatColorContainValue = !string.IsNullOrWhiteSpace(coatColor);
            bool doesBreedContainValue = !string.IsNullOrWhiteSpace(breed);

            if (doesCoatColorContainValue && doesBreedContainValue)
                return DogImagesData.DogImages.Where(x => x.CoatColor.Equals(coatColor, StringComparison.OrdinalIgnoreCase) && x.Breed.Equals(breed, StringComparison.OrdinalIgnoreCase));

            if (doesCoatColorContainValue)
                return DogImagesData.DogImages.Where(x => x.CoatColor.Equals(coatColor, StringComparison.OrdinalIgnoreCase));

            if (doesBreedContainValue)
                return DogImagesData.DogImages.Where(x => x.Breed.Equals(breed, StringComparison.OrdinalIgnoreCase));

            throw new ArgumentNullException($"{nameof(DogImagesModel.CoatColor)} and {nameof(DogImagesModel.Breed)} cannot both be null");
        }
    }
}
