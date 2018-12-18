using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Classes.Util.Form
{
    static class DataGridViewUtil
    {
        public static IList<T> ListOfRowCells<T>(DataGridViewSelectedRowCollection selectedRows, int cellIndex)
        {
            IList<T> list = new List<T>();
            foreach (DataGridViewRow row in selectedRows)
            {
                list.Add((T)row.Cells[cellIndex].Value);
            }
            return list;
        }

        public static bool IsEmpty(DataGridView dataGridView)
        {
            return dataGridView.Rows.Count == 0;
        }
    }
}
