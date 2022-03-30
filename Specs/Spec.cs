using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using System.Net.Http.Json;
using GDLibrary.Api.Controllers;

namespace Specs
{
    [TestFixture]
    public abstract class Spec
    {
        private static readonly HttpClient _httpClient;
        static Spec()
        {
            var factory = new WebApplicationFactory<Program>();
            _httpClient = factory.CreateClient();
        }

        public HttpClient client() => _httpClient;
    }
}
