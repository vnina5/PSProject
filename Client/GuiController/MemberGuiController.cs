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

namespace Client.GuiController
{
    public class MemberGuiController
    {
        private UCMemberView ucMemberView;
        private FrmMemberAdd frmMemberAdd;

        private List<Member> members = new List<Member>();

        private Member selectedMember;

        private OneMemberGuiController oneMemberGuiController;

        public MemberGuiController() 
        {
            oneMemberGuiController = new OneMemberGuiController();
        }

        public void ChangePanel(UserControl uc, Panel pnl)
        {
            pnl.Controls.Clear();
            pnl.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.AutoSize = true;
            pnl.AutoSize = true;
            uc.Width = pnl.Width;
        }

        public UserControl CreateUCMember()
        {
            ucMemberView = new UCMemberView();

            InitDgvMembers();

            ucMemberView.BtnAdd.Click += (s, a) => CreateFormMembar(FormMode.Add);
            ucMemberView.BtnUpdate.Click += (s, a) => CreateFormMembar(FormMode.Update);

            ucMemberView.BtnDetails.Click += (s, a) =>
            {
                if (members.Count == 0)
                {
                    MessageBox.Show("Nothing to select!");
                    return;
                }

                selectedMember = (Member)ucMemberView.DgvMembers.CurrentRow.DataBoundItem;
                ChangePanel(oneMemberGuiController.CreateUCMemberDetails(selectedMember), ucMemberView.PnlMember);
            };

            ucMemberView.BtnSearch.Click += (s, a) =>
            {
                string criteria = ucMemberView.TxtSearch.Text;
                InitDgvMembersSearch(criteria);
            };

            ucMemberView.BtnViewAll.Click += (s, a) => InitDgvMembers();

            return ucMemberView;
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

            dgv.AutoSize = true;
        }

        private void InitDgvMembers()
        {
            try
            {
                members = Communication.Instance.GetAllMembers();
                ucMemberView.DgvMembers.DataSource = members;

                InitDgvColumns(ucMemberView.DgvMembers);
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
                members = Communication.Instance.GetMembersSearch(criteria);
                if (members.Count == 0)
                {
                    MessageBox.Show("There is not member with this lastname!");
                }

                ucMemberView.DgvMembers.DataSource = members;
                InitDgvColumns(ucMemberView.DgvMembers);
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

        private void CreateFormMembar(FormMode formMode)
        {
            frmMemberAdd = new FrmMemberAdd();

            try
            {
                frmMemberAdd.CmbSector.DataSource = Communication.Instance.GetAllSectors();
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

            frmMemberAdd.CmbYearOfStudy.DataSource = Enum.GetValues(typeof(Year));

            switch (formMode)
            {
                case FormMode.Add:
                    frmMemberAdd.BtnSave.Text = "Add";
                    frmMemberAdd.BtnSave.Click += AddMember;
                    break;

                case FormMode.Update:
                    if (members.Count == 0)
                    {
                        MessageBox.Show("Nothing to select!");
                        return;
                    }

                    selectedMember = (Member)ucMemberView.DgvMembers.CurrentRow.DataBoundItem;

                    frmMemberAdd.TxtFirstname.Text = selectedMember.FirstName;
                    frmMemberAdd.TxtLastname.Text = selectedMember.LastName;
                    frmMemberAdd.TxtEmail.Text = selectedMember.Email;
                    //frmMember.DtpDateOfBirth.Value = selectedMember.DateOfBirth;
                    frmMemberAdd.CmbYearOfStudy.Text = selectedMember.YearOfStudy.ToString();
                    frmMemberAdd.CmbSector.Text = selectedMember.Sector.ToString();

                    frmMemberAdd.BtnSave.Text = "Update";
                    frmMemberAdd.BtnSave.Click += UpdateMember;
                    break;

                default:
                    break;
            }

            frmMemberAdd.ShowDialog();
            InitDgvMembers();

        }

        private void AddMember(object sender, EventArgs e)
        {
            Member member = new Member
            {
                FirstName = frmMemberAdd.TxtFirstname.Text,
                LastName = frmMemberAdd.TxtLastname.Text,
                Email = frmMemberAdd.TxtEmail.Text,
                //DateOfBirth = frmMember.DtpDateOfBirth.Value,
                YearOfStudy = (Year)frmMemberAdd.CmbYearOfStudy.SelectedItem,
                Sector = (Sector)frmMemberAdd.CmbSector.SelectedItem,
            };

            try
            {
                Communication.Instance.AddMember(member);
                MessageBox.Show("Success!");
                frmMemberAdd.Close();
                members.Add(member);
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

        private void UpdateMember(object sender, EventArgs e)
        {
            selectedMember.FirstName = frmMemberAdd.TxtFirstname.Text;
            selectedMember.LastName = frmMemberAdd.TxtLastname.Text;
            selectedMember.Email = frmMemberAdd.TxtEmail.Text;
            //selectedMember.DateOfBirth = frmMember.DtpDateOfBirth.Value;
            selectedMember.YearOfStudy = (Year)frmMemberAdd.CmbYearOfStudy.SelectedItem;
            selectedMember.Sector = (Sector)frmMemberAdd.CmbSector.SelectedItem;

            try
            {
                Communication.Instance.UpdateMember(selectedMember);
                MessageBox.Show("Success!");
                frmMemberAdd.Close();
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

        //private void OkMember(object sender, EventArgs e)
        //{
        //    frmMemberAdd.Close();
        //}

    }
}
