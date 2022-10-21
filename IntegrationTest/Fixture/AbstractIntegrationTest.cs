using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTest.Fixture
{
    public abstract class AbstractIntegrationTest : IClassFixture<APIWebApplicationFactory>
    {
        protected readonly APIWebApplicationFactory _factory;
        protected readonly HttpClient _client;

        public AbstractIntegrationTest(APIWebApplicationFactory fixture)
        {
            _factory = fixture;
            _client = _factory.CreateClient();
        }

    }
}
