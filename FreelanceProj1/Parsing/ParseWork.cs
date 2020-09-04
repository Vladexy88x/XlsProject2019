using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace FreelanceProj1.Parsing
{
    class ParseWork
    {
        #region GetHtmlDocument
        //private async Task<string> GetHtmlDocuments(string uriInput)
        //{
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uriInput);
        //    HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
        //    using (var streamResponse = new StreamReader(response.GetResponseStream()))
        //    {
        //        string getHtmlDoc = await streamResponse.ReadToEndAsync();
        //        response.Close();
        //        return getHtmlDoc;
        //    }

        //}
        #endregion


        //private string GetHtmlDocuments(string uriInput)
        //{
        //    string htmlCode = null;
        //    using (WebClient wc = new WebClient())
        //    {
        //        //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
        //        //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
        //        //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11;
        //        //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        //        wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.3; Win64; x64; rv:62.0) Gecko/20100101 Firefox/62.0");
        //        htmlCode = wc.DownloadString(uriInput);
        //    }
        //    return htmlCode;

        //}

        private string GetHtmlDocuments(string uriInput)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uriInput);
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64; rv:62.0) Gecko/20100101 Firefox/62.0";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (var streamResponse = new StreamReader(response.GetResponseStream()))
            {
                string getHtmlDoc = streamResponse.ReadToEnd();
                response.Close();
                return getHtmlDoc;
            }

        }

        public List<string> ParseTag(ListBox listBox, string uriInput)
        {
            if (string.IsNullOrWhiteSpace(uriInput))
            {
                MessageBox.Show("Поле Адресс пусто");
                //return;
            }

            var doc = new HtmlAgilityPack.HtmlDocument();
            //Task.Run(() => GetHtmlDocuments());
          
            HtmlWeb htmlWeb = new HtmlWeb() { AutoDetectEncoding = true, OverrideEncoding = Encoding.UTF8 };

            doc.LoadHtml(GetHtmlDocuments(uriInput));

            File.AppendAllText("Log.txt", GetHtmlDocuments(uriInput));
            

            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//tr/td[5]");
       
            List<string> listResultParse = new List<string>();

            #region OtherAlgorithmHtmlNode

            //HtmlAgilityPack.HtmlNode node = doc.DocumentNode.SelectSingleNode("//tr/td");
            //htmlRelease = node.InnerText;

            //foreach (HtmlNode node in nodes)
            //{
            //    htmlRelease = node.InnerText;
            //}

            //richText.Text = htmlRelease;
            #endregion

            if(nodes != null)
            {
                foreach (HtmlNode node in nodes)
                {
                    listResultParse.Add(node.InnerText);
                    listBox.Items.Add(node.InnerText);
                }
            }
            else
            {
                MessageBox.Show("Restart");
            }

            return listResultParse;
        }
    }
}
