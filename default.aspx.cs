using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bugtracker
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<List<string>> table_temp_list = new MsSQL().MsSQLRequestResurnList("SELECT * FROM bug_report;");


            for (int i = 0; i < table_temp_list.Count; i++)
            {
                TableRow row = new TableRow();
                for (int j = 0; j < table_temp_list[i].Count; j++)
                {
                    TableCell cell = new TableCell();
                    cell.Text = table_temp_list[i][j];
                    row.Cells.Add(cell);
                }
                Table1.Rows.Add(row);
            }

            //int numrows = 3;
            //int numcells = 2;
            //for (int j = 0; j < numrows; j++)
            //{
            //    TableRow r = new TableRow();
            //    for (int i = 0; i < numcells; i++)
            //    {
            //        TableCell c = new TableCell();
            //        c.Controls.Add(new LiteralControl("row "
            //            + j.ToString() + ", cell " + i.ToString()));
            //        r.Cells.Add(c);
            //    }
            //    Table1.Rows.Add(r);
            //}
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            new MsSQL().MsSQLRequest("INSERT bug_report VALUES (1, 2, N'капец ошибка', N'Просто нет слов её описать кошмарная ошибощище. Всё надо всё сжечь уже не спости!', GETDATE())");
        }
        protected void ButtonEdit_Click(object sender, EventArgs e)
        {
            new MsSQL().MsSQLRequest("");
        }
    }
}