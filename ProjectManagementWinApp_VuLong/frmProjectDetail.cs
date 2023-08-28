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
    public partial class frmProjectDetail : Form
    {
        IProjectRepo _proRepo = new ProjectRepo();
        public Project GetCurrentProject { get; set; }
        public bool IsUpdate { get; set; }
        public frmProjectDetail()
        {
            InitializeComponent();
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

        private void frmProjectDetail_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCities();
                btAdd.Visible = false;
                btUpdate.Visible = false;
                if (IsUpdate)
                {
                    txtId.Enabled = false;
                    btUpdate.Visible = IsUpdate;

                    txtId.Text = GetCurrentProject.Id;
                    txtName.Text = GetCurrentProject.Name;
                    txtDescription.Text = GetCurrentProject.Description;
                    txtContact.Text = GetCurrentProject.Contact;
                    txtEstValue.Text = GetCurrentProject.EstimatedValue.ToString();
                    dtpEstStart.Text = GetCurrentProject.EstimatedStartDate.ToString();
                    dtpEstEnd.Text = GetCurrentProject.EstimatedEndDate.ToString();
                    txtAddress.Text = GetCurrentProject.Address;
                    cboCity.Text = GetCurrentProject.City;
                    txtSponsor.Text = GetCurrentProject.Sponsor;
                }
                else
                {
                    btAdd.Visible = !IsUpdate;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Project project = new Project()
                {
                    Id = GetCurrentProject.Id,
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    EstimatedStartDate = (DateTime)dtpEstStart.Value,
                    EstimatedEndDate = (DateTime)dtpEstEnd.Value,
                    Contact = txtContact.Text,
                    EstimatedValue = double.Parse(txtEstValue.Text),
                    Address = txtAddress.Text,
                    City = cboCity.SelectedItem.ToString(),
                    Sponsor = txtSponsor.Text,
                };
                if (MessageBox.Show("Update this project", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    _proRepo.UpdateAProject(project);
                    MessageBox.Show("Update successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Project project = new Project()
                {
                    Id = txtId.Text,
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    EstimatedStartDate = (DateTime)dtpEstStart.Value,
                    EstimatedEndDate = (DateTime)dtpEstEnd.Value,
                    Contact = txtContact.Text,
                    EstimatedValue = double.Parse(txtEstValue.Text),
                    Address = txtAddress.Text,
                    City = cboCity.SelectedItem.ToString(),
                    Sponsor = txtSponsor.Text,
                };
                if (MessageBox.Show("Add this project", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    _proRepo.AddAProject(project);
                    MessageBox.Show("Add successfully!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
