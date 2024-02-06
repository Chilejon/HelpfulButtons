using HelpfulButtons.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace HelpfulButtons
{
    public partial class Form1 : Form
    {
        public string But1URL { get; set; }
        public string But2URL { get; set; }

        public Form1()
        {

            InitializeComponent();
        }

        //private int counter = 0;

        //private void CreateButton_Click(object sender, EventArgs e)
        //{
        //    //Create new button.
        //    System.Windows.Forms.Button button = new System.Windows.Forms.Button();

        //    //Set name for a button to recognize it later.
        //    button.Name = "Butt" + counter;

        //    // you can added other attribute here.
        //    button.Text = "New";
        //    button.Location = new Point(70, 70);
        //    button.Size = new Size(100, 100);

        //    // Increase counter for adding new button later.
        //    counter++;

        //    // add click event to the button.
        //    button.Click += new EventHandler(NewButton_Click);
        //}

        //private void NewButton_Click(object sender, EventArgs e)
        //{
        //    System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;

        //    for (int i = 0; i < counter; i++)
        //    {
        //        if (btn.Name == ("Butt" + i))
        //        {
        //            // When find specific button do what do you want.
        //            //Then exit from loop by break.
        //            break;
        //        }
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            var buttons = JsonConvert.DeserializeObject<List<ButtonSettings>>(System.IO.File.ReadAllText("..\\config\\ButtonSettings.json"));
            foreach (ButtonSettings button in buttons)
            {
                if (button.Order == 1)
                {
                    but1.Text = button.ButtonText;
                    But1URL = button.Link;

                }

                if (button.Order == 2)
                {
                    but2.Text = button.ButtonText;
                    But2URL = button.Link;
                }
            }






        }

        private void flexi_Click(object sender, EventArgs e)
        {
            // string message = "Hellow";
            // MessageBox.Show(message);

            Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", "http://flexi.stockport.gov.uk");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", "https://login.microsoftonline.com/a05ef69e-6149-4fba-a40c-df338810f644/login");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", "https://login.microsoftonline.com/a05ef69e-6149-4fba-a40c-df338810f644/saml2?SAMLRequest=hZJLb8IwEIT%2FSuR7EjsPSiyCROFQJNqiQnvopXLMGiw5NvU6pf335dEHvdCzx9%2FszO4ARWu2fNSFjX2A1w4wRO%2BtsciPDzXpvOVOoEZuRQvIg%2BSL0e2MZwnlW%2B%2BCk86QaIQIPmhnx85i14JfgH%2FTEh4fZjXZhLBFnqYSaFkVRic7aHTwYEMiXZsuNrppnIGwSRBdeqBn6fx%2BsSTRZD%2BOtuIA%2FsUYt9Y2abX0Dp0Kzhpt4UgStATVqyDusaKKC9WIWBRUxiuV5%2F0%2Bo6pXFOkhV0ai6aQmL1eyVJSxfq6qXJWVkrJYsZUq%2Bo3qyZyyvQyxg6nFIGyoSUazPKZVnJVLlvE856x6JtH8q4ZrbVfari931pxEyG%2BWy3l8ivkEHo8R9wIyHBwm5Edjf7aLy1jxvQAy%2FKdu%2FKl7kJ45nWy3%2FG6Pnk7mzmj5EY2McbuxBxGgJoykw9OXv%2Fcy%2FAQ%3D&RelayState=https%3A%2F%2Fce0594li.webitrent.com%2Fce0594li_web%2Fitrent_wrd%2Frun%2Fetadm001gf.main");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string url = "https://stockportbi.atlassian.net/jira/software/c/projects/DIGITAL/boards/15";
            if (!string.IsNullOrEmpty(jiraInput.Text.Trim()))
                url = "https://stockportbi.atlassian.net/browse/DIGITAL-" + jiraInput.Text.Trim();
            Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", url);
        }


        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\WINDOWS\\system32\\notepad.exe");
            //string tableHtml = "<table>\r\n  <thead>\r\n    <tr>\r\n      <th colspan=\"2\">The table header</th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n    <tr>\r\n      <td>The table body</td>\r\n      <td>with two columns</td>\r\n    </tr>\r\n  </tbody>\r\n</table>";
            //MessageBox.Show(tableHtml);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string url = "https://www.bbc.co.uk/weather/2636882";
            Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", url);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Process.Start("C:\\WINDOWS\\system32\\mstsc.exe");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Process proc = new Process();
            // proc.StartInfo.FileName = @"C:\Lock Machine.lnk";
            // proc.Start();

            string url = "https://wikiroulette.co/";
            Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", url);



        }

        private void button8_Click(object sender, EventArgs e)
        {
            string url = "https://www.bbc.co.uk/news";
            Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", url);
        }



        private void button11_Click(object sender, EventArgs e)
        {
            string url = "https://make.powerautomate.com/environments/Default-a05ef69e-6149-4fba-a40c-df338810f644/flows";
            Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", url);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string url = "https://stockportcouncil-my.sharepoint.com/personal/jon_chiles_stockport_gov_uk/_layouts/15/Lists.aspx?login_hint=jon%2Echiles%40stockport%2Egov%2Euk";
            Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", url);
        }

        private void butt1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var GUID = Guid.NewGuid().ToString();
            GUID = GUID.Replace("-", "");
            Clipboard.SetText(GUID);
        }
    }
}