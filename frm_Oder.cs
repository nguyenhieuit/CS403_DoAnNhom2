using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DOANCDIO3_QL_Cafe
{
    public partial class frm_Oder : Form
    {
        lopdungchung ldc = new lopdungchung();
        BLL_Bill _Bill;
        private readonly int _idBan;
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\image\\anhmon\\";
        public frm_Oder(Form form, int IdBan)
        {
            InitializeComponent();
            this.MdiParent = form;
            this.StartPosition = FormStartPosition.Manual;
            _Bill = new BLL_Bill(this, IdBan);
            _idBan = IdBan;
        }
        
        public void loadDSMon()
        {
            //DS_Mon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            string sql = "select IDMon, TenMon, GiaDuKien, HinhAnh From  Mon";
            //DS_Mon.DataSource = ldc.loadbang(sql);
            //DS_Mon.Columns["HinhAnh"].Visible = false;
        }

        public void loadcbxMaKV()
        {
            string sql = "Select *From QLKhuVuc";
            //cbx_MaKV.DataSource = ldc.loadbang(sql);
            ///cbx_MaKV.DisplayMember = "TenKhuVuc";
            //cbx_MaKV.ValueMember = "MaKhuVuc";
        }

        public void loadcbxMaBan()
        {
            string sql = "Select *From QLBan";
            //cbx_MaBan.DataSource = ldc.loadbang(sql);
            ///cbx_MaBan.DisplayMember = "TenBan";
            //cbx_MaBan.ValueMember = "MaBan";
        }
        
        public void Load_dsoder()
        {
            string sql = "Select *From Oder_Mon";
            //DS_Oder.DataSource = ldc.loadbang(sql);
        }

        private void DS_Mon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txt_MaMon.Text = DS_Mon.CurrentRow.Cells["MaMon"].Value.ToString();
            //txt_TenMon.Text = DS_Mon.CurrentRow.Cells["TenMon"].Value.ToString();
            //txt_DonGia.Text = DS_Mon.CurrentRow.Cells["DonGia"].Value.ToString();
            //anhmon_Oder.Text = DS_Mon.CurrentRow.Cells["HinhAnh"].Value.ToString();
            //anhmon_Oder.ImageLocation = duongdan + anhmon_Oder.Text;
        }

        private void frm_Oder_Load(object sender, EventArgs e)
        {
            loadDSMon();
            loadcbxMaKV();
            loadcbxMaBan();
            Load_dsoder();
            
        }

        private void bt_ThanhToan_Click(object sender, EventArgs e)
        {
            _Bill.ThanhToanHD();
        }

        private void bt_XoaMon_Click(object sender, EventArgs e)
        {
            _Bill.XoaMon();
        }

       
    }
}
