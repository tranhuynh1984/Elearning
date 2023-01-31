using EasyCaching.Core.Interceptor;
using Elearning.Infrastructure.Cachings;
using Elearning.Infrastructure.Contracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Elearning.Infrastructure.Installers
{
    public class RegisterEasyCaching : IServiceRegistration
	{
		public void RegisterAppServices(IServiceCollection services, IConfiguration config)
		{
			services.AddEasyCaching(options =>
			{
				options.UseInMemory(opt =>
				{
					opt.EnableLogging = true;
				}, "m1");
			});
			services.TryAddSingleton<IEasyCachingKeyGenerator, CustomEasyCachingKeyGenerator>();
		}
	}
}
