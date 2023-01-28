using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseApiByWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbSuplierID.Text = "0";
            tbSuplierID.Enabled = false;
            gbSuplierAction.Enabled = false;
            btnPost.Enabled = false;
        }


        //clear all textbox in gbSuplierInfo

        public void clearAll()
        {
            foreach(Control control in gbSuplierInfo.Controls)
            {
                if(control is TextBox)
                {
                    control.Text = "";
                    gbSuplierAction.Enabled = false;
                }
                
            }
        }

        //return all suplier from database

        private void btnGetAllData_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7034/");
            HttpResponseMessage httpResponseMessage = httpClient.GetAsync("api/Supliers").Result;
            var sup=httpResponseMessage.Content.ReadAsStringAsync().Result;
            dataGridView1.DataSource = JsonConvert.DeserializeObject<List<Suplier>>(sup);


           
        }


        // return one suplier by his ID number

        private void btnGetSuplierByID_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbID.Text))
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri("https://localhost:7034/");
                HttpResponseMessage httpResponseMessage = httpClient.GetAsync("api/Supliers/" + tbID.Text).Result;
                var sup = httpResponseMessage.Content.ReadAsStringAsync().Result;


                Suplier suplier = JsonConvert.DeserializeObject<Suplier>(sup);

                List<Suplier> supliers = new List<Suplier>();

                supliers.Add(suplier);

                dataGridView1.DataSource = supliers;
            }
 
        }

        // create new suplier

        private void btnPost_ClickAsync(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(tbID.Text, out id);
            Suplier suplier = new Suplier(id, tbCompanyName.Text, tbContactName.Text, tbContactTitle.Text, tbAddress.Text, tbCity.Text, tbRegion.Text, tbPostalCode.Text, tbCountry.Text, tbPhone.Text, tbFax.Text, tbHomePage.Text );

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7034/");
            
            HttpResponseMessage httpResponse= httpClient.PostAsJsonAsync("api/Supliers", suplier).Result;

            if (httpResponse.IsSuccessStatusCode)
            {
                MessageBox.Show("Supplier " + tbCompanyName.Text + " inserted.");
                clearAll();

                btnGetAllData.Focus();
            }

            
            
        }

        // show suplier info if you change suplier from list

        private void btnPutDeleteSuplier_Click(object sender, EventArgs e)
        {
            clearAll();
            tbSuplierID.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbCompanyName.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbContactName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbContactTitle.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbAddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbCity.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbRegion.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbPostalCode.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tbCountry.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            tbPhone.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            tbFax.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            tbHomePage.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();

            gbSuplierAction.Enabled = true;

        }

        // here you can change suplier info

        private void btnPut_Click(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(tbSuplierID.Text, out id);
            Suplier suplier = new Suplier(id, tbCompanyName.Text, tbContactName.Text, tbContactTitle.Text, tbAddress.Text, tbCity.Text, tbRegion.Text, tbPostalCode.Text, tbCountry.Text, tbPhone.Text, tbFax.Text, tbHomePage.Text);

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7034/");

            HttpResponseMessage httpResponse = httpClient.PutAsJsonAsync("api/Supliers/" + id, suplier).Result;

            if (httpResponse.IsSuccessStatusCode)
            {
                MessageBox.Show("Supplier " + tbCompanyName.Text + " was changed.");
                clearAll();

                btnGetAllData.Focus();

            }



        }


        // here you can delete suplier 


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(tbSuplierID.Text, out id);
            

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7034/");

            HttpResponseMessage httpResponse = httpClient.DeleteAsync("api/Supliers/" + id).Result;

            if (httpResponse.IsSuccessStatusCode)
            {
                MessageBox.Show("Supplier " + tbCompanyName.Text + " was deleted.");
                clearAll();

                btnGetAllData.Focus();

            }

            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        // client side check sistem

        private void tbCompanyName_TextChanged(object sender, EventArgs e)
        {
            if(tbCompanyName.Text.Length > 0)
            {
                    btnPost.Enabled = true;
                    btnPut.Enabled = true;
            }
            else 
            { 
                btnPost.Enabled = false; 
                btnPut.Enabled= false;
            }
        }
    }
}
