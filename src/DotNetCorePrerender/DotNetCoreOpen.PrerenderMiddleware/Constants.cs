﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreOpen.PrerenderMiddleware
{
    public static class Constants
    {
        #region Const
        public const string PrerenderIOServiceUrl = "http://service.prerender.io/";
        public const int DefaultPort = 80;
        public const string CrawlerUserAgentPattern = "(googlebot)|(bingbot)|(yandex)|(baiduspider)|(twitterbot)|(facebookexternalhit)|(rogerbot)|(linkedinbot)|(embedly)|(quora link preview)|(showyoubot)|(outbrain)|(pinterest)|(slackbot)|(vkShare)|(W3C_Validator)|(WhatsApp)|(flipboard)|(tumblr)|(bitlybot)|(Discordbot)";

        public const string EscapedFragment = "_escaped_fragment_";
        public const string HttpProtocol = "http://";
        public const string HttpsProtocol = "https://";
        public const string Https = "https";
        public const string HttpHeader_XForwardedProto = "X-Forwarded-Proto";
        public const string HttpHeader_XPrerenderToken = "X-Prerender-Token";
        public const string HttpHeader_UserAgent = "User-Agent";
        public const string HttpHeader_ContentType = "Content-Type"; 
        #endregion
    }
}
