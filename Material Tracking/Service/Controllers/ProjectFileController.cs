using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MT.Application.ProjectFiles.Commands.UploadProjectFiles;
using MT.Application.ProjectFiles.Queries.GetProjectFilesList;

namespace Service.Controllers
{
    public class ProjectFileController : ApiController
    {
        #region Properties 
        private readonly IGetProjectFilesQuery _projectFilesQuery;
        private readonly IUploadProjectFileCommand _uploadProjectFile;
        #endregion

        #region Constructor
        public ProjectFileController(
         IGetProjectFilesQuery projectFilesQuery,
         IUploadProjectFileCommand uploadProjectFile)
        {
            _projectFilesQuery = projectFilesQuery;
            _uploadProjectFile = uploadProjectFile;
        }
        #endregion

        #region GetAPI
        public IHttpActionResult Get(int id, int projectSubFolderId)
        {
            IHttpActionResult result = null;
            var projectFiles = _projectFilesQuery.Execute(id,projectSubFolderId);
            if (projectFiles != null)
                result = Ok(projectFiles);
            else
                result = NotFound();
            return result;
        }
        #endregion

        #region UploadAPI
        public IHttpActionResult Post([FromBody]UploadProjectFileModel projectFileModel)
        {
            IHttpActionResult result = null;
            try
            {
                _uploadProjectFile.Execute(projectFileModel);
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
