using Xunit;
using MVC_IP_CW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace MVC_IP_CW.Tests
{
    public class SpiderWebTests
    {
        [Fact]
        public void formatHTTP_ShouldAddhttp()
        {
            // Arrange 
            string urlWithoutHttps = "www.google.com";
            string expected = "http://www.google.com";

            // Act
            string actual = MVC_IP_CW.SpiderWeb.Format_HTTP(urlWithoutHttps);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void formatHTTP_ShouldntAddhttp()
        {
            // Arrange 
            string urlWithoutHttps = "http://www.google.com";
            string expected = "http://www.google.com";

            // Act
            string actual = MVC_IP_CW.SpiderWeb.Format_HTTP(urlWithoutHttps);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void formatHTTP_ShouldAddPartOfHttp()
        {
            // Arrange 
            string urlWithoutHttps = "ht//www.google.com";
            string expected = "http://www.google.com";

            // Act
            string actual = MVC_IP_CW.SpiderWeb.Format_HTTP(urlWithoutHttps);

            // Assert
            Assert.Equal(expected, actual);
        }

        ///<summary>
        ///Tests if a link containing a link disgned to throw an error throws the correct WebException error when an object containing this property
        ///is passed into the RetrieveHTMLCode method
        ///</summary>
        [Fact()]
        public void RetrieveHTMLCode_WebException400ShouldThrow()
        {
            //Arrange
            SpiderWeb testSpiderWeb = new SpiderWeb();
            testSpiderWeb.URL = "http://status.savanttools.com/?code=400%20Bad%20Request";
            testSpiderWeb.DateAndTime = DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’"); 

            // Act & Assert
            Assert.Throws<WebException>(() => testSpiderWeb.RetrieveHTMLCode(testSpiderWeb));
        }

        ///<summary>
        ///Tests if a link containing a link disgned to throw an error throws the correct WebException error when an object containing this property
        ///is passed into the RetrieveHTMLCode method
        ///</summary>
        [Fact()]
        public void RetrieveHTMLCode_WebException403ShouldThrow()
        {
            //Arrange
            SpiderWeb testSpiderWeb = new SpiderWeb();
            testSpiderWeb.URL = "http://status.savanttools.com/?code=403%20Forbidden";
            testSpiderWeb.DateAndTime = DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’");

            Assert.Throws<WebException>(() => testSpiderWeb.RetrieveHTMLCode(testSpiderWeb));

        }

        ///<summary>
        ///Tests if a link containing a link disgned to throw an error throws the correct WebException error when an object containing this property
        ///is passed into the RetrieveHTMLCode method
        ///</summary>
        [Fact()]
        public void RetrieveHTMLCode_WebException404ShouldThrow()
        {
            //Arrange
            SpiderWeb testSpiderWeb = new SpiderWeb();
            testSpiderWeb.URL = "http://status.savanttools.com/?code=404%20Not%20Found";
            testSpiderWeb.DateAndTime = DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’");

            Assert.Throws<WebException>(() => testSpiderWeb.RetrieveHTMLCode(testSpiderWeb));
        }
    }
}