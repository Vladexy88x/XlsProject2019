using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreelanceProj1.Parsing
{
    class SiteParse : ParseWork, IParse
    {
        private readonly string uriSite;

        public SiteParse(string uriTargetSite)
        {
            uriSite = uriTargetSite;
        }

        public void StartParse(ListBox listBox, string pathLoadFile)
        {
          //  this.GetResultParse(listBox, uriSite, pathLoadFile);
            //await this.ParseTag(listBox, textBox);
        }

        #region MyRegion
        //private string MessageComleteOnEventHandle()
        //{
        //    return MessageBox.Show("MessageComleteOnEventHandle").ToString();
        //}

        //private void SiteParse_OnMessageSendTest(object sender, EventArgs e)
        //{
        //    MessageBox.Show("SiteParse event");
        //}
        #endregion
        #region EventsTest
        //OnMessageSendTest += SiteParse_OnMessageSendTest;
        //OnMessageSendTest += (e, s) => { MessageBox.Show("ss"); };
        //OnMessageSendTest += (e, s) => { MessageComleteOnEventHandle(); };
        #endregion
    }
}
