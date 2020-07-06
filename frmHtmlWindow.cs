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
using System.Xml;
using System.IO; 

namespace REST_API_CALL
{
    public partial class frmHtmlWindow : Form
    {
        public frmHtmlWindow()
        {
            InitializeComponent();

            TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel htmlPanel = new TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel();
            //htmlPanel.Text = "<p><h1>Hello World</h1>This is html rendered text</p>";
            htmlPanel.Text = Add_String("Test Status");
            //htmlPanel.BackColor = System.Drawing.Color.Red;
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
            html_text = html_text + "           <style>";
            html_text = html_text + "           table {";
            html_text = html_text + "                   font-family:Segoe UI;";
            html_text = html_text + "                   border-collapse:collapse;";
            html_text = html_text + "                   width:100%;";
            html_text = html_text + "                   }";
            html_text = html_text + "           td,th {";
            html_text = html_text + "                   text-align:left;";
            html_text = html_text + "                   border:1px solid #dddddd";
            html_text = html_text + "                   padding:8px;";
            html_text = html_text + "                   }";
            html_text = html_text + "           tr:nth-child(even) {";
            html_text = html_text + "                   background-color:#dddddd;";
            html_text = html_text + "                   }";
            html_text = html_text + "           </style>";
            html_text = html_text + "    </head>";
            html_text = html_text + "    <body>";
            html_text = html_text + "    <div class= test_name>";
            html_text = html_text + "     <h3>" + mText + "</h3>";
            html_text = html_text + "       <table> ";
            
            html_text = html_text + "           <tr>";
            html_text = html_text + "               <td>Description</td>";
            html_text = html_text + "               <td>Main Vout</td>";
            html_text = html_text + "           </tr>";
            html_text = html_text + "           <tr>";
            html_text = html_text + "               <td>Upper Limit</td>";
            html_text = html_text + "               <td>12.6</td>";
            html_text = html_text + "           </tr>";
            html_text = html_text + "           <tr>";
            html_text = html_text + "               <td>Lower Limit</td>";
            html_text = html_text + "               <td>11.4</td>";
            html_text = html_text + "           </tr>";
            html_text = html_text + "           <tr>";
            html_text = html_text + "               <td>Result</td>";
            html_text = html_text + "               <td>12.1</td>";
            html_text = html_text + "           </tr>";
            html_text = html_text + "           <tr>";
            html_text = html_text + "               <td>Status</td>";
            html_text = html_text + "               <td>PASS</td>";
            html_text = html_text + "           </tr>";
            html_text = html_text + "       </table>";
            html_text = html_text + "   <hr />";

            html_text = html_text + "    </div>";
            html_text = html_text + "    <p></p>";
            html_text = html_text + "    </body>";
            html_text = html_text + "</html>";

            string htmlText = Regex.Replace(html_text, @"\r\n\s", "");
            return htmlText;
            //htmlPanel.Text = _StringBuilder.Append(htmlText).ToString();
        }

        private void btnOpenXML_Click(object sender, EventArgs e)
        {
            string loc = @"D:\iTester_Report_Viewer\TEST_PROTO_NA.TESTER_REPORT_XML";
            XmlDocument xmldoc = new XmlDocument();
            XmlNodeList xmlnode;
            XmlElement xmlElement;
            int i = 0;
            string str = null;
            FileStream fs = new FileStream(loc, FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("Command_Collection");
            string temp = xmlnode[0].ChildNodes.Item(3).InnerText;
            for (i = 0; i <= xmlnode.Count - 1; i++)
            {
                //xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                //str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + "  " + xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
                //MessageBox.Show(i.ToString());
            }

            MessageBox.Show(xmlnode.Count.ToString());
            MessageBox.Show(temp);
        }
    }
}
