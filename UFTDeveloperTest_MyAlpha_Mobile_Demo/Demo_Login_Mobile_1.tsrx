<?xml version="1.0" encoding="utf-8"?>
<applicationModel>
  <name>MobileLoginAppModel_1</name>
  <className>MobileLoginAppModel_1</className>
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
          <name>Wrong entry credentials.</name>
          <codeName>WrongEntryCredentialsLabel</codeName>
          <identification>
            <properties>
              <property name="Text" type="string">Wrong entry credentials. Please try again.</property>
              <property name="MobileCenterIndex" type="int">1</property>
              <property name="ClassName" type="string">Label</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="Label">
          <name>Login with credentials</name>
          <codeName>LoginWithCredentialsLabel</codeName>
          <identification>
            <properties>
              <property name="Text" type="string">Login with credentials</property>
              <property name="ResourceId" type="string">com.mobileloft.alpha.droid:id/2131363008</property>
              <property name="MobileCenterIndex" type="int">1</property>
              <property name="ClassName" type="string">Label</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="EditField">
          <name>PasswordEditField</name>
          <codeName>PasswordEditField</codeName>
          <identification>
            <properties>
              <property name="ResourceId" type="string">com.mobileloft.alpha.droid:id/2131362791</property>
              <property name="MobileCenterIndex" type="int">1</property>
              <property name="ClassName" type="string">Input</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="EditField">
          <name>UsernameEditField</name>
          <codeName>UsernameEditField</codeName>
          <identification>
            <properties>
              <property name="ResourceId" type="string">com.mobileloft.alpha.droid:id/2131362793</property>
              <property name="MobileCenterIndex" type="int">0</property>
              <property name="ClassName" type="string">Input</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="Button">
          <name>OK</name>
          <codeName>OkButton</codeName>
          <identification>
            <properties>
              <property name="Text" type="string">OK</property>
              <property name="ResourceId" type="string">android:id/button1</property>
              <property name="MobileCenterIndex" type="int">0</property>
              <property name="ClassName" type="string">Button</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="Button">
          <name>Log in_2</name>
          <codeName>LogIn2Button</codeName>
          <identification>
            <properties>
              <property name="Text" type="string">Log in</property>
              <property name="ResourceId" type="string">com.mobileloft.alpha.droid:id/2131363002</property>
              <property name="MobileCenterIndex" type="int">1</property>
              <property name="ClassName" type="string">Button</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="Button">
          <name>Log in</name>
          <codeName>LogInButton</codeName>
          <identification>
            <properties>
              <property name="Text" type="string">Log in</property>
              <property name="ResourceId" type="string">com.mobileloft.alpha.droid:id/2131363000</property>
              <property name="MobileCenterIndex" type="int">2</property>
              <property name="ClassName" type="string">Button</property>
            </properties>
          </identification>
        </object>
      </children>
    </object>
    <object technology="Mobile" type="Application">
      <name>Home</name>
      <codeName>HomeApplication</codeName>
      <identification>
        <properties>
          <property name="IsPackaged" type="boolean">false</property>
          <property name="Identifier" type="string">MC.Home</property>
        </properties>
      </identification>
      <children>
        <object technology="Mobile" type="UiObject">
          <name>com.miui.home:id/drag_la</name>
          <codeName>ComMiuiHomeIdDragLaUiObject</codeName>
          <identification>
            <properties>
              <property name="ResourceId" type="string">com.miui.home:id/drag_layer_background</property>
              <property name="MobileCenterIndex" type="int">122</property>
              <property name="ClassName" type="string">View</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="Label">
          <name>myAlpha Mobile</name>
          <codeName>MyalphaMobileLabel</codeName>
          <identification>
            <properties>
              <property name="Text" type="string">myAlpha Mobile</property>
              <property name="ResourceId" type="string">com.miui.home:id/icon_title</property>
              <property name="MobileCenterIndex" type="int">26</property>
              <property name="ClassName" type="string">Label</property>
            </properties>
          </identification>
        </object>
      </children>
    </object>
  </objects>
</applicationModel>