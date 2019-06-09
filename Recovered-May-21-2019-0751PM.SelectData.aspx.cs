using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace DealingWithDb
{
    public partial class SelectData : System.Web.UI.Page
    {
        northwindEntities db = new northwindEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click2(object sender, EventArgs e)
        {

            int id = int.Parse(TextBox1.Text);
            var query = from p in db.Products
                        where p.ProductID==id
                        select new { p.ProductID, p.ProductName, p.UnitPrice, p.CategoryID };
            GridView1.DataSource = db.Products.ToList();
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
            var query = from p in db.Products
                        where p.ProductName .StartsWith(TextBox1.Text)
                        select new { p.ProductID, p.ProductName, p.UnitPrice, p.CategoryID };
            GridView1.DataSource = db.Products.ToList();
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

           
            var query = from p in db.Products
                        
                        select new { p.ProductID, p.ProductName, p.UnitPrice, p.CategoryID };
            GridView1.DataSource = db.Products.ToList();
            GridView1.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            var psd = db.Products.Where(l => l.UnitPrice > 50);
            GridView1.DataSource = psd.OrderByDescending(l => l.UnitPrice).Take(5).ToList();
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            var MaxPrice = db.Products.Max(l => l.UnitPrice);
            
            Label1.Text ="the maximum price is : "+ MaxPrice.ToString();
            
        }
    }
}