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

        private  async void fmMain_Load(object sender, EventArgs e)
        {
            fillgcSKU();
            await NewsAsync();
        }



        private void btnApprove_Click(object sender, EventArgs e)
        {

            SendApprove();
            
        }

        private void gvSKU_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            fillRightGreyData();
            fillRightWhiteData();
            CalcStepSale();
            CalcRequireTempSale();
        }
        
        private void textBoxDiscountMC_TextChanged(object sender, EventArgs e)
        {
            CalcStepSale();
        }
        
 

        private void textBoxMCSales_TextChanged(object sender, EventArgs e)
        {
            CalcStepSale();
        }

        private void textBoxPeriodA_TextChanged(object sender, EventArgs e)
        {
            CalcStepSale();
        }

        private void textBoxSaleDays_TextChanged(object sender, EventArgs e)
        {
            CalcStepSale();
            CalcRequireTempSale();
        }

        private void textBoxTargetDays_TextChanged(object sender, EventArgs e)
        {
            CalcStepSale();
            CalcRequireTempSale();
        }
    }
}
