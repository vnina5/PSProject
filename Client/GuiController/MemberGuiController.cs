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
        public MemberGuiController() { }

        public Control CreateUCMember()
        {
            ucMember = new UCMemberView();

            try
            {
                BindingList<Member> members = Communication.Instance.GetAllMembers();
                ucMember.DgvMembers.DataSource = members;
                ucMember.DgvMembers.Columns["TableName"].Visible = false;
                ucMember.DgvMembers.Columns["Values"].Visible = false;
                ucMember.DgvMembers.Columns["Criteria"].Visible = false;
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

            //Member m = new Member
            //{
            //    FirstName = "Pera",
            //    LastName = "Peric",
            //    DateOfBirth = DateTime.Now,
            //    YearOfStudy = Year.II,
            //    Sector = new Sector
            //    {
            //        Name = "Dizajn"
            //    }
            //};

            ucMember.BtnAdd.Click += (s, a) => CreateFormMembar(FormMode.Add);
            ucMember.BtnDetails.Click += (s, a) => CreateFormMembar(FormMode.Details);
            ucMember.BtnUpdate.Click += (s, a) => CreateFormMembar(FormMode.Update);

            return ucMember;
        }

        private void CreateFormMembar(FormMode formMode)
        {
            frmMember = new FrmMemberDetails();

            try
            {
                frmMember.CmbSector.DataSource = Communication.Instance.GetAllSectors();
                frmMember.CmbYearOfStudy.DataSource = Enum.GetValues(typeof(Year));
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

            Member m = (Member)ucMember.DgvMembers.CurrentRow.DataBoundItem;

            switch (formMode)
            {
                case FormMode.Add:
                    frmMember.BtnSave.Text = "Add";
                    frmMember.BtnSave.Click += AddMember;
                    break;

                case FormMode.Details:
                    frmMember.TxtFirstname.Text = m.FirstName;
                    frmMember.TxtLastname.Text = m.LastName;
                    frmMember.DtpDateOfBirth.Value = m.DateOfBirth;
                    frmMember.CmbYearOfStudy.Text = m.YearOfStudy.ToString();
                    frmMember.CmbSector.Text = m.Sector.ToString();
                    frmMember.BtnSave.Text = "Ok";
                    frmMember.BtnSave.Click += OkMember;
                    break;

                case FormMode.Update:
                    frmMember.TxtFirstname.Text = m.FirstName;
                    frmMember.TxtLastname.Text = m.LastName;
                    frmMember.DtpDateOfBirth.Value = m.DateOfBirth;
                    frmMember.CmbYearOfStudy.Text = m.YearOfStudy.ToString();
                    frmMember.CmbSector.Text = m.Sector.ToString();
                    frmMember.BtnSave.Text = "Update";
                    frmMember.BtnSave.Click += UpdateMember;
                    break;

                default:
                    break;
            }

            frmMember.ShowDialog();
        }

        private void InitAddFormMember()
        {
            try
            {
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

            frmMember.CmbYearOfStudy.DataSource = Enum.GetValues(typeof(Year));

            frmMember.BtnSave.Text = "Add";
            frmMember.BtnSave.Click += AddMember;
        }

        private void InitDetailsFormMember(Member m)
        {
            frmMember.TxtFirstname.Text = m.FirstName;
            frmMember.TxtLastname.Text = m.LastName;
            frmMember.DtpDateOfBirth.Value = m.DateOfBirth;
            frmMember.CmbYearOfStudy.Text = m.YearOfStudy.ToString();
            frmMember.CmbSector.Text = m.Sector.ToString();

            frmMember.BtnSave.Text = "Ok";
            frmMember.BtnSave.Click += OkMember;
        }

        private void InitUpdateFormMember(Member m)
        {
            frmMember.CmbYearOfStudy.DataSource = Enum.GetValues(typeof(Year));

            frmMember.TxtFirstname.Text = m.FirstName;
            frmMember.TxtLastname.Text = m.LastName;
            frmMember.DtpDateOfBirth.Value = m.DateOfBirth;
            frmMember.CmbYearOfStudy.Text = m.YearOfStudy.ToString();
            frmMember.CmbSector.Text = m.Sector.ToString();

            frmMember.BtnSave.Text = "Update";
            frmMember.BtnSave.Click += UpdateMember;
        }

        private void AddMember(object sender, EventArgs e)
        {
            Member member = new Member
            {
                FirstName = frmMember.TxtFirstname.Text,
                LastName = frmMember.TxtLastname.Text,
                DateOfBirth = frmMember.DtpDateOfBirth.Value,
                YearOfStudy = (Year)frmMember.CmbYearOfStudy.SelectedItem,
                Sector = (Sector)frmMember.CmbSector.SelectedItem,
            };

            try
            {
                Communication.Instance.AddMember(member);
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

        private void UpdateMember(object sender, EventArgs e)
        {
            Member member = new Member
            {
                FirstName = frmMember.TxtFirstname.Text,
                LastName = frmMember.TxtLastname.Text,
                DateOfBirth = frmMember.DtpDateOfBirth.Value,
                YearOfStudy = (Year)frmMember.CmbYearOfStudy.SelectedItem,
                Sector = (Sector)frmMember.CmbSector.SelectedItem,
            };

            try
            {
                Communication.Instance.UpdateMember(member);

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
