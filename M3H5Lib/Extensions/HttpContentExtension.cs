using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M3H5Lib.Extensions
{
    public static class HttpContentExtension
    {
        public static async Task<Stream> ReadAsStreamAsync(this HttpContent content, TimeSpan timeout, CancellationToken cancellationToken)
        {
            if (content == null)
                throw new ArgumentNullException(nameof(content));

            Task<Stream> task = content.ReadAsStreamAsync();
            await Task.WhenAny(task, Task.Delay(timeout, cancellationToken))
                .ConfigureAwait(false);
            if (!task.IsCompleted)
            {
                throw new TimeoutException($"ReadAsStreamAsync timeout {timeout} exceeded");
            }
            return await task
                .ConfigureAwait(false);
        }

        public static async Task<byte[]> ReadAsByteArrayAsync(this HttpContent content, TimeSpan timeout, CancellationToken cancellationToken)
        {
            if (content == null)
                throw new ArgumentNullException(nameof(content));

            Task<byte[]> task = content.ReadAsByteArrayAsync();
            await Task.WhenAny(task, Task.Delay(timeout, cancellationToken))
                .ConfigureAwait(false);
            if (!task.IsCompleted)
            {
                throw new TimeoutException($"ReadAsStreamAsync timeout {timeout} exceeded");
            }
            return await task
                .ConfigureAwait(false);
        }

        public static async Task<string> ReadAsStringAsync(this HttpContent content, TimeSpan timeout, CancellationToken cancellationToken)
        {
            if (content == null)
                throw new ArgumentNullException(nameof(content));

            Task<string> task = content.ReadAsStringAsync();
            await Task.WhenAny(task, Task.Delay(timeout, cancellationToken))
                .ConfigureAwait(false);
            if (!task.IsCompleted)
            {
                throw new TimeoutException($"ReadAsStreamAsync timeout {timeout} exceeded");
            }
            return await task
                .ConfigureAwait(false);
        }
    }
}
