using System;
using System.Collections.Generic;
using System.Linq;
using DotNetGraphQL.Common;
using HotChocolate.Types;

namespace DotNetGraphQL.API
{
    public class Query
    {
        /// <summary>
        /// Query for dogs
        /// </summary>
        [UseFiltering]
        [UseSorting]
        public IEnumerable<DogImagesModel> GetDogs() => DogImagesData.DogImages;

        /// <summary>
        /// Query a specific dog
        /// </summary>
        /// <param name="name">The dog name.</param>
        public DogImagesModel GetDog(string name) =>
            DogImagesData.DogImages.Single(dog =>
                dog.Title.Equals(name, StringComparison.OrdinalIgnoreCase));

        /// <summary>
        /// Query dogs by coat color or breed
        /// </summary>
        /// <param name="coatColor">Dog Coat Color</param>
        /// <param name="breed">Dog Breed</param>
        /// <returns></returns>
        public IEnumerable<DogImagesModel> GetDogsByCoatColorOrBreed(string coatColor, string breed)
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
