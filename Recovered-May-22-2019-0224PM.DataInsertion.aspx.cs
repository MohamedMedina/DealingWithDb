using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DealingWithDb
{
    public partial class DataInsertion : System.Web.UI.Page
    {
        northwindEntities db = new northwindEntities();
        protected void Page_Load(object sender, EventArgs e)
        {// filling data to dropdownlist
            if (!Page.IsPostBack)
            {

                DropDownList1.DataValueField = "CategoryID";
                DropDownList1.DataTextField = "CategoryName";
                DropDownList1.DataSource = db.Categories.ToList();
                DropDownList1.DataBind();



            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            Product p = new Product() {

                ProductName = TextBox1.Text,
                UnitPrice = decimal.Parse(TextBox2.Text),
                UnitsInStock = short.Parse(TextBox3.Text),
                CategoryID=Convert.ToInt32(DropDownList1.SelectedValue)






            };

            db.Products.Add(p);
            db.SaveChanges();
            Response.Redirect("SelectData.aspx");

        }
    }
}