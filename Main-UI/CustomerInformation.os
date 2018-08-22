<OpenSpanDesignDocument Version="8.0.1026.0" Serializer="2.0" Culture="en-US">
  <ComponentInfo>
    <Type Value="OpenSpan.Design.DesignForm" />
    <Assembly Value="OpenSpan" />
    <AssemblyReferences>
      <Assembly Value="mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="OpenSpan, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
    </AssemblyReferences>
    <DynamicAssemblyReferences />
    <FileReferences />
    <BuildReferences />
  </ComponentInfo>
  <Component Version="1.0">
    <OpenSpan.Design.DesignForm Name="CustomerInformation" Id="DesignForm-8D60771F6CE6B10">
      <AutoScaleDimensions Value="6, 13" />
      <BackColor Value="Control" />
      <ClientSize Value="628, 390" />
      <Location Value="15, 15" />
      <StartPosition Value="CenterScreen" />
      <Text Value="Customer Information" />
      <TopMost Value="True" />
      <Content Name="Controls">
        <Items>
          <System.Windows.Forms.TextBox Name="MaintxtZip" Id="TextBox-8D60772F67CD322">
            <Location Value="156, 271" />
            <Size Value="100, 20" />
            <TabIndex Value="16" />
          </System.Windows.Forms.TextBox>
          <System.Windows.Forms.TextBox Name="MaintxtState" Id="TextBox-8D60772F3E74048">
            <Location Value="156, 234" />
            <Size Value="100, 20" />
            <TabIndex Value="15" />
          </System.Windows.Forms.TextBox>
          <System.Windows.Forms.TextBox Name="MaintxtCity" Id="TextBox-8D60772F19067DD">
            <Location Value="156, 195" />
            <Size Value="100, 20" />
            <TabIndex Value="14" />
          </System.Windows.Forms.TextBox>
          <System.Windows.Forms.TextBox Name="MaintxtAddress" Id="TextBox-8D60772ED1ED22A">
            <Location Value="156, 152" />
            <Size Value="100, 20" />
            <TabIndex Value="13" />
          </System.Windows.Forms.TextBox>
          <System.Windows.Forms.TextBox Name="MaintxtName" Id="TextBox-8D60772E78AAC93">
            <Location Value="156, 103" />
            <Size Value="100, 20" />
            <TabIndex Value="12" />
          </System.Windows.Forms.TextBox>
          <System.Windows.Forms.TextBox Name="MaintxtCurrentAcct" Id="TextBox-8D60772E45D9727">
            <Font Value="Microsoft Sans Serif, 8.25pt, style=Bold" />
            <Location Value="156, 26" />
            <Size Value="100, 20" />
            <TabIndex Value="11" />
            <Text Value="--------" />
          </System.Windows.Forms.TextBox>
          <System.Windows.Forms.GroupBox Name="MaingboxNearestStore" Id="GroupBox-8D6077285485CD7">
            <Location Value="339, 26" />
            <Size Value="249, 319" />
            <TabIndex Value="10" />
            <TabStop Value="False" />
            <Text Value="ACME Nearest Store" />
            <Content Name="Controls">
              <Items>
                <System.Windows.Forms.Label Name="MainlblNearestStore" Id="Label-8D607729550FD3E">
                  <AutoSize Value="True" />
                  <ImageKey Value="(none)" />
                  <Location Value="43, 122" />
                  <Size Value="22, 13" />
                  <TabIndex Value="11" />
                  <Text Value="-----" />
                </System.Windows.Forms.Label>
                <System.Windows.Forms.Button Name="MainbtnNearestStore" Id="Button-8D607729128EA21">
                  <Location Value="46, 35" />
                  <Size Value="75, 23" />
                  <TabIndex Value="0" />
                  <Text Value="Find Store" />
                  <UseVisualStyleBackColor Value="True" />
                </System.Windows.Forms.Button>
              </Items>
            </Content>
          </System.Windows.Forms.GroupBox>
          <System.Windows.Forms.ComboBox Name="MaincmbGetAcct" Id="ComboBox-8D607725E61D4EF">
            <FormattingEnabled Value="True" />
            <Location Value="156, 64" />
            <MaxDropDownItems Value="100" />
            <Size Value="121, 21" />
            <Sorted Value="True" />
            <TabIndex Value="9" />
          </System.Windows.Forms.ComboBox>
          <System.Windows.Forms.Label Name="MainlblZip" Id="Label-8D60772493ADCDC">
            <AutoSize Value="True" />
            <Font Value="Microsoft Sans Serif, 8.25pt, style=Bold" />
            <ImageKey Value="(none)" />
            <Location Value="42, 271" />
            <Size Value="25, 13" />
            <TabIndex Value="6" />
            <Text Value="Zip" />
          </System.Windows.Forms.Label>
          <System.Windows.Forms.Label Name="MainlblState" Id="Label-8D6077246A0C651">
            <AutoSize Value="True" />
            <Font Value="Microsoft Sans Serif, 8.25pt, style=Bold" />
            <ImageKey Value="(none)" />
            <Location Value="42, 234" />
            <Size Value="37, 13" />
            <TabIndex Value="5" />
            <Text Value="State" />
          </System.Windows.Forms.Label>
          <System.Windows.Forms.Label Name="MainlblCity" Id="Label-8D607724504B3B9">
            <AutoSize Value="True" />
            <Font Value="Microsoft Sans Serif, 8.25pt, style=Bold" />
            <ImageKey Value="(none)" />
            <Location Value="42, 195" />
            <Size Value="28, 13" />
            <TabIndex Value="4" />
            <Text Value="City" />
          </System.Windows.Forms.Label>
          <System.Windows.Forms.Label Name="MainlblAddress" Id="Label-8D607724374E749">
            <AutoSize Value="True" />
            <Font Value="Microsoft Sans Serif, 8.25pt, style=Bold" />
            <ForeColor Value="ControlText" />
            <ImageKey Value="(none)" />
            <Location Value="42, 159" />
            <Size Value="52, 13" />
            <TabIndex Value="3" />
            <Text Value="Address" />
          </System.Windows.Forms.Label>
          <System.Windows.Forms.Label Name="MainlblName" Id="Label-8D60772419EEAEF">
            <AutoSize Value="True" />
            <Font Value="Microsoft Sans Serif, 8.25pt, style=Bold" />
            <ForeColor Value="Highlight" />
            <ImageKey Value="(none)" />
            <Location Value="42, 111" />
            <Size Value="95, 13" />
            <TabIndex Value="2" />
            <Text Value="Customer Name" />
          </System.Windows.Forms.Label>
          <System.Windows.Forms.Label Name="MainlblGetAcct" Id="Label-8D607723F359461">
            <AutoSize Value="True" />
            <Font Value="Microsoft Sans Serif, 8.25pt, style=Bold" />
            <ForeColor Value="Highlight" />
            <ImageKey Value="(none)" />
            <Location Value="42, 64" />
            <Size Value="78, 13" />
            <TabIndex Value="1" />
            <Text Value="Get Account" />
          </System.Windows.Forms.Label>
          <System.Windows.Forms.Label Name="MainlblCurrentAcct" Id="Label-8D607723CA69AA9">
            <AutoSize Value="True" />
            <Font Value="Microsoft Sans Serif, 8.25pt, style=Bold" />
            <ForeColor Value="Highlight" />
            <Location Value="42, 26" />
            <Size Value="99, 13" />
            <TabIndex Value="0" />
            <Text Value="Current Account" />
          </System.Windows.Forms.Label>
        </Items>
      </Content>
    </OpenSpan.Design.DesignForm>
  </Component>
</OpenSpanDesignDocument>