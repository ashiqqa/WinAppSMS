using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.Models;

namespace SMS.WinApp
{
    public partial class IndexUI : Form
    {
        public IndexUI()
        {
            InitializeComponent();
        }

        private void setCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryUI catUi = new CategoryUI();
            catUi.Show();
        }
        private void setCompanyButton_Click(object sender, EventArgs e)
        {
            CompanyUI company = new CompanyUI();
            company.Show();
        }

        private void setItemButton_Click(object sender, EventArgs e)
        {
            ItemUI item = new ItemUI();
            item.Show();
        }

        private void stockInButton_Click(object sender, EventArgs e)
        {
            StockInUI stock = new StockInUI();
            stock.Show();
        }

        private void stockOutButton_Click(object sender, EventArgs e)
        {
            StockOutUI stock = new StockOutUI();
            stock.Show();
        }

        private void SearchItemSummeryBtn_Click(object sender, EventArgs e)
        {
            SearchUI search = new SearchUI();
            search.Show();
        }

        private void SearchSalesItemButton_Click(object sender, EventArgs e)
        {
            ViewSellsItemUI sell = new ViewSellsItemUI();
            sell.Show();
        }

        private void IndexUI_Load(object sender, EventArgs e)
        {
            showUserName.Text = Utility.UserName;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
