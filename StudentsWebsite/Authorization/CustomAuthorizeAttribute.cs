using StudentsWebsite.Business.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace StudentsWebsite.Authorization
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        private Role[] allowedRoles;

        public CustomAuthorizeAttribute(params Role[] allowedRoles)
        {
            this.allowedRoles = allowedRoles;
        }

        public override async Task OnAuthorizationAsync(HttpActionContext actionContext, CancellationToken cancellationToken)
        {
            IAuthorizationService authorization = GetAuthorizationService(actionContext);
            string email = actionContext.RequestContext.Principal.Identity.Name;
            if (!await authorization.AuthorizeAsync(email, allowedRoles))
            {
                HandleUnauthorizedRequest(actionContext);
            }
        }

        private static IAuthorizationService GetAuthorizationService(HttpActionContext actionContext)
        {
            return (IAuthorizationService)actionContext.RequestContext
                .Configuration.DependencyResolver.GetService(typeof(IAuthorizationService));
        }
    }
}