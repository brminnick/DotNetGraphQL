using System;
using System.Collections.Generic;
using System.Linq;
using DotNetGraphQL.Common;
using GraphQL.Types;

namespace DotNetGraphQL.API
{
    public class ImagesQuery : ObjectGraphType<object>
    {
        public ImagesQuery()
        {
            Name = "Query";

            Field<DogImagesGraphType>("dog", "Query a specific dog",
                    new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "name", Description = "Dog Name" }),
                    context => DogImagesData.DogImages.Single(x => x.Title.Equals("name", StringComparison.OrdinalIgnoreCase)));

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
