using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MT.Application.ProjectSubFolders.Commands.ChangePath;
using MT.Application.ProjectSubFolders.Queries;

namespace Service.Controllers
{
    public class ProjectSubFolderController : ApiController
    {
        #region Properties 
        private readonly IProjectSubFoldersQuery _projectSubFolders;
        private readonly IChangePathCommand _changePath;
        #endregion

        #region Constructor
        public ProjectSubFolderController(IProjectSubFoldersQuery projectSubFolders,
            IChangePathCommand changePath)
        {
            _projectSubFolders = projectSubFolders;
            _changePath = changePath;
        }
        #endregion

        #region GetAPI
        // GET: api/Admin
        public IHttpActionResult Get(int id)
        {
            IHttpActionResult result = null;
            var projectSubFolders = _projectSubFolders.Execute(id);
            if (projectSubFolders != null)
                result = Ok(projectSubFolders);
            else
                result = NotFound();
            return result;
        }
        #endregion

        #region UpdateAPI
        // PUT: api/Admin/5
        public IHttpActionResult Put([FromBody]ChangePathModel changePath)
        {
            IHttpActionResult result = null;
            try
            {
                _changePath.Execute(changePath);
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
