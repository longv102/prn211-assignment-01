using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProjectRepo : IProjectRepo
    {
        public void AddAProject(Project project) => ProjectDAO.Instance.AddAProject(project);

        public void DeleteAProject(string projectId) => ProjectDAO.Instance.DeleteAProject(projectId);

        public List<Project> FilterProjectByCity(string city) => ProjectDAO.Instance.FilterProjectByCity(city);

        public List<Project> GetProjects() => ProjectDAO.Instance.GetProjects();

        public Project SearchProjectById(string projectId) => ProjectDAO.Instance.SearchProjectById(projectId);

        public List<Project> SearchProjectByName(string name) => ProjectDAO.Instance.SearchProjectsByName(name);

        public void UpdateAProject(Project project) => ProjectDAO.Instance.UpdateAProject(project);
    }
}
