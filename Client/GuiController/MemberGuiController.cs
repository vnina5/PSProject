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
        private UCMemberView ucMember;
        private FrmMemberDetails frmMember;
        private List<Member> members = new List<Member>();

        private Member selectedMember;

        public MemberGuiController() { }

        public Control CreateUCMember()
        {
            ucMember = new UCMemberView();

            InitDgvMembers();

            ucMember.BtnAdd.Click += (s, a) => CreateFormMembar(FormMode.Add);
            ucMember.BtnDetails.Click += (s, a) => CreateFormMembar(FormMode.Details);
            ucMember.BtnUpdate.Click += (s, a) => CreateFormMembar(FormMode.Update);

            return ucMember;
        }

        private void InitDgvMembers()
        {
            try
            {
                members = Communication.Instance.GetAllMembers();
                ucMember.DgvMembers.DataSource = members;

                ucMember.DgvMembers.Columns["TableName"].Visible = false;
                ucMember.DgvMembers.Columns["InsertColumn"].Visible = false;
                ucMember.DgvMembers.Columns["InsertValues"].Visible = false;
                ucMember.DgvMembers.Columns["UpdateValues"].Visible = false;
                ucMember.DgvMembers.Columns["PrimaryKey"].Visible = false;
                ucMember.DgvMembers.Columns["ForeignKey"].Visible = false;
                ucMember.DgvMembers.Columns["ForeignKey2"].Visible = false;
                ucMember.DgvMembers.Columns["Criteria"].Visible = false;

                ucMember.AutoSize = true;
                ucMember.DgvMembers.AutoSize = true;

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
            frmMember = new FrmMemberDetails();

            try
            {
                frmMember.CmbYearOfStudy.DataSource = Enum.GetValues(typeof(Year));
                frmMember.CmbSector.DataSource = Communication.Instance.GetAllSectors();
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

            if (members.Count == 0)
            {
                selectedMember = null;
            }
            else
            {
                selectedMember = (Member)ucMember.DgvMembers.CurrentRow.DataBoundItem;
            }

            if (formMode != FormMode.Add)
            { 
                if (selectedMember != null)
                {
                    frmMember.TxtFirstname.Text = selectedMember.FirstName;
                    frmMember.TxtLastname.Text = selectedMember.LastName;
                    frmMember.TxtEmail.Text = selectedMember.Email;
                    //frmMember.DtpDateOfBirth.Value = selectedMember.DateOfBirth;
                    frmMember.CmbYearOfStudy.Text = selectedMember.YearOfStudy.ToString();
                    frmMember.CmbSector.Text = selectedMember.Sector.ToString();
                }
                else
                {
                    MessageBox.Show("Nothing is selected!");
                    return;
                }

            }

            switch (formMode)
            {
                case FormMode.Add:
                    frmMember.BtnSave.Text = "Add";
                    frmMember.BtnSave.Click += AddMember;
                    break;

                case FormMode.Details:
                    frmMember.BtnSave.Text = "Ok";
                    frmMember.BtnSave.Click += OkMember;
                    break;

                case FormMode.Update:
                    frmMember.BtnSave.Text = "Update";
                    frmMember.BtnSave.Click += UpdateMember;
                    break;

                default:
                    break;
            }

            frmMember.ShowDialog();
            InitDgvMembers();

        }

        private void AddMember(object sender, EventArgs e)
        {
            Member member = new Member
            {
                FirstName = frmMember.TxtFirstname.Text,
                LastName = frmMember.TxtLastname.Text,
                Email = frmMember.TxtEmail.Text,
                //DateOfBirth = frmMember.DtpDateOfBirth.Value,
                YearOfStudy = (Year)frmMember.CmbYearOfStudy.SelectedItem,
                Sector = (Sector)frmMember.CmbSector.SelectedItem,
            };

            try
            {
                Communication.Instance.AddMember(member);
                MessageBox.Show("Success!");
                frmMember.Close();
                members.Add(member);
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

        private void UpdateMember(object sender, EventArgs e)
        {
            selectedMember.FirstName = frmMember.TxtFirstname.Text;
            selectedMember.LastName = frmMember.TxtLastname.Text;
            selectedMember.Email = frmMember.TxtEmail.Text;
            //selectedMember.DateOfBirth = frmMember.DtpDateOfBirth.Value;
            selectedMember.YearOfStudy = (Year)frmMember.CmbYearOfStudy.SelectedItem;
            selectedMember.Sector = (Sector)frmMember.CmbSector.SelectedItem;

            try
            {
                Communication.Instance.UpdateMember(selectedMember);
                MessageBox.Show("Success!");
                frmMember.Close();
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

        private void OkMember(object sender, EventArgs e)
        {
            frmMember.Close();
        }

    }
}
