using Domain.DTO.Requestes.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
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

        public async Task SignIn(string loginname, string password)
        {
            HttpResponseMessage responseLogin = await _client.PostAsJsonAsync("/api/account/login", new AuthentificationRequestDTO()
            {
                Login_name = loginname,
                Password = password
            });

            var login = await responseLogin.Content.ReadAsStringAsync();
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", login);
        }


        public void SignOut()
        {
            _client.DefaultRequestHeaders.Authorization = null;
        }

    }
}
