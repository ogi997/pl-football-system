﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PLFootballSystem.Util
{
    class ChangeTheme
    {
        public static void UpdateConfig(string key, string value)
        {
            var xmlDoc = new XmlDocument();

            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement xmlElement in xmlDoc.DocumentElement)
            {
                if (xmlElement.Name.Equals("appSettings"))
                {
                    foreach (XmlNode xNode in xmlElement.ChildNodes)
                    {
                        if (xNode.Attributes[0].Value.Equals(key))
                        {
                            xNode.Attributes[1].Value = value;
                        }
                    }
                }
            }

            ConfigurationManager.RefreshSection("appSettings");

            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }

        public static string GetTheme()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement xmlElement in xmlDoc.DocumentElement)
            {
                if ("appSettings".Equals(xmlElement.Name))
                {
                    foreach (XmlNode xNode in xmlElement.ChildNodes)
                    {
                        if ("theme".Equals(xNode.Attributes[0].Value))
                        {
                            Console.WriteLine(xNode.Attributes[1].Value);
                            return xNode.Attributes[1].Value;
                        }
                    }
                }
            }
            return null;
        }
    }
}
