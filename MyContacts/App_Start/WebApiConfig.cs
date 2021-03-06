﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using MyContacts.MessageHandlers;

namespace MyContacts
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Remove XML formatter
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // Web API configuration and services
            config.MessageHandlers.Add(new LoggingHandler());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
