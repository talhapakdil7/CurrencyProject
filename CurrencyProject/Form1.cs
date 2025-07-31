using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyProject
{



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        decimal dollar = 0;


        decimal euro = 0;

        private async void Form1_Load(object sender, EventArgs e)
        {
            #region Dollar
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=TRY&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "807ef66047msh7cf02002dc6d933p1f484ajsn409036ec991b" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                //     Console.WriteLine(body);

                var json = JObject.Parse(body);

                var result = json["result"].ToString();

                label1.Text = $"1 USD = {result} TRY";
                dollar = decimal.Parse(result);

                #endregion



                #region euro

                var client2 = new HttpClient();
                var request2 = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=EUR&to=TRY&amount=1"),
                    Headers =
    {
        { "x-rapidapi-key", "807ef66047msh7cf02002dc6d933p1f484ajsn409036ec991b" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
                };
                using (var response2 = await client2.SendAsync(request2))
                {
                    response.EnsureSuccessStatusCode();
                    var body2 = await response2.Content.ReadAsStringAsync();
                    //     Console.WriteLine(body);

                    var json2 = JObject.Parse(body2);

                    var result2 = json2["result"].ToString();

                    label2.Text = $"1 EUR = {result2} TRY";

                    euro = decimal.Parse(result2);
                    #endregion

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            decimal unitPrice=decimal.Parse(textBox1.Text);

        

            decimal totalprice = 0; 

            if (radioButton1.Checked)
            {


              totalprice = unitPrice * dollar;
                textBox2.Text = totalprice.ToString() + " TRY";





            }
            if(radioButton2.Checked)
            {
                totalprice = unitPrice * euro;
                textBox2.Text = totalprice.ToString() + " TRY";
            }


        }
    }


}
