<?xml version="1.0" encoding="utf-8"?>
<applicationModel>
  <name>Calculator Application Model</name>
  <className>CalculatorApplicationModel</className>
  <objects>
    <object technology="WPF" type="Window">
      <name>Calculator</name>
      <codeName>CalculatorWindow</codeName>
      <description />
      <identification>
        <properties>
          <property name="WindowTitleRegExp" type="string">Calculator</property>
          <property name="ObjectName" type="string">Calculator</property>
          <property name="FullType" type="string">window</property>
        </properties>
      </identification>
      <children>
        <object technology="WPF" type="Button">
          <name>On</name>
          <codeName>OnButton</codeName>
          <description />
          <identification>
            <properties>
              <property name="ObjectName" type="string">onButton</property>
              <property name="Text" type="string">On</property>
            </properties>
          </identification>
        </object>
        <object technology="WPF" type="Button">
          <name>Off</name>
          <codeName>OffButton</codeName>
          <description />
          <identification>
            <properties>
              <property name="ObjectName" type="string">offButton</property>
              <property name="Text" type="string">Off</property>
            </properties>
          </identification>
        </object>
        <object technology="WPF" type="Button">
          <name>1</name>
          <codeName>OneButton</codeName>
          <description />
          <identification>
            <properties>
              <property name="ObjectName" type="string">oneButton</property>
              <property name="Text" type="string">1</property>
            </properties>
          </identification>
        </object>
        <object technology="WPF" type="Button">
          <name>6</name>
          <codeName>SixButton</codeName>
          <description />
          <identification>
            <properties>
              <property name="ObjectName" type="string">sixButton</property>
              <property name="Text" type="string">6</property>
            </properties>
          </identification>
        </object>
        <object technology="WPF" type="Button">
          <name>+</name>
          <codeName>AddButton</codeName>
          <description />
          <identification>
            <properties>
              <property name="ObjectName" type="string">addButton</property>
              <property name="Text" type="string">+</property>
            </properties>
          </identification>
        </object>
        <object technology="WPF" type="Button">
          <name>C</name>
          <codeName>ClearButton</codeName>
          <description />
          <identification>
            <properties>
              <property name="ObjectName" type="string">clearButton</property>
              <property name="Text" type="string">C</property>
            </properties>
          </identification>
        </object>
        <object technology="WPF" type="EditField">
          <name>displayTextbox</name>
          <codeName>OutputField</codeName>
          <description />
          <identification>
            <properties>
              <property name="ObjectName" type="string">displayTextbox</property>
            </properties>
          </identification>
        </object>
        <object technology="WPF" type="Button">
          <name>=1</name>
          <codeName>CalcButton</codeName>
          <description />
          <identification>
            <properties>
              <property name="ObjectName" type="string">calcButton</property>
              <property name="Text" type="string">=</property>
            </properties>
          </identification>
        </object>
        <object technology="WPF" type="Button">
          <name>*</name>
          <codeName>MultiplyButton</codeName>
          <description />
          <identification>
            <properties>
              <property name="ObjectName" type="string">multButton</property>
              <property name="Text" type="string">*</property>
            </properties>
          </identification>
        </object>
        <object technology="WPF" type="Button">
          <name>2</name>
          <codeName>TwoButton</codeName>
          <description />
          <identification>
            <properties>
              <property name="ObjectName" type="string">twoButton</property>
              <property name="Text" type="string">2</property>
            </properties>
          </identification>
        </object>
        <object technology="WPF" type="Button">
          <name>3</name>
          <codeName>ThreeButton</codeName>
          <description />
          <identification>
            <properties>
              <property name="ObjectName" type="string">threeButton</property>
              <property name="Text" type="string">3</property>
            </properties>
          </identification>
        </object>
        <object technology="WPF" type="Button">
          <name>-</name>
          <codeName>MinusButton</codeName>
          <description />
          <identification>
            <properties>
              <property name="ObjectName" type="string">subButton</property>
              <property name="Text" type="string">-</property>
            </properties>
          </identification>
        </object>
        <object technology="WPF" type="Button">
          <name>9</name>
          <codeName>NineButton</codeName>
          <description />
          <identification>
            <properties>
              <property name="ObjectName" type="string">nineButton</property>
              <property name="Text" type="string">9</property>
            </properties>
          </identification>
        </object>
      </children>
    </object>
  </objects>
</applicationModel>