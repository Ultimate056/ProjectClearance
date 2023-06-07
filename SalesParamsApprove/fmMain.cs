using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesParamsApprove.Database;

namespace SalesParamsApprove
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            fillgcSKU();
        }

        private void fillgcSKU()
        {
            try
            {
                string sql = @"select  spr_tm.tm_name as Brand, spr_tov.id_tov as idSKU, spr_tov.id_tov_oem as Art, spr_tov.n_tov as Ntov, sAdvancement.nAdvancement as SaleStatus
                                from spr_tov 
                                inner join spr_tm on spr_tov.id_tm = spr_tm.tm_id
                                inner join sAdvancement on spr_tov.idAdvancement = sAdvancement.idAdvancement
                                where sAdvancement.idAdvancement > 2
                                order by sAdvancement.idAdvancement ";

                gcSKU.DataSource = DBExecute.SelectTable(sql);
                //DataTable ds = DBExecute.SelectTable(sql);
                //gcSKU.DataSource = ds;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка заполнения SKU " + ex.Message);
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

            }

        }

        private void gvSKU_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            fillRightGreyData();
        }

        public void fillRightGreyData()
        {
            try
            {
                DataRow focusrow = gvSKU.GetFocusedDataRow();
                int idtov = Convert.ToInt32(focusrow["idSKU"]);
                string sql = $@"select * from [dbo].[uf_getValuesForClearance] ({idtov})";
                DataTable res = DBExecute.SelectTable(sql);
                textBoxCurRemain.Text = res.Rows[0]["rest"].ToString(); //Текущий остаток, шт
                textBoxCurDays.Text = res.Rows[0]["restdays"].ToString(); //Текущий остаток, дн:
                textBoxCurTemp.Text = res.Rows[0]["rateSales"].ToString(); //Текущий темп продаж
                textBoxHO.Text = res.Rows[0]["turnoverDays"].ToString(); //Норм.оборачиваемость, дней:
                textBoxMCMarket.Text = res.Rows[0]["priceMarket"].ToString(); //МЦ рынка

 
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка при заполнении полей: " +  ex.Message);
            }
        }
    }
}
