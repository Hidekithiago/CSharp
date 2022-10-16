## <a href="https://github.com/Hidekithiago/CSharp/blob/master/README.md">XML</a> <br>
<details>
<details><summary><b>GET NODE</b></summary>
  
####  NuGet
  > 
  
####  import
  >using System.Xml;
  
####  Code
  >XmlDocument doc = new XmlDocument();
  ><br>doc.Load("C:/Quaestum/Projetos c#/XML_doc.xml");
  ><br>XmlNodeList elemList = doc.GetElementsByTagName("documentoVinculado");
  ><br>Console.Write("Inicio da busca...");
  ><br>string content = "";
  ><br>for (int i = 0; i < elemList.Count; i++)
  ><br>{
  ><br>content = elemList[i].InnerXml;
  ><br>}
  ><br>Console.WriteLine("Fim da busca.\n");
  ><br>char[] delimiterChars = { '<', '>', '/' };
  ><br>IEnumerable<string> elements = content.Split(delimiterChars).Distinct();
  ><br>Console.WriteLine("Itens encontrados em documentoVinculado:");
  ><br>foreach (string element in elements)
  ><br>{
  ><br>Console.WriteLine(element);
  ><br>}
  
</details>
</details>
