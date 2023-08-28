using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class ProjectDAO
    {
        private List<Project> projectList = new List<Project>()
        {
            new Project()
            {
                Id = "P001",
                Name = "Project A",
                Description = "This is project A",
                EstimatedStartDate = DateTime.Now,
                EstimatedEndDate = DateTime.Parse("9/10/2023"),
                Contact = "01",
                EstimatedValue = 300,
                Address = "District 3",
                City = "HCM",
                Sponsor = "Sponsor A"
            },
            new Project()
            {
                Id = "P002",
                Name = "Project B",
                Description = "This is project B",
                EstimatedStartDate = DateTime.Now,
                EstimatedEndDate = DateTime.Parse("9/30/2023"),
                Contact = "02",
                EstimatedValue = 350,
                Address = "Binh Duong New City",
                City = "TDM",
                Sponsor = "Sponsor B"
            },
            new Project()
            {
                Id = "P003",
                Name = "Project C",
                Description = "This is project C",
                EstimatedStartDate = DateTime.Now,
                EstimatedEndDate = DateTime.Parse("9/29/2023"),
                Contact = "03",
                EstimatedValue = 500,
                Address = "District 1",
                City = "HCM",
                Sponsor = "Sponsor C"
            }
        };
        private ProjectDAO() { }
        private static readonly object instanceLock = new object();
        private static ProjectDAO instance;
        public static ProjectDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProjectDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Project> GetProjects() => projectList.OrderByDescending(p => p.Name).ToList();

        public void DeleteAProject(string projectId)
        {
            try
            {
                if (string.IsNullOrEmpty(projectId)) throw new Exception("Error!");
                Project deletedProject = projectList.FirstOrDefault(p => p.Id.Equals(projectId));
                if (deletedProject != null)
                {
                    projectList.Remove(deletedProject);
                }
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Project SearchProjectById(string projectId)
        {
            try
            {
                Project project = null;
                project = projectList.FirstOrDefault(p => p.Id.Equals(projectId));
                return project;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Project> SearchProjectsByName(string name)
        {
            try
            {
                List<Project> projects = null;
                projects = projectList.Where(p => p.Name.Contains(name)).OrderByDescending(p => p.Name).ToList();
                return projects;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Project> FilterProjectByCity(string city)
        {
            try
            {
                List<Project> projects = null;
                projects = projectList.Where(p => p.City.Equals(city)).OrderByDescending(p => p.Name).ToList();
                return projects;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AddAProject(Project project)
        {
            try
            {
                // validation of a project
                string pattern = @"^P\d{3}$"; // format of the project ID
                if (string.IsNullOrEmpty(project.Id)) throw new Exception("ID is required!");
                bool isValid = Regex.IsMatch(project.Id, pattern);
                if (isValid == false) throw new Exception("Format of the ID is Pxxx, x stands for a digit!"); 
                bool checkDuplicate = projectList.Any(p => p.Id == project.Id);
                if (checkDuplicate) throw new Exception("Duplicate of project ID!");
                if (string.IsNullOrEmpty(project.Name)) throw new Exception("Name is required!");
                if (string.IsNullOrEmpty(project.Description)) throw new Exception("Description is required!");
                if (string.IsNullOrEmpty(project.Contact)) throw new Exception("Contact is required!");
                if (string.IsNullOrEmpty(project.City)) throw new Exception("City is required!");
                if (string.IsNullOrEmpty(project.Address)) throw new Exception("Address is required!");
                if (string.IsNullOrEmpty(project.Sponsor)) throw new Exception("Sponsor is required!");
                if (project.EstimatedStartDate.CompareTo(project.EstimatedEndDate) >= 0)
                    throw new Exception("StartDate MUST be smaller than EndDate!");
                projectList.Add(project);
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateAProject(Project project)
        {
            try
            {
                if (string.IsNullOrEmpty(project.Name)) throw new Exception("Name is required!");
                if (string.IsNullOrEmpty(project.Description)) throw new Exception("Description is required!");
                if (string.IsNullOrEmpty(project.Contact)) throw new Exception("Contact is required!");
                if (string.IsNullOrEmpty(project.City)) throw new Exception("City is required!");
                if (string.IsNullOrEmpty(project.Address)) throw new Exception("Address is required!");
                if (string.IsNullOrEmpty(project.Sponsor)) throw new Exception("Sponsor is required!");
                if (project.EstimatedStartDate.CompareTo(project.EstimatedEndDate) >= 0)
                    throw new Exception("StartDate MUST be smaller than EndDate!");
                Project curProject = projectList.FirstOrDefault(p => p.Id.Equals(project.Id));
                if (curProject != null)
                {
                    var index = projectList.IndexOf(curProject);
                    projectList[index] = project;
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
