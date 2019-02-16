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
    public partial class ItemUI : Form
    {
        public ItemUI()
        {
            InitializeComponent();
        }
        Manager _manager = new Manager();
        private void ItemUI_Load(object sender, EventArgs e)
        {
            CategoryManager category = new CategoryManager();
            categoryBindingSource.DataSource = _manager.ComboDataTable(category.GetAllCategory());
            
            CompanyManager company = new CompanyManager();
            companyBindingSource.DataSource = _manager.ComboDataTable(company.GetAllCompany());
            
        }

        private void saveItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item();
                item.CategoryId = Convert.ToInt32(categoryCombo.SelectedValue);
                item.CompanyId = Convert.ToInt32(companyCombo.SelectedValue);
                item.Name = itemNameTextBox.Text;
                item.ReorderLevel = Convert.ToInt32(reorderLevelNum.Value);

                ItemManager itemManager = new ItemManager();
                if (itemManager.SaveItem(item))
                {
                    MessageBox.Show("Item save successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to save Item");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
