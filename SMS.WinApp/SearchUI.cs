using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.BLL;
using SMS.Models;

namespace SMS.WinApp
{
    public partial class SearchUI : Form
    {
        public SearchUI()
        {
            InitializeComponent();
        }
        Manager _manager = new Manager();
        CompanyManager _company = new CompanyManager();
        CategoryManager _category = new CategoryManager();
        SearchManager _search = new SearchManager();
        UiModel model = new UiModel();
        private int comId;
        private void SearchUI_Load(object sender, EventArgs e)
        {
            companyBindingSource.DataSource = _manager.ComboDataTable(_company.GetAllCompany());
            categoryBindingSource.DataSource = _manager.ComboDataTable(_category.GetAllCategory());
            
            searchItemDataGrid.Hide();
            exportButton.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item();

                item.CategoryId = Convert.ToInt32(categoryCombo.SelectedValue);
                item.CompanyId = Convert.ToInt32(companyCombo.SelectedValue);

                searchItemDataGrid.DataSource = _search.GetAllItem(item);
                model.AddAutoIncrementColumn(searchItemDataGrid);
                searchItemDataGrid.Show();
                exportButton.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            UiModel model = new UiModel();
            model.ExportToPdf(searchItemDataGrid, "ItemSummery");
        }

        private void companyCombo_TextChanged(object sender, EventArgs e)
        {
            comId = Convert.ToInt32(companyCombo.SelectedValue);
            categoryBindingSource.DataSource = _manager.ComboDataTable(_category.GetAllCategory());
            //categoryBindingSource.DataSource = _manager.ComboDataTable(_category.GetCategory(comId));
        }

    }
}
