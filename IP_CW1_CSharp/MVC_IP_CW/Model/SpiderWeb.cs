using NUnit.Framework;
using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MVC_IP_CW
{
    // <summary> Class <c> SpiderWeb</c>
    /// 
    /// Defines the properties of 'SpiderWeb' objects and has methods to handle Sending and Recieving HTTP response messages.
    /// Relevant exceptions are caught by methods to prevent program halting.
    /// 
    /// Impletments IDsiplay interface. XMLIgnore is used to prevent serilisation of uneeded data
    /// </summary>

    [Serializable()]
    public class SpiderWeb : ISerializable
    {
        //Defines the private variables for the class
        [XmlIgnore]
        private string url;
        private string dateAndTime;
        [XmlIgnore]
        private string htmlResponseCode;
        [XmlIgnore]
        private string httpStatusCode;


        [XmlIgnore]
        public HttpWebRequest request;
        [XmlIgnore]
        public HttpWebResponse response;
        [XmlIgnore]
        public Match m;

        //Declare object
        public SpiderWeb() { }

        /// <summary>
        ///Constructor for spiderWeb objects.
        ///</summary>
        ///    <param name="dateandtime"> the date and time of navigation </param> 
        ///    <param name="url"> the URL of the desired website  </param> 
        ///    <param name="htmlcode"> the recieved html code from the HTTP response </param>
        ///    <param name="httpstatus"> the recieved status code from the HTTP response </param>
        ///
        public SpiderWeb(string url, string htmlcode, string httpstatus, string dateandtime)
        {
            this.url = url;
            this.htmlResponseCode = htmlcode;
            this.httpStatusCode = httpstatus;
            this.dateAndTime = dateandtime;
        }


        /// <summary>
        ///Setup get; and set; methods for all the properties of the SpiderWeb objects
        /// </summary>
        public string URL
        {
            get { return url; }
            set { url = value; }
        }

        [XmlIgnore]
        public string HTMLResponseCode
        {
            get { return htmlResponseCode; }
            set { htmlResponseCode = value; }
        }

        [XmlIgnore]
        public string HTTPSStatusCode
        {
            get { return httpStatusCode; }
            set { httpStatusCode = value; }
        }


        public string DateAndTime
        {
            get { return dateAndTime; }
            set { dateAndTime = value; }
        }

        /// <summary>
        /// Checks if the string presented contains the string "https://", if not it will add it then return it. 
        /// <param name = httpRequest> a string of a httpRequest <param>
        /// <returns> httpRequest string in new format (if needed)</returns>
        /// </summary>
        public static string Format_HTTP(string httpRequest)
        {

            // correct start for https request, of length 8 charcters
            string correct_start = "http://";
            string formatted_html = "";

            // check if address already contains initial "https"
            if (httpRequest.Contains("http://") == false)
            {

                //loops from 1 to 8 as "http://" has 8 characters
                for (int i = 0; i < 8; i++)
                {
                    try
                    {

                        // asserts that the i character of the i correct start matches the reciprical in the httpRequest string
                        if (httpRequest[i] != correct_start[i])
                        {
                            // if they dont match insert the current char converted to a string into a holder string 
                            formatted_html = httpRequest.Insert(i, correct_start[i].ToString());

                            // stores the updated string in the initial string, to prevent loss of update
                            httpRequest = formatted_html;
                            System.Diagnostics.Debug.WriteLine(formatted_html);
                        }
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        return httpRequest;
                    }
                }
                return httpRequest;
            }
            else
            {
                return httpRequest;
            }
        }

        /// <summary> 
        /// Uses the URL property of the object to create a HTTP request & response. Then sets the HTMLResponseCode and Status for the given URL.
        ///<para>
        /// Checks if the provided object URL is empty or null then opens a try/catch block. It then gets the URL property of the provided SpiderWeb
        /// object, then calls the formatting method to reduce user caused errors. It then creates a HttpWebRequest from this url and calls the 
        /// getResponse method to create a HTTPWebResponse. A Number of exceptions are caught to prevent the user crashing the program, such as error 404.
        /// </para>
        /// <param name=SW> An instance of the spiderweb object </param> 
        /// <returns> HTMLRepsonseCode - the html code of the desired website and its status code </returns>
        /// </summary>
        public string RetrieveHTMLCode(SpiderWeb SW)
        {

            // checks if the URL of the SW object is empty or null, if not proceed. 
            if (SW.URL != null && SW.URL != "")
            {
                try
                {
                    //checks that URL has https:// in the request, creates a new string in the new format
                    string formattedURL = Format_HTTP(SW.URL);

                    //sets the object URL to equal the formatted string
                    SW.URL = formattedURL;

                    //URL request to a server
                    request = (HttpWebRequest)WebRequest.Create(SW.URL);

                    //Response from a server 
                    response = (HttpWebResponse)request.GetResponse();

                    //will only get here if status == OK
                    StreamReader responseStream = new StreamReader(response.GetResponseStream());

                    //reader
                    SW.HTMLResponseCode = responseStream.ReadToEnd();
                    SW.HTTPSStatusCode = string.Format("{0} \t\t Code : {1}", response.StatusDescription, (int)response.StatusCode);

                    //close the stream to release the connection, prevents the application running out of connections
                    responseStream.Close();


                }
                //Catches format issues with the URL stored in the object when trying to use as a HTTPWebRequest
                catch (UriFormatException)
                {
                    MessageBox.Show("Could Not Search", "Please use a correct URL format eg www.google.com", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                // //Eexception thrown when an error occurs while accessing the network through a pluggable protocol such as error 404.. etc 
                catch (WebException ex)
                {

                    if (ex.Status == WebExceptionStatus.ProtocolError | ex.Status.ToString() == "ConnectFailure")
                    {

                        //create a HttpWebResponse from the error response
                        var ErrorResponse = ex.Response as HttpWebResponse;

                        if (ErrorResponse != null)
                        {
                            // display message box to alert user to the exact error 
                            //MessageBox.Show(string.Format("  {0} \t\t Status Code : {1}", ErrorResponse.StatusDescription, (int)ErrorResponse.StatusCode), "Error Loading Page", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            // add the same error information to the status box in the GUI
                            SW.HTTPSStatusCode = string.Format(" {0} \t\t Status Code : {1}", ErrorResponse.StatusDescription, (int)ErrorResponse.StatusCode);

                            // add extra information 
                            SW.HTMLResponseCode = "This site causes an error, please see below for details...";

                           
                        }
                        throw new WebException(string.Format("  {0} \t\t Status Code : {1}", ErrorResponse.StatusDescription, (int)ErrorResponse.StatusCode));
                    } 
                  
                }

                // catches any other, previously uncaught, exceptions that may triggor program crash
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Please enter a valid URL", "Error Loading HTML", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    SW.HTMLResponseCode = "This site causes an error, please see below for details...";
                    SW.HTTPSStatusCode = "Entered URL causes an error : " + e.Message;
                }

            }
            else
            {
                //if URL is null or empty this will trigger to inform user to enter valid input
                System.Windows.Forms.MessageBox.Show("Please enter a valid URL", "Error Loading HTML", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                SW.HTMLResponseCode = "This site causes an error, please see below for details...";
                SW.HTTPSStatusCode = "Error Loading HTML - Please enter a valid URL - eg www.google.com";
            }
            return (HTMLResponseCode);


        }

        /// <summary> 
        /// Populates a SerializationInfo with the data needed to serialize the target object.
        /// </summary>
        ///<paramref name="context"> holds the serialized object data about the exception being thrown </param>
        ///<paramref name="info"/> contains contextual information about the source or destination </param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            GetObjectData(info, context);
        }
    }
}