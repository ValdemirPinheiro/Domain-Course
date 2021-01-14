using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Tests.Handlers
{
    public class SubscriptionHandlerTests
    {
        public void ShouldReturnErrorWhen()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();


            command.FirstName = "Valdemir";
            command.LastName = "Pinheiro";
            command.Document = "99999999999";
            command.Email = "vv@da.io";
            command.BarCode = "231156456454";
            command.BoletoNumber = "889489444849";
            command.PaymentNumber = "12321";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "PINHEIRO";
            command.PayerDocument = "12345678911";
            command.PayerEmail = "pinheiroone@gmail.com";
            command.PayerDocumentType = Domain.Enums.EDocumentType.CPF;
            command.Street = "dsadasdas";
            command.Number = "123";
            command.Neighborhood = "dsasdads";
            command.City = "João Pessoa";
            command.State = "PB";
            command.Country = "BR";
            command.ZipCode = "58073000";

            handler.Handle(command);
            Assert.AreEqual(false, handler.Valid);
        }
    }
}
