using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Text.RegularExpressions;
using FreelanceProj1.Parsing;
using FreelanceProj1.LoadFiles;

namespace FreelanceProj1
{
    public partial class MainForm : Form
    {
        private string fullFileName { get; set; }

        public MainForm()
        {
            InitializeComponent();

        }

        private void StartParse_Click(object sender, EventArgs e)
        {
            IParse parse = new SiteParse(urlTargetInp.Text);
            parse.StartParse(listBox1, fullFileName);
        }

        private void CrtFile_Click(object sender, EventArgs e)
        {
            XlsWork.XlsWorker xlsWorker = new XlsWork.XlsWorker();
            //xlsWorker.WriteDataXlsx();
            // xlsWorker.ReadDataXlsx();
            xlsWorker.WriteDataXlsxBeta(listBox1, urlTargetInp.Text);
        

        }

        //private void OuterHtmlSite()
        //{
        //    HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
        //    string innerAllHtml = null;
                    
        //    System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create("https://vivt.ru/");
        //    System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
        //    using (var streamResponse = new StreamReader(response.GetResponseStream()))
        //    {
        //        innerAllHtml = streamResponse.ReadToEnd();
        //        response.Close();
        //    }

        //    HtmlAgilityPack.HtmlWeb htmlWeb = new HtmlAgilityPack.HtmlWeb() { AutoDetectEncoding = true, OverrideEncoding = Encoding.UTF8 };


        //    document.LoadHtml(innerAllHtml);
            

        //    HtmlAgilityPack.HtmlNodeCollection nodes = document.DocumentNode.SelectNodes("//ul/li/span[1]");
        //    foreach (HtmlAgilityPack.HtmlNode node in nodes)
        //    {
        //        listBox1.Items.Add(node.OuterHtml);
        //    }
        //}

        private void LoadFileXlsx_Click(object sender, EventArgs e)
        {
            LoadFile xlsLoadFile = new LoadFile();
            fullFileName = xlsLoadFile.CustomLoadFile(openFileDialog1);
            
        }
    }
}
