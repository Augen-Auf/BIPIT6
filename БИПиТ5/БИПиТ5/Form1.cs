using System;
using System.Windows.Forms;
using System.ServiceModel;
using БИПиТ5.ServiceReference1;

namespace БИПиТ5
{
    public partial class Form1 : Form
    {
        readonly Service1Client wfc = new Service1Client("NetTcpBinding_IService1");

        static Uri address = new Uri("net.tcp://localhost:8732/Design_Time_Addresses/ClassLibrary/Service1/");
        NetTcpBinding binding = new NetTcpBinding();
        EndpointAddress endpoint = new EndpointAddress(address);

        public Form1()
        {
            InitializeComponent();   
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ChannelFactory<IService1> factory = new ChannelFactory<IService1>(binding, endpoint);
                IService1 channel = factory.CreateChannel();
                channel.ResponseFromHost(binding.Name, address.Port.ToString(), address.LocalPath,
                    address.ToString(), address.Scheme);
                factory.Close();

                dataGridView1.DataSource = wfc.GetData();

                comboBox1.DataSource = new BindingSource(wfc.Clients(), null);
                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";

                comboBox2.DataSource = new BindingSource(wfc.Services(), null);
                comboBox2.DisplayMember = "Value";
                comboBox2.ValueMember = "Key";
            }
            catch (EndpointNotFoundException exc)
            {
                MessageBox.Show("Host closed!".ToString());
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   if (Convert.ToInt32(textBox1.Text) <= 0)
                    label6.Text = "Число должно быть положительным!";
                else
                {
                    wfc.NewRec(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue),
                    Convert.ToInt32(textBox1.Text), dateTimePicker1.Value);
                    label6.Text = "";

                    ChannelFactory<IService1> factory = new ChannelFactory<IService1>(binding, endpoint);
                    IService1 channel = factory.CreateChannel();
                    channel.CountOfDBRows((dataGridView1.Rows.Count + 1).ToString());
                    factory.Close();

                    dataGridView1.DataSource = wfc.GetData();
                }
            }
            catch (EndpointNotFoundException exc)
            {
                MessageBox.Show("Host closed!".ToString());
            }
            catch (Exception exc)
            {
                label6.Text = "Входная строка(и) имела(и) неверный формат!";
            }
        }
    }
}
