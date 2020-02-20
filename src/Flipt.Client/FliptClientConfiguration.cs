using System;
using System.Collections.Generic;
using System.Text;

namespace Flipt.Client
{
    public class FliptClientConfiguration
    {
        private string baseUrl;

        public string BaseUrl { get => baseUrl ?? throw new InvalidOperationException("BaseUrl of Flipt.Client must be set for pipeline."); set => baseUrl = value; }

        public Dictionary<string, string> Headers { get; set; }
    }
}
