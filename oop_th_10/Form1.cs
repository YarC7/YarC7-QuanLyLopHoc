using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace oop_th_10
{
    public partial class FormQLLH : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter dap;

        DataSet ds;
        DataTable table = new DataTable();
        public FormQLLH()

        {
            InitializeComponent();

        }

        private void FormQLSP_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=CanhW13U;Initial Catalog=QuanLyLopHoc;Integrated Security=True";
            string sql = "SELECT * FROM SinhVien ";
            conn.Open();
            loaddata(sql);

        }
        private void loaddata(string sql)
        {
            ds = new DataSet();
            dap = new SqlDataAdapter(sql, conn);
            dap.Fill(ds);
            dgv_ketqua.DataSource = ds.Tables[0];




        }
        private void loadata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from SinhVien";
            cmd.ExecuteNonQuery();
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = cmd;
            table.Clear();
            dap.Fill(table);
            dgv_ketqua.DataSource = table;

        }
        private void HienChiTiet(Boolean hien)
        {

            btn_add.Enabled = hien;
            btn_edit.Enabled = hien;
        }
        public bool chayedit(Boolean hien)
        {

            
            
            return btn_add.Enabled = true;
        }


        private void btn_tk_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM SinhVien";
            string dk = "";
            if (txt_masv.Text.Trim() != "")
            {
                dk += "masv like '%" + txt_masv.Text + "%'";
            }
            if (dk != "")
            {
                sql += " WHERE " + dk;
            }
            loaddata(sql);
            btn_add.Enabled = true;
            btn_edit.Enabled = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_ketqua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_masv.ReadOnly = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            Form2 frm = new Form2();

            
            try
            {
                frm.Show();
                int i;
                i = dgv_ketqua.CurrentRow.Index;
                frm.txt_msv.Text = dgv_ketqua.Rows[i].Cells[0].Value.ToString();
                frm.txt_name.Text = dgv_ketqua.Rows[i].Cells[1].Value.ToString();               
                frm.gp_gt.Text = dgv_ketqua.Rows[i].Cells[2].Value.ToString();
                frm.txt_email.Text = dgv_ketqua.Rows[i].Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            




        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            

            if (MessageBox.Show("Bạn có chắc chắn xóa mã mặt hàng " + txt_masv.Text + " không? Nếu có ấn nút Lưu, không thì ấn nút Hủy", "Xóa sản phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from SinhVien where masv='" + txt_masv.Text + "'",conn);

                cmd.ExecuteNonQuery();

                loadata();


            }
        }



        private void btn_cancle_Click(object sender, EventArgs e)
        {

            btn_add.Enabled = true;
            btn_edit.Enabled = true;
        }

        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i=0; i<dgv_ketqua.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgv_ketqua.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgv_ketqua.Rows.Count; i++)
            {
                for (int j=0; j<dgv_ketqua.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgv_ketqua.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
        private void ImportExcel(string path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                for (int i = excelWorksheet.Dimension.Start.Column;i<=excelWorksheet.Dimension.End.Column;i++)
                {
                    dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());

                }
                for(int i= excelWorksheet.Dimension.Start.Row+1; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    List<string> listRows = new List<string>();
                    for (int j= excelWorksheet.Dimension.Start.Column;j<=excelWorksheet.Dimension.End.Column; j++)
                    {
                        listRows.Add(excelWorksheet.Cells[i, j].Value?.ToString());
                    }
                    dataTable.Rows.Add(listRows.ToArray());
                }
                dgv_ketqua.DataSource = dataTable;

            }
        }

        private void ex_exp_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx |Excel 2003 (*.xls)|*.xls ";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuat file thanh cong");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\n"+ex.Message);
                }
            }
        }
        private void ex_imp_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Title = "Import Excel";
            OpenFileDialog.Filter = "Excel (*.xlsx)|*.xlsx |Excel 2003 (*.xls)|*.xls ";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(OpenFileDialog.FileName);
                    MessageBox.Show("Nhap file thanh cong");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex.Message);
                }
            }

        }

        
    }
}
