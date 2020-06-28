using System;
using System.Windows.Forms;
using System.Xml;

namespace WeightRecord
{
    public class ConfigHelper
    {
        private void UpdateConfig(string Xvalue)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Application.ExecutablePath + ".config");
            XmlNode node = doc.SelectSingleNode(@"//add[@key='setInterval']");
            XmlElement ele = (XmlElement)node;
            ele.SetAttribute("value", Xvalue);
            doc.Save(Application.ExecutablePath + ".config");
        }
        private void SetValue(String AppKey, String AppValue)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(System.Windows.Forms.Application.ExecutablePath + ".config");
            XmlNode xNode;
            XmlElement xElem1;
            XmlElement xElem2;
            xNode = xDoc.SelectSingleNode("//appSettings");
            xElem1 = (XmlElement)xNode.SelectSingleNode("//add[@key=’" + AppKey + "’]");
            if (xElem1 != null)
                xElem1.SetAttribute("value", AppValue);
            else
            {
                xElem2 = xDoc.CreateElement("add");
                xElem2.SetAttribute("key", AppKey);
                xElem2.SetAttribute("value", AppValue);
                xNode.AppendChild(xElem2);
            }
            xDoc.Save(System.Windows.Forms.Application.ExecutablePath + ".config");
        }


    }
}
