using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace DotNetGraphQL.Mobile
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public class GetDogsByCoatColor
        : IGetDogsByCoatColor
    {
        public GetDogsByCoatColor(
            IReadOnlyList<IDogImage> dogs)
        {
            Dogs = dogs;
        }

        public IReadOnlyList<IDogImage> Dogs { get; }
    }
}
