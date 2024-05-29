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
    public partial class transaction : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public transaction()
        {
            InitializeComponent();
        }

        private async void getBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear previous data
                dataGridView1.DataSource = null;

                HttpResponseMessage response = await client.GetAsync("http://localhost/myapi/phpapi/krizanneTransactions.php");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Parse the JSON response
                var transactions = JsonConvert.DeserializeObject<List<Transaction>>(responseBody);

                // Bind the list of users to the DataGridView
                dataGridView1.DataSource = transactions;

                // Ensure columns fill the container
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            var transactionData = new { sale_type = typeComb.SelectedItem.ToString(), branch = branchTxtbox.Text, laptop_id = laptopTxtbox.Text, peripheral_id = peripheralTxtbox.Text, total = totalTxtbox.Text  };
            string json = JsonConvert.SerializeObject(transactionData);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync("http://localhost/myapi/phpapi/krizanneTransactions.php", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // Parse the JSON response
                var transaction = JsonConvert.DeserializeObject<Transaction>(responseBody);

                getBtn_Click(null, null);
                // Do something with the transaction object
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            // Reset the TextBox and ComboBox after adding the transaction
            typeComb.SelectedIndex = -1; // Reset ComboBox selection

            branchTxtbox.Clear(); // Clear TextBox
            laptopTxtbox.Clear();
            peripheralTxtbox.Clear();
            totalTxtbox.Clear();
        }
    
    }

    public class Transaction
    {
        public string sale_date { get; set; }
        public string sale_type { get; set; }
        public int branch { get; set; }
        public int laptop_id { get; set; }
        public int peripheral_id { get; set; }
        public int total { get; set; }


    }

}
