using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using MT.Application.ProjectFolders.Queries.GetFoldersList;

namespace Service.Controllers
{
    public class ProjectFolderController : ApiController
    {

        #region Properties 
        private readonly IGetProjectFoldersQuery _getProjectFolders;
  
        #endregion

        #region Constructor
        public ProjectFolderController(IGetProjectFoldersQuery getProjectFolders)
        {
            _getProjectFolders = getProjectFolders;
        }
        #endregion

        #region GetAPI
        // GET: api/Admin
        public IHttpActionResult Get()
        {
            IHttpActionResult result = null;
            var projectFolders = _getProjectFolders.Execute();
            if (projectFolders != null)
                result = Ok(projectFolders);
            else
                result = NotFound();
            return result;
        }
        #endregion
    }
}