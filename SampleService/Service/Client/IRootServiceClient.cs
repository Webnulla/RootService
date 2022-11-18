using RootServiceNamespace;

namespace SampleService.Service.Client
{
    public interface IRootServiceClient
    {
        public RootServiceNamespace.RootServiceClient RootServiceClient { get; }
        public Task<IEnumerable<WeatherForecast>> Get();
    }
}
