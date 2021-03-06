﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebShop.Model.Models;
using WebShop.Service;

namespace WebShop.Web.Infrastructure.Core
{
    public class ApiControllerBase : ApiController
    {
        private IErrorService _errorService;
        public ApiControllerBase(IErrorService errorService)
        {
            this._errorService = errorService;
        }

        protected HttpResponseMessage CreateHttpResponse(HttpRequestMessage requestMessage, Func<HttpResponseMessage> func)
        {
            HttpResponseMessage response = null;
            try
            {
                response = func.Invoke();
            }
            catch(DbEntityValidationException ex)
            {
                foreach(var eve in ex.EntityValidationErrors)
                {
                    Trace.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\"");
                        foreach(var ve in eve.ValidationErrors)
                        {
                        Trace.WriteLine($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                        }
                }
                LogError(ex);
                response = requestMessage.CreateResponse(System.Net.HttpStatusCode.BadRequest, ex.Message);
            }
            catch(DbUpdateException dbEx)
            {
                LogError(dbEx);
                response = requestMessage.CreateResponse(System.Net.HttpStatusCode.BadRequest, dbEx.Message);
            }
            catch (Exception ex)
            {
                LogError(ex);
                response = requestMessage.CreateResponse(System.Net.HttpStatusCode.BadRequest, ex.Message);
            }
            return response;
        }
        private void LogError(Exception ex)
        {
            try
            {
                Error error = new Error();
                error.CreatedDate = DateTime.Now;
                error.Message = ex.Message;
                error.StackTrace = ex.StackTrace;
                _errorService.Create(error);
                _errorService.Save();
            }catch
            {

            }
        }
    }
}