using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using WebClient.ServiceReference1;

namespace WebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        readonly Service1Client wfc = new Service1Client("BasicHttpBinding_IService1");
        
        static Uri address = new Uri("http://localhost:8733/Design_Time_Addresses/ClassLibrary/Service1/");
        BasicHttpBinding binding = new BasicHttpBinding();
        EndpointAddress endpoint = new EndpointAddress(address);

        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/Content/Js/jquery-3.2.1.min.js",
            });
            try
            {
                if (!IsPostBack)
                {
                    ChannelFactory<IService1> factory = new ChannelFactory<IService1>(binding, endpoint);
                    IService1 channel = factory.CreateChannel();
                    channel.ResponseFromHost(binding.Name, address.Port.ToString(), address.LocalPath,
                        address.ToString(), address.Scheme);
                    factory.Close();

                    GridView1.DataSource = wfc.GetData();
                    GridView1.DataBind();

                    DropDownList1.DataSource = wfc.Clients();
                    DropDownList1.DataTextField = "Value";
                    DropDownList1.DataValueField = "Key";
                    DropDownList1.DataBind();

                    DropDownList2.DataSource = wfc.Services();
                    DropDownList2.DataTextField = "Value";
                    DropDownList2.DataValueField = "Key";
                    DropDownList2.DataBind();
                }
            }
            catch (EndpointNotFoundException exc)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Host closed!')", true);
            }
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsValid)
                {
                    wfc.NewRec(Convert.ToInt32(DropDownList1.SelectedValue), Convert.ToInt32(DropDownList2.SelectedValue),
                        Convert.ToInt32(TextBox1.Text), Convert.ToDateTime(DateO.Text));

                    ChannelFactory<IService1> factory = new ChannelFactory<IService1>(binding, endpoint);
                    IService1 channel = factory.CreateChannel();
                    channel.CountOfDBRows((GridView1.Rows.Count + 1).ToString());
                    factory.Close();

                    GridView1.DataSource = wfc.GetData();
                    GridView1.DataBind();
                }
            }
            catch (Exception exc)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Host closed!')", true);
            }

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                args.IsValid = Convert.ToDouble(TextBox1.Text) > 0;
            }

            catch
            {
                args.IsValid = false;
            }
        }
    }
}