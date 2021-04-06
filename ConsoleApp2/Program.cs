using System.IO;
using System.Xml;

/*Author : Zilioti
  Made in: VolvoCE
  Year   :2021
*/



var files = Directory.GetFiles("C:/Users/A376228/Desktop/xml", "*.xml", SearchOption.AllDirectories);

foreach (var file in files)
{
    XmlDocument xml = new XmlDocument();
    xml.Load(file);
    XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(xml.NameTable);
    xmlNamespaceManager.AddNamespace("x", "http://www.portalfiscal.inf.br/nfe");
    XmlNodeList nodeList = xml.DocumentElement.SelectNodes(xpath: "//x:infNFe/x:det[@nItem >= 2]",
        xmlNamespaceManager);

    foreach (XmlNode node in nodeList)
    {
        node.ParentNode.RemoveChild(node);
    }
    xml.Save(file);

}