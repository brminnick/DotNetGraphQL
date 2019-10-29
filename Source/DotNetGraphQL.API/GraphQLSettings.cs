using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace DotNetGraphQL.API
{
    class GraphQLSettings
    {
        public GraphQLSettings(in PathString path, in bool enableMetrics, in Func<HttpContext, IDictionary<string, object>> buildUserContext) =>
            (Path, EnableMetrics, BuildUserContext) = (path, enableMetrics, buildUserContext);

        public PathString Path { get; }
        public bool EnableMetrics { get; }
        public Func<HttpContext, IDictionary<string, object>> BuildUserContext { get; }

    }
}
