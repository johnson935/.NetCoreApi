
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Tweetbook.Installers
{
    public interface IInstaller
    {
        void InstallServices(IConfiguration configuration, IServiceCollection services);
    }
}
