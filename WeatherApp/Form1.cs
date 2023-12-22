using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace WeatherApp
{
    public partial class MainForm : Form
    {
        private const string ApiKey = "YOUR_OPENWEATHERMAP_API_KEY";
        private const string ApiBaseUrl = "http://api.openweathermap.org/data/2.5/weather";

        public MainForm()
        {
            InitializeComponent();

            // language combo box components
            cboLanguage.Items.AddRange(new string[] { "en", "ru", "fr", "es", "ja", "kr", "zh_cn" });
            cboLanguage.SelectedIndex = 0; // Set default language
        }

        private async void btnGetWeather_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text.Trim();
            string language = cboLanguage.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(city))
            {
                string apiUrl = $"{ApiBaseUrl}?lang={language}&q={city}&appid={ApiKey}&units=metric";

                try
                {
                    string jsonResponse = await FetchDataAsync(apiUrl);
                    DisplayWeather(jsonResponse);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a city name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task<string> FetchDataAsync(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new HttpRequestException($"Failed to fetch data. Status Code: {response.StatusCode}");
                }
            }
        }

        private void DisplayWeather(string jsonResponse)
        {
            JObject data = JObject.Parse(jsonResponse);

            string cityName = data["name"].ToString();
            string temperature = data["main"]["temp"].ToString();
            string description = data["weather"][0]["description"].ToString();

            string humidity = data["main"]["humidity"].ToString();
            string pressure = data["main"]["pressure"].ToString();
            string country = data["sys"]["country"].ToString();

            lblCity.Text = $"City: {cityName}";
            lblTemperature.Text = $"Temperature: {temperature} °C";
            lblDescription.Text = $"Description: {description}";

            lblHumadity.Text = $"Humidity: {humidity}";
            lblPressure.Text = $"Pressure: {pressure}";
            lblCountry.Text = $"Country: {country}";
        }
    }
}
