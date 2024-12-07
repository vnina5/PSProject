using Client.UserControls;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.GuiController
{
    public class OneMemberGuiController
    {
        private Member member;
        private List<Activity> memberActivities = new List<Activity>();

        private UCMemberDetails ucMemberDetails;

        public OneMemberGuiController() { }

        public UserControl CreateUCMemberDetails(Member selectedMember)
        {
            this.member = selectedMember;

            ucMemberDetails = new UCMemberDetails();

            ucMemberDetails.TxtFirstname.Text = member.FirstName;
            ucMemberDetails.TxtLastname.Text = member.LastName;
            ucMemberDetails.TxtEmail.Text = member.Email;
            ucMemberDetails.TxtYearOfStudy.Text = member.YearOfStudy.ToString();
            ucMemberDetails.TxtSector.Text = member.Sector.ToString();
            ucMemberDetails.TxtNumOfActivities.Text = member.NumOfActivities.ToString();
            ucMemberDetails.TxtHoursOfWork.Text = member.HoursOfWork.ToString();
            ucMemberDetails.TxtPoints.Text = member.Points.ToString();

            ucMemberDetails.DgvMemberActivities.Visible = false;

            ucMemberDetails.BtnViewActivities.Click += (s, a) =>
            {
                if (member.NumOfActivities == 0)
                {
                    MessageBox.Show($"{member.FirstName} {member.LastName} has not any activity.");
                    return;
                }

                InitDgvMemberActivities();
                ucMemberDetails.DgvMemberActivities.Visible = true;
            };
            

            return ucMemberDetails;
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
            //dgv.Columns[1].Visible = false;
            //dgv.Columns[7].Visible = false;
            //dgv.Columns[8].Visible = false;
            //dgv.Columns[9].Visible = false;

            dgv.Columns["Id"].Visible = false;

            dgv.AutoSize = true;
        }

        private void InitDgvMemberActivities()
        {
            try
            {
                memberActivities = Communication.Instance.GetMemberActivities(member);
                ucMemberDetails.DgvMemberActivities.DataSource = memberActivities;

                InitDgvColumns(ucMemberDetails.DgvMemberActivities);
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
