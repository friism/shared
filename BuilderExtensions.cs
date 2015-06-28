using Microsoft.AspNet.Builder;

namespace Shared
{
	public static class BuilderExtensions
	{
		public static IApplicationBuilder UseKestrelWorkaround(this IApplicationBuilder app)
		{
			return app.UseMiddleware<KestrelWorkaround>();
		}
	}
}
