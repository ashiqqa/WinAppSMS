using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.BLL;
using SMS.Models;

namespace SMS.WinApp
{
    public partial class ViewSellsItemUI : Form
    {
        public ViewSellsItemUI()
        {
            InitializeComponent();
        }

        SearchManager _search = new SearchManager();
        UiModel model = new UiModel();
        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                SellsDate date = new SellsDate();
                date.From = fromDatePicker.Value;
                date.To = toDatePicker.Value;

                sellsItemDataGrid.DataSource = _search.GetSellsItem(date);
                model.AddAutoIncrementColumn(sellsItemDataGrid);
                sellsItemDataGrid.Show();
                exportButton.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            try
            {
                UiModel model = new UiModel();
                model.ExportToPdf(sellsItemDataGrid, "SalesItem");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void ViewSellsItemUI_Load(object sender, EventArgs e)
        {
            sellsItemDataGrid.Hide();
            exportButton.Hide();
        }
    }
}
