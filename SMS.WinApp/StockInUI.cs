using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using SMS.BLL;
using SMS.Models;

namespace SMS.WinApp
{
    public partial class StockInUI : Form
    {
        public StockInUI()
        {
            InitializeComponent();
        }
        Manager _manager = new Manager();
        CompanyManager _companyManager = new CompanyManager();
        StockInManager _stockInManager = new StockInManager();
        private int itemId;
        private void StockInUI_Load(object sender, EventArgs e)
        {
            companyBindingSource.DataSource = _manager.ComboDataTable(_companyManager.GetAllCompany());
            int companyId = Convert.ToInt32(companyCombo.SelectedValue);
            itemBindingSource.DataSource = _manager.ComboDataTable(_stockInManager.GetAllItem(companyId));
        }

        private void companyCombo_TextChanged(object sender, EventArgs e)
        {
            int companyId = Convert.ToInt32(companyCombo.SelectedValue);
            itemBindingSource.DataSource = _manager.ComboDataTable(_stockInManager.GetAllItem(companyId));
        }

        private void itemCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            itemId = Convert.ToInt32(itemCombo.SelectedValue);
            showReorderLevel.Text = _stockInManager.GetReorderLevel(itemId);
            showAvailableQuantity.Text = _stockInManager.GetAvailableQuantity(itemId);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Stock stockIn = new Stock();
                stockIn.CompanyId = Convert.ToInt32(companyCombo.SelectedValue);
                stockIn.ItemId = Convert.ToInt32(itemCombo.SelectedValue);
                stockIn.Quantity = Convert.ToInt32(quantityBox.Value);

               bool save = _stockInManager.SaveToStockIn(stockIn);
                _stockInManager.SaveItemQuantity(stockIn.Quantity, itemId);
                if (save)
                {
                    MessageBox.Show("Stock In " + quantityBox.Value + " " + itemCombo.Text);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
