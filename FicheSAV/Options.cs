using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace FicheSAV
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            XmlDocument preferences = new XmlDocument(); ;

            if (File.Exists(@"config.xml"))
            {
                preferences.Load(@"config.xml");
                XmlNode ServeurIp = preferences.SelectSingleNode("config/serveur");
                label3.Text = ServeurIp.Attributes["ip"].Value;
                preferences.Save("config.xml");
            }
            else
            {
                XmlDeclaration declaration;
                declaration = preferences.CreateXmlDeclaration("1.0", "utf-8", null);
                preferences.AppendChild(declaration);

                XmlElement racine = preferences.CreateElement("config");
                preferences.AppendChild(racine);

                XmlElement serveur = preferences.CreateElement("serveur");
                racine.AppendChild(serveur);

                XmlAttribute ip = preferences.CreateAttribute("ip");
                ip.Value = "127.0.0.1";
                serveur.Attributes.Append(ip);

                preferences.Save("config.xml");

                label3.Text = ip.Value;
            }
        }

        private void bValider_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                XmlDocument preference = new XmlDocument();
                preference.Load(@"config.xml");
                XmlNode ServeurIp = preference.SelectSingleNode("config/serveur");
                ServeurIp.Attributes["ip"].Value = textBox1.Text;
                preference.Save("config.xml");

                MessageBox.Show("Adresse IP du serveur changée");
                Hide();
            }
        }

    }
}
