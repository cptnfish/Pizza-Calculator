using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pizza_Calculator
{
    public partial class Dropdown_Size : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Dropdownlist0_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = Dropdownlist0.SelectedItem.Text;
            string selectedValue = Dropdownlist0.SelectedItem.Value;

            // https://www.dotnettutorial.co.in/2019/02/how-to-bind-xml-data-to-dropdownlist-in-asp-net.html

            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath(@"C:\Users\dasax\source\repos\Pizza Calculator\App_Data\Ingredients.xml"));
           // Dropdownlist0.DataValueField = "cid";
            Dropdownlist0.DataTextField = "name";
            Dropdownlist0.DataSource = ds;
            Dropdownlist0.DataBind();
            Dropdownlist0.Items.Insert(0, new ListItem("--select--", "0"));


            /* int kcal = 0;

             if (selectedText == "Small")
             {
                  kcal = 500;
             }
             if (selectedText == "Medium")
             {
                  kcal = 750;
             }
             if (selectedText == "Large")
             {
                  kcal = 1000;
             }
             Response.Write($"Your Pizza Size {selectedText} is {kcal} kcal"   );
            */
        }
    }
}