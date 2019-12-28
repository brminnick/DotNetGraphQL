using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace DotNetGraphQL.Mobile
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public class GetDogsByCoatColorOperation
        : IOperation<IGetDogsByCoatColor>
    {
        public string Name => "getDogsByCoatColor";

        public IDocument Document => MyQueries.Default;

        public OperationKind Kind => OperationKind.Query;

        public Type ResultType => typeof(IGetDogsByCoatColor);

        public Optional<string> CoatColor { get; set; }

        public IReadOnlyList<VariableValue> GetVariableValues()
        {
            var variables = new List<VariableValue>();

            if (CoatColor.HasValue)
            {
                variables.Add(new VariableValue("coatColor", "String", CoatColor.Value));
            }

            return variables;
        }
    }
}
