﻿namespace Odachi.Security.BasicAuthentication
{
	/// <summary>
	/// Default values used by <see cref="BasicAuthenticationMiddleware"/> when not defined in <see cref="BasicAuthenticationOptions"/>.
	/// </summary>
	public static class BasicAuthenticationDefaults
	{
		/// <summary>
		/// The default realm used by basic authentication.
		/// </summary>
		public const string Realm = "Protected Area";
	}
}