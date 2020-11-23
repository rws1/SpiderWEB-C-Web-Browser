using MVC_IP_CW.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MVC_IP_CW
{
    public partial class firstPage : Form
    {

        XmlSerializer mySerializer, favSerializer;
        List<SpiderWeb> browserHistory;
        List<Favourites> userFavourites;
        List<SpiderWeb> reversedBrowserHistory;

        [XmlIgnore]

        // used to traverse history list
        private int historyCounter = 1;

        // History Tab Components
        Label historyMainLabel = new System.Windows.Forms.Label();
        GroupBox historySearchGroupBox = new System.Windows.Forms.GroupBox();
        Button historySearchButton = new System.Windows.Forms.Button();
        Button closeHistoryTabButton = new System.Windows.Forms.Button();
        TextBox textBox1 = new System.Windows.Forms.TextBox();
        DataGridView historySearchGridDataView = new System.Windows.Forms.DataGridView();
        GroupBox historyGroupBox = new System.Windows.Forms.GroupBox();
        DataGridView historyDataView = new System.Windows.Forms.DataGridView();
        TabPage historyTab = new TabPage("History");


        //Favourites Tab Components 
        GroupBox homePageGroupBox = new System.Windows.Forms.GroupBox();
        Button changeHomePageButton = new System.Windows.Forms.Button();
        TextBox homePageTextBox = new System.Windows.Forms.TextBox();
        GroupBox favouritesGroupBox = new System.Windows.Forms.GroupBox();
        DataGridView favouritesGridDataView = new System.Windows.Forms.DataGridView();
        Button removeFavouriteButton = new System.Windows.Forms.Button();
        Button addFavouritesButton = new System.Windows.Forms.Button();
        Label favouritesMainLabel = new System.Windows.Forms.Label();
        Button closeFavouritesTabButton = new System.Windows.Forms.Button();
        TabPage favouritesTab = new TabPage("Favourites");

        //Rendoring Tab Options
        TabPage rendorTab = new TabPage("Rendored HTML");

        public SpiderWeb SpiderWeb { get; set; }
        SpiderWeb SW = new SpiderWeb();

        public Favourites Favourites { get; set; }
        Favourites FV = new Favourites();


        public firstPage()
        {
            InitializeComponent();

            ListView listView = new ListView();

            // initialise lists and serialiser 
            browserHistory = new List<SpiderWeb>();
            userFavourites = new List<Favourites>();
            reversedBrowserHistory = new List<SpiderWeb>(); 
            mySerializer = new XmlSerializer(typeof(List<SpiderWeb>));
            favSerializer = new XmlSerializer(typeof(List<Favourites>));

            // load history
            loadHistory();
            //load favourites
            loadFavourites();


            // naviagte to users set homepage
            displayHomePage(userFavourites);
            addressBox.Text = homePageTextBox.Text;


            // if a favourite is set, navigate to it
            if (addressBox.Text != "")
            {
                navigateToURL();
            }


        }
        private void loadHistory()
        {

            FileStream f = new FileStream(@"history2.xml", FileMode.Open, FileAccess.Read);

            //if loop to prevent attempted deserialisation when file contents is empty

            if (f.Length != 2)
            {
                browserHistory = (List<SpiderWeb>)mySerializer.Deserialize(f);
            }

            f.Close();

            //reverseList(browserHistory);

            historyDataView.DataSource = browserHistory;

            // only perform column adjustment when list is populated
            if (historyDataView.Rows.Count != 0)
            {
                this.historyDataView.Columns[0].Width = 150;
                this.historyDataView.Columns[1].Visible = false;
                this.historyDataView.Columns[2].Visible = false;
                this.historyDataView.Columns[3].Width = 160;

                //historyDataView.Sort(historyDataView.Columns[3], ListSortDirection.Ascending);

            }
        }
        private void addToHistory()
        {
            //open the file to check for prior references of current reference
            Stream fs = new FileStream(@"history2.xml", FileMode.Create, FileAccess.Write);


            SW.URL = addressBox.Text;
            SW.DateAndTime = DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’");

            int i = 0;

            // switch statement stopping an empty URL being added to the browserHistory list
            switch (SW.URL.Length == i)
            {
                case true:
                    break;
                case false:
                    browserHistory.Add(SW);
                    break;

            }

            mySerializer.Serialize(fs, browserHistory);
            fs.Close();

        }

        private void clearHistory()
        {
            FileStream g = new FileStream(@"history2.xml", FileMode.Create, FileAccess.Write);
            g.Close();
            // empty list contents
            browserHistory.Clear();
            historyDataView.DataSource = null;


        }

        private void reverseList(List<SpiderWeb> SW)
        {
            if (SW.Count != 0)
            {
                SW.Clear();

                SW.ForEach((SpiderWeb) =>
                {
                    reversedBrowserHistory.Add(new SpiderWeb());
                });

                reversedBrowserHistory.Reverse();
            }
        }



        private void navigateToURL()
        {
            //add date variable, used for sorting in history
            var time = DateTime.Now;
            //format the date for output
            string formattedTime = time.ToString("dd MMM yyy HH’:’mm’:’ss ‘GMT’");

            //call methods from spider web class handling request and responses
            SW.URL = addressBox.Text;
            homeTab.Text = addressBox.Text;

            SW.DateAndTime = formattedTime;

            //http request using the current given URL in the addressBox
            htmlCodeTextBox.Text = SW.HTMLDisplay(SW);
            statusTextBox.Text = SW.HTTPSStatusCode;


            addToHistory();
            loadHistory();


            // reset the history counter
            historyCounter = 1;

        }

        private void NavigateButton_Click(object sender, EventArgs e)
        {

            navigateToURL();
 
            // reset the history counter
            historyCounter = 1;

        }

        private void manageFavouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFavouritesTab();
        }

        private void openFavouritesTab()
        {
            if (tabControl1.TabPages.Contains(favouritesTab) == false)
            {
                InitializeFavouritesTabComponents();
                loadFavourites();
                displayHomePage(userFavourites);
                selectATab(favouritesTab);
            }
            else
            {
                selectATab(favouritesTab);
            }

        }

        private void openHistoryTab()
        {
            InitializeHistoryTabComponents();
            loadHistory();
        }

        private void loadFavourites()
        {

            FileStream favStream = new FileStream(@"favourites.xml", FileMode.OpenOrCreate, FileAccess.Read);

            //if loop to prevent attempted deserialisation when file contents is empty
            if (favStream.Length != 2)
            {
                try
                {
                    userFavourites = (List<Favourites>)favSerializer.Deserialize(favStream);

                    favouritesGridDataView.DataSource = userFavourites;
                }
                catch
                (Exception e)
                {
                   // 
                }

            }
            if (favouritesGridDataView.Rows.Count != 0)
            {
                this.favouritesGridDataView.Columns[2].Visible = false;
                // this.favouritesGridDataView.Columns[1].
            }

            favStream.Close();

        }

        private void displayHomePage(List<Favourites> FV)
        {
            foreach (Favourites fav in FV)
                if (Boolean.Equals(true, fav.HomePage))
                {
                    homePageTextBox.Text = fav.URL;
                }
        }

        private void selectATab(TabPage tab)
        {
            tabControl1.SelectedTab = tab;
        }

        private void viewBrowsingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(historyTab) == false)
            {
                openHistoryTab();
                selectATab(historyTab);
            }

            else
            {
                tabControl1.SelectedTab = historyTab;

            }
        }

        private void closeTabButton_Click(object sender, EventArgs e)
        {

            tabControl1.TabPages.Remove(historyTab);
        }

        private void closeHistoryTabButton_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(favouritesTab);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearBrowsingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearHistory();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //int used to set the position in list to refer to
            if ((historyCounter < browserHistory.Count && historyCounter >= 1))//| addressBox.Text == "")
            {
                //clear the html from current website
                htmlCodeTextBox.Text = "";

                //get the second last entry in the list
                var lastEntry = browserHistory.ElementAt(historyCounter);
                addressBox.Text = lastEntry.URL;

                // increment the counter, to give the next item in the list if pressed again
                historyCounter++;


                //navigate to the site without adding to history 
                SW.URL = addressBox.Text;
                htmlCodeTextBox.Text = SW.HTMLDisplay(SW);
                statusTextBox.Text = SW.HTTPSStatusCode;
            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            //int used to set the position in list to refer to
            if (historyCounter < browserHistory.Count && historyCounter >= 1)
            {
                //clear the html from current website
                htmlCodeTextBox.Text = "";

                // reduce the counter, to give the next most recent item in the list if pressed again
                historyCounter--;

                //get the second last entry in the list
                var lastEntry = browserHistory.ElementAt(historyCounter);
                addressBox.Text = lastEntry.URL;

                //navigate to the site without adding to history 
                SW.URL = addressBox.Text;
                htmlCodeTextBox.Text = SW.HTMLDisplay(SW);
                statusTextBox.Text = SW.HTTPSStatusCode;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFavourites();
            loadHistory();
            displayHomePage(userFavourites);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            loadFavourites();
            displayHomePage(userFavourites);
            addressBox.Text = homePageTextBox.Text;
            navigateToURL();

        }

        private void favoritesButton_Click(object sender, EventArgs e)
        {
            var fav = new addNewFavouriteForm();
            fav.Favourites = FV;
            fav.ShowDialog();

            openFavouritesTab();

        }

        private void changeHomePageButton_Click(object sender, EventArgs e)
        {
            var changeHomePage = new addNewFavouriteForm();
            changeHomePage.Favourites = FV;
            changeHomePage.changeSettingsForHomepage();
            changeHomePage.ShowDialog();
            changeHomePage.resetSettings();
        }

        private void addFavouritesButton_Click(object sender, EventArgs e)
        {

            var fav = new addNewFavouriteForm();
            fav.Favourites = FV;
            fav.ShowDialog();
            openFavouritesTab();
            
            //refresh list display
            loadFavourites(); 
        }

        private void removeFavouriteButton_Click(object sender, EventArgs e)
        {
            if (favouritesGridDataView.SelectedRows.Count > 0)
            {
                string url = favouritesGridDataView.CurrentCell.Value.ToString();
                int beforeRemoval = userFavourites.Count;
                MessageBox.Show(url);
                if (url.Contains("www."))
                {


                    foreach (Favourites fav in userFavourites)
                    {
                        if (string.Equals(url, fav.URL))
                        {
                            userFavourites.Remove(fav);
                            Stream fs = new FileStream(@"favourites.xml", FileMode.Create, FileAccess.Write);
                            favSerializer.Serialize(fs, userFavourites);
                            fs.Close();
                            loadFavourites();
                            break;
                        }
                        else
                        {
                            string message = "Could not find matching URL in favourites\nensure URL is selected when pressing 'remove'";
                            string title = "Error";
                            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    string message = "Please select the URL of the favourite \nyou would like to remove \nthen press the 'remove' button";
                    string title = "Select URL";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    int afterRemoval = userFavourites.Count;

                    switch (beforeRemoval == afterRemoval + 1)
                    {
                        case true:
                            MessageBox.Show("Favourite {0} was removed successfully", url);
                            break;

                        case false:
                            MessageBox.Show(String.Format("No favourite named {0} could be found, please try again", url));
                            break;
                    }
                }
            }
            else
            {
                string message = "Please select the URL of the favourite \nyou would like to remove \nthen press the 'remove' button";
                string title = "Select URL";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void historySearchButton_Click(object sender, EventArgs e)
        {
            List<SpiderWeb> searchBrowserHistory = new List<SpiderWeb>();

            string searchTerm = textBox1.Text;

            if (textBox1.Text != null)
            {

                foreach (SpiderWeb SW in browserHistory)
                {

                    if (SW.URL.Contains(textBox1.Text))
                    {
                        searchBrowserHistory.Add(SW);
                    }


                }
                historySearchGridDataView.DataSource = searchBrowserHistory;
            }

            else
            {
                MessageBox.Show("Invalid Input");

                // Reset the search box on message alert
                textBox1.Text = string.Empty;
                textBox1.Focus();
            }
        }

        private void renderWebPageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(rendorTab);
            rendorPage rendor = new rendorPage();
            //rendor.ShowDialog();
            //rendor.navigate(SW.URL);
        }

        private void firstPage_Load(object sender, EventArgs e)
        {

        }

        private void FavouritesGridDataView_CellContentDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {


            if (favouritesGridDataView.CurrentCell.Value.ToString().Contains("www."))
            {
                addressBox.Text = favouritesGridDataView.CurrentCell.Value.ToString();
                navigateToURL();
                selectATab(homeTab);
            }
        }
    }
}
