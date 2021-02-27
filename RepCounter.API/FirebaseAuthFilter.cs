using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepCounter.API
{
	public class FirebaseAuthFilter : AuthorizeAttribute, IAuthorizationFilter
	{
		public void OnAuthorization(AuthorizationFilterContext context)
		{
			if(context.HttpContext.Request.Headers.TryGetValue("Authorization", out StringValues token))
			{
				if (token.Count > 0)
				{
					string[] bearer = token[0].Split();
					if (bearer[0].Trim().ToLower() == "bearer")
					{
						var tokenString = bearer[1];
					}
				}
			}
		}
	}
}
