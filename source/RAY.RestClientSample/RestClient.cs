namespace RAY.RestClientSample
{
    using System;
    using System.IO;
    using System.Net;

    public class RestClient
    {
        public RestClient()
        {
            HttpMethod = HttpVerb.GET;
        }

        private HttpVerb HttpMethod { get; set; }

        public string MakeRequest(string requestUri)
        {
            var responseValue = string.Empty;
            var request = (HttpWebRequest)WebRequest.Create(requestUri);
            request.Method = HttpMethod.ToString();
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException($"Error code: {response.StatusCode.ToString()}");
                }

                // INFO: Process the response stream (could be JSON, XML, or HTML etc...)
                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (var reader = new StreamReader(responseStream))
                        {
                            responseValue = reader.ReadToEnd();
                        }
                    }
                } // INFO: End of using Stream
            } // INFO: End of using ResoinseStrem

            return responseValue;
        }
    }
}