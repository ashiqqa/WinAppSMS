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
    public partial class CategoryUI : Form
    {
        public CategoryUI()
        {
            InitializeComponent();
        }
        CategoryManager _manager = new CategoryManager();
        UiModel _model = new UiModel();
        private int catId;
        private string catName;
        private void saveCategoryButton_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name = catNameTextBox.Text;

            try
            {
                if (saveCategoryButton.Text == "Save")
                {
                    bool save = _manager.SaveData(category);
                    if (save)
                    {
                        catNameTextBox.Clear();
                        MessageBox.Show("Category save successfully!");
                        categoryGridView.DataSource = _manager.GetAllCategory();
                        _model.AddAutoIncrementColumn(categoryGridView);
                    }
                    else
                    {
                        MessageBox.Show("Failed to save!");
                    }
                }

                if (saveCategoryButton.Text == "Update")
                {
                    bool update = _manager.UpdateData(category,catId, catName);
                    if (update)
                    {
                        catNameTextBox.Clear();
                        MessageBox.Show("Update succesfully!");
                        saveCategoryButton.Text = "Save";
                        saveCategoryButton.BackColor = Color.ForestGreen;
                        categoryGridView.DataSource = _manager.GetAllCategory();
                        _model.AddAutoIncrementColumn(categoryGridView);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void CategoryUI_Load(object sender, EventArgs e)
        {
            _model.AddEditColumn(categoryGridView);
            _model.AddDeleteColumn(categoryGridView);
            
            categoryBindingSource.DataSource = _manager.GetAllCategory();
            _model.AddAutoIncrementColumn(categoryGridView);
        }

        private void categoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Edit event;
                if (categoryGridView.Columns[e.ColumnIndex].Index == 3)
                {
                    int rowIndex = categoryGridView.Rows[e.RowIndex].Index;
                    catNameTextBox.Text = categoryGridView.Rows[rowIndex].Cells[2].Value.ToString();

                    catId = Convert.ToInt32(categoryGridView.Rows[rowIndex].Cells[1].Value);
                    catName = catNameTextBox.Text;

                    saveCategoryButton.Text = "Update";
                    saveCategoryButton.BackColor = Color.Chocolate;
                }
                //Delete event;
                if (categoryGridView.Columns[e.ColumnIndex].Index == 4)
                {
                    catNameTextBox.Clear();
                    saveCategoryButton.BackColor = Color.ForestGreen;
                    saveCategoryButton.Text = "Save";
                
                    int rowIndex = categoryGridView.Rows[e.RowIndex].Index;
                    int catId = Convert.ToInt32(categoryGridView.Rows[rowIndex].Cells[1].Value);
                    if (MessageBox.Show("Are you sure want to delete? ", "Confirm", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _manager.DeleteData(catId);
                        categoryGridView.DataSource = _manager.GetAllCategory();
                        _model.AddAutoIncrementColumn(categoryGridView);
                    }
                
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
