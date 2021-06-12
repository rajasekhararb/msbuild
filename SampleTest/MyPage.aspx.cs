using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SampleTest.DAL;
using log4net;
namespace SampleTest
{
    public partial class MyPage : System.Web.UI.Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void btb_submit_Click(object sender, EventArgs e)
        {

           
                //c sharp codety
                try
                {
                    Employee obj = new Employee();
                    Employee ss = obj.get();

                    
                    lbl_id.Text = Convert.ToString(ss.ID);
                    lbl_pwd.Text = ss.PassWord;

                }
                catch (Exception ex)
                {


                    throw ex;
                }



            
        }
    }
}