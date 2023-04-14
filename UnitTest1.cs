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
            
            validation vd = new validation();
            //FirstName
            string Expected = "Enter the Valid FristName";
            try
            {
                bool result = validation.Check("1");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(Expected, ex.Message);
            }

            //LastName
            string Expected1 = "Enter the Valid LastName";
            try
            {
                bool result = validation.Check2("1");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(Expected1, ex.Message);
            }
            ////Email
            string Expected2 = "Enter valid Email";
            try
            {
                bool email = vd.ValidateEmail("@ahsda");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(Expected2, ex.Message);
            }
            ////Phone
            string Expected3 = "Enter valid Phone";
            try
            {
                bool Phone = vd.ValidatePhone("2972");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(Expected3, ex.Message);
            }
            ////password
            string Expected4 = "Enter valid Password";
            try
            {
                bool Pass = vd.ValidatePassword("a");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(Expected4, ex.Message);
            }
            ////password1
            string Expected5 = "Enter valid Password1";
            try
            {
                bool pass1 = vd.ValidatePassword1("a");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(Expected5, ex.Message);
            }
            ////password2
            string Expected6 = "Enter valid Password2";
            try
            {
                bool pass2 = vd.ValidatePassword2("a");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(Expected6, ex.Message);
            }
            ////password3
            string Expected7 = "Enter valid Password3";
            try
            {
                bool pass1 = vd.ValidatePassword3("a");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(Expected7, ex.Message);
            }

        }

    }

}