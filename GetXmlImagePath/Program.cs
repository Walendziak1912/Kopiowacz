using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace GetXmlImagePath
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\DL\Desktop\VirtualBox\IncomingXML";

            DirectoryInfo dir = new DirectoryInfo(path);
            var files = dir.GetFiles();
            foreach (var file in files)
            {
                ImportSession import = new ImportSession();
                XmlSerializer serializer = new XmlSerializer(typeof(ImportSession));
                using (Stream reader = new FileStream(file.FullName, FileMode.Open))
                {
                    import= (ImportSession)serializer.Deserialize(reader);
                }
                foreach (var item in import.Batches.Batch.Pages.Page)
                {
                    File.AppendAllText("C:\\plikitoSkopiowania.txt", item.ImportFileName + System.Environment.NewLine);
                }
            }


        }
    }

    [XmlRoot(ElementName = "Page")]
    public class Page
    {
        [XmlAttribute(AttributeName = "ImportFileName")]
        public string ImportFileName { get; set; }
    }

    [XmlRoot(ElementName = "Pages")]
    public class Pages
    {
        [XmlElement(ElementName = "Page")]
        public List<Page> Page { get; set; }
    }

    [XmlRoot(ElementName = "Batch")]
    public class Batch
    {
        [XmlElement(ElementName = "Pages")]
        public Pages Pages { get; set; }
        [XmlAttribute(AttributeName = "EnableAutomaticSeparationAndFormID")]
        public string EnableAutomaticSeparationAndFormID { get; set; }
        [XmlAttribute(AttributeName = "BatchClassName")]
        public string BatchClassName { get; set; }
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "Batches")]
    public class Batches
    {
        [XmlElement(ElementName = "Batch")]
        public Batch Batch { get; set; }
    }

    [XmlRoot(ElementName = "ImportSession")]
    public class ImportSession
    {
        [XmlElement(ElementName = "Batches")]
        public Batches Batches { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd { get; set; }
        [XmlAttribute(AttributeName = "DeleteBatchOnError")]
        public string DeleteBatchOnError { get; set; }
    }
}
