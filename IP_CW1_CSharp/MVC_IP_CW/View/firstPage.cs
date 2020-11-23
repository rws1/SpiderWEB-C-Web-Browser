using MVC_IP_CW.View;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MVC_IP_CW
{
    // <summary> Partial Class <c> firstPage /c>
    /// 
    /// Assigns functionality to the GUI initialised in the fistPage class. Partitioned to avoid keep functionality and visual components as discrete units
    /// 
    /// Implements the Form interface
    /// </summary>
    public partial class firstPage : Form
    {
        //Declare the serialisers for both the history and favourite items
        XmlSerializer hisSerializer, favSerializer;

        //Declare list of SpiderWeb items for history and Favourites for favourites
        List<SpiderWeb> browserHistory;
        List<Favourites> userFavourites;

        [XmlIgnore]

        //Declare int used used to traverse history list
        private int historyCounter;

        //Declare History Tab and Components
        Label historyMainLabel = new System.Windows.Forms.Label();
        GroupBox historySearchGroupBox = new System.Windows.Forms.GroupBox();
        Button historySearchButton = new System.Windows.Forms.Button();
        Button closeHistoryTabButton = new System.Windows.Forms.Button();
        TextBox historySearchTermTextBox = new System.Windows.Forms.TextBox();
        DataGridView historySearchGridDataView = new System.Windows.Forms.DataGridView();
        GroupBox historyGroupBox = new System.Windows.Forms.GroupBox();
        DataGridView historyDataGridView = new System.Windows.Forms.DataGridView();
        TabPage historyTab = new TabPage("History");


        //Declare Favourites Tab and Components 
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

        //Declare AddNewFavourites tab and components
        TextBox aliasTextBox = new System.Windows.Forms.TextBox();
        TextBox favouritesURLTextBox = new System.Windows.Forms.TextBox();
        CheckBox homePageCheckBox = new System.Windows.Forms.CheckBox();
        Label aliasLabel = new System.Windows.Forms.Label();
        Label urlLabel = new System.Windows.Forms.Label();
        Label favouriteAddLabel = new System.Windows.Forms.Label();
        Button submitFavouriteButton = new System.Windows.Forms.Button();
        Button cancelAddButton = new System.Windows.Forms.Button();
        TabPage addNewFavouriteTab = new TabPage("Add New Favourite");

        //Decalre Rendering Tab and give it a title
        TabPage renderTab = new TabPage("Rendered HTML");

        //Declare get and set methods for the spiderweb & Favourite objects
        public SpiderWeb SpiderWeb { get; set; }
        public Favourites Favourites { get; set; }

        //Declare a new Spiderweb & Favourite Objects
        SpiderWeb SW = new SpiderWeb();
        Favourites FV = new Favourites();

        /// <summary>
        /// Calls methods that declare and initiliase the first GUI for the user and loads history and favourites information 
        /// </summary>
        public firstPage()
        {
            //Calls method from firstPage class to declare and initialise most components
            InitializeComponent();

            //Assign lists to object type
            browserHistory = new List<SpiderWeb>();
            userFavourites = new List<Favourites>();

            //Assign serialisers used to retrieve and write information to files in the form of the List given to it
            hisSerializer = new XmlSerializer(typeof(List<SpiderWeb>));
            favSerializer = new XmlSerializer(typeof(List<Favourites>));

            // load history into browserHistory list and populate the corresponding DataGridView
            loadHistory();

            //load favourites into the userFavourites list
            loadFavourites();

            //Initialise the history counter to length of the browserHistory list - 1. This is used as an index reference when traversing the list chronologically 
            //as new items are added to the end of the list.
            historyCounter = browserHistory.Count - 1;

            // naviagte to users set homepage
            displayHomePage(userFavourites);
            addressBox.Text = homePageTextBox.Text;


            // if a favourite is set, navigate to it, loading
            if (addressBox.Text != "")
            {
                navigateToURL();
            }


        }


        //////////////////////////
        ////// Functional Code 
        /////////////////////////


        /// <summary>
        /// Opens the newHistory file, deserialises it and adds to the browserHistory list. This list is then set at the datasource for the  historyDataGridView. If an error occurs it creates a new file. 
        /// </summary>
        public void loadHistory()
        {
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "newHistory.xml")))
            {
                //Opens new file stream of the newHistoryXML with ability to only open and read.
                FileStream f = new FileStream(Path.Combine(Environment.CurrentDirectory, "newHistory.xml"), FileMode.Open, FileAccess.Read);
                try
                {
                    //Deserialise the XML file to a list of objects, set this as the content for our browserHistory list
                    browserHistory = (List<SpiderWeb>)hisSerializer.Deserialize(f);

                    //close filestream
                    f.Close();
                }
                //Catches errors that occur from the file corrupted or badly formatted. 
                catch (Exception e)
                {
                    f.Close();

                    // Create a new file, overwriting existing ones.
                    FileStream f2 = new FileStream(Path.Combine(Environment.CurrentDirectory, "newHistory.xml"), FileMode.Create, FileAccess.Write);

                    // Close filestream
                    f2.Close();
                }
            }
            else
            {
                // Create a new file, overwriting existing ones.
                FileStream f3 = new FileStream(Path.Combine(Environment.CurrentDirectory, "newHistory.xml"), FileMode.Create, FileAccess.Write);

                // Close filestream
                f3.Close();
            }

            //Sets the data source of the historyDataGridView to the browser history list. Enables it to display the information held in that list. 
            historyDataGridView.DataSource = browserHistory;

            // only perform column adjustment when list is populated
            if (historyDataGridView.Rows.Count != 0)
            {
                this.historyDataGridView.Columns[0].Width = 150;
                this.historyDataGridView.Columns[1].Visible = false;
                this.historyDataGridView.Columns[2].Visible = false;
                this.historyDataGridView.Columns[3].Width = 160;

                //historyDataGridView.Sort(historyDataGridView.Columns[3], ListSortDirection.Ascending);

            }
        }

        /// <summary>
        /// Overwrites any existing newHistory.xml file, sets the new Favourite object properties, adds the new object to list then saves the list back
        /// to the file original file once the list has been serialisated.
        /// </summary>
        public void addToHistory()
        {
            //open the file to check for prior references of current reference
            Stream fs = new FileStream(Path.Combine(Environment.CurrentDirectory, "newHistory.xml"), FileMode.Create, FileAccess.Write);

            //set the address box text as the url property of the SpiderWeb object
            SW.URL = addressBox.Text;
            //set the DateAndTime property of the SpiderWeb object to a formatted string of the current time and date. 
            SW.DateAndTime = DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’");

            // switch statement stopping an empty URL being added to the browserHistory list
            switch (SW.URL.Contains("www."))
            {
                //if true, ie empty, the list is serialised then saved to the XMLfile newHistory
                case false:
                    hisSerializer.Serialize(fs, browserHistory);
                    fs.Close();
                    MessageBox.Show("Please enter a correct URL\n eg www.google.com", "Bad URL", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    break;
                //if false, not empty,the current object is added the list. This list is then serialised and saved to the XMLfile newHistory
                case true:
                    browserHistory.Add(SW);
                    hisSerializer.Serialize(fs, browserHistory);
                    fs.Close();
                    break;
            }
            loadHistory();
        }

        /// <summary>
        /// Overwrites the newHistory.xml with a blank new one, then clears the browserHistory list of objects and nullifies the datasource 
        /// of the historyDataGridView
        /// </summary>
        public void clearHistory(List<SpiderWeb> clearHistory)
        {
            // Overwrite the newHistory.xml file with a new one with no content
            FileStream g = new FileStream(Path.Combine(Environment.CurrentDirectory, "newHistory.xml"), FileMode.Create, FileAccess.Write);
            g.Close();
            // empty list of its objects
            clearHistory.Clear();
            //nullify the data source.
            historyDataGridView.DataSource = null;

        }

        /// <summary>
        /// Creates a new History tab, unless one is already. If so, then it directs the user to that tab. 
        /// </summary>
        private void openHistoryTab()
        {
            InitializeHistoryTabComponents();
            loadHistory();
        }

        /// <summary>
        /// Appends HTML code to the htmlCodeTextBox and a HTTP status to the statusTextBox, provided a good url is given.
        /// </summary>
        /// <para>  
        /// Using the url in the addressBox, it creates a new object, calls methods to handle the HTTP request, response and corresponding status code. 
        /// It then adds object to the history list, reloads the history and resets the history counter
        /// </para> 
        public void navigateToURL()
        {

            //sets the addressBox text to a new object of SpiderWeb
            SW.URL = addressBox.Text;
            //set the DateAndTime property of the SpiderWeb object to a formatted string of the current time and date. 
            SW.DateAndTime = DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’");

            //set the tab title to be the URL in the addressBox
            homeTab.Text = addressBox.Text;

            //set the current form title 
            this.Text = "SpiderWEB - " + addressBox.Text;

            //http request using the current given URL in the addressBox by calling methods from spider web class handling request and responses
            htmlCodeTextBox.Text = SW.RetrieveHTMLCode(SW);
            statusTextBox.Text = SW.HTTPSStatusCode;

            //method that updates the browserHistory list
            loadHistory();

            //method that adds this new SpiderWeb object to the browserHistory list
            addToHistory();
            // reset the history counter
            historyCounter = browserHistory.Count - 1;

        }

        /// <summary>
        /// Creates a new favourites tab, unless one is already. If so, then it directs the user to that tab. 
        /// </summary>
        private void openFavouritesTab()
        {
            //Tests if the Tab Controll cotains favourites tab
            if (tabControl1.TabPages.Contains(favouritesTab) == false)
            {
                InitializeFavouritesTabComponents();
                loadFavourites();
                //displayHomePage(userFavourites);
                selectATab(favouritesTab);
            }
            //if favourites tab exists, navigate to it. 
            else
            {
                selectATab(favouritesTab);
            }

        }

        /// <summary>
        /// Creates a new newFavourites tab, unless one is already. If so, then it directs the user to that tab. 
        /// </summary>
        private void openAddNewFavouritesTab()
        {
            //Tests if the Tab Controll cotains newfavourites tab
            if (tabControl1.TabPages.Contains(addNewFavouriteTab) == false)
            {
                InitializeAddNewFavouriteTabComponent();
                selectATab(addNewFavouriteTab);
            }
            //if favourites tab exists, navigate to it. 
            else
            {
                selectATab(addNewFavouriteTab);
            }
        }

        /// <summary>
        /// Creates a new favourites tab, unless one is already. If so, then it directs the user to that tab.
        /// </summary>
        /// <param name="favourites">List of favourites</param>
        public void loadFavourites()
        {

            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "newFavourites.xml")))
            {
                //Opens new file stream of the newHistoryXML with ability to only open and read.
                FileStream f = new FileStream(Path.Combine(Environment.CurrentDirectory, "newFavourites.xml"), FileMode.Open, FileAccess.Read);
                try
                {
                    //Deserialise the XML file to a list of objects, set this as the content for our browserHistory list
                    userFavourites = (List<Favourites>)favSerializer.Deserialize(f);

                    //close filestream
                    f.Close();
                }
                //Catches errors that occur from the file corrupted or badly formatted. 
                catch (Exception e)
                {
                    f.Close();

                    // Create a new file, overwriting existing ones.
                    FileStream f2 = new FileStream(Path.Combine(Environment.CurrentDirectory, "newFavourites.xml"), FileMode.Create, FileAccess.Write);

                    // Close filestream
                    f2.Close();
                }
            }
            else
            {
                // Create a new file, overwriting existing ones.
                FileStream f3 = new FileStream(Path.Combine(Environment.CurrentDirectory, "newFavourites.xml"), FileMode.Create, FileAccess.Write);

                // Close filestream
                f3.Close();
            }

            //Sets the data source of the historyDataGridView to the browser history list. Enables it to display the information held in that list. 
            favouritesGridDataView.DataSource = userFavourites;

            //if there are rows of data in the DataGridView
            if (favouritesGridDataView.Rows.Count != 0)
            {
                //sets wiodth of data columns
                this.favouritesGridDataView.Columns[0].Width = 145;
                this.favouritesGridDataView.Columns[1].Width = 145;
                this.favouritesGridDataView.Columns[2].Visible = false;
            }
        }

        public void addToFavourites()
        {
            //Opens a filestream and overwrites (if it exists) the newFavourites.xml file with an empty one
            Stream fs = new FileStream(Path.Combine(Environment.CurrentDirectory, "newFavourites.xml"), FileMode.Create, FileAccess.Write);

            //set properties of FV object
            FV.Alias = aliasTextBox.Text;
            FV.URL = favouritesURLTextBox.Text;
            FV.HomePage = homePageCheckBox.Checked;

            //checks alias contains 'www.' or 'http' as this would causes errors with another method 
            if ((aliasTextBox.Text.Contains("www.") | aliasTextBox.Text.Contains("http")) && (favouritesURLTextBox.Text != "" | favouritesURLTextBox.Text != null))
            {   //Displayer message box to user, informing them of correct alias format
                MessageBox.Show("Please enter a valid alias, they must not contain 'www.' or 'http'", "Invalid or Erroneous Alias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                favSerializer.Serialize(fs, userFavourites);
                fs.Close();
            }
            //if alias does not contain 'www.' or 'http'
            else
            {
                //check if homePage box is checked
                if (homePageCheckBox.Checked == true)
                {
                    //removes old homepage
                    removeOldHomePage(userFavourites);
                    displayHomePage(userFavourites);

                    //adds new favourite to list
                    userFavourites.Add(FV);

                    //serialises userFavourites list
                    favSerializer.Serialize(fs, userFavourites);

                    //close filestream
                    fs.Close();

                    MessageBox.Show("New favourite added and set as your new Home Page!", "Successs!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //if homePage box is unchecked
                else
                {
                    //adds new favourite to list
                    userFavourites.Add(FV);

                    //serialises userFavourites list
                    favSerializer.Serialize(fs, userFavourites);

                    //close filestream
                    fs.Close();

                    //Inform user of addition of new favourite and homepage success
                    MessageBox.Show("New favourite added successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                loadFavourites();


            }
        }

        /// <summary>
        /// Iterates through the userFavourites list, finds the object whos homepage property is set to true. Then sets this as the text for the homePageTextbox
        /// </summary>
        private void displayHomePage(List<Favourites> userFavourites)
        {
            //iterate through all the favourites in the userFavourites list
            foreach (Favourites fav in userFavourites)
                //if the homepage value of the current object is true 
                if (Boolean.Equals(true, fav.HomePage))
                {
                    //set the homePageTextbox text to the URL of that favourite
                    homePageTextBox.Text = fav.URL;
                }
        }

        public void removeOldHomePage(List<Favourites> userFavourites)
        {
            //if the userFavourites list is not empty
            if (userFavourites.Count > 0)
            {
                //iterate thourgh the Favourite objects in the userFavourites list
                foreach (Favourites fav in userFavourites)
                {
                    //set the current Favourites homePage property to false
                    fav.HomePage = false;
                }
            }
        }

        /// <summary>
        /// Changes the favourites label to be specific for adding a homepage, sets the usual checkbox to be true and sets visibility to false to prevent user changing 
        /// </summary>
        public void changeSettingsForHomepage()
        {
            favouriteAddLabel.Text = "Add New Homepage";
            addNewFavouriteTab.Text = "Add New HomePage";
            homePageCheckBox.Checked = true;
            homePageCheckBox.Visible = false;
        }

        /// <summary>
        /// Changes the selected tab the user is looking at in the GUI
        /// </summary>
        /// <paramref name="tab"/> The TabPage you want your user to view </param>
        private void selectATab(TabPage tab)
        {
            tabControl1.SelectedTab = tab;
        }

        /// <summary>
        /// Pulls an object out of a list at the position equal to the value of the history counter, having first been incremented or decremented based on the input string.
        /// </summary>
        /// <paramref name="direction"/> The direction (chronologically) that you wish to traverse the list in </param>
        private void TraverseBrowserHistory(string direction)
        {
            // decrement the or increment counter the counter based on string given . This governs wether a larger or smaller indexen in the list is retrieved
            switch (direction)
            {
                case ("forward"):
                    historyCounter++;
                    break;

                case ("backward"):
                    historyCounter--;
                    break;

            }


            // historyCounter--;

            //if the history counter is set to the number of objects in the browserHistory list minus 1 OR the history counter is not less than 0.  
            //BrowserHistory count-1 as we shall use this as an index reference, that start at 0 thus prevents a ArrayOutOfBoundsException. Similarly,
            //if the counter is less than 0 it will also cause this error. 
            if ((historyCounter <= browserHistory.Count - 1 && historyCounter >= 0))
            {
                //clear the html from current website
                htmlCodeTextBox.Text = "";

                //get the element at the current index value of the history counter
                var lastEntry = browserHistory.ElementAt(historyCounter);

                //set the addressBox text to be the url property of the object at this element
                addressBox.Text = lastEntry.URL;

                //Set the SpiderWeb object to the lastEntry object
                SW = lastEntry;

                //navigate to the site without adding to history as it is already in the history
                htmlCodeTextBox.Text = SW.RetrieveHTMLCode(SW);
                statusTextBox.Text = SW.HTTPSStatusCode;
            }
            else
            {
                //reverse the change to the history counter if the counter is at the end or the start of the list
                switch (direction)
                {
                    case ("forward"):
                        historyCounter--;
                        break;

                    case ("backward"):
                        historyCounter++;
                        break;
                }
            }

        }


        //////////////////////////
        ////// Action Listeners
        /////////////////////////

        //Strip Menu Action Listeners

        /// <summary>
        /// Action listener for the File - exit option on the strip menu . Exits the program.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Creates a pop up form of the webBrowser class to render the URL currently 
        /// </summary>
        private void renderWebPageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //if the status code contains 'OK'
            if (statusTextBox.Text.Contains("OK"))
            {
                //create an instance of the rendow form and give it the URL in the addressBox
                renderPage render = new renderPage(addressBox.Text);

                //show the new form
                render.ShowDialog();
            }
            //if the status code does not contain 'OK'
            else
            {
                //Display message box to user asking them to first navigate to a valid site pior 
                MessageBox.Show("Please first navigate to a website that shows HTTP Status Code to be 'OK', then press render", "No Valid URL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Action listener for the "manage favourites" option. Calls the openFavouritesTab method. 
        /// </summary>
        private void manageFavouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFavouritesTab();
        }

        /// <summary>
        /// Action listener for the view browing history option in the menu. Creates calls methods that create a new history tab if one does not already exist.
        /// </summary>
        private void viewBrowsingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Checks if the TabControl already contains a historyTab TabPage if so calls methods that create the tab and make it the selected tab
            if (tabControl1.TabPages.Contains(historyTab) == false)
            {
                openHistoryTab();
                selectATab(historyTab);
            }
            //the tab exists already, make it the selected one to bring it to the front.
            else
            {
                tabControl1.SelectedTab = historyTab;

            }
        }

        /// <summary>
        /// Action listener for the History - Clear Browsing History option on the strip menu . Empties the browsingHistory list and newHistory.xml.
        /// </summary>
        private void clearBrowsingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearHistory(browserHistory);
        }

        // main buttons on firstPage

        /// <summary>
        /// Action listener for the Navigate button. Calls the naigateToURL method. 
        /// </summary>
        private void NavigateButton_Click(object sender, EventArgs e)
        {
            navigateToURL();
        }

        /// <summary>
        /// Action listener for the refreshButton. Reload the current URL.
        /// </summary>
        private void resfreshButton_Click(object sender, EventArgs e)
        {
            addressBox.Text = SW.URL;
            navigateToURL();
        }

        /// <summary>
        /// Action listener for the backButton. navigates the user to the last website they were at chronologically.
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            TraverseBrowserHistory("backward");
        }

        /// <summary>
        /// Action listener for the forwardsButton. Navigates the user to the a more recent website they were at chronologically, if possible. 
        /// </summary>
        private void forwardButton_Click(object sender, EventArgs e)
        {
            TraverseBrowserHistory("forward");
        }

        /// <summary>
        /// Action listener for the homeButton. Navigates the user to the home page defined in the userFvaourites list.
        /// </summary>
        private void homeButton_Click(object sender, EventArgs e)
        {
            SW.URL = homePageTextBox.Text;
            addressBox.Text = homePageTextBox.Text;
            navigateToURL();
        }

        /// <summary>
        /// Action listener for the favouritesButton. Allows the user to add a favourite object to the userFavourites list via a new form window.  
        /// </summary>
        private void favoritesButton_Click(object sender, EventArgs e)
        {
            openAddNewFavouritesTab();
        }

        // favourite tab action listeners

        /// <summary>
        /// Action listener for the closeFavouritesTabButton. Removes the favourites tab from the TabControl.
        /// </summary>
        private void closeFavouritesTabButton_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(favouritesTab);
        }

        /// <summary>
        /// Action listener for the changeHomePage button. Allows the user to add a new favourite object to the userFavourites list
        /// which is autmatically set as the homepage via an edited version of the addNewFavouritesButton form.  
        /// </summary>
        private void changeHomePageButton_Click(object sender, EventArgs e)
        {

            openAddNewFavouritesTab();
            changeSettingsForHomepage();

            displayHomePage(userFavourites);
        }

        /// <summary>
        /// On click Action listener for the FavouriteButton. Calls methods that load favourites then add to  
        /// </summary>
        private void submitFavouriteButton_Click(object sender, EventArgs e)
        {

            addToFavourites();
            loadFavourites();
            //empty the submission area
            tabControl1.TabPages.Remove(addNewFavouriteTab);

        }

        /// <summary>
        /// On click Action listener for the cancelAddButton. Removes the addNewFavourite tab from the tab control
        /// </summary>
        private void cancelAddButton_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(addNewFavouriteTab);
        }

        /// <summary>
        /// Action listener for the addFavouritesButton in the favourites tab. Allows the user to add a favourite object to the userFavourites list via a new form window.  
        /// </summary>
        private void addFavouritesButton_Click(object sender, EventArgs e)
        {
            openAddNewFavouritesTab();
        }

        /// <summary>
        /// Action listener for the removeFavouritesButton in the favourites tab. Allows the user to remove a favourite object to the userFavourites list  
        /// </summary>
        private void removeFavouriteButton_Click(object sender, EventArgs e)
        {

            //creates a string of the value found in the selected cell, in the selected row
            string url = favouritesGridDataView.CurrentCell.Value.ToString();

            //checks the number of objects in the list prior to removal, for comparison after
            int beforeRemoval = userFavourites.Count;

            if (int.Parse(favouritesGridDataView.CurrentCell.RowIndex.ToString()) > 0)
            {
                //removes an element from the userFavourites list at the index position of the selected favouritesGridDataView cell
                userFavourites.RemoveAt(int.Parse(favouritesGridDataView.CurrentCell.RowIndex.ToString()));

                //userFavourites.Remove(userFavourites.Find(x => x.URL.Contains(url)));

                //check length of userFavourites 
                int afterRemoval = userFavourites.Count;

                //Checks that that the count before = the new count +1
                switch (beforeRemoval == afterRemoval + 1)
                {
                    // if true, save changes to file by creating new file and additng the list to it to it via serialisation 
                    case true:
                        MessageBox.Show(String.Format("Favourite {0} was removed successfully", url));

                        //open filestream to write the new list to the file.
                        Stream fs = new FileStream(Path.Combine(Environment.CurrentDirectory, "newFavourites.xml"), FileMode.Create, FileAccess.Write);

                        //serialise the userFavourites list
                        favSerializer.Serialize(fs, userFavourites);

                        //close the filestream
                        fs.Close();

                        //load the updated list back into userFavourites 
                        loadFavourites();

                        break;

                    //if false, undo the changes by reloading in the file, thus resorting the list
                    case false:
                        MessageBox.Show(String.Format("No favourite named {0} could be found, please try again", url), "Favourite Removed");
                        loadHistory();
                        break;
                }
            }
            displayHomePage(userFavourites);
        }

        /// <summary>
        /// If user double clicks a cell containing a URL in the favouritesGridDataView, navigate to that URL
        /// </summary>
        private void favouritesGridDataView_CellContentDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

            //if the string value of the contents in the selected cell in the  favouritesGridDataView contains 'www.'
            if (favouritesGridDataView.CurrentCell.Value.ToString().Contains("www."))
            {
                //set the addressBox text to be this string 
                addressBox.Text = favouritesGridDataView.CurrentCell.Value.ToString();
                //load the HTML at the location
                navigateToURL();
                //set the homeTab as current tab
                selectATab(homeTab);
            }
        }

        //history tab action listeners

        /// <summary>
        /// Action listener for the closeHistoryTabButton. Removes the history tab from the TabControl.
        /// </summary>
        private void closeHistoryTabButton_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(historyTab);
        }

        /// <summary>
        /// Action listener for the historySearchButton. On click, will search the browserHistory list for a object whos url property contains the string
        /// provided in the historySearchTermTextBox   
        /// </summary>
        private void historySearchButton_Click(object sender, EventArgs e)
        {
            //create new list of spiderWeb objects to be the data source for the historySearchGridDataView display
            List<SpiderWeb> searchBrowserHistory = new List<SpiderWeb>();

            //if the historySearchTermTextBox text value is not null
            if (historySearchTermTextBox.Text != null)
            {
                //iterate through the browser history list 
                foreach (SpiderWeb SW in browserHistory)
                {
                    //if the current object URL property contains the term provided in the historySearchTermTextBox
                    if (SW.URL.Contains(historySearchTermTextBox.Text))
                    {
                        //add this object to the list created at the start
                        searchBrowserHistory.Add(SW);
                    }


                }
                //set the historySearchGridDataView datasource as the searchBrowserHistory list 
                historySearchGridDataView.DataSource = searchBrowserHistory;

                //if the historySearchGridDataView countains any results (ie more than one row)
                if (historySearchGridDataView.Rows.Count != 0)
                {
                    //format the cells
                    this.historySearchGridDataView.Columns[0].Width = 150;
                    this.historySearchGridDataView.Columns[1].Visible = false;
                    this.historySearchGridDataView.Columns[2].Visible = false;
                    this.historySearchGridDataView.Columns[3].Width = 160;
                }
            }

            else
            {
                //Display message box informing user of incorrect input
                MessageBox.Show("Invalid Input");

                // Reset the search box by setting it to an empty string
                historySearchTermTextBox.Text = string.Empty;

                //focus the users selection back on the historySearchTermTextBox
                historySearchTermTextBox.Focus();
            }
        }

        /// <summary>
        /// If user double clicks a cell containing a URL in the historyGridDataView, navigate to that URL
        /// </summary>
        private void historyGridDataView_CellContentDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            //if the string value of the contents in the selected cell in the historyDataGridView contains 'www.'
            if (historyDataGridView.CurrentCell.Value.ToString().Contains("www."))
            {
                //set the addressBox text to be the string 
                addressBox.Text = historyDataGridView.CurrentCell.Value.ToString();
                //load the HTML at the location
                navigateToURL();
                //set the homeTab as current tab
                selectATab(homeTab);
            }
        }

        /// <summary>
        /// If user double clicks a cell containing a URL in the historySearchGridDataView, navigate to that URL
        /// </summary>
        private void historySearchGridDataView_CellContentDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            //if the string value of the contents in the selected cell in the historySearchGridDataView contains 'www.'
            if (historySearchGridDataView.CurrentCell.Value.ToString().Contains("www."))
            {
                //set the addressBox text to be this string 
                addressBox.Text = historySearchGridDataView.CurrentCell.Value.ToString();
                //load the HTML at the location
                navigateToURL();
                //set the homeTab as current tab
                selectATab(homeTab);
            }
        }
    }
}

