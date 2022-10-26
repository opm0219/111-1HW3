using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW3
{
    public partial class Test : System.Web.UI.Page
    {
        string[] str_type = new string[2] { "蔬菜", "水果" };
        string[,] str_choice = new string[2, 2] { { "A菜", "空心菜" }, { "番茄", "火龍果" } };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                for (int i_ct = 0; i_ct < str_type.Length; i_ct++)
                {
                    ListItem listbox1 = new ListItem();
                    listbox1.Text = listbox1.Value = str_type[i_ct];
                    ddl_Category.Items.Add(listbox1);
                }
                mt_listsecondchange();
            }
        }

        protected void ddl_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            mt_listsecondchange();
        }

        protected void mt_listsecondchange()
        {
            int i_index = ddl_Category.SelectedIndex;
            ddl_Food.Items.Clear();
            for (int i_ct = 0; i_ct < str_choice.GetLength(1); i_ct++)
            {
                ListItem listbox2 = new ListItem();
                listbox2.Text = listbox2.Value = str_choice[i_index, i_ct];
                ddl_Food.Items.Add(listbox2);
            }

        }
    }
}