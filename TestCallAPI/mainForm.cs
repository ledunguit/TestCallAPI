using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCallAPI
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                string getMegaUrl = "http://itsec.codes/api.php?key=" + txtKey.Text;

                HttpClient httpClient = new HttpClient();

                string linkResponse = httpClient.GetStringAsync(getMegaUrl).Result;

                ResponseMessage response = JsonSerializer.Deserialize<ResponseMessage>(linkResponse);

                run run = new run(response.key, response.expired);
                DialogResult = DialogResult.OK;
                run.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể kết nối tới API");
                return;
            }
            
        }
    }
}
