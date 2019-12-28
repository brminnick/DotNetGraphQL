using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace DotNetGraphQL.Mobile
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IDogImage
    {
        string AvatarUrl { get; }

        System.DateTimeOffset? BirthDate { get; }

        string Breed { get; }

        string CoatColor { get; }

        IReadOnlyList<string> ImagesList { get; }

        string Title { get; }

        string WebsiteUrl { get; }
    }
}
