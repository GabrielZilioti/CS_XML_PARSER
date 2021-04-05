using System.Xml;

XmlDocument xml = new XmlDocument();
xml.Load(filename: "C:/Users/A376228/Desktop/xml/ped1.xml");
XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(xml.NameTable);
xmlNamespaceManager.AddNamespace("x", "http://www.portalfiscal.inf.br/nfe");
XmlNodeList nodeList = xml.DocumentElement.SelectNodes(xpath: "//x:infNFe/x:det[@nItem >= 2]",
    xmlNamespaceManager);

foreach (XmlNode node in nodeList)
{
    node.ParentNode.RemoveChild(node);
}
xml.Save(filename: "C:/Users/A376228/Desktop/xml/ped1-ready.xml");
