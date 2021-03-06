﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
            Trace.TraceInformation($"{correlationId} - Request: {requestInfo}\r\n");

            var response = await base.SendAsync(request, cancellationToken);

            var responseInfo = $"{(int)response.StatusCode} {response.ReasonPhrase}";
            Trace.TraceInformation($"{correlationId} - Response: {requestInfo} -> {responseInfo}\r\n\r\n");

            return response;
        }
    }
}