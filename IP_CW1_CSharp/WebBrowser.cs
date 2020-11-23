using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_CW1_CSharp
{
    static class WebBrowser
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SpiderWEB());
            
        }
    }

    [Serializable()]
    public class History : ISerializable
    {

        public string Address { get; set; }
        public string TimeOfAccess { get; set; }

        public History() { }

        public History(string address, string timeOfAccess)
        {
            Address = address;
            TimeOfAccess = timeOfAccess;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Address", Address);
            info.AddValue("TimeOfAccess", TimeOfAccess);
        }

        public History(SerializationInfo info, StreamingContext context)
        {
            Address = (string)info.GetValue("Address", typeof(string));
            Address = (string)info.GetValue("TimeOfAccess", typeof(string));
        }
    }
}
