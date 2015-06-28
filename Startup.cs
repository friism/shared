using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.Runtime;
using Microsoft.AspNet.Hosting;
using Odachi.Security.BasicAuthentication;
using System.Security.Claims;
using Newtonsoft.Json.Serialization;

namespace Shared
{
	public class Startup
	{
		public IConfiguration Configuration { get; private set; }

		public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv)
		{
			Configuration = new Configuration(appEnv.ApplicationBasePath)
				.AddJsonFile("config.json")
				.AddEnvironmentVariables();
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
			services.ConfigureMvcJson(jsonOptions =>
				{
					jsonOptions.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
				});
		}

		public void Configure(IApplicationBuilder app)
		{
			app.UseBasicAuthentication(options =>
				{
					options.Realm = "Heroku";
					options.Authenticator = new GenericAuthenticator(
						(username, password) => {
							if (username == Configuration.Get("ADDON_USERNAME")
								&& password == Configuration.Get("ADDON_PASSWORD"))
							{
								return new ClaimsIdentity("Basic");
							}
							return null;
						}
					);
				}
			);

			app.UseMvc();
		}
	}
}
