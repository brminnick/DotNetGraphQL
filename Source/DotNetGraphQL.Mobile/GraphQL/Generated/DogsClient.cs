using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace DotNetGraphQL.Mobile
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public class DogsClient
        : IDogsClient
    {
        private const string _clientName = "DogsClient";

        private readonly IOperationExecutor _executor;

        public DogsClient(IOperationExecutorPool executorPool)
        {
            _executor = executorPool.CreateExecutor(_clientName);
        }

        public Task<IOperationResult<IGetAllDogs>> GetAllDogsAsync(
            CancellationToken cancellationToken = default)
        {

            return _executor.ExecuteAsync(
                new GetAllDogsOperation(),
                cancellationToken);
        }

        public Task<IOperationResult<IGetAllDogs>> GetAllDogsAsync(
            GetAllDogsOperation operation,
            CancellationToken cancellationToken = default)
        {
            if (operation is null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            return _executor.ExecuteAsync(operation, cancellationToken);
        }

        public Task<IOperationResult<IGetDogsByCoatColor>> GetDogsByCoatColorAsync(
            Optional<string> coatColor = default,
            CancellationToken cancellationToken = default)
        {
            if (coatColor.HasValue && coatColor.Value is null)
            {
                throw new ArgumentNullException(nameof(coatColor));
            }

            return _executor.ExecuteAsync(
                new GetDogsByCoatColorOperation { CoatColor = coatColor },
                cancellationToken);
        }

        public Task<IOperationResult<IGetDogsByCoatColor>> GetDogsByCoatColorAsync(
            GetDogsByCoatColorOperation operation,
            CancellationToken cancellationToken = default)
        {
            if (operation is null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            return _executor.ExecuteAsync(operation, cancellationToken);
        }
    }
}
