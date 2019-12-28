using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace DotNetGraphQL.Mobile
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public class GetAllDogsOperation
        : IOperation<IGetAllDogs>
    {
        public string Name => "getAllDogs";

        public IDocument Document => MyQueries.Default;

        public OperationKind Kind => OperationKind.Query;

        public Type ResultType => typeof(IGetAllDogs);

        public IReadOnlyList<VariableValue> GetVariableValues()
        {
            return Array.Empty<VariableValue>();
        }
    }
}
