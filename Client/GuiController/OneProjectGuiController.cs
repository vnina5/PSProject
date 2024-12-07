using Client.UserControls;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class OneProjectGuiController
    {
        private Project project;
        private UCProjectDetails ucProjectDetails;
        private BindingList<Activity> activities = new BindingList<Activity>();

        private OneActivityGuiController oneActivityGuiController;

        public OneProjectGuiController() 
        { 
            oneActivityGuiController = new OneActivityGuiController();
        }

        public UserControl CreateUCProjectDetails(Project selectedProject)
        {
            this.project = selectedProject;

            ucProjectDetails = new UCProjectDetails();

            ucProjectDetails.TxtName.Text = project.Name;
            ucProjectDetails.TxtDescription.Text = project.Description;
            ucProjectDetails.TxtDateStart.Text = project.DateStart.ToString();
            ucProjectDetails.TxtDateEnd.Text = project.DateEnd.ToString();
            ucProjectDetails.TxtDuration.Text = project.Duration.ToString();

            InitDgvActivities();

            ucProjectDetails.BtnDetailsActivity.Click += (s, a) =>
            {
                if (activities.Count == 0)
                {
                    MessageBox.Show("Nothing to select!");
                    return;
                }

                Activity selectedActivity = (Activity)ucProjectDetails.DgvActivities.CurrentRow.DataBoundItem;
                ChangePanel(oneActivityGuiController.CreateUCActivityDetails(selectedActivity), ucProjectDetails.PnlActivity);
            };

            ucProjectDetails.BtnViewAll.Click += (s, a) => InitDgvActivities();

            ucProjectDetails.CmbFilterActivity.DataSource = Enum.GetValues(typeof(StatusActivity));
            ucProjectDetails.BtnFilterActivity.Click += (s, a) =>
            {
                StatusActivity status = (StatusActivity)ucProjectDetails.CmbFilterActivity.SelectedItem;
                InitDgvActivitiesFilter(status);
            };


            HandleProgressOfProject();


            return ucProjectDetails;
        }

        private void HandleProgressOfProject()
        {
            ucProjectDetails.PbProject.Visible = true;
            ucProjectDetails.PbProject.Minimum = 0;
            ucProjectDetails.PbProject.Maximum = activities.Count;
            ucProjectDetails.PbProject.Value = 0;
            ucProjectDetails.PbProject.Step = 1;

            foreach (Activity a in activities)
            {
                if (a.Status == StatusActivity.Completed)
                {
                    ucProjectDetails.PbProject.PerformStep();
                }
            }
            
        }

        private void InitDgvActivitiesFilter(StatusActivity status)
        {
            try
            {
                activities = Communication.Instance.GetFilterActivitiesOfProject(status, project.Id);
                if (activities.Count == 0)
                {
                    MessageBox.Show($"There is no {status} activities!");
                }

                ucProjectDetails.DgvActivities.DataSource = activities;
                InitDgvColumns(ucProjectDetails.DgvActivities);
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

        private void InitDgvActivities()
        {
            try
            {
                activities = Communication.Instance.GetActivitiesOfProject(project.Id);

                ucProjectDetails.DgvActivities.DataSource = activities;
                InitDgvColumns(ucProjectDetails.DgvActivities);
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

            dgv.Columns["Project"].Visible = false;
            dgv.Columns["PlannedDuration"].Visible = false;
            dgv.Columns["ActualDuration"].Visible = false;

            dgv.Columns["Id"].Visible = false;

            dgv.AutoSize = true;
        }

        public void ChangePanel(UserControl uc, Panel pnl)
        {
            pnl.Controls.Clear();
            pnl.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.AutoSize = true;
            pnl.AutoSize = true;
        }

    }
}
