using System;

namespace Rest.REST
{
    internal class RestClient
    {
        private string url;

        public RestClient(string url)
        {
            this.url = url;
        }

        internal object Execute(RestRequest request)
        {
            throw new NotImplementedException();
        }
    }
}