using System;
using Microsoft.Extensions.DependencyInjection;
using NexusTravel.Dal.Models;

namespace NexusTravel.ClientTest
{
    public class Runner
    {
        private readonly SystemSettingDto _systemSetting;

        public Runner(IServiceProvider service)
        {
            var runner = service.GetRequiredService<TestSystemSettings>();
            runner.Display();
        }
    }
}
