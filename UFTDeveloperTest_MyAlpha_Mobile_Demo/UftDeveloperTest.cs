using HP.LFT.SDK;
using HP.LFT.SDK.Mobile;
using HP.LFT.Verifications;
using NUnit.Framework;
using System;
using System.Threading;

namespace UFTDeveloperTest_MyAlpha_Mobile_Demo
{
    [TestFixture]
    public class UftDeveloperTest : UnitTestClassBase
    {
        private string deviceID = "";
        private string username = "";
        private string pwd = "";
        private string card_number = "";

        [OneTimeSetUp]
        public void TestFixtureSetUp()
        {
            // Setup once per fixture
        }

        [SetUp]
        public void SetUp()
        {
            // Before each test
            //Parameterization
            deviceID = "ebd0c990";
            username = "DemoUser1";
            pwd = "5ffd7638254f3f30b8193716a390983ac0ee";
            card_number = "01234567890123";
        }

        [Test]
        public void Test()
        {
            IDevice device = MobileLab.LockDeviceById(deviceID);

            MobileLoginAppModel_1 mobileLoginAppModel = new MobileLoginAppModel_1(device);
            MobileForgotPwdAppModel mobileForgotPwdAppModel = new MobileForgotPwdAppModel(device);
            MobileForgotUsrAppModel mobileForgotUsrAppModel = new MobileForgotUsrAppModel(device);

            //click on alphaMobile app
            mobileLoginAppModel.HomeApplication.MyalphaMobileLabel.Tap();

            //select login - depends on active screen
            bool creds_exist = mobileLoginAppModel.MyalphaMobileApplication.LoginWithCredentialsLabel.Exists();
            if (creds_exist == true)
                mobileLoginAppModel.MyalphaMobileApplication.LoginWithCredentialsLabel.Tap();
            else
                mobileLoginAppModel.MyalphaMobileApplication.LogIn2Button.Tap();

            //enter credentials
            mobileLoginAppModel.MyalphaMobileApplication.UsernameEditField.SetText(username);
            mobileLoginAppModel.MyalphaMobileApplication.PasswordEditField.SetSecure(pwd);
            mobileLoginAppModel.MyalphaMobileApplication.LogInButton.Tap();

            Thread.Sleep(3000);

            //check wrong creds message is displayed
            bool wrong_creds = mobileLoginAppModel.MyalphaMobileApplication.LoginWithCredentialsLabel.Exists();
            if (wrong_creds == true)
                HP.LFT.Report.Reporter.ReportEvent("Verify Succesfull Error message exists", "Error message displayed", HP.LFT.Report.Status.Passed, mobileLoginAppModel.MyalphaMobileApplication.WrongEntryCredentialsLabel.GetSnapshot());

            mobileLoginAppModel.MyalphaMobileApplication.OkButton.Tap();


            //click forgot myPassword
            mobileForgotPwdAppModel.MyalphaMobileApplication.IForgotMyPasswordIBLabel.Tap();

            bool forgot_pwd = mobileForgotPwdAppModel.MyalphaMobileApplication.ForgotMyPasswordLabel.Exists();
            if (forgot_pwd == true)
                HP.LFT.Report.Reporter.ReportEvent("Verify Forgot Password message exists", "Info message displayed", HP.LFT.Report.Status.Passed, mobileForgotPwdAppModel.MyalphaMobileApplication.ForgotMyPasswordLabel.GetSnapshot());

            mobileForgotPwdAppModel.MyalphaMobileApplication.ContinueButton.Tap();
            mobileForgotPwdAppModel.MyalphaMobileApplication.UsernameEditField.SetText(username);
            Thread.Sleep(2000);
            mobileForgotPwdAppModel.MyalphaMobileApplication.Continue2Button.Tap();

            bool conf_code = mobileForgotPwdAppModel.MyalphaMobileApplication.FillInTheConfirmationLabel.Exists();
            if (conf_code == true)
                HP.LFT.Report.Reporter.ReportEvent("Verify Confirmation Code message exists", "Info message displayed", HP.LFT.Report.Status.Passed, mobileForgotPwdAppModel.MyalphaMobileApplication.FillInTheConfirmationLabel.GetSnapshot());

            mobileForgotPwdAppModel.MyalphaMobileApplication.BackButton.Tap();
            Thread.Sleep(1000);
            mobileForgotPwdAppModel.MyalphaMobileApplication.BackButton.Tap();
            Thread.Sleep(1000);
            mobileForgotPwdAppModel.MyalphaMobileApplication.BackButton.Tap();
            Thread.Sleep(1000);
            mobileLoginAppModel.MyalphaMobileApplication.LogIn2Button.Tap();


            //forgot username
            mobileForgotUsrAppModel.MyalphaMobileApplication.IForgotMyUsernameLabel.Tap();

            bool usr_reminder = mobileForgotUsrAppModel.MyalphaMobileApplication.UsernameReminderLabel.Exists();
            if (usr_reminder == true)
                HP.LFT.Report.Reporter.ReportEvent("Verify Username Reminder message exists", "Info message displayed", HP.LFT.Report.Status.Passed, mobileForgotUsrAppModel.MyalphaMobileApplication.UsernameReminderLabel.GetSnapshot());
            
            bool credit_card = mobileForgotUsrAppModel.MyalphaMobileApplication.YourDebitCreditOrPrLabel.Exists();
            if (credit_card == true)
                HP.LFT.Report.Reporter.ReportEvent("Verify Credit Card message exists", "Info message displayed", HP.LFT.Report.Status.Passed, mobileForgotUsrAppModel.MyalphaMobileApplication.YourDebitCreditOrPrLabel.GetSnapshot());

            mobileForgotUsrAppModel.MyalphaMobileApplication.GetStartedButton.Tap();
            Thread.Sleep(1000);
            bool scan_credit_card = mobileForgotUsrAppModel.MyalphaMobileApplication.YouCanScanYourCardLabel.Exists();
            if (scan_credit_card == true)
                HP.LFT.Report.Reporter.ReportEvent("Verify Credit Card message exists", "Info message displayed", HP.LFT.Report.Status.Passed, mobileForgotUsrAppModel.MyalphaMobileApplication.YouCanScanYourCardLabel.GetSnapshot());

            mobileForgotUsrAppModel.MyalphaMobileApplication.CreditCardEditField.SetText(card_number);
            Thread.Sleep(1000);
            mobileForgotUsrAppModel.MyalphaMobileApplication.ContinueButton.Tap();
            Thread.Sleep(1000);

            bool six_digit = mobileForgotUsrAppModel.MyalphaMobileApplication.ASixDigitVerificationLabel.Exists();
            if (six_digit == true)
                HP.LFT.Report.Reporter.ReportEvent("Verify Six digit code message exists", "Info message displayed", HP.LFT.Report.Status.Passed, mobileForgotUsrAppModel.MyalphaMobileApplication.ASixDigitVerificationLabel.GetSnapshot());

            mobileForgotUsrAppModel.MyalphaMobileApplication.BackButton.Tap();
            Thread.Sleep(1000);
            mobileForgotUsrAppModel.MyalphaMobileApplication.BackButton.Tap();
            Thread.Sleep(1000);
            mobileForgotUsrAppModel.MyalphaMobileApplication.BackButton.Tap();

            device.Home();

        }

        [TearDown]
        public void TearDown()
        {
            // Clean up after each test
        }

        [OneTimeTearDown]
        public void TestFixtureTearDown()
        {
            // Clean up once per fixture
        }
    }
}
