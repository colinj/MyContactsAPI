using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace MyContacts.MessageHandlers
{
    public class LoggingHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var correlationId = $"{DateTime.Now.Ticks}{Thread.CurrentThread.ManagedThreadId}";
            var requestInfo = $"{request.Method} {request.RequestUri}";
            Debug.WriteLine($"{correlationId} - Request: {requestInfo}");

            var response = await base.SendAsync(request, cancellationToken);

            var responseInfo = $"{(int)response.StatusCode} {response.ReasonPhrase}";
            Debug.WriteLine($"{correlationId} - Response: {requestInfo}\r\n{responseInfo}");

            return response;
        }
    }
}