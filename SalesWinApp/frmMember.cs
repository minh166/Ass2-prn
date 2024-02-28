using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmMember : Form
    {
        int memberId = 0;
        String type = "";
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        public frmMember()
        {
            InitializeComponent();
        }

        public frmMember(String accountType)
        {
            type = accountType;
            InitializeComponent();
            if (!accountType.Equals("admin@fstore.com"))
            {
                btnAddNew.Hide();
                btnDelete.Hide();
            }
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            if (type == "admin@fstore.com")
            {
                loadMember();
            }
            else
            {
                loadAccount();
            }
        }

        private void loadAccount()
        {
            var listMember = memberRepository.getListAccount(type);
            try
            {
                source = new BindingSource();
                source.DataSource = listMember;
                dgvMember.DataSource = listMember;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member list");
                throw;
            }
        }

        private void loadMember()
        {
            var listMember = memberRepository.getMembers();
            try
            {
                source = new BindingSource();
                source.DataSource = listMember;
                dgvMember.DataSource = listMember;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member list");
                throw;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            int memberId = 0;
            String Email = "";
            String companyName = "";
            String City = "";
            String Country = "";
            String Password = "";
            try
            {
                memberId = Convert.ToInt32(txtMemberID.Text);
                Email = txtEmail.Text;
                companyName = txtCompany.Text;
                City = txtCity.Text;
                Country = txtCountry.Text;
                Password = txtPassword.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid information!");
                return;
            }

            MemberObject member = new MemberObject();
            member.MemberId = memberId;
            member.Email = Email;
            member.CompanyName = companyName;
            member.City = City;
            member.County = Country;
            member.Password = Password;

            memberRepository.addNewMember(member);
            loadMember();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int memberId = Convert.ToInt32(txtMemberID.Text);
            memberRepository.deleteMember(memberId);
            txtMemberID.Text = "";
            txtEmail.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            txtCompany.Text = "";
            txtPassword.Text = "";

            loadMember();
        }

        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            memberId = Convert.ToInt32(dgvMember.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
            txtMemberID.Text = dgvMember.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtEmail.Text = dgvMember.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtCompany.Text = dgvMember.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtCity.Text = dgvMember.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtCountry.Text = dgvMember.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtPassword.Text = dgvMember.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String Email = "";
            String companyName = "";
            String City = "";
            String Country = "";
            String Password = "";
            try
            {
                Email = txtEmail.Text;
                companyName = txtCompany.Text;
                City = txtCity.Text;
                Country = txtCountry.Text;
                Password = txtPassword.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid information!");
                return;
            }

            MemberObject member = new MemberObject();
            member.MemberId = memberId;
            member.Email = Email;
            member.CompanyName = companyName;
            member.City = City;
            member.County = Country;
            member.Password = Password;

            memberRepository.updateMember(member);
            txtMemberID.Text = "";
            txtEmail.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            txtCompany.Text = "";
            txtPassword.Text = "";
            if (type == "admin@fstore.com")
            {
                loadMember();
            }
            else
            {
                loadAccount();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frmMain = new frmMain(type);
            frmMain.Show();
        }
    }
}
