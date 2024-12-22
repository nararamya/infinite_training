using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                imgProduct.Visible = false;
                labelPrice.Visible = false;
            }
        }

        protected void Products_Selected(object sender, EventArgs e)
        {
            int choose_product = int.Parse(Products.SelectedValue);

            imgProduct.Visible = false;
            labelPrice.Visible = false;


            switch (choose_product)
            {
                case 1:
                    imgProduct.ImageUrl = "images/coke.jpg";
                    labelPrice.Text = "Price: $200";
                    break;
                case 2:
                    imgProduct.ImageUrl = "images/doll.jpg";
                    labelPrice.Text = "Price: $500";
                    break;
                case 3:
                    imgProduct.ImageUrl = "images/makeup.jpg";
                    labelPrice.Text = "Price: $600";
                    break;
                case 4:
                    imgProduct.ImageUrl = "images/shoe.jpg";
                    labelPrice.Text = "Price: $1000";
                    break;
                default:
                    imgProduct.Visible = false;
                    labelPrice.Visible = false;
                    break;
            }


            if (choose_product != 0)
            {
                imgProduct.Visible = true;
            }
        }

        protected void btnGetPrice_Click(object sender, EventArgs e)
        {
            labelPrice.Visible = true;

        }
    }
}
    
    
