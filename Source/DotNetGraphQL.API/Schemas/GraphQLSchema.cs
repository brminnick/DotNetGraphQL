using GraphQL.Types;

namespace DotNetGraphQL.API
{
    public class ImagesSchema : Schema
    {
        public ImagesSchema()
        {
            Query = new ImagesQuery();
            //Mutation = resolver.Resolve<GotMutation>();
        }
    }
}
