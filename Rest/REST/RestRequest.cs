namespace Rest.REST
{
    internal class RestRequest
    {
        private string v;
        private object get;

        public RestRequest(string v, object get)
        {
            this.v = v;
            this.get = get;
        }
    }
}