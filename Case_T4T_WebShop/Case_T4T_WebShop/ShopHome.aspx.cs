using Case_T4T_WebShop.cs;
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
            GetOrder();
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
                    ID = sandwich.Id.ToString(),
                    CssClass = "ProductsTextBox",
                    Width = 60,
                    Text = "1"
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
        private void GetOrder()
        {
            //Get list of Textbox objects in ContentPlaceHolder
            ContentPlaceHolder cph = (ContentPlaceHolder)Master.FindControl("ContentPlaceHolder1");
            ControllFinder<TextBox> cf = new ControllFinder<TextBox>();
            cf.FindChildControlsRecursive(cph);
            var textBoxList = cf.FoundControls;

            //Create orders using data from textfields
            ArrayList orderList = new ArrayList();

            foreach (TextBox textBox in textBoxList)
            {
                //Make sure textbox.Text is not null
                if (textBox.Text != "")
                {
                    int amountOfOrders = Convert.ToInt32(textBox.Text);

                    //Generate Order for each textbox which has an order greater than 0
                    if (amountOfOrders > 0)
                    {
                        cs.Sandwich sandwich = Connection.GetSandwichById(Convert.ToInt32(textBox.ID));
                        //Label1.Text = sandwich.Details;
                    }
                }
            }
            //return orderList;
        }
    }
}