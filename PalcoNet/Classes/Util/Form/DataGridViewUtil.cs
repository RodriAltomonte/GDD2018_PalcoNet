using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalcoNet.Classes.Util.Form
{
    static class DataGridViewUtil
    {
        public static IList<T> ListOfRowCells<T>(System.Windows.Forms.DataGridViewSelectedRowCollection selectedRows, int cellIndex)
        {
            IList<T> list = new List<T>();
            foreach (System.Windows.Forms.DataGridViewRow row in selectedRows)
            {
                list.Add((T)row.Cells[cellIndex].Value);
            }
            return list;
        }
    }
}
