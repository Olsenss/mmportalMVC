using Microsoft.VisualStudio.TestTools.UnitTesting;
using mmportalMVC.Services;
using System;

namespace UnitTestMellemmanden
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SendEmailTest()
        {
            var service = new EmailService();
            var to = "mwolsen123@gmail.com";
            var sub = "Emnefelt";
            var body = "<h1>Hej</h1>";

            service.SendEmail(to,sub,body);
        }
    }
}
