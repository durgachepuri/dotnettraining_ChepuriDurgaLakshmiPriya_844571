using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace _11_2_assesment
{
    public partial class NewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            DURGAEntities1 s = new DURGAEntities1();
            New_User u = new New_User();
            u.First_name = TextBox1.Text;
            u.Age = int.Parse(TextBox2.Text);
            u.Login_Name = TextBox3.Text;
            u.Password = TextBox4.Text;
            u.Experience = int.Parse(TextBox6.Text);
            u.Expected_Salary = int.Parse(TextBox7.Text);
            s.New_User.Add(u);
            s.SaveChanges();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
