<OpenSpanDesignDocument Version="8.0.1026.0" Serializer="2.0" Culture="en-US">
  <ComponentInfo>
    <Type Value="OpenSpan.Automation.Automator" />
    <Assembly Value="OpenSpan.Automation" />
    <AssemblyReferences>
      <Assembly Value="mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="OpenSpan, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters.Web, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Automation, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
    </AssemblyReferences>
    <DynamicAssemblyReferences />
    <FileReferences />
    <BuildReferences />
  </ComponentInfo>
  <Component Version="1.0">
    <OpenSpan.Automation.Automator Name="ACME_P_NavToHome" Id="Automator-8D606A84F759AFD">
      <AutomationDocument>
        <Name Value="" />
        <Size Value="5005, 5000" />
        <Objects>
          <ConnectionBlock>
            <ConnectableUniqueId Value="Automator-8D606A84F759AFD\EntryPoint-8D606A860B8FDA6" />
            <Left Value="0" />
            <Top Value="60" />
            <PartID Value="1" />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D606A84F759AFD\ConnectableProperties-8D607394366C4A7" />
            <PartID Value="3" />
            <Left Value="140" />
            <Top Value="80" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ACMEwpHome" />
            <Fittings>
              <IsCreated Collapsed="False" ActualText="IsCreated" />
            </Fittings>
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <ConnectableUniqueId Value="Automator-8D606A84F759AFD\LabelHost-8D607394C6AB20C" />
            <Left Value="440" />
            <Top Value="500" />
            <PartID Value="4" />
          </ConnectionBlock>
          <ConnectionBlock>
            <ConnectableUniqueId Value="Automator-8D606A84F759AFD\LabelHost-8D6073955241D54" />
            <Left Value="460" />
            <Top Value="420" />
            <PartID Value="5" />
          </ConnectionBlock>
          <ConnectionBlock type="OpenSpan.Automation.Design.ConnectionBlocks.MultiExitPointBlock">
            <ConnectableUniqueId Value="Automator-8D606A84F759AFD\ExitPoint-8D60739695057FD" />
            <Left Value="640" />
            <Top Value="500" />
            <PartID Value="6" />
            <Title Value="Success" />
            <EventName Value="" />
          </ConnectionBlock>
          <ConnectionBlock type="OpenSpan.Automation.Design.ConnectionBlocks.MultiExitPointBlock">
            <ConnectableUniqueId Value="Automator-8D606A84F759AFD\ExitPoint-8D607396F000C38" />
            <Left Value="600" />
            <Top Value="400" />
            <PartID Value="7" />
            <Title Value="Failed" />
            <EventName Value="" />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="GoToLabel" />
            <ConnectableUniqueId Value="Automator-8D606A84F759AFD\JumpHost-8D60739BBC9611A" />
            <PartID Value="10" />
            <Left Value="360" />
            <Top Value="100" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="Jump To" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D606A84F759AFD\ConnectableProperties-8D60739F72E6273" />
            <PartID Value="14" />
            <Left Value="340" />
            <Top Value="180" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ACMESearchSystem" />
            <Fittings>
              <IsRunning Collapsed="False" ActualText="IsRunning" />
            </Fittings>
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <ConnectableUniqueId Value="Automator-8D606A84F759AFD\LabelHost-8D6073A1282CF94" />
            <Left Value="0" />
            <Top Value="260" />
            <PartID Value="16" />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="WaitForCreate" />
            <ConnectableUniqueId Value="Automator-8D606A84F759AFD\ConnectableMethod-8D6073A4F61C514" />
            <PartID Value="18" />
            <Left Value="140" />
            <Top Value="260" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ACMEwpSignIn" />
            <Fittings>
              <Result Collapsed="False" ActualText="Result" />
            </Fittings>
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="GoToLabel" />
            <ConnectableUniqueId Value="Automator-8D606A84F759AFD\JumpHost-8D6073A5E595F7F" />
            <PartID Value="20" />
            <Left Value="600" />
            <Top Value="140" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="Jump To" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Start" />
            <ConnectableUniqueId Value="Automator-8D606A84F759AFD\ConnectableMethod-8D6073A8FFE4DF1" />
            <PartID Value="22" />
            <Left Value="540" />
            <Top Value="240" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ACMESearchSystem" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock type="OpenSpan.Automation.Design.ConnectionBlocks.EntryPointExecuteBlock">
            <DisplayName Value="Execute" />
            <ConnectableUniqueId Value="Automator-8D606A84F759AFD\ConnectableMethod-8D6073D1C13E567" />
            <PartID Value="25" />
            <Left Value="40" />
            <Top Value="440" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ACME_P_Signin" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="GoToLabel" />
            <ConnectableUniqueId Value="Automator-8D606A84F759AFD\JumpHost-8D6073D25480C39" />
            <PartID Value="26" />
            <Left Value="250" />
            <Top Value="445" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="Jump To" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="GoToLabel" />
            <ConnectableUniqueId Value="Automator-8D606A84F759AFD\JumpHost-8D6073D30EBCC82" />
            <PartID Value="27" />
            <Left Value="260" />
            <Top Value="520" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="Jump To" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="GoToLabel" />
            <ConnectableUniqueId Value="Automator-8D606A84F759AFD\JumpHost-8D6073D467BAF11" />
            <PartID Value="31" />
            <Left Value="414" />
            <Top Value="321" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="Jump To" />
            <OverriddenIds />
          </ConnectionBlock>
        </Objects>
        <Links>
          <Link PartID="9" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="5" PortName="_param1" PortType="Property" ConnectableId="Automator-8D606A84F759AFD\LabelHost-8D6073955241D54" MemberComponentId="EMPTY" />
            <To PartID="7" PortName="param1" PortType="Property" ConnectableId="Automator-8D606A84F759AFD\ExitPoint-8D607396F000C38" MemberComponentId="EMPTY" />
            <LinkPoints>
              <Point value="556, 465" />
              <Point value="566, 465" />
              <Point value="566, 465" />
              <Point value="566, 445" />
              <Point value="592, 445" />
              <Point value="602, 445" />
            </LinkPoints>
          </Link>
          <DecisionEventLink PartID="11" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="3" ParentMemberName="IsCreated" DecisionValue="True" ConnectableId="Automator-8D606A84F759AFD\ConnectableProperties-8D607394366C4A7" />
            <To PartID="10" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D606A84F759AFD\JumpHost-8D60739BBC9611A" MemberComponentId="Automator-8D606A84F759AFD\JumpHost-8D60739BBC9611A" />
            <LinkPoints>
              <Point value="317, 156" />
              <Point value="327, 156" />
              <Point value="324, 156" />
              <Point value="324, 156" />
              <Point value="332, 156" />
              <Point value="332, 117" />
              <Point value="353, 117" />
              <Point value="363, 117" />
            </LinkPoints>
          </DecisionEventLink>
          <Link PartID="13" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="1" PortName="Complete" PortType="Event" ConnectableId="Automator-8D606A84F759AFD\EntryPoint-8D606A860B8FDA6" MemberComponentId="Automator-8D606A84F759AFD\EntryPoint-8D606A860B8FDA6" />
            <To PartID="3" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D606A84F759AFD\ConnectableProperties-8D607394366C4A7" MemberComponentId="Automator-8D606A84F759AFD\ConnectableProperties-8D607394366C4A7" />
            <LinkPoints>
              <Point value="111, 78" />
              <Point value="121, 78" />
              <Point value="124, 78" />
              <Point value="124, 125" />
              <Point value="135, 125" />
              <Point value="145, 125" />
            </LinkPoints>
          </Link>
          <DecisionEventLink PartID="15" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="3" ParentMemberName="IsCreated" DecisionValue="False" ConnectableId="Automator-8D606A84F759AFD\ConnectableProperties-8D607394366C4A7" />
            <To PartID="14" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D606A84F759AFD\ConnectableProperties-8D60739F72E6273" MemberComponentId="Automator-8D606A84F759AFD\ConnectableProperties-8D60739F72E6273" />
            <LinkPoints>
              <Point value="317, 171" />
              <Point value="327, 171" />
              <Point value="324, 171" />
              <Point value="324, 171" />
              <Point value="332, 171" />
              <Point value="332, 209" />
              <Point value="335, 209" />
              <Point value="345, 209" />
            </LinkPoints>
          </DecisionEventLink>
          <Link PartID="19" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="16" PortName="Complete" PortType="Event" ConnectableId="Automator-8D606A84F759AFD\LabelHost-8D6073A1282CF94" MemberComponentId="Automator-8D606A84F759AFD\LabelHost-8D6073A1282CF94" />
            <To PartID="18" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D606A84F759AFD\ConnectableMethod-8D6073A4F61C514" MemberComponentId="Automator-8D606A84F759AFD\ConnectableMethod-8D6073A4F61C514" />
            <LinkPoints>
              <Point value="99, 278" />
              <Point value="109, 278" />
              <Point value="109, 278" />
              <Point value="109, 305" />
              <Point value="135, 305" />
              <Point value="145, 305" />
            </LinkPoints>
          </Link>
          <DecisionEventLink PartID="21" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="14" ParentMemberName="IsRunning" DecisionValue="True" ConnectableId="Automator-8D606A84F759AFD\ConnectableProperties-8D60739F72E6273" />
            <To PartID="20" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D606A84F759AFD\JumpHost-8D6073A5E595F7F" MemberComponentId="Automator-8D606A84F759AFD\JumpHost-8D6073A5E595F7F" />
            <LinkPoints>
              <Point value="517, 240" />
              <Point value="527, 240" />
              <Point value="524, 240" />
              <Point value="524, 240" />
              <Point value="532, 240" />
              <Point value="532, 157" />
              <Point value="593, 157" />
              <Point value="603, 157" />
            </LinkPoints>
          </DecisionEventLink>
          <DecisionEventLink PartID="23" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="14" ParentMemberName="IsRunning" DecisionValue="False" ConnectableId="Automator-8D606A84F759AFD\ConnectableProperties-8D60739F72E6273" />
            <To PartID="22" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D606A84F759AFD\ConnectableMethod-8D6073A8FFE4DF1" MemberComponentId="Automator-8D606A84F759AFD\ConnectableMethod-8D6073A8FFE4DF1" />
            <LinkPoints>
              <Point value="517, 255" />
              <Point value="527, 255" />
              <Point value="524, 255" />
              <Point value="524, 255" />
              <Point value="532, 255" />
              <Point value="532, 269" />
              <Point value="535, 269" />
              <Point value="545, 269" />
            </LinkPoints>
          </DecisionEventLink>
          <Link PartID="24" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="22" PortName="Complete" PortType="Event" ConnectableId="Automator-8D606A84F759AFD\ConnectableMethod-8D6073A8FFE4DF1" MemberComponentId="Automator-8D606A84F759AFD\ConnectableMethod-8D6073A8FFE4DF1" />
            <To PartID="20" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D606A84F759AFD\JumpHost-8D6073A5E595F7F" MemberComponentId="Automator-8D606A84F759AFD\JumpHost-8D6073A5E595F7F" />
            <LinkPoints>
              <Point value="717, 269" />
              <Point value="727, 269" />
              <Point value="724, 269" />
              <Point value="724, 269" />
              <Point value="732, 269" />
              <Point value="732, 236" />
              <Point value="596, 236" />
              <Point value="596, 157" />
              <Point value="593, 157" />
              <Point value="603, 157" />
            </LinkPoints>
          </Link>
          <Link PartID="28" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="25" PortName="param1" PortType="Property" ConnectableId="Automator-8D606A84F759AFD\ConnectableMethod-8D6073D1C13E567" MemberComponentId="Automator-8D606A84F759AFD\ConnectableMethod-8D6073D1C13E567" />
            <To PartID="27" PortName="_param1" PortType="Property" ConnectableId="Automator-8D606A84F759AFD\JumpHost-8D6073D30EBCC82" MemberComponentId="Automator-8D606A84F759AFD\JumpHost-8D6073D30EBCC82" />
            <LinkPoints>
              <Point value="191, 520" />
              <Point value="201, 520" />
              <Point value="204, 520" />
              <Point value="204, 566" />
              <Point value="255, 566" />
              <Point value="265, 566" />
            </LinkPoints>
          </Link>
          <Link PartID="29" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="25" PortName="Complete" PortType="Event" ConnectableId="Automator-8D606A84F759AFD\ConnectableMethod-8D6073D1C13E567" MemberComponentId="Automator-8D6073ACBE170E9\ExitPoint-8D6073B5B78603C" />
            <To PartID="27" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D606A84F759AFD\JumpHost-8D6073D30EBCC82" MemberComponentId="Automator-8D606A84F759AFD\JumpHost-8D6073D30EBCC82" />
            <LinkPoints>
              <Point value="191, 503" />
              <Point value="201, 503" />
              <Point value="204, 503" />
              <Point value="204, 537" />
              <Point value="253, 537" />
              <Point value="263, 537" />
            </LinkPoints>
          </Link>
          <Link PartID="30" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="25" PortName="Complete" PortType="Event" ConnectableId="Automator-8D606A84F759AFD\ConnectableMethod-8D6073D1C13E567" MemberComponentId="Automator-8D6073ACBE170E9\ExitPoint-8D6073B49CD154E" />
            <To PartID="26" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D606A84F759AFD\JumpHost-8D6073D25480C39" MemberComponentId="Automator-8D606A84F759AFD\JumpHost-8D6073D25480C39" />
            <LinkPoints>
              <Point value="191, 486" />
              <Point value="201, 486" />
              <Point value="204, 486" />
              <Point value="204, 462" />
              <Point value="243, 462" />
              <Point value="253, 462" />
            </LinkPoints>
          </Link>
          <DecisionEventLink PartID="32" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="18" ParentMemberName="Result" DecisionValue="True" ConnectableId="Automator-8D606A84F759AFD\ConnectableMethod-8D6073A4F61C514" />
            <To PartID="25" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D606A84F759AFD\ConnectableMethod-8D6073D1C13E567" MemberComponentId="Automator-8D606A84F759AFD\ConnectableMethod-8D6073D1C13E567" />
            <LinkPoints>
              <Point value="317, 336" />
              <Point value="327, 336" />
              <Point value="324, 336" />
              <Point value="324, 336" />
              <Point value="332, 336" />
              <Point value="332, 372" />
              <Point value="36, 372" />
              <Point value="36, 469" />
              <Point value="35, 469" />
              <Point value="45, 469" />
            </LinkPoints>
          </DecisionEventLink>
          <DecisionEventLink PartID="33" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="18" ParentMemberName="Result" DecisionValue="False" ConnectableId="Automator-8D606A84F759AFD\ConnectableMethod-8D6073A4F61C514" />
            <To PartID="31" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D606A84F759AFD\JumpHost-8D6073D467BAF11" MemberComponentId="Automator-8D606A84F759AFD\JumpHost-8D6073D467BAF11" />
            <LinkPoints>
              <Point value="317, 351" />
              <Point value="327, 351" />
              <Point value="324, 351" />
              <Point value="324, 351" />
              <Point value="332, 351" />
              <Point value="332, 338" />
              <Point value="407, 338" />
              <Point value="417, 338" />
            </LinkPoints>
          </DecisionEventLink>
          <Link PartID="38" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="4" PortName="Complete" PortType="Event" ConnectableId="Automator-8D606A84F759AFD\LabelHost-8D607394C6AB20C" MemberComponentId="Automator-8D606A84F759AFD\LabelHost-8D607394C6AB20C" />
            <To PartID="6" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D606A84F759AFD\ExitPoint-8D60739695057FD" MemberComponentId="Automator-8D606A84F759AFD\ExitPoint-8D60739695057FD" />
            <LinkPoints>
              <Point value="555, 518" />
              <Point value="565, 518" />
              <Point value="598, 518" />
              <Point value="598, 518" />
              <Point value="632, 518" />
              <Point value="642, 518" />
            </LinkPoints>
          </Link>
        </Links>
        <Comments />
        <SubGraphs />
      </AutomationDocument>
      <DocumentPosition Value="Binary">
        <Binary>AAEAAAD/////AQAAAAAAAAAMAgAAAFFTeXN0ZW0uRHJhd2luZywgVmVyc2lvbj00LjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPWIwM2Y1ZjdmMTFkNTBhM2EFAQAAABVTeXN0ZW0uRHJhd2luZy5Qb2ludEYCAAAAAXgBeQAACwsCAAAAAAAAAAAAgEML</Binary>
      </DocumentPosition>
      <ShowDesignCompNames Value="True" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicMethodInfo dynamicType="Method" name="_EntryPointExecute" aliasName="Execute" visibility="DefaultOn" source="" blockTypeName="OpenSpan.Automation.Design.ConnectionBlocks.EntryPointExecuteBlock" returnType="System.Void">
            <param name="param1" aliasName="msg" paramType="System.String" isIn="False" isOut="True" position="0" />
          </OpenSpan.DynamicMembers.DynamicMethodInfo>
        </Items>
      </Content>
    </OpenSpan.Automation.Automator>
    <OpenSpan.Automation.EntryPoint Name="entryPoint1" Id="EntryPoint-8D606A860B8FDA6">
      <AliasName Value="Execute" />
      <ComponentName Value="Execute" />
      <DisplayName Value="Execute" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="Automator-8D606A84F759AFD\EntryPoint-8D606A860B8FDA6" />
      <MemberDetails Value="" />
      <MethodName Value="_EntryPointExecute" />
      <Removing Value="False" />
      <UseAlias Value="True" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="Result" canRead="True" canWrite="True" type="System.Void" aliasName="Result" shouldSerialize="False" visibility="AlwaysHidden" source="" blockTypeName="" />
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="param1" canRead="True" canWrite="False" type="System.String" aliasName="msg" shouldSerialize="False" visibility="AlwaysHidden" source="" blockTypeName="" />
        </Items>
      </Content>
    </OpenSpan.Automation.EntryPoint>
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties1" Id="ConnectableProperties-8D607394366C4A7">
      <ComponentName Value="ACMEwpHome" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.Controls.WebPage" />
      <InstanceUniqueId Value="WebAdapter-8D6036EE92E82A8\WebPage-8D60376ACF65820" />
      <MemberDetails Value=".IsCreated Property" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="IsCreated" />
            <MemberType Value="Property" />
            <TypeName Value="System.Boolean" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableProperties>
    <OpenSpan.Automation.LabelHost Name="labelHost1" Id="LabelHost-8D607394C6AB20C">
      <ComponentName Value="OpenSpan.Automation.EntryPoint" />
      <DisplayName Value="Success" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="EMPTY" />
      <LabelName Value="Success" />
      <MemberDetails Value="" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="_param1" canRead="True" canWrite="True" type="System.String" aliasName="msg" shouldSerialize="False" visibility="AlwaysHidden" source="" blockTypeName="" />
          <OpenSpan.DynamicMembers.DynamicMethodInfo dynamicType="Method" name="GoToLabel" aliasName="GoToLabel" visibility="AlwaysHidden" source="" blockTypeName="" returnType="System.Void" />
        </Items>
      </Content>
    </OpenSpan.Automation.LabelHost>
    <OpenSpan.Automation.LabelHost Name="labelHost2" Id="LabelHost-8D6073955241D54">
      <ComponentName Value="OpenSpan.Automation.EntryPoint" />
      <DisplayName Value="Failed" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="EMPTY" />
      <LabelName Value="Failed" />
      <MemberDetails Value="" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicMethodInfo dynamicType="Method" name="GoToLabel" aliasName="GoToLabel" visibility="AlwaysHidden" source="" blockTypeName="" returnType="System.Void">
            <param name="_param1" aliasName="msg" paramType="System.String" isIn="True" isOut="False" position="0" />
          </OpenSpan.DynamicMembers.DynamicMethodInfo>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="_param1" canRead="True" canWrite="True" type="System.String" aliasName="msg" shouldSerialize="False" visibility="AlwaysHidden" source="" blockTypeName="" />
        </Items>
      </Content>
    </OpenSpan.Automation.LabelHost>
    <OpenSpan.Automation.ExitPoint Name="exitPoint1" Id="ExitPoint-8D60739695057FD">
      <ComponentName Value="Execute" />
      <DisplayName Value="Success" />
      <EntryPoint Value="ComponentReference" Name="entryPoint1" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="Automator-8D606A84F759AFD\EntryPoint-8D606A860B8FDA6" />
      <MemberDetails Value="" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="Result" canRead="True" canWrite="True" type="System.Void" aliasName="Result" shouldSerialize="False" visibility="DefaultOn" source="" blockTypeName="" />
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="param1" canRead="True" canWrite="True" type="System.String" aliasName="msg" shouldSerialize="False" visibility="AlwaysHidden" source="" blockTypeName="" />
        </Items>
      </Content>
    </OpenSpan.Automation.ExitPoint>
    <OpenSpan.Automation.ExitPoint Name="exitPoint2" Id="ExitPoint-8D607396F000C38">
      <ComponentName Value="Execute" />
      <DisplayName Value="Failed" />
      <EntryPoint Value="ComponentReference" Name="entryPoint1" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="Automator-8D606A84F759AFD\EntryPoint-8D606A860B8FDA6" />
      <MemberDetails Value="" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="Result" canRead="True" canWrite="True" type="System.Void" aliasName="Result" shouldSerialize="False" visibility="DefaultOn" source="" blockTypeName="" />
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="param1" canRead="True" canWrite="True" type="System.String" aliasName="msg" shouldSerialize="False" visibility="AlwaysHidden" source="" blockTypeName="" />
        </Items>
      </Content>
    </OpenSpan.Automation.ExitPoint>
    <OpenSpan.Automation.JumpHost Name="jumpHost1" Id="JumpHost-8D60739BBC9611A">
      <ComponentName Value="labelHost1" />
      <DisplayName Value="GoToLabel" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.LabelHost" />
      <InstanceUniqueId Value="Automator-8D606A84F759AFD\LabelHost-8D607394C6AB20C" />
      <MemberDetails Value=" - Success" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="GoToLabel" />
            <MemberType Value="Method" />
            <TypeName Value="System.Void" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Void" />
              </OpenSpan.Automation.MethodSignature>
            </Content>
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.JumpHost>
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties2" Id="ConnectableProperties-8D60739F72E6273">
      <ComponentName Value="ACMESearchSystem" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.WebAdapter" />
      <InstanceUniqueId Value="WebAdapter-8D6036EE92E82A8" />
      <MemberDetails Value=".IsRunning Property" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="IsRunning" />
            <MemberType Value="Property" />
            <TypeName Value="System.Boolean" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableProperties>
    <OpenSpan.Automation.LabelHost Name="labelHost3" Id="LabelHost-8D6073A1282CF94">
      <ComponentName Value="OpenSpan.Automation.EntryPoint" />
      <DisplayName Value="SignIn" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="EMPTY" />
      <LabelName Value="SignIn" />
      <MemberDetails Value="" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicMethodInfo dynamicType="Method" name="GoToLabel" aliasName="GoToLabel" visibility="AlwaysHidden" source="" blockTypeName="" returnType="System.Void" />
        </Items>
      </Content>
    </OpenSpan.Automation.LabelHost>
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod1" Id="ConnectableMethod-8D6073A4F61C514">
      <ComponentName Value="ACMEwpSignIn" />
      <DisplayName Value="WaitForCreate" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.Controls.WebPage" />
      <InstanceUniqueId Value="WebAdapter-8D6036EE92E82A8\WebPage-8D60375DAC432D3" />
      <MemberDetails Value=".WaitForCreate() Method" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="Result" canRead="True" canWrite="False" type="System.Boolean" aliasName="Result" shouldSerialize="False" visibility="DefaultOn" source="" blockTypeName="" />
        </Items>
      </Content>
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="WaitForCreate" />
            <MemberType Value="Method" />
            <TypeName Value="System.Boolean" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Boolean" />
              </OpenSpan.Automation.MethodSignature>
            </Content>
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableMethod>
    <OpenSpan.Automation.JumpHost Name="jumpHost2" Id="JumpHost-8D6073A5E595F7F">
      <ComponentName Value="labelHost3" />
      <DisplayName Value="GoToLabel" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.LabelHost" />
      <InstanceUniqueId Value="Automator-8D606A84F759AFD\LabelHost-8D6073A1282CF94" />
      <MemberDetails Value=" - SignIn" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="GoToLabel" />
            <MemberType Value="Method" />
            <TypeName Value="System.Void" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Void" />
              </OpenSpan.Automation.MethodSignature>
            </Content>
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.JumpHost>
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod2" Id="ConnectableMethod-8D6073A8FFE4DF1">
      <ComponentName Value="ACMESearchSystem" />
      <DisplayName Value="Start" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.WebAdapter" />
      <InstanceUniqueId Value="WebAdapter-8D6036EE92E82A8" />
      <MemberDetails Value=".Start() Method" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Start" />
            <MemberType Value="Method" />
            <TypeName Value="System.Void" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Void" />
              </OpenSpan.Automation.MethodSignature>
            </Content>
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableMethod>
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod3" Id="ConnectableMethod-8D6073D1C13E567">
      <ComponentName Value="ACME_P_Signin" />
      <DisplayName Value="Execute" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.Automator" />
      <InstanceUniqueId Value="Automator-8D6073ACBE170E9" />
      <MemberDetails Value=".Execute() Method" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="_EntryPointExecute" />
            <MemberType Value="Method" />
            <TypeName Value="System.Void" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Void" />
                <Content Name="ParameterPrototype">
                  <Items>
                    <OpenSpan.Automation.ParameterPrototype>
                      <CanRead Value="True" />
                      <CanWrite Value="False" />
                      <DefaultSet Value="False" />
                      <ParamName Value="param1" />
                      <Position Value="0" />
                      <TypeName Value="System.String" />
                    </OpenSpan.Automation.ParameterPrototype>
                  </Items>
                </Content>
              </OpenSpan.Automation.MethodSignature>
            </Content>
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableMethod>
    <OpenSpan.Automation.JumpHost Name="jumpHost3" Id="JumpHost-8D6073D25480C39">
      <ComponentName Value="labelHost1" />
      <DisplayName Value="GoToLabel" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.LabelHost" />
      <InstanceUniqueId Value="Automator-8D606A84F759AFD\LabelHost-8D607394C6AB20C" />
      <MemberDetails Value=" - Success" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="GoToLabel" />
            <MemberType Value="Method" />
            <TypeName Value="System.Void" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Void" />
              </OpenSpan.Automation.MethodSignature>
            </Content>
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.JumpHost>
    <OpenSpan.Automation.JumpHost Name="jumpHost4" Id="JumpHost-8D6073D30EBCC82">
      <ComponentName Value="labelHost2" />
      <DisplayName Value="GoToLabel" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.LabelHost" />
      <InstanceUniqueId Value="Automator-8D606A84F759AFD\LabelHost-8D6073955241D54" />
      <MemberDetails Value=" - Failed" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="GoToLabel" />
            <MemberType Value="Method" />
            <TypeName Value="System.Void" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Void" />
                <Content Name="ParameterPrototype">
                  <Items>
                    <OpenSpan.Automation.ParameterPrototype>
                      <CanRead Value="False" />
                      <CanWrite Value="True" />
                      <DefaultSet Value="False" />
                      <ParamName Value="_param1" />
                      <Position Value="0" />
                      <TypeName Value="System.String" />
                    </OpenSpan.Automation.ParameterPrototype>
                  </Items>
                </Content>
              </OpenSpan.Automation.MethodSignature>
            </Content>
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.JumpHost>
    <OpenSpan.Automation.JumpHost Name="jumpHost5" Id="JumpHost-8D6073D467BAF11">
      <ComponentName Value="labelHost2" />
      <DisplayName Value="GoToLabel" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.LabelHost" />
      <InstanceUniqueId Value="Automator-8D606A84F759AFD\LabelHost-8D6073955241D54" />
      <MemberDetails Value=" - Failed" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="GoToLabel" />
            <MemberType Value="Method" />
            <TypeName Value="System.Void" />
            <Content Name="Signature">
              <OpenSpan.Automation.MethodSignature>
                <ReturnType Value="System.Void" />
                <Content Name="ParameterPrototype">
                  <Items>
                    <OpenSpan.Automation.ParameterPrototype>
                      <CanRead Value="False" />
                      <CanWrite Value="True" />
                      <DefaultSet Value="True" />
                      <DefaultValue Value="Unable to find Sign In Page" />
                      <ParamName Value="_param1" />
                      <Position Value="0" />
                      <TypeName Value="System.String" />
                    </OpenSpan.Automation.ParameterPrototype>
                  </Items>
                </Content>
              </OpenSpan.Automation.MethodSignature>
            </Content>
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.JumpHost>
  </Component>
</OpenSpanDesignDocument>