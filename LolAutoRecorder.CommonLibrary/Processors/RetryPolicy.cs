using LolAutoRecorder.CommonLibrary.Exceptions;
using LolAutoRecorder.CommonLibrary.Interfaces;
using Ninject.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace LolAutoRecorder.CommonLibrary.Processors
{
    public class RetryPolicy : IRetryPolicy
    {
        private const int DelayBetweenRequests = 10000;
        private readonly ILogger _logger;

        public RetryPolicy(ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task ExecuteAsync(Func<Task> factory, Func<bool> condition, int maxRetries = 10, int delayBetweenRequests = DelayBetweenRequests)
        {
            int retries = 0;
            do
            {
                _logger.Debug($"ExecuteAsync | retryNumber: {retries}, maxRetriesNumber: {maxRetries}");
                if (retries > 0) await Task.Delay(DelayBetweenRequests);

                await ExecuteCore(factory);
                retries++;
            } while (retries > maxRetries || !condition());
        }

        public T Execute<T>(Func<T> factory, Func<T, bool> condition, int maxRetries = 10, int delayBetweenRequest = DelayBetweenRequests)
        {
            var result = default(T);
            int retries = 0;
            do
            {
                _logger.Debug($"Execute<T> | type: {typeof(T)}, retryNumber: {retries}, maxRetriesNumber: {maxRetries}");
                if (retries > 0) Task.Delay(delayBetweenRequest);

                result = ExecuteCore(factory);
                retries++;
            } while (retries > maxRetries || !condition(result));

            return result;
        }

        public async Task<T> ExecuteAsync<T>(Func<Task<T>> factory, Func<T, bool> condition, int maxRetries = 10, int delayBetweenRequest = DelayBetweenRequests)
        {
            var result = default(T);
            int retries = 0;
            do
            {
                _logger.Debug($"ExecuteAsync<T> | type: {typeof(T)}, retryNumber: {retries}, maxRetriesNumber: {maxRetries}");
                if (retries > 0) await Task.Delay(delayBetweenRequest);

                result = await ExecuteCore(factory);
                retries++;
            } while (retries > maxRetries || !condition(result));

            return result;
        }

        private async Task<T> ExecuteCore<T>(Func<Task<T>> factory)
        {
            try
            {
                return await factory();
            }
            catch (LeagueOfLegendsProcessException exception)
            {
                throw new LeagueOfLegendsProcessException($"League of Legends client exception. ", exception);
            }
            catch (Exception exception)
            {
                throw new RetryPolicyException($"There was an error during retry policy execution. Check inner exception for details.", exception);
            }
        }

        private T ExecuteCore<T>(Func<T> factory)
        {
            try
            {
                return factory();
            }
            catch (LeagueOfLegendsProcessException exception)
            {
                throw new LeagueOfLegendsProcessException($"League of Legends client exception. ", exception);
            }
            catch (Exception exception)
            {
                throw new RetryPolicyException($"There was an error during retry policy execution. Check inner exception for details.", exception);
            }
        }

        private async Task ExecuteCore(Func<Task> factory)
        {
            try
            {
                await factory();
            }
            catch (LeagueOfLegendsProcessException exception)
            {
                throw new LeagueOfLegendsProcessException($"League of Legends client exception. ", exception);
            }
            catch (Exception exception)
            {
                throw new RetryPolicyException($"There was an error during retry policy execution. Check inner exception for details.", exception);
            }
        }
    }
}
