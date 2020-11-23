using System;
using System.Runtime.Serialization;

namespace MVC_IP_CW
{   //key word informing the serialiser that this class is serializable
    [Serializable()]

    // <summary> Class <c> Favourites /c>
    /// 
    /// Defines the properties of the Favourites objects. Contains a method to check status codes of potential Favourite object URLs
    /// 
    /// Implements the ISerializable interface
    /// </summary>
    public class Favourites : ISerializable
    {

        // <summary>
        /// Private fields for favourite Objects
        /// </summary>
        // private fields
        private string alias;
        private string url;
        private Boolean homePage;


        public Favourites() { }

        /// <summary>
        ///Constructor for Favourites objects. 
        ///</summary>
        ///     <param name="alias"> the date and time of navigation </param> 
        ///     <param name="url"> the URL of the desired website  </param> 
        ///     <param name="homepage">is the object set a homepage? </param>

        public Favourites(string alias, string url, Boolean homepage)
        {
            this.alias = alias;
            this.url = url;
            this.homePage = homepage;
        }

        /// <summary>
        ///Setup get; and set; methods for all the properties of the Favourites objects
        /// </summary>
        public string Alias
        {
            get { return alias; }
            set { alias = value; }
        }


        public string URL
        {
            get { return url; }
            set { url = value; }
        }


        public Boolean HomePage
        {
            get { return homePage; }
            set { homePage = value; }
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