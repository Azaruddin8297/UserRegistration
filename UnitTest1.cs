using System.Security.Cryptography.X509Certificates;
using UserReg;
namespace UserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            validation vd = new validation();

            //Act

            bool email =  vd.ValidateEmail("ajar@gmail.com");
            bool Phone = vd.ValidatePhone("91 8297214219");
            bool pass = vd.ValidatePassword("Ajar1234");
            bool paas1 = vd.ValidatePassword1("Ajar1234");
            bool paas2 = vd.ValidatePassword1("Ajar1234");
            bool paas3 = vd.ValidatePassword1("Ajar1234");


            //Assert
            //FirstName
            Assert.AreEqual(validation.Check("Azar"), true);
            //LastName
            Assert.AreEqual(validation.Check("Azar"), true);
            //Email
            Assert.AreEqual(email, true);
            //Phone
            Assert.AreEqual(Phone, true);
            //password
            Assert.AreEqual(pass, true);
            //password1
            Assert.AreEqual(paas1, true);
            //password2
            Assert.AreEqual(paas2, true);
            //password3
            Assert.AreEqual(paas3, true);

        }
   
    }
    
}