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
using System.Configuration;
using Dolgozat0311;
using Newtonsoft.Json;
using System.IO;


namespace Dolgozat0311
{
    public partial class Form1 : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("endpointUrl");

        private static string ReadSetting(string keyName)
        {
            string result = null;
            try
            {
                var value = ConfigurationManager.AppSettings;
                result = value[keyName];
            }
            catch (ConfigurationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listafrissitese();
        }

        private async void listafrissitese()
        {
            listBox_Tagok.Items.Clear();
            try
            {
                HttpResponseMessage response = await client.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var tag = Tag.FromJson(jsonString);
                    foreach (Tag item in tag)
                    {
                        listBox_Tagok.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox_Vasarlasok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tag tag = (Tag)listBox_Tagok.SelectedItem;
            textBox1_Id.Text = tag.Id.ToString();
            textBox_fullname.Text = tag.Fullname.ToString();
            dateTimePicker1_Entry.Value = DateTime.Parse(tag.Entry);
            numericUpDown1_Ratings.Value = tag.Rating;

        }

        private void button_Read_Click(object sender, EventArgs e)
        {
            listafrissitese();
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            Tag tag = new Tag();
            if (string.IsNullOrEmpty(textBox_fullname.Text))
            {
                MessageBox.Show("Kötelező a név megadása");
                textBox_fullname.Focus();
                return;
            }
            tag.Fullname = textBox_fullname.Text;
            tag.Entry = dateTimePicker1_Entry.Value.ToString("yyyy-MM-dd");
            tag.Rating = (int)numericUpDown1_Ratings.Value;
            var json = JsonConvert.SerializeObject(tag);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync(endPoint, data).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Sikeres felvitel!");
                listafrissitese();
            }
            else
            {
                MessageBox.Show("Sikertelen felvitel!");
            }
            textBox1_Id.Text = string.Empty;
            textBox_fullname.Text = string.Empty;
            numericUpDown1_Ratings.Value = numericUpDown1_Ratings.Minimum;
            dateTimePicker1_Entry.Checked = false;
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1_Id.Text))
            {
                MessageBox.Show("Kötelező tagot kiválasztani");
                return;
            }
            if (textBox_fullname.Text.Length < 3)
            {
                MessageBox.Show("Kötelező a nevet megadni");
                textBox_fullname.Focus();
                return;
            }
            if (!dateTimePicker1_Entry.Checked)
            {
                MessageBox.Show("Kötelező a dátumot megadni");
                return;
            }

            Tag tag = new tag();

            tag.Id = long.Parse(textBox1_Id.Text);
            tag.Fullname = textBox_fullname.Text;
            tag.Entry = dateTimePicker1_Entry.Value.ToString("yyyy-MM-dd");
            tag.Rating = (int)numericUpDown1_Ratings.Value;

            var json = JsonConvert.SerializeObject(tag);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            string endPointUpdate = $"{endPoint}/{tag.Id}";
            var response = client.PutAsync(endPointUpdate, data).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Sikeres módosítás!");
                listafrissitese();
            }
            else
            {
                MessageBox.Show("Sikertelen módosítás!");
            }
            textBox1_Id.Text = string.Empty;
            textBox_fullname.Text = string.Empty;
            numericUpDown1_Ratings.Value = numericUpDown1_Ratings.Minimum;
            dateTimePicker1_Entry.Checked = false;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Törölni szeretné?") == DialogResult.OK)
            {
                Tag tag = new Tag();

                tag.Id = long.Parse(textBox1_Id.Text);
                string endPointDelete = $"{endPoint}/{tag.Id}";
                tag.Fullname = textBox_fullname.Text;
                tag.Entry = dateTimePicker1_Entry.Value.ToString("yyyy-MM-dd");
                tag.Rating = (int)numericUpDown1_Ratings.Value;

                string endPointUpdate = $"{endPoint}/{tag.Id}";
                var response = client.DeleteAsync(endPointUpdate).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sikeres törlés!");
                    listafrissitese();
                }
                else
                {
                    MessageBox.Show("Sikertelen törlés!");
                }
                textBox1_Id.Text = string.Empty;
                textBox_fullname.Text = string.Empty;
                numericUpDown1_Ratings.Value = numericUpDown1_Ratings.Minimum;
                dateTimePicker1_Entry.Checked = false;

            }
        }
    }
}
