using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.BLL;
using SMS.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SMS.WinApp
{
    public partial class StockOutUI : Form
    {
        public StockOutUI()
        {
            InitializeComponent();
        }
        Manager _manager = new Manager();
        CompanyManager _companyManager = new CompanyManager();
        StockInManager _stockInManager = new StockInManager();
        StockOutManager _stockOutManager = new StockOutManager();
        UiModel model = new UiModel();
        Stock _stock = new Stock();
        private int _itemId;

        private void StockOutUI_Load(object sender, EventArgs e)
        {
            companyBindingSource.DataSource = _manager.ComboDataTable(_companyManager.GetAllCompany());
            int companyId = Convert.ToInt32(companyCombo.SelectedValue);
            itemBindingSource.DataSource = _manager.ComboDataTable(_stockInManager.GetAllItem(companyId));
            _stockOutManager.CreateItemTable();
            addItemDataGrid.DataSource = _stockOutManager.GetItemTable();
            addItemDataGrid.Hide();
            sellButton.Hide();
            damageButton.Hide();
            lostButton.Hide();
        }
        private void companyCombo_TextChanged(object sender, EventArgs e)
        {
            int companyId = Convert.ToInt32(companyCombo.SelectedValue);
            itemBindingSource.DataSource = _manager.ComboDataTable(_stockInManager.GetAllItem(companyId));
            quantityBox.Text = "0";
        }

        private void itemCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            _itemId = Convert.ToInt32(itemCombo.SelectedValue);
            showReorderLevel.Text = _stockInManager.GetReorderLevel(_itemId);
            showAvailableQuantity.Text = _stockInManager.GetAvailableQuantity(_itemId);
            quantityBox.Text = "0";

            if (_stockOutManager.NotAvailable(_itemId))
            {
                notAvailableMsgLabel.Text = "Available quantity is under Reorder level";
                addButton.Hide();
            }
            else
            {
                addButton.Show();
                notAvailableMsgLabel.Text = "";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                    Item item = new Item();
                    item.CompanyId = Convert.ToInt32(companyCombo.SelectedValue);
                    item.CompanyName = companyCombo.Text;
                    item.Id = Convert.ToInt32(itemCombo.SelectedValue);
                    item.Name = itemCombo.Text;
                    item.Quantity = Convert.ToInt32(quantityBox.Value);
                    _stockOutManager.AddItem(item);

                    addItemDataGrid.Show();
                    sellButton.Show();
                    damageButton.Show();
                    lostButton.Show();

                    addItemDataGrid.DataSource = _stockOutManager.GetItemTable();
                    model.AddAutoIncrementColumn(addItemDataGrid);

                    _stock.ItemId = Convert.ToInt32(itemCombo.SelectedValue);
                    _stock.Quantity = Convert.ToInt32(quantityBox.Value);
                    _stockOutManager.AddToList(_stock);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        
        private void sellButton_Click(object sender, EventArgs e)
        {
            try
            {
                int status = (int)StatusEnum.Sale;
                _stockOutManager.StockOut(status);
                MessageBox.Show("You sale " + addItemDataGrid.Rows.Count + " item");
                _stockOutManager.ClearItemTable(quantityBox.Text);
                addItemDataGrid.DataSource = _stockOutManager.GetItemTable();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void damageButton_Click(object sender, EventArgs e)
        {
            try
            {
                int status = (int) StatusEnum.Damage;
                _stockOutManager.StockOut(status);
                MessageBox.Show(addItemDataGrid.Rows.Count + " Item damaged!");
                _stockOutManager.ClearItemTable(quantityBox.Text);
                addItemDataGrid.DataSource = _stockOutManager.GetItemTable();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void lostButton_Click(object sender, EventArgs e)
        {
            try
            {
                int status = (int) StatusEnum.Lost;
                _stockOutManager.StockOut(status);
                MessageBox.Show(addItemDataGrid.Rows.Count + " Item Lost!");
                _stockOutManager.ClearItemTable(quantityBox.Text);
                addItemDataGrid.DataSource = _stockOutManager.GetItemTable();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        
        private void quantityBox_ValueChanged(object sender, EventArgs e)
        {
            int availableQuantity = Convert.ToInt32(showAvailableQuantity.Text);
            if (quantityBox.Value > availableQuantity)
            {
                qntyErrMsgLabel.Text = quantityBox.Value + " "+itemCombo.Text+ " Not available in stock!";
                addButton.Hide();
            }
            else if(_stockOutManager.NotAvailable(_itemId) ==false)
            {
                addButton.Show();
                qntyErrMsgLabel.Text = "";
            }
            else
            {
                qntyErrMsgLabel.Text = "";
            }
        }
        
    }
}
