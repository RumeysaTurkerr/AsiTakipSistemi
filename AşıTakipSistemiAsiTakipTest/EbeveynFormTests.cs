using Microsoft.VisualStudio.TestTools.UnitTesting;
using AşıTakipSistemi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AşıTakipSistemi.Tests
{
    [TestClass()]
    public class EbeveynFormTests
    {
        EbeveynForm e = new EbeveynForm();
        [TestMethod()]
        public void bilgiDondurTest()
        {

            string expected = e.bilgiDondur("77788899");   // girilen tc'ye sahip kişinin 
                                                           //aşıya kalan gün sayısı test
            Assert.AreEqual(expected, "18");

        }

        [TestMethod()]
        public void aramaTest()
        {
            string expected = e.arama("123456789");  //girilen tc
            Assert.AreEqual(expected, "abc123");    //beklenen şifre

        }
    }
}