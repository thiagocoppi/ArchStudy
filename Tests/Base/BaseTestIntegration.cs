using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Base
{
    public abstract class BaseTestIntegration
    {
        public IServiceProvider StartupTest()
        {
            const string testProjectDir = "Tests";
            var factory = new TestServerFactory();
            var client = factory.WithWebHostBuilder(builder =>
            {
                builder.UseSolutionRelativeContentRoot(testProjectDir);
            }).Services;

            return client;
        }
    }
}
