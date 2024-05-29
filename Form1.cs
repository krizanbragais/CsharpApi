using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;


namespace CsharpApi
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            // Clear previous data
            dataGridView1.DataSource = null;

            HttpResponseMessage response = await client.GetAsync("http://localhost/myapi/phpapi/krizanneAPI.php");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            // Parse the JSON response
            var laptops = JsonConvert.DeserializeObject<List<Laptop>>(responseBody);

            // Bind the list of users to the DataGridView
            dataGridView1.DataSource = laptops;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            var productData = new { brand = brandTxtbox.Text, series = seriesTxtbox.Text, price = priceTxtbox.Text };
            string json = JsonConvert.SerializeObject(productData);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync("http://localhost/myapi/phpapi/krizanneAPI.php", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Parse the JSON response
                var laptops = JsonConvert.DeserializeObject<Laptop>(responseBody);

                btnGet_Click(null, null);
                MessageBox.Show("Product Added");
                // Do something with the user object
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public class Laptop
        {
            public string brand { get; set; }
            public string series { get; set; }
            public int price { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var transactions = new transaction();
            this.Hide();
            transactions.Show();
        }
    }
}
