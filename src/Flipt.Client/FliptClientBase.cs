using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Flipt.Client
{
    public class FliptClientBase
    {
        public FliptClientBase(FliptClientConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        internal FliptClientConfiguration Configuration { get; }

        private protected async Task<HttpClient> CreateHttpClientAsync(CancellationToken cancellationToken = default)
        {
            var client = new HttpClient();

            client.BaseAddress = new Uri(Configuration.BaseUrl);
            if (Configuration != null)
                foreach (var header in Configuration.Headers)
                    client.DefaultRequestHeaders.Add(header.Key, header.Value);

            return client;
        }
    }
}
