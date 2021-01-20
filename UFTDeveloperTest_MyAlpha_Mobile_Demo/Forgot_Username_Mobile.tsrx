<?xml version="1.0" encoding="utf-8"?>
<applicationModel>
  <name>MobileForgotUsrAppModel</name>
  <className>MobileForgotUsrAppModel</className>
  <objects>
    <object technology="Mobile" type="Application">
      <name>myAlpha Mobile</name>
      <codeName>MyalphaMobileApplication</codeName>
      <identification>
        <properties>
          <property name="IsPackaged" type="boolean">false</property>
          <property name="Identifier" type="string">com.mobileloft.alpha.droid</property>
        </properties>
      </identification>
      <children>
        <object technology="Mobile" type="Label">
          <name>Your debit, credit or pr</name>
          <codeName>YourDebitCreditOrPrLabel</codeName>
          <identification>
            <properties>
              <property name="Text" type="string">Your debit, credit or prepaid card</property>
              <property name="MobileCenterIndex" type="int">3</property>
              <property name="ClassName" type="string">Label</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="Label">
          <name>You can scan your card</name>
          <codeName>YouCanScanYourCardLabel</codeName>
          <identification>
            <properties>
              <property name="Text" type="string">You can scan your card</property>
              <property name="MobileCenterIndex" type="int">1</property>
              <property name="ClassName" type="string">Label</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="Label">
          <name>Username Reminder</name>
          <codeName>UsernameReminderLabel</codeName>
          <identification>
            <properties>
              <property name="Text" type="string">Username Reminder</property>
              <property name="MobileCenterIndex" type="int">0</property>
              <property name="ClassName" type="string">Label</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="Label">
          <name>I forgot my Username</name>
          <codeName>IForgotMyUsernameLabel</codeName>
          <identification>
            <properties>
              <property name="Text" type="string">I forgot my Username</property>
              <property name="ResourceId" type="string">com.mobileloft.alpha.droid:id/2131362718</property>
              <property name="MobileCenterIndex" type="int">3</property>
              <property name="ClassName" type="string">Label</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="Label">
          <name>And your mobile phone</name>
          <codeName>AndYourMobilePhoneLabel</codeName>
          <identification>
            <properties>
              <property name="Text" type="string">And your mobile phone</property>
              <property name="MobileCenterIndex" type="int">4</property>
              <property name="ClassName" type="string">Label</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="Label">
          <name>A six-digit verification</name>
          <codeName>ASixDigitVerificationLabel</codeName>
          <identification>
            <properties>
              <property name="Text" type="string">A six-digit verification code has been sent to your registered phone number</property>
              <property name="ResourceId" type="string">com.mobileloft.alpha.droid:id/2131362609</property>
              <property name="MobileCenterIndex" type="int">1</property>
              <property name="ClassName" type="string">Label</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="EditField">
          <name>CreditCardEditField</name>
          <codeName>CreditCardEditField</codeName>
          <identification>
            <properties>
              <property name="ResourceId" type="string">com.mobileloft.alpha.droid:id/2131362242</property>
              <property name="MobileCenterIndex" type="int">0</property>
              <property name="ClassName" type="string">Input</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="Button">
          <name>Get started</name>
          <codeName>GetStartedButton</codeName>
          <identification>
            <properties>
              <property name="Text" type="string">Get started</property>
              <property name="ResourceId" type="string">com.mobileloft.alpha.droid:id/2131363727</property>
              <property name="MobileCenterIndex" type="int">1</property>
              <property name="ClassName" type="string">Button</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="Button">
          <name>Continue</name>
          <codeName>ContinueButton</codeName>
          <identification>
            <properties>
              <property name="Text" type="string">Continue</property>
              <property name="ResourceId" type="string">com.mobileloft.alpha.droid:id/2131362606</property>
              <property name="MobileCenterIndex" type="int">1</property>
              <property name="ClassName" type="string">Button</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="Button">
          <name>BackButton</name>
          <codeName>BackButton</codeName>
          <identification>
            <properties>
              <property name="ResourceId" type="string">com.mobileloft.alpha.droid:id/2131363137</property>
              <property name="MobileCenterIndex" type="int">0</property>
              <property name="ClassName" type="string">Button</property>
            </properties>
          </identification>
        </object>
      </children>
    </object>
  </objects>
</applicationModel>