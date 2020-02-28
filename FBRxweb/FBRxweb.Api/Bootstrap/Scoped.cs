#region Namespace
using Microsoft.Extensions.DependencyInjection;
using FBRxweb.Infrastructure.Security;
using RxWeb.Core.Data;
using RxWeb.Core.Security;
using RxWeb.Core.Annotations;
using RxWeb.Core;
using FBRxweb.UnitOfWork.DbEntityAudit;
using FBRxweb.BoundedContext.Main;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Domain.FacebookUserModule;

 using FBRxweb.Domain.ViewOnlineUserModule;


            using FBRxweb.Domain.PostModule;
            using FBRxweb.Domain.FacebookChatModule;
            #endregion Namespace



namespace FBRxweb.Api.Bootstrap
{
    public static class ScopedExtension
    {

        public static void AddScopedService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRepositoryProvider, RepositoryProvider>();
            serviceCollection.AddScoped<ITokenAuthorizer, TokenAuthorizer>();
            serviceCollection.AddScoped<IModelValidation, ModelValidation>();
            serviceCollection.AddScoped<IAuditLog, AuditLog>();
            serviceCollection.AddScoped<IApplicationTokenProvider, ApplicationTokenProvider>();
            serviceCollection.AddScoped(typeof(IDbContextManager<>), typeof(DbContextManager<>));

            #region ContextService

            serviceCollection.AddScoped<ILoginContext, LoginContext>();
            serviceCollection.AddScoped<ILoginUow, LoginUow>();
                        serviceCollection.AddScoped<IFacebookUserContext, FacebookUserContext>();
            serviceCollection.AddScoped<IFacebookUserUow, FacebookUserUow>();
                       
                        serviceCollection.AddScoped<IUserChatContext, UserChatContext>();
            serviceCollection.AddScoped<IUserChatUow, UserChatUow>();
                        serviceCollection.AddScoped<IViewOnlineUserContext, ViewOnlineUserContext>();
            serviceCollection.AddScoped<IViewOnlineUserUow, ViewOnlineUserUow>();
                        serviceCollection.AddScoped<IPostContext, PostContext>();
            serviceCollection.AddScoped<IPostUow, PostUow>();
                        serviceCollection.AddScoped<IPostDetailContext, PostDetailContext>();
 
         
                        serviceCollection.AddScoped<IFacebookChatContext, FacebookChatContext>();
            serviceCollection.AddScoped<IFacebookChatUow, FacebookChatUow>();
            #endregion ContextService



              #region DomainService
   
            serviceCollection.AddScoped<IFacebookUserDomain, FacebookUserDomain>();
       
            serviceCollection.AddScoped<IvAllPostDomain, vAllPostDomain>();
            
            serviceCollection.AddScoped<IPostMediaDomain, PostMediaDomain>();
            
            serviceCollection.AddScoped<IPostMessageDomain, PostMessageDomain>();
            
            serviceCollection.AddScoped<IPostLikeDomain, PostLikeDomain>();
            
            serviceCollection.AddScoped<IPostCommentDomain, PostCommentDomain>();
            
            serviceCollection.AddScoped<IPostShareDomain, PostShareDomain>();
            
         
            serviceCollection.AddScoped<IChatMediaDomain, ChatMediaDomain>();
            
            serviceCollection.AddScoped<IChatMessageDomain, ChatMessageDomain>();
            
           
            
            serviceCollection.AddScoped<IvCheckLikeUserDomain, vCheckLikeUserDomain>();
            
            serviceCollection.AddScoped<IvCheckCommentUserDomain, vCheckCommentUserDomain>();
            
            serviceCollection.AddScoped<IvCheckShareUserDomain, vCheckShareUserDomain>();
            #endregion DomainService


















        }
    }
}

