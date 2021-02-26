using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HtmlAgilityPack;
using System.Net;
using System.Text;

namespace WebApplication1
{
    public partial class Form1 : WebForm1
    {
        public string html;
        public Uri url;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 3; i++)
            {

                for (int j = 1; j < 3; j++)
                {
                    VeriAl("https://www.watsons.com.tr/c/makyaj-281?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div[" + j + "]/div/div[2]/h3/a", makyaj1);
                    VeriAl("https://www.watsons.com.tr/c/makyaj-281?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div[" + j + "]/div/div[2]/div[1]", makyaj2);
                    VeriAl("https://www.watsons.com.tr/c/makyaj-281?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div[" + j + "]/div/div[2]/div[3]/div/span[2]", makyaj3);

                }
            }
            /* for (int i = 1; i <3; i++)
             {

                 for (int j = 1; j <3; j++)
                 { 
                     VeriAl("https://www.watsons.com.tr/c/cilt-322?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div[" + j + "]/div/div[2]/h3/a", cilt1);
                     VeriAl("https://www.watsons.com.tr/c/cilt-322?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div["+j+"]/div/div[2]/div[1]", cilt2);
                     VeriAl("https://www.watsons.com.tr/c/cilt-322?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div["+j+"]/div/div[2]/div[3]/div/span[2]", cilt3);
                 }
             }

             for (int i = 1; i < 3; i++)
             {

                 for (int j = 1; j < 3; j++)
                 {
                     VeriAl("https://www.watsons.com.tr/c/sac-307?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div["+j+"]/div/div[2]/h3/a", sac1);
                     VeriAl("https://www.watsons.com.tr/c/sac-307?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div["+j+"]/div/div[2]/div[1]", sac2);
                     VeriAl("https://www.watsons.com.tr/c/sac-307?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div["+j+"]/div/div[2]/div[3]/div/span[2]", sac3);
                 }
             }

             for (int i = 1; i < 3; i++)
             {

                 for (int j = 1; j < 3; j++)
                 {
                     VeriAl("https://www.watsons.com.tr/c/parfum-ve-deodorant-287?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div["+j+"]/div/div[2]/h3/a", parfum1);
                     VeriAl("https://www.watsons.com.tr/c/parfum-ve-deodorant-287?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div["+j+"]/div/div[2]/div[1]", parfum2);
                     VeriAl("https://www.watsons.com.tr/c/parfum-ve-deodorant-287?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div["+j+"]/div/div[2]/div[3]/div/span[2]", parfum3);
                 }
             }

             for (int i = 1; i < 3; i++)
             {

                 for (int j = 1; j < 3; j++)
                 {
                     VeriAl("https://www.watsons.com.tr/c/kisisel-bakim-302?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div[" + j + "]/div/div[2]/h3/a", kisisel1);
                     VeriAl("https://www.watsons.com.tr/c/kisisel-bakim-302?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div[" + j + "]/div/div[2]/div[1]", kisisel2);
                     VeriAl("https://www.watsons.com.tr/c/kisisel-bakim-302?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div[" + j + "]/div/div[2]/div[3]/div/span[2]", kisisel3);
                 }
             }


             for (int i = 1; i < 3; i++)
             {

                 for (int j = 1; j < 3; j++)
                 {
                     VeriAl("https://www.watsons.com.tr/c/erkek-298?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div[" + j + "]/div/div[2]/h3/a", erkek1);
                     VeriAl("https://www.watsons.com.tr/c/erkek-298?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div[" + j + "]/div/div[2]/div[1]", erkek2);
                     VeriAl("https://www.watsons.com.tr/c/erkek-298?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div[" + j + "]/div/div[2]/div[3]/div/span[2]", erkek3);
                 }
             }

             for (int i = 1; i < 3; i++)
             {

                 for (int j = 1; j < 3; j++)
                 {
                     VeriAl("https://www.watsons.com.tr/c/ev-ve-yasam-555?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div[" + j + "]/div/div[2]/h3/a", ev1);
                     VeriAl("https://www.watsons.com.tr/c/ev-ve-yasam-555?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div[" + j + "]/div/div[2]/div[1]", ev2);
                     VeriAl("https://www.watsons.com.tr/c/ev-ve-yasam-555?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div[" + j + "]/div/div[2]/div[3]/div/span[2]", ev3);
                 }
             }

             for (int i = 1; i < 3; i++)
             {

                 for (int j = 1; j < 3; j++)
                 {
                     VeriAl("https://www.watsons.com.tr/c/anne-bebek-370?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div[" + j + "]/div/div[2]/h3/a",anne1);
                     VeriAl("https://www.watsons.com.tr/c/anne-bebek-370?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div[" + j + "]/div/div[2]/div[1]", anne2);
                     VeriAl("https://www.watsons.com.tr/c/anne-bebek-370?pagenumber=" + i + "", "/html/body/div[1]/div[1]/div[2]/div/div/div[3]/div/div[2]/div[4]/div/div[" + j + "]/div/div[2]/div[3]/div/span[2]", anne3);
                 }
             }*/




        }
        public void VeriAl(String Url, String XPath, ListBox CikanSonuc)
        {
            try
            {
                url = new Uri(Url);
            }
            catch (UriFormatException)
            {
            }
            catch (ArgumentNullException)
            {
            }
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            try
            {
                html = client.DownloadString(url);
            }
            catch (WebException)
            {
            }
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            try
            {
                CikanSonuc.Items.Add(doc.DocumentNode.SelectSingleNode(XPath).InnerText);
            }
            catch (NullReferenceException)
            {
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}