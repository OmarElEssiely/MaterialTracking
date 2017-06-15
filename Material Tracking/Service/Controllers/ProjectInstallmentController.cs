using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MT.Application.ProjectInstallments.Commands.AddInstallment;
using MT.Application.ProjectInstallments.Commands.DeleteInstallment;
using MT.Application.ProjectInstallments.Commands.UpdateInstallment;
using MT.Application.ProjectInstallments.Queries;

namespace Service.Controllers
{
    public class ProjectInstallmentController : ApiController
    {
        #region Properties 
        private readonly IGetProjectInstallmentsQuery _projectInstallments;
        private readonly IUpdateInstallmentCommand _updateInstallment;
        private readonly IAddInstallmentCommand _addInstallment;
        private readonly IDeleteInstallmentCommand _deleteInstallment;
        #endregion

        #region Constructor
        public ProjectInstallmentController(
         IGetProjectInstallmentsQuery getProjectInstallments,
         IUpdateInstallmentCommand updateInstallment,
         IAddInstallmentCommand addInstallment,
         IDeleteInstallmentCommand deleteInstallment)
        {
            _projectInstallments = getProjectInstallments;
            _updateInstallment = updateInstallment;
            _addInstallment = addInstallment;
            _deleteInstallment = deleteInstallment;
        }
        #endregion

        #region GetAPIs

        // GET: api/Admin/5
        public IHttpActionResult Get(int id)
        {
            IHttpActionResult result = null;
            var installment = _projectInstallments.Execute(id);
            if (installment != null)
                result = Ok(installment);
            else
                result = NotFound();
            return result;
        }
        #endregion

        #region InsertAPI
        // POST: api/Admin
        public IHttpActionResult Post([FromBody]AddInstallmentModel installmentModel)
        {
            IHttpActionResult result = null;
            try
            {
                _addInstallment.Execute(installmentModel);
                result = Ok();
            }
            catch (Exception e)
            {
                result = NotFound();
            }
            return result;
        }


        #endregion

        #region UpdateAPI
        // PUT: api/Admin/5
        public IHttpActionResult Put([FromBody]UpdateInstallmentModel installmentModel)
        {
            IHttpActionResult result = null;
            try
            {
                _updateInstallment.Execute(installmentModel);
                result = Ok();
            }
            catch (Exception e)
            {
                result = NotFound();
            }
            return result;
        }
        #endregion

        #region DeleteAPI
        // DELETE: api/Admin/5
        public IHttpActionResult Delete(DeleteInstallmentModel installmentModel)
        {
            IHttpActionResult result = null;
            try
            {
                _deleteInstallment.Execute(installmentModel);
                result = Ok();
            }
            catch (Exception e)
            {
                result = NotFound();
            }
            return result;
        }
        #endregion
    }
}
