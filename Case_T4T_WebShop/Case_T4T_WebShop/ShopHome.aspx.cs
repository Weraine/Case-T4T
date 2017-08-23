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
        private ArrayList currentOrder = new ArrayList();
        private string orderText;

        protected void Page_Load(object sender, EventArgs e)
        {
            FillPanel();
        }
        protected void OrderBtn_Click(object sender, EventArgs e)
        {
            currentOrder = GetOrder();
            //diplay order and price
            orderText = "Your Order : <br /> <br />";
            double total = 0;
            foreach (Order order in currentOrder)
            {
                orderText += order.Product + " : "+ "x"+ order.Amount + "---->" + order.Price + "$ <br /><br />";
                total += order.Price;
            }
            orderText += "Total : " + total + "$";
            Label1.Text = orderText;
            //hide order button/panel and show confirm/edit buttons
            OrderBtn.Visible = false;
            Panel1.Visible = false;
            ConfirmBtn.Visible = true;
            EditBtn.Visible = true;
            confirmOrderLbl.Visible = true;
        }
        protected void Confirm_Click(object sender, EventArgs e)
        {
            //send mail

            //reset page
        }
        protected void EditBtn_Click(object sender, EventArgs e)
        {
            OrderBtn.Visible = true;
            Panel1.Visible = true;
            ConfirmBtn.Visible = false;
            EditBtn.Visible = false;
            confirmOrderLbl.Visible = false;

            Label1.Text = "Please order a sandwich : ";
        }


        private void FillPanel()
        {
            Label1.Text = "Please order a sandwich : ";
            ArrayList SandwichList = cs.Connection.GetSandwiches();
            foreach (cs.Sandwich sandwich in SandwichList)
            {
                Panel sandwichPanel = new Panel();
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
                    Text = "0"
                };

                //Add controls to Panels
                sandwichPanel.Controls.Add(literal);
                sandwichPanel.Controls.Add(lblName);
                sandwichPanel.Controls.Add(literal2);
                sandwichPanel.Controls.Add(lblPrice);
                sandwichPanel.Controls.Add(textBox);

                Panel1.Controls.Add(sandwichPanel);
            }
        }
        private ArrayList GetOrder()
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
                        Order order = new Order(amountOfOrders,sandwich.Name,sandwich.Price);
                        orderList.Add(order);
                    }
                }
            }
            return orderList;
        }


    }
}