using Client.Forms;
using Client.UserControls;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Client.GuiController
{
    public class ProjectGuiController
    {
        private UCProjectView ucProjectView;
        private FrmProjectAdd frmProjectAdd;

        private List<Project> projects = new List<Project>();

        private Project selectedProject;

        private OneProjectGuiController oneProjectGuiController;

        public ProjectGuiController() 
        {
            oneProjectGuiController = new OneProjectGuiController();
        }

        private void InitDgvColumns(DataGridView dgv)
        {
            dgv.Columns["TableName"].Visible = false;
            dgv.Columns["InsertColumn"].Visible = false;
            dgv.Columns["InsertValues"].Visible = false;
            dgv.Columns["UpdateValues"].Visible = false;
            dgv.Columns["PrimaryKey"].Visible = false;
            dgv.Columns["ForeignKey"].Visible = false;
            dgv.Columns["ForeignKey2"].Visible = false;
            dgv.Columns["Criteria"].Visible = false;
            dgv.Columns["Search"].Visible = false;

            dgv.Columns["Id"].Visible = false;

            dgv.AutoSize = true;
        }

        private void InitDgvProjects()
        {
            try
            {
                projects = Communication.Instance.GetAllProjects();
                ucProjectView.DgvProjects.DataSource = projects;

                InitDgvColumns(ucProjectView.DgvProjects);
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong \n" + ex.Message);
            }
        }

        private void InitDgvProjectsSearch(string criteria)
        {
            try
            {
                projects = Communication.Instance.GetProjectsSearch(criteria);
                if (projects.Count == 0)
                {
                    MessageBox.Show("There is no project with this name!");
                }

                ucProjectView.DgvProjects.DataSource = projects;
                InitDgvColumns(ucProjectView.DgvProjects);
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong \n" + ex.Message);
            }
        }

        //private BindingList<Activity> InitDgvActivities()
        //{
        //    BindingList<Activity> a = new BindingList<Activity>();
        //    try
        //    {
        //        a = Communication.Instance.GetActivitiesOfProject(selectedProject.Id);
 
        //    }
        //    catch (SocketException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        Application.Exit();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    return a;
        //}

        public void ChangePanel(UserControl uc, Panel pnl)
        {
            pnl.Controls.Clear();
            pnl.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.AutoSize = true;
            pnl.AutoSize = true;
            uc.Width = pnl.Width;
        }

        public UserControl CreateUCProjectView()
        {
            ucProjectView = new UCProjectView();
            InitDgvProjects();
            ucProjectView.BtnAdd.Click += (s, a) => CreateFormProject(FormMode.Add);
            ucProjectView.BtnUpdate.Click += (s, a) => CreateFormProject(FormMode.Update);
            ucProjectView.BtnDetails.Click += (s, a) =>
            {
                if (projects.Count == 0)
                {
                    MessageBox.Show("Nothing to select!");
                    return;
                }
                selectedProject = (Project)ucProjectView.DgvProjects.CurrentRow.DataBoundItem;
                ChangePanel(oneProjectGuiController.CreateUCProjectDetails(selectedProject), ucProjectView.PnlProject);
            };
            ucProjectView.BtnSearch.Click += (s, a) =>
            {
                string criteria = ucProjectView.TxtSearch.Text;
                InitDgvProjectsSearch(criteria);
            };
            ucProjectView.BtnViewAll.Click += (s, a) => InitDgvProjects();
            return ucProjectView;
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
            InitDgvColumns(frmProjectAdd.DgvActivities);

            bool update = false;
            HandleActivities(activityList, update);
            

            switch (formMode)
            {
                case FormMode.Add:
                    frmProjectAdd.Text = "Add project";
                    frmProjectAdd.BtnSave.Click += (s, a) => AddProject(activityList);
                    break;

                case FormMode.Update:
                    if (projects.Count == 0)
                    {
                        MessageBox.Show("Nothing to select!");
                        return;
                    }

                    selectedProject = (Project)ucProjectView.DgvProjects.CurrentRow.DataBoundItem;

                    frmProjectAdd.TxtName.Text = selectedProject.Name;
                    frmProjectAdd.TxtDescription.Text = selectedProject.Description;
                    frmProjectAdd.DtpDateOfStart.Value = selectedProject.DateStart;
                    frmProjectAdd.DtpDateOfEnd.Value = selectedProject.DateEnd;
                    frmProjectAdd.GroupBox1.Visible = false;
                    //activityList = InitDgvActivities();

                    frmProjectAdd.Text = "Update project";
                    frmProjectAdd.BtnSave.Click += (s, a) => UpdateProject(activityList);
                    break;

                default:
                    break;
            }

            frmProjectAdd.ShowDialog();
            InitDgvProjects();
        }

        private void HandleActivities(BindingList<Activity> activityList, bool update)
        {
            Activity act = new Activity();
            int index = 0;

            frmProjectAdd.BtnCancle.Click += (s, a) =>
            {
                ClearActivity();
                update = false;
            };

            frmProjectAdd.BtnAddActivity.Click += (s, a) =>
            {
                if (string.IsNullOrEmpty(frmProjectAdd.TxtNameActivity.Text) || string.IsNullOrEmpty(frmProjectAdd.TxtDuration.Text) || string.IsNullOrEmpty(frmProjectAdd.TxtPoints.Text))
                {
                    if (string.IsNullOrEmpty(frmProjectAdd.TxtNameActivity.Text))
                    {
                        frmProjectAdd.TxtNameActivity.BackColor = Color.Salmon;
                    }
                    if (string.IsNullOrEmpty(frmProjectAdd.TxtDuration.Text))
                    {
                        frmProjectAdd.TxtDuration.BackColor = Color.Salmon;
                    }
                    if (string.IsNullOrEmpty(frmProjectAdd.TxtPoints.Text))
                    {
                        frmProjectAdd.TxtPoints.BackColor = Color.Salmon;
                    }

                    MessageBox.Show("Some field is empthy!");
                    return;
                }

                Activity activity = new Activity();

                activity.Name = frmProjectAdd.TxtNameActivity.Text;
                
                try
                {
                    activity.PlannedDuration = Int32.Parse(frmProjectAdd.TxtDuration.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Duration must be number!");
                    return;
                }

                try
                {
                    activity.Points = Int32.Parse(frmProjectAdd.TxtPoints.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Points must be number!");
                    return;
                }

                if (update)
                {
                    activityList.Remove(act);
                    activityList.Insert(index, activity);
                }
                else
                {
                    activityList.Add(activity);
                }

                ClearActivity();
                update = false;
            };

            frmProjectAdd.BtnUpdateActivity.Click += (s, a) =>
            {
                if (activityList.Count != 0)
                {
                    act = (Activity)frmProjectAdd.DgvActivities.CurrentRow.DataBoundItem;
                    index = frmProjectAdd.DgvActivities.CurrentRow.Index;

                    frmProjectAdd.TxtNameActivity.Text = act.Name;
                    frmProjectAdd.TxtDuration.Text = act.PlannedDuration.ToString();
                    frmProjectAdd.TxtPoints.Text = act.Points.ToString();

                    update = true;
                }
                else
                {
                    MessageBox.Show("Nothing to select!");
                }
            };

            frmProjectAdd.BtnDeleteActivity.Click += (s, a) =>
            {
                if (activityList.Count != 0)
                {
                    act = (Activity)frmProjectAdd.DgvActivities.CurrentRow.DataBoundItem;
                    activityList.Remove(act);
                }
                else
                {
                    MessageBox.Show("Nothing to select!");
                }
            };
        }

        private void ClearActivity()
        {
            frmProjectAdd.TxtNameActivity.Clear();
            frmProjectAdd.TxtDuration.Clear();
            frmProjectAdd.TxtPoints.Clear();

            frmProjectAdd.TxtNameActivity.BackColor = Color.White;
            frmProjectAdd.TxtDuration.BackColor = Color.White;
            frmProjectAdd.TxtPoints.BackColor = Color.White;
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

            if (string.IsNullOrEmpty(project.Name) || string.IsNullOrEmpty(project.Description))
            {
                if (string.IsNullOrEmpty(project.Name))
                {
                    frmProjectAdd.TxtName.BackColor = Color.Salmon;
                }
                if (string.IsNullOrEmpty(project.Description))
                {
                    frmProjectAdd.TxtDescription.BackColor = Color.Salmon;
                }

                MessageBox.Show("Some field is empthy!");
                return;
            }

            if (project.ActivityList.Count == 0)
            {
                MessageBox.Show("There are no activities!");
                return;
            }

            if (project.DateEnd < project.DateStart)
            {
                MessageBox.Show("Date of end must be after date of start!");
                return;
            }

            try
            {
                Communication.Instance.AddProject(project);
                MessageBox.Show("Project is successful added!");
                frmProjectAdd.Close();
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong \n" + ex.Message);
            }
        }

        private void UpdateProject(BindingList<Activity> activityList)
        {
            selectedProject.Name = frmProjectAdd.TxtName.Text;
            selectedProject.Description = frmProjectAdd.TxtDescription.Text;
            selectedProject.DateStart = frmProjectAdd.DtpDateOfStart.Value;
            selectedProject.DateEnd = frmProjectAdd.DtpDateOfEnd.Value;
            //selectedProject.ActivityList = activityList;

            if (string.IsNullOrEmpty(selectedProject.Name) || string.IsNullOrEmpty(selectedProject.Description))
            {
                if (string.IsNullOrEmpty(selectedProject.Name))
                {
                    frmProjectAdd.TxtName.BackColor = Color.Salmon;
                }
                if (string.IsNullOrEmpty(selectedProject.Description))
                {
                    frmProjectAdd.TxtDescription.BackColor = Color.Salmon;
                }

                MessageBox.Show("Some field is empthy!");
                return;
            }

            //if (selectedProject.ActivityList.Count == 0)
            //{
            //    MessageBox.Show("There are no activities!");
            //    return;
            //}

            if (selectedProject.DateEnd < selectedProject.DateStart)
            {
                MessageBox.Show("Date of end must be after date of start!");
                return;
            }

            try
            {
                Communication.Instance.UpdateProject(selectedProject);
                MessageBox.Show("Project is successful updated!");
                frmProjectAdd.Close();
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong \n" + ex.Message);
            }
        }

        //private void OkProject(object sender, EventArgs e)
        //{
        //    frmProjectAdd.Close();
        //}


    }
}
