using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.Core.Entities;

namespace REST_API_CALL
{
    public partial class frmHtmlWindow : Form
    {
        public frmHtmlWindow()
        {
            InitializeComponent();

            TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel htmlPanel = new TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel();
            //htmlPanel.Text = "<p><h1>Hello World</h1>This is html rendered text</p>";
            htmlPanel.Text = Add_String("olioli");
            htmlPanel.BackColor = System.Drawing.Color.Red;
            htmlPanel.Dock = DockStyle.Fill;
            Controls.Add(htmlPanel);

            
        }

        public string Add_String(string mText)
        {
            string html_text = "";
            html_text = html_text + "<html>";
            html_text = html_text + "    <head>";
            html_text = html_text + "        <title></title>";
            html_text = html_text + "        <link rel=\"Stylesheet\" href=\"property:iTester_Report_Viewer.Bridge.StyleSheet\" />";
            html_text = html_text + "    </head>";
            html_text = html_text + "    <body>
            html_text = html_text + "    <div class= test_name>";
            html_text = html_text + "     <h3>" + mText + "</h3>";
            html_text = html_text + "<hr />";

            html_text = html_text + "    </div>";
            html_text = html_text + "    <p>this is a paragraph</p>";
            html_text = html_text + "    </body>";
            html_text = html_text + "</html>";

            string htmlText = Regex.Replace(html_text, @"\r\n\s", "");
            return htmlText;
            //htmlPanel.Text = _StringBuilder.Append(htmlText).ToString();
        }
    }
}
