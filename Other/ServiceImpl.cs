using Microsoft.ServiceFabric.Services.Remoting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Other
{
    public interface IMyService : IService
    {
        Task<int> HelloWorldAsync();
    }

    internal class ServiceImpl : IMyService
    {
        public Task<int> HelloWorldAsync()
        {
            ServiceEventSource.Current.Message("Hello world");
            return Task.FromResult(1);
        }
    }
}
