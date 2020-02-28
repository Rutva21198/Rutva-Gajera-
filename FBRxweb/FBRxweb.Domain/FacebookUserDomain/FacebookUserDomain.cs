using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using FBRxweb.UnitOfWork.Main;
using FBRxweb.Models.Main;

namespace FBRxweb.Domain.FacebookUserModule
{
    public class FacebookUserDomain : IFacebookUserDomain
    {
        public FacebookUserDomain(IFacebookUserUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(FacebookUser parameters)
        {
          
           return await Uow.Repository<FacebookUser>().AllAsync();
            //throw new NotImplementedException();
        }

        public async Task<object> GetBy(FacebookUser parameters)
        {
            return await Uow.Repository<FacebookUser>().SingleOrDefaultAsync(t => t.Email == parameters.Email && t.Password == parameters.Password);
           // throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(FacebookUser entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(FacebookUser entity)
        {
           
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(FacebookUser entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(FacebookUser entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(FacebookUser parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(FacebookUser parameters)
        {
            throw new NotImplementedException();
        }

        public IFacebookUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IFacebookUserDomain : ICoreDomain<FacebookUser,FacebookUser> { }
}
