using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.DAL;
using SMS.Models;

namespace SMS.BLL
{
    public class Manager
    {
        public DataTable ComboDataTable(DataTable data)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            DataRow dr = dt.NewRow();
            dr["Id"] = 0;
            dr["Name"] = "---Select One---";
            dt.Rows.Add(dr);

            dt.Merge(data);
            return dt;
        }
    }
}
