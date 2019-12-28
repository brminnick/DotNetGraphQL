using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace DotNetGraphQL.Mobile
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public interface IDogsClient
    {
        Task<IOperationResult<IGetAllDogs>> GetAllDogsAsync(
            CancellationToken cancellationToken = default);

        Task<IOperationResult<IGetAllDogs>> GetAllDogsAsync(
            GetAllDogsOperation operation,
            CancellationToken cancellationToken = default);

        Task<IOperationResult<IGetDogsByCoatColor>> GetDogsByCoatColorAsync(
            Optional<string> coatColor = default,
            CancellationToken cancellationToken = default);

        Task<IOperationResult<IGetDogsByCoatColor>> GetDogsByCoatColorAsync(
            GetDogsByCoatColorOperation operation,
            CancellationToken cancellationToken = default);
    }
}
