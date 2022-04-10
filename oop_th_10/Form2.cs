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
namespace oop_th_10
{
    public partial class Form2 : Form

    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter dap;
        SqlCommand command;
        DataSet ds;
        DataTable table = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }
        public void loaddata(string sql)
        {
            ds = new DataSet();
            dap = new SqlDataAdapter(sql, conn);
            dap.Fill(ds);
            
            FormQLLH frm1 = new FormQLLH();
            frm1.btn_add.Enabled = false;


        }
        private void loadata()
        {
            command = conn.CreateCommand();
            command.CommandText = "Select * from SinhVien";
            SqlDataAdapter dap = new SqlDataAdapter();
            dap.SelectCommand = command;
            table.Clear();
            dap.Fill(table);
            FormQLLH form = new FormQLLH();
            form.btn_add.Enabled = false;
        }

        public  void btn_save_Click(object sender, EventArgs e)
        {
            
            FormQLLH form = new FormQLLH();
           
            string sql = "";
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            if (txt_msv.Text.Trim() == "")
            {
                error.SetError(txt_msv, "Bạn không để trống masv!");
                return;
            }
            else
            {
                error.Clear();
            }

            if (txt_name.Text.Trim() == "")
            {
                error.SetError(txt_name, "Bạn không để trống hoten!");
                return;
            }
            else
            {
                error.Clear();
            }
            
            if (txt_email.Text.Trim() == "")
            {
                error.SetError(txt_email, "Bạn không để trống email");
                return;
            }
            else
            {
                error.Clear();
            }
            if (rbt_nam.Checked) 
            {
                gp_gt.Text = "Nam";
            }
            else
            {
                gp_gt.Text = "Nu";
            }
            //edit click
            if (form.btn_edit.Enabled == true)
            {
                txt_msv.ReadOnly = true;
                txt_msv.Enabled = false;


                command = conn.CreateCommand();

                command.CommandText = "Update SinhVien SET hoten =N'" + txt_name.Text + "',gioitinh =N'" + gp_gt.Text + "',email =N'" + txt_email.Text + "'Where masv =N'" + txt_msv.Text + "' ";

                command.ExecuteNonQuery();
                loadata();

            }
            //add click
            if (form.chayedit(true))
            {

                //Kiểm tra xem ô nhập MaSP có bị trống không 
                if (txt_msv.Text.Trim() == "")
                {
                    error.SetError(txt_msv, "Bạn không để trống mã sản phẩm trường này!");
                    return;
                }
                else
                {
                    txt_msv.ReadOnly = true;
                    txt_msv.Enabled = false;
                    //Kiểm tra xem mã sản phẩm đã tồn tại chưa đẻ tránh việc insert mới bị lỗi 
                    sql = "Select Count(*) From SinhVien Where masv ='" + txt_msv.Text + "'";
                    cmd = new SqlCommand(sql, conn);

                    int? val = (int)cmd.ExecuteScalar();
                    if (val > 0)
                    {
                        error.SetError(txt_msv, "Mã sv trùng trong cơ sở dữ liệu");
                        return;
                    }
                    error.Clear();
                    sql = "INSERT INTO SinhVien(masv,hoten,gioitinh,email)VALUES (";
                    sql += "N'" + txt_msv.Text + "',N'" + txt_name.Text + "','" + gp_gt.Text + "','" + txt_email.Text + "')";
                    if (form.btn_edit.Enabled == true)
                    {

                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    //Cap nhat lai DataGrid
                    sql = "Select * from SinhVien";
                    loaddata(sql);
                    //dong ket noi
                    conn.Close();
                    //Ẩn hiện các nút phù hợp chức năng
                    }
                }
            }



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=CanhW13U;Initial Catalog=QuanLyLopHoc;Integrated Security=True";
            //string sql = "SELECT * FROM SinhVien ";
            //conn.Open();
            
        }
    }
}
