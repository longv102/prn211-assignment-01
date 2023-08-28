using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IProjectRepo
    {
        public List<Project> GetProjects();

        public void DeleteAProject(string projectId);

        public Project SearchProjectById(string projectId);

        public List<Project> SearchProjectByName(string name);

        public List<Project> FilterProjectByCity(string city);

        public void AddAProject(Project project);

        public void UpdateAProject(Project project);
    }
}
