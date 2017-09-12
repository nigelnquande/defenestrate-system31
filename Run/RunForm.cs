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
using System.Xml;

namespace run
{
    public partial class RunForm : Form
    {
        public RunForm ()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Make the run.xml file (if it doesn't exist) and return the path to it
        /// </summary>
        /// <returns></returns>
        private String GetRunListPath () {
            String dirSep = Char.ToString(Path.DirectorySeparatorChar);
            String userAppData;
            String UserAppDataPath = Application.UserAppDataPath;
            if (UserAppDataPath.Length > 0) // Windows
                userAppData = (UserAppDataPath.EndsWith(dirSep)) ?
                    UserAppDataPath : UserAppDataPath + dirSep;
            else { // *NIX
                String homeDir = System.Environment.GetEnvironmentVariable("HOME");
                userAppData = ((homeDir.EndsWith(dirSep)) ?
                    homeDir : homeDir + dirSep) + "Run" + dirSep;
            }
            bool userDirExists = false;
            try { // attempt to store the last run items in the user's appData path
                Directory.CreateDirectory(userAppData);
                userDirExists = true;
            } catch (Exception ex) {
                userDirExists = false;
            }

            String filePath = userAppData + "run.xml";
            if (userDirExists) {
                StreamWriter xmlWriter = null;
                if (!File.Exists(filePath)) try {
                        xmlWriter = File.AppendText(filePath);
                        xmlWriter.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\" ?>");
                        xmlWriter.WriteLine("<items><!-- List of the last eight (or fewer) programs run  -->");
                        xmlWriter.WriteLine("\t<item>mspaint</item>"); // Alias to netpaint
                        xmlWriter.WriteLine("\t<item>cmd</item>"); // alias to bash
                        xmlWriter.WriteLine("\t<item>calc</item>"); // alias to galculator
                        xmlWriter.WriteLine("\t<item>regedit</item>"); // alias to fake regedit as UNIX doesn't have a registry
                        xmlWriter.WriteLine("\t<item>syskey</item>"); // fake syskey
                        xmlWriter.WriteLine("\t<item>msinfo32</item>"); // fake msinfo32
                        xmlWriter.WriteLine("\t<item>services.msc</item>"); // fake services.msc
                        xmlWriter.WriteLine("</items>");

                    } catch (Exception ex) {
                    } finally {
                        if (null != xmlWriter) try {
                                xmlWriter.Flush();
                                xmlWriter.Close();
                            } catch (Exception ex) { };
                    }
            } else userAppData = Application.ExecutablePath.Substring(
                0, Application.ExecutablePath.LastIndexOf(Path.DirectorySeparatorChar) + 1
            ); // use the current execution directory as the App Data directory

            return userAppData + "run.xml";
        }

        private List<string> GetNodeText (XmlDocument doc) {
            List<string> nodeList = new List<string>();
            foreach (XmlNode node in doc.DocumentElement.ChildNodes) {
                if (node.HasChildNodes) { // root node: items
                    foreach (XmlNode innerNode in node.ChildNodes) { // item
                        nodeList.Add(innerNode.InnerText);
                    }
                } // else nodeList.Add(node.InnerText);
            }
            return nodeList;
        }

        /// <summary>
        /// Read the items in run.xml and place them into the combo box.
        /// </summary>
        private void LoadRecentlyRun () {
            String filePath = this.GetRunListPath();
            StreamReader xmlReader = null;
            try {
                xmlReader = File.OpenText(filePath);
                String xml = xmlReader.ReadToEnd();
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                foreach (string item in GetNodeText(doc)) { this.openComboBox.Items.Add(item); }
                if (this.openComboBox.Items.Count > 0) this.openComboBox.SelectedIndex = 0;
            } catch (IOException ex) {
            } catch (Exception ex) {
            }
        }

        private void RunForm_Load (object sender, EventArgs e)
        {
            LoadRecentlyRun();
            // MessageBox.Show(this, GetRunListPath(), "Run.xml configuration Path"); 


        }
    }
}
