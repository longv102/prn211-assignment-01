using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementWinApp_VuLong
{
    public partial class frmProjectMgmt : Form
    {
        IProjectRepo _proRepo = new ProjectRepo();
        public frmProjectMgmt()
        {
            InitializeComponent();
        }

        private void LoadProjects()
        {
            try
            {
                BindingSource source = new BindingSource();
                source.DataSource = _proRepo.GetProjects();

                txtId.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtContact.DataBindings.Clear();
                txtEstValue.DataBindings.Clear();
                dtpEstStart.DataBindings.Clear();
                dtpEstEnd.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtSponsor.DataBindings.Clear();

                txtId.DataBindings.Add("Text", source, "Id");
                txtName.DataBindings.Add("Text", source, "Name");
                txtDescription.DataBindings.Add("Text", source, "Description");
                dtpEstStart.DataBindings.Add("Text", source, "EstimatedStartDate");
                dtpEstEnd.DataBindings.Add("Text", source, "EstimatedEndDate");
                txtContact.DataBindings.Add("Text", source, "Contact");
                txtEstValue.DataBindings.Add("Text", source, "EstimatedValue");
                txtAddress.DataBindings.Add("Text", source, "Address");
                txtCity.DataBindings.Add("Text", source, "City");
                txtSponsor.DataBindings.Add("Text", source, "Sponsor");

                dgvResult.DataSource = null;
                dgvResult.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load projects", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProjects(List<Project> list)
        {
            try
            {
                BindingSource source = new BindingSource();
                source.DataSource = list;

                txtId.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtContact.DataBindings.Clear();
                txtEstValue.DataBindings.Clear();
                dtpEstStart.DataBindings.Clear();
                dtpEstEnd.DataBindings.Clear();
                txtAddress.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtSponsor.DataBindings.Clear();

                txtId.DataBindings.Add("Text", source, "Id");
                txtName.DataBindings.Add("Text", source, "Name");
                txtDescription.DataBindings.Add("Text", source, "Description");
                dtpEstStart.DataBindings.Add("Text", source, "EstimatedStartDate");
                dtpEstEnd.DataBindings.Add("Text", source, "EstimatedEndDate");
                txtContact.DataBindings.Add("Text", source, "Contact");
                txtEstValue.DataBindings.Add("Text", source, "EstimatedValue");
                txtAddress.DataBindings.Add("Text", source, "Address");
                txtCity.DataBindings.Add("Text", source, "City");
                txtSponsor.DataBindings.Add("Text", source, "Sponsor");

                dgvResult.DataSource = null;
                dgvResult.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load projects", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCities()
        {
            try
            {
                BindingSource source = new BindingSource();
                source.DataSource = _proRepo.GetProjects().Select(p => p.City).Distinct().ToList();

                cboCity.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load cities", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmProjectMgmt_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            txtName.Enabled = false;
            txtDescription.Enabled = false;
            txtEstValue.Enabled = false;
            txtContact.Enabled = false;
            dtpEstStart.Enabled = false;
            dtpEstEnd.Enabled = false;
            txtAddress.Enabled = false;
            txtCity.Enabled = false;
            txtSponsor.Enabled = false;
            LoadCities();
            LoadProjects();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string projectId = txtId.Text.Trim();
                if (MessageBox.Show("Delete this project?", "Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _proRepo.DeleteAProject(projectId);
                    //LoadCities();
                    LoadProjects();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmProjectDetail frmProjectDetail = new frmProjectDetail()
            {
                IsUpdate = false,
            };
            frmProjectDetail.Show();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = txtSearch.Text.Trim();
                if (cbId.Checked)
                {
                    List<Project> result = new List<Project>();
                    Project project = _proRepo.SearchProjectById(searchValue);
                    result.Add(project);
                    if (result.Any())
                    {
                        //LoadCities();
                        LoadProjects(result);
                    }
                    else
                    {
                        MessageBox.Show("No record is matched!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (cbName.Checked)
                {
                    List<Project> result = _proRepo.SearchProjectByName(searchValue);
                    if (result.Any())
                    {
                        //LoadCities();
                        LoadProjects(result);
                    }
                    else
                    {
                        MessageBox.Show("No record is matched!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    //LoadCities();
                    LoadProjects();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboCity.DataSource != null)
                {
                    var city = cboCity.SelectedItem.ToString();
                    if (!string.IsNullOrEmpty(city))
                    {
                        List<Project> result = _proRepo.FilterProjectByCity(city);
                        if (result.Any())
                        {
                            LoadProjects(result);
                        }
                        else
                        {
                            MessageBox.Show("No record is matched!", "Filter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Filter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Project project = new Project()
                {
                    Id = txtId.Text,
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    Contact = txtContact.Text,
                    EstimatedValue = double.Parse(txtEstValue.Text),
                    EstimatedStartDate = (DateTime)dtpEstStart.Value,
                    EstimatedEndDate = (DateTime)dtpEstEnd.Value,
                    Address = txtAddress.Text,
                    City = txtCity.Text,
                    Sponsor = txtSponsor.Text,
                };
                frmProjectDetail frmProjectDetail = new frmProjectDetail()
                {
                    IsUpdate = true,
                    GetCurrentProject = project,
                };
                frmProjectDetail.Show();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
