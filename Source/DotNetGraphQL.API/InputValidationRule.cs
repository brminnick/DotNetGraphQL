using System.Threading.Tasks;
using GraphQL.Validation;

namespace DotNetGraphQL.Common
{
    public class InputValidationRule : IValidationRule
    {
        public Task<INodeVisitor> ValidateAsync(ValidationContext context) => Task.FromResult<INodeVisitor>(new EnterLeaveListener());
    }
}
