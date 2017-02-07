using Sample.API.Models;
using Sample.API.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Sample.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AccountController : ApiController
    {

        private IAccountRepository _accountrepository;


        public AccountController(IAccountRepository accountRepository)
        {
            _accountrepository = accountRepository;
        }

        /// <summary>
        ///  Gets all user accounts.
        /// </summary>
        /// <returns>A collection containing the user accounts <see cref="UserAccount"/> instances for a given user.</returns>
        public async Task<IEnumerable<UserAccount>> Get()
        {
            IEnumerable<UserAccount> userAccounts = await _accountrepository.GetAll();
            return userAccounts;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<UserAccount> Get(int id)
        {
            UserAccount userAccount = await _accountrepository.GetUserAccount(id);
            return userAccount;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userAccount"></param>
        public async Task<IHttpActionResult> Post([FromBody]UserAccount userAccount)
        {
            if (userAccount == null)
            {
                return BadRequest();
            }

            try
            {
                // Add account for this user.
                var result = await _accountrepository.AddAsync(userAccount);
                return Ok(result);
            }
            catch (Exception ex)
            {
                string msg = string.Format(CultureInfo.CurrentCulture, ex.Message);
                //TODO : Log the detailed Error to persistant storage
                HttpResponseMessage error = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, msg);
                return ResponseMessage(error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userAccount"></param>
        public async Task<IHttpActionResult> Put(int id, [FromBody]UserAccount userAccount)
        {
            if (userAccount == null)
            {
                return BadRequest();
            }
            if (id != userAccount.Id)
            {
                return BadRequest();
            }

            try
            {
                var result = await _accountrepository.UpdateAsync(userAccount);
                return Ok(result);
            }
            catch (Exception ex)
            {
                string msg = string.Format(CultureInfo.CurrentCulture, ex.Message);
                HttpResponseMessage error = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, msg);
                return ResponseMessage(error);
            }
        }


        public IHttpActionResult Delete(int id)
        {
            try
            {
                 _accountrepository.Remove(id);
                return Ok();
            }
            catch (Exception ex)
            {
                string msg = string.Format(CultureInfo.CurrentCulture, ex.Message);
                HttpResponseMessage error = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, msg);
                return ResponseMessage(error);
            }
        }

    }
}
