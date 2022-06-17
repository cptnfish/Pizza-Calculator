using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Schema;

namespace Pizza_Calculator
{
    public partial class Dropdown_Size : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("~/App_Data/Ingredients.xml");

            XmlNode dough = xmlDocument.SelectSingleNode("/Ingredients/dough/small");
            Response.Write($"{dough}");
            */
        }

        protected void Dropdownlist0_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = Dropdownlist0.SelectedItem.Text;
            string selectedValue = Dropdownlist0.SelectedItem.Value;

            // https://www.dotnettutorial.co.in/2019/02/how-to-bind-xml-data-to-dropdownlist-in-asp-net.html
            
            
            XmlDocument xDocu = new XmlDocument();
            xDocu.Load(@"C:\Users\Danny\Source\Repos\Pizza-Calculator\App_Data\Ingredients.xml");
            
            XmlNode dough = xDocu.DocumentElement.SelectSingleNode($"dough/{selectedText.ToLower()}/calories");
            string s_dough = dough.InnerText;
             
            Response.Write($"{s_dough}");

            /*
             int kcal = 0;

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