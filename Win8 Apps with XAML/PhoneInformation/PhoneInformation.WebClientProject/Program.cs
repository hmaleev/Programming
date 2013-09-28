﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Xml;
using Newtonsoft.Json;
using System.IO;
namespace PhoneInformation.WebClientProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var info = new HtmlWeb();
            HtmlNodeCollection links;
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode declarationNode = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDoc.AppendChild(declarationNode);

            XmlNode phonesNode = xmlDoc.CreateElement("Phones");
            xmlDoc.AppendChild(phonesNode);
            for (int i = 1; i <= 3; i++)
            {
                var result = info.Load("http://www.gsmarena.com/lg-phones-f-20-0-p" + i + ".php");
              links = result.DocumentNode.SelectNodes("//div[@class='makers']//a");
              foreach (var item in links)
              {
                  XmlNode phoneNode = xmlDoc.CreateElement("Phone");
                  XmlNode linkNode = xmlDoc.CreateElement("Link");
                  XmlNode imageNode = xmlDoc.CreateElement("Image");
                  XmlNode nameNode = xmlDoc.CreateElement("Name");

                  linkNode.InnerText = item.Attributes["href"].Value;
                  imageNode.InnerText = item.FirstChild.Attributes["src"].Value;
                  nameNode.InnerText = item.InnerText;

                  phoneNode.AppendChild(linkNode);
                  phoneNode.AppendChild(imageNode);
                  phoneNode.AppendChild(nameNode);

                  phonesNode.AppendChild(phoneNode);
              }
            }
           var x= JsonConvert.SerializeObject(xmlDoc);
           var z = JsonConvert.DeserializeObject(x);
           File.WriteAllText(@"../../lg.json", x);
           xmlDoc.Save(@"../../lg.xml");
            //Console.WriteLine("Done");
        }
    }
}