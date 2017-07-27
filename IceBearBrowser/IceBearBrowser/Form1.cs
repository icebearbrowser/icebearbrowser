using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IceBearBrowser
{
    public partial class Form1 : Form
    {
        WebBrowser currentTab;
        private int selectedTab;
        
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("www.google.com");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string url = textBox1.Text.Replace(" ", "+");
               
                Control ctl = new Control();
                WebBrowser current = (WebBrowser) tabControl1.SelectedTab.GetNextControl(ctl, true);
                current.Navigate("www.google.com/search?q=" + url);
                currentTab = current;



            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentTab == null)
            {
                currentTab = webBrowser1;
            }
            currentTab.Navigate("https://scratch.mit.edu/projects/142822405/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentTab == null)
            {
                currentTab = webBrowser1;
            }
            currentTab.Navigate("https://www.youtube.com/watch?v=DQ3XTQ9Npng");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentTab == null)
            {
                currentTab = webBrowser1;
            }
            currentTab.Navigate("https://scratch.mit.edu/projects/11016250/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currentTab == null)
            {
                currentTab = webBrowser1;
            }
            currentTab.Navigate("https://www.youtube.com/watch?v=5xxQs34UMx4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (currentTab == null)
            {
                currentTab = webBrowser1;
            }
            currentTab.Navigate("https://www.youtube.com/watch?v=3H2hWgVbblw");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void tabControl1_SelectedIndexChanged(Object sender, EventArgs e)
        {

            MessageBox.Show("You are in the TabControl.SelectedIndexChanged event.");
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Control ctl = new Control();
            WebBrowser current = (WebBrowser)tabControl1.SelectedTab.GetNextControl(ctl, true);
            currentTab = current;
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage"])
            {
                
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                TabPage tabpage = new TabPage();
                
                tabpage.Text = "New Tab " + (tabControl1.TabCount).ToString();
                tabpage.Name = "newTab" + (tabControl1.TabCount).ToString();
                tabControl1.Controls.Add(tabpage);
                WebBrowser webbrowser = new WebBrowser();
                webbrowser.Parent = tabpage;
                webbrowser.Dock = DockStyle.Fill;
                webbrowser.Navigate("www.google.com");
                currentTab = webbrowser;
            

                string addTabTitle = "+ New Tab ";
                TabPage addTabPage = new TabPage(addTabTitle);
                addTabPage.Name = "tabPage";
                tabControl1.TabPages.Add(addTabPage);
                
            }


        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void tabPage_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VERSION 1.2.0 OFFICIAL PATCH \n \n What's new? \n - Added Tab Closing \n - Changed Logo");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String bookmark = currentTab.Url.ToString();
             comboBox1.Items.Add(bookmark);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }
    }
}
