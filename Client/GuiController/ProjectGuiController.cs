using Client.Forms;
using Client.UserControls;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Client.GuiController
{
    public class ProjectGuiController
    {
        private UCProjectView ucProjectView;
        private UCProjectDetails ucProjectDetails;
        private FrmProjectAdd frmProjectAdd;

        private UCActivityDetails ucActivityDetails;
        private UCActivityAdd ucActivityAdd;

        private List<Project> projects = new List<Project>();
        private BindingList<Activity> activities = new BindingList<Activity>();

        private Project selectedProject;
        private Activity selectedActivity;

        public ProjectGuiController() 
        { 
        
        }

        public Control CreateUCProjectView()
        {
            ucProjectView = new UCProjectView();

            InitDgvProject();

            ucProjectView.BtnAdd.Click += (s, a) => CreateFormProject(FormMode.Add);
            ucProjectView.BtnUpdate.Click += (s, a) => CreateFormProject(FormMode.Update);

            ucProjectView.BtnDetails.Click += (s, a) => CreateUCProjectDetails();


            return ucProjectView;
        }

        private void CreateUCProjectDetails()
        {
            if (projects.Count == 0)
            {
                MessageBox.Show("Nothing is selected!");
                return;
            }
            
            ucProjectDetails = new UCProjectDetails();

            selectedProject = (Project)ucProjectView.DgvProjects.CurrentRow.DataBoundItem;

            ucProjectDetails.TxtName.Text = selectedProject.Name;
            ucProjectDetails.TxtDescription.Text = selectedProject.Description;
            ucProjectDetails.TxtDateStart.Text = selectedProject.Description.ToString();
            ucProjectDetails.TxtDateEnd.Text = selectedProject.Description.ToString();
            ucProjectDetails.TxtDuration.Text = selectedProject.Duration.ToString();

            try
            {
                activities = Communication.Instance.GetActivitiesOfProject(selectedProject.Id);
                ucProjectDetails.DgvActivities.DataSource = activities;
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ucProjectDetails.Dock = DockStyle.Fill;
            ucProjectDetails.AutoSize = true;

            ucProjectView.PnlProject.Controls.Clear();
            ucProjectView.PnlProject.Controls.Add(ucProjectDetails);


        }

        private void InitDgvProject()
        {
            try
            {
                projects = Communication.Instance.GetAllProjects();
                ucProjectView.DgvProjects.DataSource = projects;

                ucProjectView.DgvProjects.Columns["TableName"].Visible = false;
                ucProjectView.DgvProjects.Columns["InsertColumn"].Visible = false;
                ucProjectView.DgvProjects.Columns["InsertValues"].Visible = false;
                ucProjectView.DgvProjects.Columns["UpdateValues"].Visible = false;
                ucProjectView.DgvProjects.Columns["PrimaryKey"].Visible = false;
                ucProjectView.DgvProjects.Columns["ForeignKey"].Visible = false;
                ucProjectView.DgvProjects.Columns["ForeignKey2"].Visible = false;
                ucProjectView.DgvProjects.Columns["Criteria"].Visible = false;

                ucProjectView.AutoSize = true;
                ucProjectView.DgvProjects.AutoSize = true;
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateFormProject(FormMode formMode)
        {
            frmProjectAdd = new FrmProjectAdd();

            BindingList<Activity> activityList = new BindingList<Activity>();
            frmProjectAdd.DgvActivities.DataSource = activityList;

            frmProjectAdd.DgvActivities.Columns[0].Visible = false;
            frmProjectAdd.DgvActivities.Columns[1].Visible = false;
            frmProjectAdd.DgvActivities.Columns[4].Visible = false;
            frmProjectAdd.DgvActivities.Columns[6].Visible = false;
            frmProjectAdd.DgvActivities.Columns[7].Visible = false;
            frmProjectAdd.DgvActivities.Columns[8].Visible = false;
            frmProjectAdd.DgvActivities.Columns[9].Visible = false;
            frmProjectAdd.DgvActivities.Columns[10].Visible = false;
            frmProjectAdd.DgvActivities.Columns[11].Visible = false;
            frmProjectAdd.DgvActivities.Columns[12].Visible = false;
            frmProjectAdd.DgvActivities.Columns[13].Visible = false;
            frmProjectAdd.DgvActivities.Columns[14].Visible = false;

            frmProjectAdd.BtnAddActivity.Click += (s, a) => CreateUCActivityAdd(activityList);
            frmProjectAdd.BtnDeleteActivity.Click += (s, a) =>
            {
                if (activityList.Count != 0)
                {
                    Activity act = (Activity)frmProjectAdd.DgvActivities.CurrentRow.DataBoundItem;
                    activityList.Remove(act);
                }
                else
                {
                    MessageBox.Show("Nothing is selected!");
                }
            };


            //selectedProject = (Project)ucProject.DgvProjects.CurrentRow.DataBoundItem;

            //if (formMode != FormMode.Add)
            //{
            //    frmProject.TxtName.Text = selectedProject.Name;
            //    frmProject.DtpDateOfStart.Value = selectedProject.DateStart;
            //    frmProject.DtpDateOfEnd.Value = selectedProject.DateEnd;
            //    frmProject.DgvActivities.DataSource = selectedProject.ActivityList;
            //}

            switch (formMode)
            {
                case FormMode.Add:
                    frmProjectAdd.BtnSave.Text = "Add";
                    frmProjectAdd.BtnSave.Click += (s, a) => AddProject(activityList);
                    break;

                case FormMode.Update:
                    frmProjectAdd.BtnSave.Text = "Update";
                    frmProjectAdd.BtnSave.Click += UpdateProject;
                    break;

                default:
                    break;
            }

            frmProjectAdd.ShowDialog();
            InitDgvProject();

        }

        private void CreateUCActivityAdd(BindingList<Activity> activityList)
        {
            ucActivityAdd = new UCActivityAdd();
            ucActivityAdd.BtnAdd.Click += (s, a) =>
            {
                Activity activity = new Activity
                {
                    Name = ucActivityAdd.TxtNameActivity.Text,
                    //Description = ucActivityAdd.TxtDescription.Text,
                    PlannedDuration = Int32.Parse(ucActivityAdd.TxtDuration.Text),
                    Points = Int32.Parse(ucActivityAdd.TxtPoints.Text),
                };

                activityList.Add(activity);

            };


            frmProjectAdd.PnlActivity.Controls.Clear();
            frmProjectAdd.PnlActivity.Controls.Add(ucActivityAdd);

            ucActivityAdd.Dock = DockStyle.Fill;
            ucActivityAdd.AutoSize = true;

        }

        private void AddActivityOnProject(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddProject(BindingList<Activity> activityList)
        {
            Project project = new Project
            {
                Name = frmProjectAdd.TxtName.Text,
                Description = frmProjectAdd.TxtDescription.Text,
                DateStart = frmProjectAdd.DtpDateOfStart.Value,
                DateEnd = frmProjectAdd.DtpDateOfEnd.Value,
                ActivityList = activityList,
            };

            try
            {
                Communication.Instance.AddProject(project);
                MessageBox.Show("Success!");
                frmProjectAdd.Close();
                projects.Add(project);
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateProject(object sender, EventArgs e)
        {
            selectedProject.Name = frmProjectAdd.TxtName.Text;
            selectedProject.DateStart = frmProjectAdd.DtpDateOfStart.Value;
            selectedProject.DateEnd = frmProjectAdd.DtpDateOfEnd.Value;
            selectedProject.ActivityList = (BindingList<Activity>)frmProjectAdd.DgvActivities.DataSource;

            try
            {
                Communication.Instance.UpdateProject(selectedProject);
                MessageBox.Show("Success!");
                frmProjectAdd.Close();
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OkProject(object sender, EventArgs e)
        {
            frmProjectAdd.Close();
        }

    }
}
