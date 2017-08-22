using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Case_T4T_WebShop
{
    public partial class ShopHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPanel();
        } 
        private void FillPanel()
        {
            ArrayList SandwichList = cs.Connection.GetSandwiches();
            foreach (cs.Sandwich sandwich in SandwichList)
            {
                Panel coffeePanel = new Panel();
                Literal literal = new Literal { Text = "<br />" };
                Literal literal2 = new Literal { Text = "<br />" };
                Label lblName = new Label { Text = sandwich.Name, CssClass = "ProductsName" };
                Label lblPrice = new Label
                {
                    Text = String.Format(sandwich.Price + "<br />"),
                    CssClass = "ProductsPrice"
                };
                TextBox textBox = new TextBox
                {
                    ID = sandwich.Name,
                    CssClass = "ProductsTextBox",
                    Width = 60,
                    Text = "0"
                };

                //Add controls to Panels
                coffeePanel.Controls.Add(literal);
                coffeePanel.Controls.Add(lblName);
                coffeePanel.Controls.Add(literal2);
                coffeePanel.Controls.Add(lblPrice);
                coffeePanel.Controls.Add(textBox);

                Panel1.Controls.Add(coffeePanel);
            }
        }
    }
}