using System;
using Microsoft.Extensions.DependencyInjection;

namespace NexusTravel.ClientTest
{
    public class Runner
    {
        public Runner(IServiceProvider service)
        {
            var runner = service.GetRequiredService<TestSystemSettings>();
            runner.Display();
        }
    }
}
