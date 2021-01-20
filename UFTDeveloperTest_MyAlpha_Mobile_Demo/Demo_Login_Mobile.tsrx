<?xml version="1.0" encoding="utf-8"?>
<applicationModel>
  <name>MobileLoginAppModel</name>
  <className>MobileLoginAppModel</className>
  <objects>
    <object technology="Mobile" type="Application">
      <name>Home</name>
      <codeName>HomeApplication</codeName>
      <description />
      <identification>
        <properties>
          <property name="Identifier" type="string">MC.Home</property>
          <property name="IsPackaged" type="boolean">false</property>
        </properties>
      </identification>
      <children>
        <object technology="Mobile" type="Label">
          <name>myAlpha Mobile</name>
          <codeName>MyAlphaMobileLabel</codeName>
          <description />
          <identification>
            <properties>
              <property name="ClassName" type="string">Label</property>
              <property name="Text" type="string">myAlpha Mobile</property>
              <property name="NativeClass" type="string">android.widget.TextView</property>
              <property name="ResourceId" type="string">com.miui.home:id/icon_title</property>
              <property name="MobileCenterIndex" type="int">26</property>
            </properties>
          </identification>
        </object>
      </children>
    </object>
    <object technology="Mobile" type="Application">
      <name>myAlpha Mobile</name>
      <codeName>MyAlphaMobileApplication</codeName>
      <description />
      <identification>
        <properties>
          <property name="Identifier" type="string">com.mobileloft.alpha.droid</property>
          <property name="IsPackaged" type="boolean">false</property>
        </properties>
      </identification>
      <children>
        <object technology="Mobile" type="Button">
          <name>Log in</name>
          <codeName>LogInButton</codeName>
          <description />
          <identification>
            <properties>
              <property name="ClassName" type="string">Button</property>
              <property name="Text" type="string">Log in</property>
              <property name="NativeClass" type="string">android.widget.Button</property>
              <property name="ResourceId" type="string">com.mobileloft.alpha.droid:id/2131363002</property>
              <property name="MobileCenterIndex" type="int">1</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="Label">
          <name>Login with credentials</name>
          <codeName>LoginWithCredentialsLabel</codeName>
          <description />
          <identification>
            <properties>
              <property name="ClassName" type="string">Label</property>
              <property name="Text" type="string">Login with credentials</property>
              <property name="NativeClass" type="string">android.widget.TextView</property>
              <property name="ResourceId" type="string">com.mobileloft.alpha.droid:id/2131363008</property>
              <property name="MobileCenterIndex" type="int">1</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="EditField">
          <name>UsernameEditField</name>
          <codeName>UsernameEditField</codeName>
          <description />
          <identification>
            <properties>
              <property name="ClassName" type="string">Input</property>
              <property name="Text" type="string">Username</property>
              <property name="NativeClass" type="string">android.widget.EditText</property>
              <property name="ResourceId" type="string">com.mobileloft.alpha.droid:id/2131362793</property>
              <property name="MobileCenterIndex" type="int">0</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="EditField">
          <name>PasswordEditField</name>
          <codeName>PasswordEditField</codeName>
          <description />
          <identification>
            <properties>
              <property name="ClassName" type="string">Input</property>
              <property name="NativeClass" type="string">android.widget.EditText</property>
              <property name="ResourceId" type="string">com.mobileloft.alpha.droid:id/2131362791</property>
              <property name="MobileCenterIndex" type="int">1</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="Label">
          <name>Wrong entry credentials. Please try again.</name>
          <codeName>WrongEntryCredentialsPleaseTryAgainLabel</codeName>
          <description />
          <identification>
            <properties>
              <property name="ClassName" type="string">Label</property>
              <property name="Text" type="string">Wrong entry credentials. Please try again.</property>
              <property name="NativeClass" type="string">android.widget.TextView</property>
              <property name="MobileCenterIndex" type="int">1</property>
            </properties>
          </identification>
        </object>
        <object technology="Mobile" type="Button">
          <name>OK</name>
          <codeName>OKButton</codeName>
          <description />
          <identification>
            <properties>
              <property name="ClassName" type="string">Button</property>
              <property name="Text" type="string">OK</property>
              <property name="NativeClass" type="string">android.widget.Button</property>
              <property name="ResourceId" type="string">android:id/button1</property>
              <property name="MobileCenterIndex" type="int">0</property>
            </properties>
          </identification>
        </object>
      </children>
    </object>
  </objects>
</applicationModel>