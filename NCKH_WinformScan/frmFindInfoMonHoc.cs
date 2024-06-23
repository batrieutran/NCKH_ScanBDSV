using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCKH_WinformScan
{
    public partial class frmTransformPoin : Form
    {
        dbConnection db = new dbConnection();

        public frmTransformPoin()
        {
            InitializeComponent();
            txtHovaTen.TextChanged += (s, e) => CheckRequiredFields();
            txtMSSV.TextChanged += (s, e) => CheckRequiredFields();
            txtNoiSinh.TextChanged += (s, e) => CheckRequiredFields();
            txtDC.TextChanged += (s, e) => CheckRequiredFields();
            txtEmail.TextChanged += (s, e) => CheckRequiredFields();
            mtbPhone.TextChanged += (s, e) => CheckRequiredFields();

            CheckRequiredFields();
        }

        private void frmTransformPoin_Load(object sender, EventArgs e)
        {
            dtNgaysinh.CustomFormat = "dd/MM/yyyy";
            dtGridChuyenDiem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Welcome
            cbKHOld.Enabled = false;
            chlHPCC.Enabled = false;
            chlHPDH.Enabled = false;
            txtMaHPC.Enabled = false;
            txtHPC.Enabled = false;
            txtHPDH.Enabled = false;
            txtMaHPDH.Enabled = false;
            numDiemHPDH.Enabled = false;
           

            //Checklist Hoc Phan Da Hoc
            txtMaHPDH.ReadOnly = true;
            txtHPDH.ReadOnly = true;


            //Checklist Hoc Phan Chuyen
            txtMaHPC.ReadOnly = true;
            txtHPC.ReadOnly = true;
            chlHPCC.DataSource = db.getBang("HocPhan");
            chlHPCC.DisplayMember = "TenHP";
            chlHPCC.ValueMember = "MaHP";

            //Nghanh
            cbNghanh.DataSource = db.getBang("ChuyenNghanh");
            cbNghanh.DisplayMember = "TenNghanh";
            cbNghanh.ValueMember = "MaNghanh";

            //Khoa Moi
            cbKhoaHienTai.DataSource = db.KHMoi();
            cbKhoaHienTai.DisplayMember = "TenKH";
            cbKhoaHienTai.ValueMember = "TenKH";

        }


        private void CheckRequiredFields()
        {
            bool allFieldsFilled = !string.IsNullOrWhiteSpace(txtHovaTen.Text) &&
                                   !string.IsNullOrWhiteSpace(txtMSSV.Text) &&
                                   !string.IsNullOrWhiteSpace(txtNoiSinh.Text) &&
                                   !string.IsNullOrWhiteSpace(txtDC.Text) &&
                                   !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                                   !string.IsNullOrWhiteSpace(mtbPhone.Text);

            btnThemSVChuyenDiem.Enabled = allFieldsFilled;
        }

        private void chlHPDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chlHPDH.SelectedIndex != -1)
            {
                string maHP = ((DataRowView)chlHPDH.SelectedItem)["MaHP"].ToString();
                string tenHP = ((DataRowView)chlHPDH.SelectedItem)["TenHP"].ToString();
                txtMaHPDH.Text = maHP;
                txtHPDH.Text = tenHP;
            }
        }

        private void chlHPCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chlHPCC.SelectedIndex != -1)
            {
                string maHPC = ((DataRowView)chlHPCC.SelectedItem)["MaHP"].ToString();
                string tenHPC = ((DataRowView)chlHPCC.SelectedItem)["TenHP"].ToString();
                txtMaHPC.Text = maHPC;
                txtHPC.Text = tenHPC;
            }
        }

        private void chlHPDH_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Temporarily disable the event handler to avoid recursion
            chlHPCC.ItemCheck -= chlHPCC_ItemCheck;

            if (e.Index >= 0 && e.Index < chlHPCC.Items.Count)
            {
                chlHPCC.SetItemChecked(e.Index, e.NewValue == CheckState.Checked);

                if (chlHPCC.GetItemCheckState(e.Index) != e.NewValue)
                {
                    chlHPCC.SetItemChecked(e.Index, e.CurrentValue == CheckState.Checked);
                    MessageBox.Show("Please select another item, as the corresponding item in the other list was not updated.");
                }
                else if (e.NewValue == CheckState.Checked)
                {
                    string maHPC = ((DataRowView)chlHPCC.Items[e.Index])["MaHP"].ToString();
                    string tenHPC = ((DataRowView)chlHPCC.Items[e.Index])["TenHP"].ToString();
                    txtMaHPC.Text = maHPC;
                    txtHPC.Text = tenHPC;
                    
                }
            }
            else
            {
                e.NewValue = e.CurrentValue;
                DialogResult result = MessageBox.Show("Khóa hiện tại không có môn học này ?", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }

            // Re-enable the event handler
            chlHPCC.ItemCheck += chlHPCC_ItemCheck;
        }

        private void chlHPCC_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Temporarily disable the event handler to avoid recursion
            chlHPDH.ItemCheck -= chlHPDH_ItemCheck;

            if (e.Index >= 0 && e.Index < chlHPDH.Items.Count)
            {
                chlHPDH.SetItemChecked(e.Index, e.NewValue == CheckState.Checked);

                if (chlHPDH.GetItemCheckState(e.Index) != e.NewValue)
                {
                    chlHPDH.SetItemChecked(e.Index, e.CurrentValue == CheckState.Checked);
                }
            }
            else
            {
                e.NewValue = e.CurrentValue;
                DialogResult result = MessageBox.Show("Khóa hiện tại không có môn học này", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }

            // Re-enable the event handler
            chlHPDH.ItemCheck += chlHPDH_ItemCheck;
        }


        private void cbKhoaHienTai_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!cbKhoaHienTai.Text.Contains("System.Data"))
            {
                cbKHOld.DataSource = db.KHOld(cbKhoaHienTai.Text.ToString());
                cbKHOld.DisplayMember = "TenKH";
            }
            chlHPCC.DataSource = db.getInfoHP(cbKhoaHienTai.Text.ToString(), cbNghanh.SelectedValue.ToString());
            chlHPCC.DisplayMember = "TenHP";
            chlHPCC.ValueMember = "MaHP";
        }

        private void cbKHOld_SelectedValueChanged(object sender, EventArgs e)
        {
            chlHPDH.DataSource = db.getInfoHP(cbKHOld.Text.ToString(), cbNghanh.SelectedValue.ToString());
            chlHPDH.DisplayMember = "TenHP";
            chlHPDH.ValueMember = "MaHP";
        }

        private void cbNghanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbKhoaHienTai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbKHOld_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbNghanh_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThemSVChuyenDiem_Click(object sender, EventArgs e)
        {
            //Chuyển điểm
            cbKHOld.Enabled = true;
            chlHPCC.Enabled = true;
            chlHPDH.Enabled = true;
            txtMaHPC.Enabled = true;
            txtHPC.Enabled = true;
            txtHPDH.Enabled = true;
            txtMaHPDH.Enabled = true;
            numDiemHPDH.Enabled = true;

            //Ngược lại Form
            txtHovaTen.Enabled = false;
            txtMSSV.Enabled = false;
            dtNgaysinh.Enabled = false;
            cbLop.Enabled = false;
            cbNghanh.Enabled = false;
            cbKhoaHienTai.Enabled = false;
            txtNoiSinh.Enabled = false;
            txtDC.Enabled = false;
            txtEmail.Enabled = false;
            mtbPhone.Enabled = false;

            int ketQua = db.ThongTinSinhVien(txtMSSV.Text, txtHovaTen.Text, dtNgaysinh.Text, cbLop.Text, cbNghanh.Text, cbKhoaHienTai.Text, cbBac.Text, txtNoiSinh.Text, txtDC.Text, txtEmail.Text, mtbPhone.Text);
            if (ketQua >= 0)
            {
                MessageBox.Show("Thêm Thông Tin Sinh Viên Thành Công");
            }
            else
            {
                MessageBox.Show("Sinh Viên Đã Tồn Tại");
            }
        }

    }
}
