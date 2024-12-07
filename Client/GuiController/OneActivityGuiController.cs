using Client.Forms;
using Client.UserControls;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class OneActivityGuiController
    {
        private Activity activity;
        //private Member member = new Member();
        //private MemberActivity memberActivity;

        private List<MemberActivity> assignedMembers = new List<MemberActivity>();
        private List<Member> allMembers = new List<Member>();

        private UCActivityDetails ucActivityDetails;
        private FrmMembersAll frmMembersAll;

        public OneActivityGuiController() { }

        

        public UserControl CreateUCActivityDetails(Activity selectedActivity)
        {
            this.activity = selectedActivity;
            //memberActivity = new MemberActivity();

            ucActivityDetails = new UCActivityDetails();

            ucActivityDetails.TxtNameActivity.Text = selectedActivity.Name;
            ucActivityDetails.TxtPlannedDuration.Text = selectedActivity.PlannedDuration.ToString();
            ucActivityDetails.TxtActualDuration.Text = selectedActivity.ActualDuration.ToString();
            ucActivityDetails.TxtPoints.Text = selectedActivity.Points.ToString();
            ucActivityDetails.TxtStatus.Text = selectedActivity.Status.ToString();

            HandleActivityStatus();     

            return ucActivityDetails;
        }

        private void HandleActivityStatus()
        {
            switch (activity.Status)
            {
                case StatusActivity.Unassigned:
                    ucActivityDetails.LblMember.Visible = false;
                    //ucActivityDetails.TxtMember.Visible = false;
                    ucActivityDetails.DgvAssignedMembers.Visible = false;
                    ucActivityDetails.BtnMA.Text = "Assign activity";
                    ucActivityDetails.BtnMA.Click += AssignActivity;
                    break;

                case StatusActivity.Assigned:
                    ucActivityDetails.LblMember.Visible = true;
                    GetActivityMembers();
                    //ucActivityDetails.TxtMember.Text = member.ToString();
                    ucActivityDetails.BtnMA.Text = "Complet activity";
                    ucActivityDetails.BtnMA.Click += CompletActivity;
                    break;

                case StatusActivity.Completed:
                    ucActivityDetails.LblMember.Visible = true;
                    GetActivityMembers();
                    //ucActivityDetails.TxtMember.Text = member.ToString();
                    ucActivityDetails.BtnMA.Visible = false;
                    break;

                default:
                    break;
            }
        }

        private void GetActivityMembers()
        {
            try
            {
                assignedMembers = Communication.Instance.GetActivityMembers(activity);

                List<Member> listMembers = new List<Member>();
                foreach (MemberActivity ma in assignedMembers)
                {
                    listMembers.Add(ma.Member);
                }
                ucActivityDetails.DgvAssignedMembers.DataSource = listMembers;

                InitDgvColumns(ucActivityDetails.DgvAssignedMembers);
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

        private void AssignActivity(object sender, EventArgs e)
        {
            frmMembersAll = new FrmMembersAll();

            InitDgvMembers();

            frmMembersAll.BtnSearch.Click += (s, a) =>
            {
                string criteria = frmMembersAll.TxtSearch.Text;
                InitDgvMembersSearch(criteria);
            };

            frmMembersAll.BtnViewAll.Click += (s, a) => InitDgvMembers();

            List<Member> selectedMembers = new List<Member>();
            frmMembersAll.TxtAdded.Text = "";

            frmMembersAll.BtnAdd.Click += (s, a) =>
            {
                if (allMembers.Count == 0)
                {
                    MessageBox.Show("Nothing to select!");
                    return;
                }

                Member selectedMember = (Member)frmMembersAll.DgvMembers.CurrentRow.DataBoundItem;
                selectedMembers.Add(selectedMember);
                frmMembersAll.TxtAdded.Text += selectedMember.ToString() + ", ";
            };


            frmMembersAll.BtnAssign.Click += (s, a) =>
            {
                if (selectedMembers.Count == 0)
                {
                    MessageBox.Show("Nothing selected!");
                    return;
                }

                SaveMemberActivity(selectedMembers);
            };

            frmMembersAll.ShowDialog();
        }

        private void SaveMemberActivity(List<Member> selectedMembers)
        {
            List<MemberActivity> listMemberActivity = new List<MemberActivity>();
            
            activity.Status = StatusActivity.Assigned;
            foreach (Member m in selectedMembers)
            {
                m.NumOfActivities += 1;

                listMemberActivity.Add(new MemberActivity
                {
                    Activity = activity,
                    Member = m,
                    Project = activity.Project,
                    DateAssigned = DateTime.Now,
                });
            }

            try
            {
                Communication.Instance.AssignMemberActivity(listMemberActivity);

                MessageBox.Show("Success!");
                frmMembersAll.Close();

                HandleActivityStatus();
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

        private void CompletActivity(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.OKCancel);
            if (dialogResult != DialogResult.OK)
            {
                return;
            }

            activity.Status = StatusActivity.Completed;
            foreach (MemberActivity ma in assignedMembers)
            {
                ma.Activity = activity;
                //ma.Member = member;
                ma.Member.Points += activity.Points;
            }

            try
            {
                Communication.Instance.CompletMemberActivity(assignedMembers);

                MessageBox.Show("Success!");

                HandleActivityStatus();
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

            //dgv.Columns["NumOfActivities"].Visible = false;
            dgv.Columns["YearOfStudy"].Visible = false;
            dgv.Columns["HoursOfWork"].Visible = false;
            //dgv.Columns["Points"].Visible = false;
            dgv.Columns["Password"].Visible = false;
            //dgv.Columns["Sector"].Visible = false;

            dgv.Columns["Id"].Visible = false;

            //dgv.AutoSize = true;
        }

        private void InitDgvMembers()
        {
            try
            {
                allMembers = Communication.Instance.GetAllMembers();
                frmMembersAll.DgvMembers.DataSource = allMembers;

                InitDgvColumns(frmMembersAll.DgvMembers);
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

        private void InitDgvMembersSearch(string criteria)
        {
            try
            {
                allMembers = Communication.Instance.GetMembersSearch(criteria);
                if (allMembers.Count == 0)
                {
                    MessageBox.Show("There is no member with this lastname!");
                }

                frmMembersAll.DgvMembers.DataSource = allMembers;
                InitDgvColumns(frmMembersAll.DgvMembers);
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

    }
}
