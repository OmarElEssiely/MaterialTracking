using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Application.Projects.Commands.CreateProject;
using Application.Projects.Commands.DeleteProject;
using Application.Projects.Commands.UpdateProject;
using Application.Projects.Queries.GetProjectList;
using MT.Application.Projects.Queries.GetProjectById;

namespace Service.Controllers
{
    public class ProjectController : ApiController
    {
        #region Properties 
        private readonly IGetProjectListQuery _getProjectListQuery;
        private readonly IGetProjectByIdQuery _getProjectById;
        private readonly IUpdateProjectCommand _updateProjectCommand;
        private readonly ICreateProjectCommand _createProjectCommand;
        private readonly IDeleteProjectCommand _deleteProjectCommand;
        #endregion

        #region Constructor
        public ProjectController(
         IGetProjectListQuery getProjectListQuery,
         IGetProjectByIdQuery getProjectById,
         IUpdateProjectCommand updateProjectCommand,
         ICreateProjectCommand createProjectCommand,
         IDeleteProjectCommand deleteProjectCommand)
        {
            _getProjectListQuery = getProjectListQuery;
            _getProjectById = getProjectById;
            _updateProjectCommand = updateProjectCommand;
            _createProjectCommand = createProjectCommand;
            _deleteProjectCommand = deleteProjectCommand;
        }
        #endregion

        #region GetAPIs

        // GET: api/Admin
        public IHttpActionResult Get()
        {
            IHttpActionResult result = null;
            var projectList = _getProjectListQuery.Execute();
            if (projectList != null)
                result = Ok(projectList);
            else
                result = NotFound();
            return result;
        }

        // GET: api/Admin/5
        public IHttpActionResult Get(int id)
        {
            IHttpActionResult result = null;
            var project = _getProjectById.Execute(id);
            if (project != null)
                result = Ok(project);
            else
                result = NotFound();
            return result;
        }
        #endregion

        #region InsertAPI
        // POST: api/Admin
        public IHttpActionResult Post([FromBody]CreateProjectModel createProjectModel)
        {
            IHttpActionResult result = null;
            try
            {
               int id= _createProjectCommand.Execute(createProjectModel);
                result = Ok(id);
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
        public IHttpActionResult Put([FromBody]UpdateProjectModel updateProjectModel)
        {
            IHttpActionResult result = null;
            try
            {
                _updateProjectCommand.Execute(updateProjectModel);
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
        public IHttpActionResult Delete(int id)
        {
            IHttpActionResult result = null;
            try
            {
                _deleteProjectCommand.Execute(id);
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
