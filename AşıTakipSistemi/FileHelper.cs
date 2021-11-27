using AşıTakipSistemi.Model.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace AşıTakipSistemi
{
    class FileHelper
    {
        private static string KlasorYolu = @"C:\\AsiTakipSistemi";
        private static string CocukKayıtYolu = Path.Combine(KlasorYolu, "Cocuklar.xml");
        public static void KlasorOlustur()
        {
            if (!Directory.Exists(KlasorYolu))
                Directory.CreateDirectory(KlasorYolu);
        }
        #region Cocuklar
        public static void CocukKayıtOlustur()
        {
            KlasorOlustur();

            if (!File.Exists(CocukKayıtYolu))
            {
                var file = File.Create(CocukKayıtYolu);
                file.Close();
            }
        }

        public static void IlkCocukKayıtEkle()
        {
            CocukSchema cocuklar = new CocukSchema();
            List<CocukSchemaCocuk> cocukItemList = new List<CocukSchemaCocuk> {
           new CocukSchemaCocuk(){ ID=1, TC="123456789",Şifre="A123",Cinsiyet="Kız",Ad="AYŞE",DoğumTarihi=DateTime.Parse("2017-12-12"), Soyad= "YILMAZ", Kilo=45.0,Boy=150.0},
           new CocukSchemaCocuk(){ID=2, TC="131398410",Şifre="B420",Cinsiyet="Erkek",Ad="Hasan",Soyad= "Tire",DoğumTarihi=DateTime.Parse("2017-12-10"), Kilo=10.0,Boy=100.0}
       };

            cocuklar.Cocuk = cocukItemList.ToArray();

            XmlSerializer xs = new XmlSerializer(typeof(CocukSchema));
            var xml = "";
            using (var sw = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sw))
                {
                    xs.Serialize(writer, cocuklar);

                    xml = sw.ToString();
                }
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            xmlDoc.Save(CocukKayıtYolu);


        }

        public static List<cocukTable> cocukKayıtlarıOku()
        {
            if (File.Exists(CocukKayıtYolu))
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(CocukKayıtYolu);

                XmlNode cocuklarNode = xml.ChildNodes[1];
                List<cocukTable> cocukList = new List<cocukTable>();


                foreach (XmlNode cocuk in cocuklarNode)
                    cocukList.Add(new cocukTable(Convert.ToInt32(cocuk["ID"].InnerText.Trim()), cocuk["TC"].InnerText.Trim(), cocuk["Şifre"].InnerText.Trim(), cocuk["Ad"].InnerText.Trim(), cocuk["Soyad"].InnerText.Trim(), Convert.ToDateTime(cocuk["DoğumTarihi"].InnerText.Trim()), Convert.ToDouble(cocuk["Kilo"].InnerText.Trim()), Convert.ToDouble(cocuk["Boy"].InnerText.Trim())));

                return cocukList;
            }

            return new List<cocukTable>();
        }

        public static void cocukEkle(cocukTable cocukBilgisi)
        {
            CocukKayıtOlustur();

            XElement cocuklar = new XElement("Cocuklar",
                                                        new XElement("ID", cocukBilgisi.ID),
                                                                new XElement("TC", cocukBilgisi.TC),
                                                                new XElement("Şifre", cocukBilgisi.Şifre),
                                                                 new XElement("Ad", cocukBilgisi.Ad),
                                                                 new XElement("Soyad", cocukBilgisi.Soyad),
                                                                 new XElement("DoğumTarihi", cocukBilgisi.DoğumTarihi),
                                                                 new XElement("Kilo", cocukBilgisi.Kilo),
                                                                  new XElement("Boy", cocukBilgisi.Boy)
                                                                   );

            FileStream stream = File.Open(CocukKayıtYolu, FileMode.Open);
            XDocument xml = XDocument.Load(stream);

            stream.Close();

            xml.Root.Add(cocuklar);
            xml.Save(CocukKayıtYolu);
        }
    }
}
#endregion Cocuklar