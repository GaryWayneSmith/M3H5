using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M3H5Lib.Extensions
{
    public static class HttpClientExtension
    {
        public static async Task<HttpResponseMessage> SendAsync(this HttpClient client, HttpRequestMessage request, HttpCompletionOption completionOption, TimeSpan timeout, CancellationToken cancellationToken)
        {
            if (client == null)
                throw new ArgumentNullException(nameof(client));

            Task<HttpResponseMessage> task = client.SendAsync(request, completionOption, cancellationToken);
            await Task
                .WhenAny(task, Task.Delay(timeout, cancellationToken))
                .ConfigureAwait(false);
            if (!task.IsCompleted)
            {
                throw new TimeoutException($"SendAsync timeout {timeout} exceeded");
            }
            return await task
                .ConfigureAwait(false);
        }

        public static async Task<HttpResponseMessage> GetAsync(this HttpClient client, string requestUri, HttpCompletionOption completionOption, TimeSpan timeout, CancellationToken cancellationToken)
        {
            return await client.GetAsync(new Uri(requestUri, UriKind.RelativeOrAbsolute), completionOption, timeout, cancellationToken)
                .ConfigureAwait(false);
        }

        public static async Task<HttpResponseMessage> GetAsync(this HttpClient client, Uri requestUri, HttpCompletionOption completionOption, TimeSpan timeout, CancellationToken cancellationToken)
        {
            if (client == null)
                throw new ArgumentNullException(nameof(client));

            Task<HttpResponseMessage> task = client.GetAsync(requestUri, completionOption, cancellationToken);
            await Task.WhenAny(task, Task.Delay(timeout, cancellationToken))
                .ConfigureAwait(false);
            if (!task.IsCompleted)
            {
                throw new TimeoutException($"SendAsync timeout {timeout} exceeded");
            }
            return await task
                .ConfigureAwait(false);
        }

    }
}
