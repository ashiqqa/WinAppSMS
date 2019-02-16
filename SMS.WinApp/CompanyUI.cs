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
    public partial class CompanyUI : Form
    {
        public CompanyUI()
        {
            InitializeComponent();
        }
        CompanyManager _companyManager = new CompanyManager();
        UiModel _model = new UiModel();
        private int companyId;
        private string companyName;
        private void saveCompanyButton_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.Name = companyNameTextBox.Text;
            try
            {
                if (saveCompanyButton.Text == "Save")
                {
                    bool save = _companyManager.SaveData(company);
                    if (save)
                    {
                        companyNameTextBox.Clear();
                        MessageBox.Show("Save successfully!");
                        companyBindingSource.DataSource = _companyManager.GetAllCompany();
                        _model.AddAutoIncrementColumn(companyGridView);
                    }
                    else
                    {
                        MessageBox.Show("Failed to save!");
                    }
                }

                if (saveCompanyButton.Text == "Update")
                {
                    bool update = _companyManager.UpdateData(company, companyId, companyName);
                    if (update)
                    {
                        companyNameTextBox.Clear();
                        MessageBox.Show("Update succesfully!");
                        saveCompanyButton.Text = "Save";
                        saveCompanyButton.BackColor = Color.ForestGreen;
                        companyBindingSource.DataSource = _companyManager.GetAllCompany();
                        _model.AddAutoIncrementColumn(companyGridView);
                    }
                    else
                    {
                        MessageBox.Show("Failed to Update!");
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void CompanyUI_Load(object sender, EventArgs e)
        {
            _model.AddEditColumn(companyGridView);
            _model.AddDeleteColumn(companyGridView);
            companyBindingSource.DataSource = _companyManager.GetAllCompany();
            _model.AddAutoIncrementColumn(companyGridView);
        }

        private void companyGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Edit event;
                if (companyGridView.Columns[e.ColumnIndex].Index == 3)
                {
                    int rowIndex = companyGridView.Rows[e.RowIndex].Index;
                    companyNameTextBox.Text = companyGridView.Rows[rowIndex].Cells[2].Value.ToString();

                    companyId = Convert.ToInt32(companyGridView.Rows[rowIndex].Cells[1].Value);
                    companyName = companyGridView.Rows[rowIndex].Cells[2].Value.ToString();

                    saveCompanyButton.BackColor = Color.Chocolate;
                    saveCompanyButton.Text = "Update";
                }
                //Delete Event;
                if (companyGridView.Columns[e.ColumnIndex].Index == 4)
                {
                    companyNameTextBox.Clear();
                    saveCompanyButton.BackColor = Color.ForestGreen;
                    saveCompanyButton.Text = "Save";

                    int rowIndex = companyGridView.Rows[e.RowIndex].Index;
                    int companyId = Convert.ToInt32(companyGridView.Rows[rowIndex].Cells[1].Value);

                    if (MessageBox.Show("Are you sure want to delete?", "Confirm", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _companyManager.DeleteData(companyId);
                        companyBindingSource.DataSource = _companyManager.GetAllCompany();
                        _model.AddAutoIncrementColumn(companyGridView);
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
