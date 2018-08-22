<OpenSpanDesignDocument Version="8.0.1026.0" Serializer="2.0" Culture="en-US">
  <ComponentInfo>
    <Type Value="OpenSpan.Automation.Automator" />
    <Assembly Value="OpenSpan.Automation" />
    <AssemblyReferences>
      <Assembly Value="mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="OpenSpan, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters.Web, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Automation, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
    </AssemblyReferences>
    <DynamicAssemblyReferences />
    <FileReferences />
    <BuildReferences />
  </ComponentInfo>
  <Component Version="1.0">
    <OpenSpan.Automation.Automator Name="ACME_P_SearchByZip" Id="Automator-8D607434C2DEFF4">
      <AutomationDocument>
        <Name Value="" />
        <Size Value="5012, 5010" />
        <Objects>
          <ConnectionBlock>
            <ConnectableUniqueId Value="Automator-8D607434C2DEFF4\LabelHost-8D6074366FCA391" />
            <Left Value="740" />
            <Top Value="0" />
            <PartID Value="1" />
          </ConnectionBlock>
          <ConnectionBlock>
            <ConnectableUniqueId Value="Automator-8D607434C2DEFF4\LabelHost-8D607437DAE4557" />
            <Left Value="740" />
            <Top Value="100" />
            <PartID Value="2" />
          </ConnectionBlock>
          <ConnectionBlock>
            <ConnectableUniqueId Value="Automator-8D607434C2DEFF4\EntryPoint-8D60743A7E144C5" />
            <Left Value="0" />
            <Top Value="0" />
            <PartID Value="3" />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="WaitForCreate" />
            <ConnectableUniqueId Value="Automator-8D607434C2DEFF4\ConnectableMethod-8D60743FA6D7DF1" />
            <PartID Value="4" />
            <Left Value="140" />
            <Top Value="0" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ACMEwpHome" />
            <Fittings>
              <Result Collapsed="False" ActualText="Result" />
            </Fittings>
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D607434C2DEFF4\ConnectableProperties-8D60744590FAC8E" />
            <PartID Value="10" />
            <Left Value="580" />
            <Top Value="180" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ACMEtxtZip" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="PerformClick" />
            <ConnectableUniqueId Value="Automator-8D607434C2DEFF4\ConnectableMethod-8D6074489528681" />
            <PartID Value="12" />
            <Left Value="60" />
            <Top Value="340" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ACMEbtnFindStore" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock type="OpenSpan.Automation.Design.ConnectionBlocks.MultiExitPointBlock">
            <ConnectableUniqueId Value="Automator-8D607434C2DEFF4\ExitPoint-8D60744D5A73D70" />
            <Left Value="880" />
            <Top Value="0" />
            <PartID Value="16" />
            <Title Value="Success" />
            <EventName Value="" />
          </ConnectionBlock>
          <ConnectionBlock type="OpenSpan.Automation.Design.ConnectionBlocks.MultiExitPointBlock">
            <ConnectableUniqueId Value="Automator-8D607434C2DEFF4\ExitPoint-8D60744DDA7B0B9" />
            <Left Value="880" />
            <Top Value="100" />
            <PartID Value="17" />
            <Title Value="Failure" />
            <EventName Value="" />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="GoToLabel" />
            <ConnectableUniqueId Value="Automator-8D607434C2DEFF4\JumpHost-8D607451BFD4F14" />
            <PartID Value="22" />
            <Left Value="740" />
            <Top Value="340" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="Jump To" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="GoToLabel" />
            <ConnectableUniqueId Value="Automator-8D607434C2DEFF4\JumpHost-8D607452597F964" />
            <PartID Value="24" />
            <Left Value="720" />
            <Top Value="420" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="Jump To" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="GoToLabel" />
            <ConnectableUniqueId Value="Automator-8D607434C2DEFF4\JumpHost-8D6074547215788" />
            <PartID Value="28" />
            <Left Value="320" />
            <Top Value="140" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="Jump To" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="GoToLabel" />
            <ConnectableUniqueId Value="Automator-8D607434C2DEFF4\JumpHost-8D60745613CC092" />
            <PartID Value="30" />
            <Left Value="540" />
            <Top Value="100" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="Jump To" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="WaitForCreate" />
            <ConnectableUniqueId Value="Automator-8D607434C2DEFF4\ConnectableMethod-8D6074A34DB0F4F" />
            <PartID Value="34" />
            <Left Value="300" />
            <Top Value="360" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ACMEtblNearestStore" />
            <Fittings>
              <Result Collapsed="False" ActualText="Result" />
            </Fittings>
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D607434C2DEFF4\ConnectableProperties-8D6074A3D527585" />
            <PartID Value="35" />
            <Left Value="520" />
            <Top Value="340" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ACMEtblNearestStore" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="WaitForCreate" />
            <ConnectableUniqueId Value="Automator-8D607434C2DEFF4\ConnectableMethod-8D60755136E11C5" />
            <PartID Value="43" />
            <Left Value="60" />
            <Top Value="120" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ACMEwpStores" />
            <Fittings>
              <Result Collapsed="False" ActualText="Result" />
            </Fittings>
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <ConnectableUniqueId Value="Automator-8D607434C2DEFF4\LabelHost-8D60755B82A82C3" />
            <Left Value="20" />
            <Top Value="448" />
            <PartID Value="52" />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="GoToLabel" />
            <ConnectableUniqueId Value="Automator-8D607434C2DEFF4\JumpHost-8D60755C68DE0E7" />
            <PartID Value="54" />
            <Left Value="820" />
            <Top Value="200" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="Jump To" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="PerformClick" />
            <ConnectableUniqueId Value="Automator-8D607434C2DEFF4\ConnectableMethod-8D6075C04F0F66B" />
            <PartID Value="57" />
            <Left Value="380" />
            <Top Value="20" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="ACMElnkStores" />
            <OverriddenIds />
          </ConnectionBlock>
          <ConnectionBlock>
            <DisplayName Value="Properties" />
            <ConnectableUniqueId Value="Automator-8D607434C2DEFF4\ConnectableProperties-8D6076C94BAD81F" />
            <PartID Value="60" />
            <Left Value="220" />
            <Top Value="260" />
            <Collapsed Value="False" />
            <WillExecute Value="True" />
            <InstanceName Value="zipCode" />
            <OverriddenIds />
          </ConnectionBlock>
        </Objects>
        <Links>
          <Link PartID="5" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="3" PortName="Complete" PortType="Event" ConnectableId="Automator-8D607434C2DEFF4\EntryPoint-8D60743A7E144C5" MemberComponentId="Automator-8D607434C2DEFF4\EntryPoint-8D60743A7E144C5" />
            <To PartID="4" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D607434C2DEFF4\ConnectableMethod-8D60743FA6D7DF1" MemberComponentId="Automator-8D607434C2DEFF4\ConnectableMethod-8D60743FA6D7DF1" />
            <LinkPoints>
              <Point value="111, 18" />
              <Point value="121, 18" />
              <Point value="124, 18" />
              <Point value="124, 45" />
              <Point value="135, 45" />
              <Point value="145, 45" />
            </LinkPoints>
          </Link>
          <Link PartID="19" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="2" PortName="_param1" PortType="Property" ConnectableId="Automator-8D607434C2DEFF4\LabelHost-8D607437DAE4557" MemberComponentId="EMPTY" />
            <To PartID="17" PortName="_param1" PortType="Property" ConnectableId="Automator-8D607434C2DEFF4\ExitPoint-8D60744DDA7B0B9" MemberComponentId="EMPTY" />
            <LinkPoints>
              <Point value="842, 145" />
              <Point value="852, 145" />
              <Point value="852, 145" />
              <Point value="852, 145" />
              <Point value="872, 145" />
              <Point value="882, 145" />
            </LinkPoints>
          </Link>
          <DecisionEventLink PartID="31" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="4" ParentMemberName="Result" DecisionValue="False" ConnectableId="Automator-8D607434C2DEFF4\ConnectableMethod-8D60743FA6D7DF1" />
            <To PartID="30" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D607434C2DEFF4\JumpHost-8D60745613CC092" MemberComponentId="Automator-8D607434C2DEFF4\JumpHost-8D60745613CC092" />
            <LinkPoints>
              <Point value="317, 91" />
              <Point value="327, 91" />
              <Point value="332, 91" />
              <Point value="332, 117" />
              <Point value="533, 117" />
              <Point value="543, 117" />
            </LinkPoints>
          </DecisionEventLink>
          <Link PartID="32" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="1" PortName="_param1" PortType="Property" ConnectableId="Automator-8D607434C2DEFF4\LabelHost-8D6074366FCA391" MemberComponentId="EMPTY" />
            <To PartID="16" PortName="Result" PortType="Property" ConnectableId="Automator-8D607434C2DEFF4\ExitPoint-8D60744D5A73D70" MemberComponentId="EMPTY" />
            <LinkPoints>
              <Point value="855, 45" />
              <Point value="865, 45" />
              <Point value="868, 45" />
              <Point value="868, 61" />
              <Point value="872, 61" />
              <Point value="882, 61" />
            </LinkPoints>
          </Link>
          <Link PartID="36" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="35" PortName="Text" PortType="Property" ConnectableId="Automator-8D607434C2DEFF4\ConnectableProperties-8D6074A3D527585" MemberComponentId="WebAdapter-8D6036EE92E82A8\Table-8D60377D611EEA8" />
            <To PartID="22" PortName="_param1" PortType="Property" ConnectableId="Automator-8D607434C2DEFF4\JumpHost-8D607451BFD4F14" MemberComponentId="Automator-8D607434C2DEFF4\JumpHost-8D607451BFD4F14" />
            <LinkPoints>
              <Point value="704, 402" />
              <Point value="714, 402" />
              <Point value="716, 402" />
              <Point value="716, 386" />
              <Point value="735, 386" />
              <Point value="745, 386" />
            </LinkPoints>
          </Link>
          <DecisionEventLink PartID="38" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="34" ParentMemberName="Result" DecisionValue="True" ConnectableId="Automator-8D607434C2DEFF4\ConnectableMethod-8D6074A34DB0F4F" />
            <To PartID="35" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D607434C2DEFF4\ConnectableProperties-8D6074A3D527585" MemberComponentId="Automator-8D607434C2DEFF4\ConnectableProperties-8D6074A3D527585" />
            <LinkPoints>
              <Point value="484, 436" />
              <Point value="494, 436" />
              <Point value="492, 436" />
              <Point value="492, 436" />
              <Point value="500, 436" />
              <Point value="500, 385" />
              <Point value="515, 385" />
              <Point value="525, 385" />
            </LinkPoints>
          </DecisionEventLink>
          <DecisionEventLink PartID="39" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="34" ParentMemberName="Result" DecisionValue="False" ConnectableId="Automator-8D607434C2DEFF4\ConnectableMethod-8D6074A34DB0F4F" />
            <To PartID="24" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D607434C2DEFF4\JumpHost-8D607452597F964" MemberComponentId="Automator-8D607434C2DEFF4\JumpHost-8D607452597F964" />
            <LinkPoints>
              <Point value="484, 451" />
              <Point value="494, 451" />
              <Point value="492, 451" />
              <Point value="492, 451" />
              <Point value="500, 451" />
              <Point value="500, 437" />
              <Point value="713, 437" />
              <Point value="723, 437" />
            </LinkPoints>
          </DecisionEventLink>
          <Link PartID="40" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="12" PortName="Complete" PortType="Event" ConnectableId="Automator-8D607434C2DEFF4\ConnectableMethod-8D6074489528681" MemberComponentId="Automator-8D607434C2DEFF4\ConnectableMethod-8D6074489528681" />
            <To PartID="34" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D607434C2DEFF4\ConnectableMethod-8D6074A34DB0F4F" MemberComponentId="Automator-8D607434C2DEFF4\ConnectableMethod-8D6074A34DB0F4F" />
            <LinkPoints>
              <Point value="237, 385" />
              <Point value="247, 385" />
              <Point value="252, 385" />
              <Point value="252, 405" />
              <Point value="295, 405" />
              <Point value="305, 405" />
            </LinkPoints>
          </Link>
          <DecisionEventLink PartID="49" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="43" ParentMemberName="Result" DecisionValue="True" ConnectableId="Automator-8D607434C2DEFF4\ConnectableMethod-8D60755136E11C5" />
            <To PartID="10" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D607434C2DEFF4\ConnectableProperties-8D60744590FAC8E" MemberComponentId="Automator-8D607434C2DEFF4\ConnectableProperties-8D60744590FAC8E" />
            <LinkPoints>
              <Point value="237, 196" />
              <Point value="247, 196" />
              <Point value="244, 196" />
              <Point value="244, 196" />
              <Point value="252, 196" />
              <Point value="252, 225" />
              <Point value="575, 225" />
              <Point value="585, 225" />
            </LinkPoints>
          </DecisionEventLink>
          <Link PartID="53" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="52" PortName="Complete" PortType="Event" ConnectableId="Automator-8D607434C2DEFF4\LabelHost-8D60755B82A82C3" MemberComponentId="Automator-8D607434C2DEFF4\LabelHost-8D60755B82A82C3" />
            <To PartID="12" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D607434C2DEFF4\ConnectableMethod-8D6074489528681" MemberComponentId="Automator-8D607434C2DEFF4\ConnectableMethod-8D6074489528681" />
            <LinkPoints>
              <Point value="111, 466" />
              <Point value="121, 466" />
              <Point value="124, 466" />
              <Point value="124, 444" />
              <Point value="52, 444" />
              <Point value="52, 385" />
              <Point value="55, 385" />
              <Point value="65, 385" />
            </LinkPoints>
          </Link>
          <Link PartID="55" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="10" PortName="Complete" PortType="Event" ConnectableId="Automator-8D607434C2DEFF4\ConnectableProperties-8D60744590FAC8E" MemberComponentId="Automator-8D607434C2DEFF4\ConnectableProperties-8D60744590FAC8E" />
            <To PartID="54" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D607434C2DEFF4\JumpHost-8D60755C68DE0E7" MemberComponentId="Automator-8D607434C2DEFF4\JumpHost-8D60755C68DE0E7" />
            <LinkPoints>
              <Point value="757, 225" />
              <Point value="767, 225" />
              <Point value="764, 225" />
              <Point value="764, 225" />
              <Point value="772, 225" />
              <Point value="772, 217" />
              <Point value="813, 217" />
              <Point value="823, 217" />
            </LinkPoints>
          </Link>
          <DecisionEventLink PartID="56" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="43" ParentMemberName="Result" DecisionValue="False" ConnectableId="Automator-8D607434C2DEFF4\ConnectableMethod-8D60755136E11C5" />
            <To PartID="28" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D607434C2DEFF4\JumpHost-8D6074547215788" MemberComponentId="Automator-8D607434C2DEFF4\JumpHost-8D6074547215788" />
            <LinkPoints>
              <Point value="237, 211" />
              <Point value="247, 211" />
              <Point value="244, 211" />
              <Point value="244, 211" />
              <Point value="252, 211" />
              <Point value="252, 157" />
              <Point value="313, 157" />
              <Point value="323, 157" />
            </LinkPoints>
          </DecisionEventLink>
          <DecisionEventLink PartID="58" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="4" ParentMemberName="Result" DecisionValue="True" ConnectableId="Automator-8D607434C2DEFF4\ConnectableMethod-8D60743FA6D7DF1" />
            <To PartID="57" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D607434C2DEFF4\ConnectableMethod-8D6075C04F0F66B" MemberComponentId="Automator-8D607434C2DEFF4\ConnectableMethod-8D6075C04F0F66B" />
            <LinkPoints>
              <Point value="317, 76" />
              <Point value="327, 76" />
              <Point value="351, 76" />
              <Point value="351, 65" />
              <Point value="375, 65" />
              <Point value="385, 65" />
            </LinkPoints>
          </DecisionEventLink>
          <Link PartID="59" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="57" PortName="Complete" PortType="Event" ConnectableId="Automator-8D607434C2DEFF4\ConnectableMethod-8D6075C04F0F66B" MemberComponentId="Automator-8D607434C2DEFF4\ConnectableMethod-8D6075C04F0F66B" />
            <To PartID="43" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D607434C2DEFF4\ConnectableMethod-8D60755136E11C5" MemberComponentId="Automator-8D607434C2DEFF4\ConnectableMethod-8D60755136E11C5" />
            <LinkPoints>
              <Point value="557, 65" />
              <Point value="567, 65" />
              <Point value="564, 65" />
              <Point value="564, 65" />
              <Point value="572, 65" />
              <Point value="572, 84" />
              <Point value="532, 84" />
              <Point value="532, 108" />
              <Point value="20, 108" />
              <Point value="20, 165" />
              <Point value="55, 165" />
              <Point value="65, 165" />
            </LinkPoints>
          </Link>
          <Link PartID="61" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="60" PortName="This" PortType="Property" ConnectableId="Automator-8D607434C2DEFF4\ConnectableProperties-8D6076C94BAD81F" MemberComponentId="Automator-8D607434C2DEFF4\HiddenTypeProxy-8D607444453F00D" />
            <To PartID="10" PortName="Text" PortType="Property" ConnectableId="Automator-8D607434C2DEFF4\ConnectableProperties-8D60744590FAC8E" MemberComponentId="WebAdapter-8D6036EE92E82A8\TextBox-8D60376C973831A" />
            <LinkPoints>
              <Point value="411, 322" />
              <Point value="421, 322" />
              <Point value="428, 322" />
              <Point value="428, 242" />
              <Point value="575, 242" />
              <Point value="585, 242" />
            </LinkPoints>
          </Link>
          <Link PartID="62" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="35" PortName="Complete" PortType="Event" ConnectableId="Automator-8D607434C2DEFF4\ConnectableProperties-8D6074A3D527585" MemberComponentId="Automator-8D607434C2DEFF4\ConnectableProperties-8D6074A3D527585" />
            <To PartID="22" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D607434C2DEFF4\JumpHost-8D607451BFD4F14" MemberComponentId="Automator-8D607434C2DEFF4\JumpHost-8D607451BFD4F14" />
            <LinkPoints>
              <Point value="704, 385" />
              <Point value="714, 385" />
              <Point value="716, 385" />
              <Point value="716, 357" />
              <Point value="733, 357" />
              <Point value="743, 357" />
            </LinkPoints>
          </Link>
          <Link PartID="63" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="1" PortName="Complete" PortType="Event" ConnectableId="Automator-8D607434C2DEFF4\LabelHost-8D6074366FCA391" MemberComponentId="Automator-8D607434C2DEFF4\LabelHost-8D6074366FCA391" />
            <To PartID="16" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D607434C2DEFF4\ExitPoint-8D60744D5A73D70" MemberComponentId="Automator-8D607434C2DEFF4\ExitPoint-8D60744D5A73D70" />
            <LinkPoints>
              <Point value="855, 18" />
              <Point value="865, 18" />
              <Point value="868, 18" />
              <Point value="868, 18" />
              <Point value="872, 18" />
              <Point value="882, 18" />
            </LinkPoints>
          </Link>
          <Link PartID="64" Sensitive="False" Asynchronous="False" LogBeforeExecution="" LogAfterExecution="">
            <From PartID="2" PortName="Complete" PortType="Event" ConnectableId="Automator-8D607434C2DEFF4\LabelHost-8D607437DAE4557" MemberComponentId="Automator-8D607434C2DEFF4\LabelHost-8D607437DAE4557" />
            <To PartID="17" PortName="DoWork" PortType="Method" ConnectableId="Automator-8D607434C2DEFF4\ExitPoint-8D60744DDA7B0B9" MemberComponentId="Automator-8D607434C2DEFF4\ExitPoint-8D60744DDA7B0B9" />
            <LinkPoints>
              <Point value="842, 118" />
              <Point value="852, 118" />
              <Point value="862, 118" />
              <Point value="862, 118" />
              <Point value="872, 118" />
              <Point value="882, 118" />
            </LinkPoints>
          </Link>
        </Links>
        <Comments />
        <SubGraphs />
      </AutomationDocument>
      <ShowDesignCompNames Value="True" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicMethodInfo dynamicType="Method" name="_EntryPointExecute" aliasName="Execute" visibility="DefaultOn" source="" blockTypeName="OpenSpan.Automation.Design.ConnectionBlocks.EntryPointExecuteBlock" returnType="System.String">
            <param name="param1" aliasName="zipCode" paramType="System.String" isIn="True" isOut="False" position="0" />
            <param name="_param1" aliasName="msg" paramType="System.String" isIn="False" isOut="True" position="1" />
          </OpenSpan.DynamicMembers.DynamicMethodInfo>
        </Items>
      </Content>
    </OpenSpan.Automation.Automator>
    <OpenSpan.Automation.LabelHost Name="labelHost1" Id="LabelHost-8D6074366FCA391">
      <ComponentName Value="OpenSpan.Automation.EntryPoint" />
      <DisplayName Value="Success" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="EMPTY" />
      <LabelName Value="Success" />
      <MemberDetails Value="" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicMethodInfo dynamicType="Method" name="GoToLabel" aliasName="GoToLabel" visibility="AlwaysHidden" source="" blockTypeName="" returnType="System.Void">
            <param name="_param1" aliasName="storeAddr" paramType="System.String" isIn="True" isOut="False" position="0" />
          </OpenSpan.DynamicMembers.DynamicMethodInfo>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="_param1" canRead="True" canWrite="True" type="System.String" aliasName="storeAddr" shouldSerialize="False" visibility="AlwaysHidden" source="" blockTypeName="" />
        </Items>
      </Content>
    </OpenSpan.Automation.LabelHost>
    <OpenSpan.Automation.LabelHost Name="labelHost2" Id="LabelHost-8D607437DAE4557">
      <ComponentName Value="OpenSpan.Automation.EntryPoint" />
      <DisplayName Value="Failure" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="EMPTY" />
      <LabelName Value="Failure" />
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
    <OpenSpan.Automation.EntryPoint Name="entryPoint1" Id="EntryPoint-8D60743A7E144C5">
      <AliasName Value="Execute" />
      <ComponentName Value="&lt;No Instance&gt;" />
      <DisplayName Value="" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="Automator-8D607434C2DEFF4\EntryPoint-8D60743A7E144C5" />
      <MemberDetails Value="" />
      <MethodName Value="_EntryPointExecute" />
      <Removing Value="False" />
      <UseAlias Value="True" />
      <Content Name="Controls">
        <Capacity Value="4" />
        <Items>
          <OpenSpan.Automation.HiddenTypeProxy Name="hiddenTypeProxy1" Id="HiddenTypeProxy-8D607444453F00D">
            <AliasName Value="zipCode" />
            <Parent Value="ComponentReference" Name="entryPoint1" />
            <ProxiedTypeName Value="System.String, mscorlib" />
            <Scope Value="Local" Extended="True" />
            <UseAlias Value="True" />
            <Content Name="DynamicMembers">
              <Items>
                <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="Instance" canRead="True" canWrite="True" type="System.String" aliasName="Instance" shouldSerialize="False" visibility="AlwaysHidden" source="" blockTypeName="" />
              </Items>
            </Content>
          </OpenSpan.Automation.HiddenTypeProxy>
        </Items>
      </Content>
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="Result" canRead="True" canWrite="True" type="System.String" aliasName="Result" shouldSerialize="False" visibility="AlwaysHidden" source="" blockTypeName="" />
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="param1" canRead="False" canWrite="True" type="System.String" aliasName="zipCode" shouldSerialize="False" visibility="AlwaysHidden" source="" blockTypeName="" />
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="_param1" canRead="True" canWrite="False" type="System.String" aliasName="msg" shouldSerialize="False" visibility="AlwaysHidden" source="" blockTypeName="" />
        </Items>
      </Content>
    </OpenSpan.Automation.EntryPoint>
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod1" Id="ConnectableMethod-8D60743FA6D7DF1">
      <ComponentName Value="ACMEwpHome" />
      <DisplayName Value="WaitForCreate" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.Controls.WebPage" />
      <InstanceUniqueId Value="WebAdapter-8D6036EE92E82A8\WebPage-8D60376ACF65820" />
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
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties1" Id="ConnectableProperties-8D60744590FAC8E">
      <ComponentName Value="ACMEtxtZip" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.Controls.TextBox" />
      <InstanceUniqueId Value="WebAdapter-8D6036EE92E82A8\TextBox-8D60376C973831A" />
      <MemberDetails Value=".Text Property" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Text" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableProperties>
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod4" Id="ConnectableMethod-8D6074489528681">
      <ComponentName Value="ACMEbtnFindStore" />
      <DisplayName Value="PerformClick" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.Controls.Button" />
      <InstanceUniqueId Value="WebAdapter-8D6036EE92E82A8\Button-8D60376CB53752D" />
      <MemberDetails Value=".PerformClick() Method" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="PerformClick" />
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
    <OpenSpan.Automation.ExitPoint Name="exitPoint1" Id="ExitPoint-8D60744D5A73D70">
      <ComponentName Value="Execute" />
      <DisplayName Value="Success" />
      <EntryPoint Value="ComponentReference" Name="entryPoint1" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="Automator-8D607434C2DEFF4\EntryPoint-8D60743A7E144C5" />
      <MemberDetails Value="" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="Result" canRead="True" canWrite="True" type="System.String" aliasName="Result" shouldSerialize="False" visibility="DefaultOn" source="" blockTypeName="" />
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="_param1" canRead="True" canWrite="True" type="System.String" aliasName="msg" shouldSerialize="False" visibility="AlwaysHidden" source="" blockTypeName="" />
        </Items>
      </Content>
    </OpenSpan.Automation.ExitPoint>
    <OpenSpan.Automation.ExitPoint Name="exitPoint2" Id="ExitPoint-8D60744DDA7B0B9">
      <ComponentName Value="Execute" />
      <DisplayName Value="Failure" />
      <EntryPoint Value="ComponentReference" Name="entryPoint1" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="Automator-8D607434C2DEFF4\EntryPoint-8D60743A7E144C5" />
      <MemberDetails Value="" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="Result" canRead="True" canWrite="True" type="System.String" aliasName="Result" shouldSerialize="False" visibility="DefaultOn" source="" blockTypeName="" />
          <OpenSpan.DynamicMembers.DynamicPropertyInfo dynamicType="Property" name="_param1" canRead="True" canWrite="True" type="System.String" aliasName="msg" shouldSerialize="False" visibility="AlwaysHidden" source="" blockTypeName="" />
        </Items>
      </Content>
    </OpenSpan.Automation.ExitPoint>
    <OpenSpan.Automation.JumpHost Name="jumpHost1" Id="JumpHost-8D607451BFD4F14">
      <ComponentName Value="labelHost1" />
      <DisplayName Value="GoToLabel" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.LabelHost" />
      <InstanceUniqueId Value="Automator-8D607434C2DEFF4\LabelHost-8D6074366FCA391" />
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
    <OpenSpan.Automation.JumpHost Name="jumpHost2" Id="JumpHost-8D607452597F964">
      <ComponentName Value="labelHost2" />
      <DisplayName Value="GoToLabel" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.LabelHost" />
      <InstanceUniqueId Value="Automator-8D607434C2DEFF4\LabelHost-8D607437DAE4557" />
      <MemberDetails Value=" - Failure" />
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
                      <DefaultValue Value="Unable to get search results page" />
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
    <OpenSpan.Automation.JumpHost Name="jumpHost3" Id="JumpHost-8D6074547215788">
      <ComponentName Value="labelHost2" />
      <DisplayName Value="GoToLabel" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.LabelHost" />
      <InstanceUniqueId Value="Automator-8D607434C2DEFF4\LabelHost-8D607437DAE4557" />
      <MemberDetails Value=" - Failure" />
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
                      <DefaultValue Value="Failed to create Search Page" />
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
    <OpenSpan.Automation.JumpHost Name="jumpHost4" Id="JumpHost-8D60745613CC092">
      <ComponentName Value="labelHost2" />
      <DisplayName Value="GoToLabel" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.LabelHost" />
      <InstanceUniqueId Value="Automator-8D607434C2DEFF4\LabelHost-8D607437DAE4557" />
      <MemberDetails Value=" - Failure" />
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
                      <DefaultValue Value="Failed to load home page" />
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
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod5" Id="ConnectableMethod-8D6074A34DB0F4F">
      <ComponentName Value="ACMEtblNearestStore" />
      <DisplayName Value="WaitForCreate" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.Controls.Table" />
      <InstanceUniqueId Value="WebAdapter-8D6036EE92E82A8\Table-8D60377D611EEA8" />
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
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties2" Id="ConnectableProperties-8D6074A3D527585">
      <ComponentName Value="ACMEtblNearestStore" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.Controls.Table" />
      <InstanceUniqueId Value="WebAdapter-8D6036EE92E82A8\Table-8D60377D611EEA8" />
      <MemberDetails Value=".Text Property" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="Text" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableProperties>
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod3" Id="ConnectableMethod-8D60755136E11C5">
      <ComponentName Value="ACMEwpStores" />
      <DisplayName Value="WaitForCreate" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.Controls.WebPage" />
      <InstanceUniqueId Value="WebAdapter-8D6036EE92E82A8\WebPage-8D60376C9808448" />
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
    <OpenSpan.Automation.LabelHost Name="labelHost3" Id="LabelHost-8D60755B82A82C3">
      <ComponentName Value="OpenSpan.Automation.EntryPoint" />
      <DisplayName Value="Store" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.EntryPoint" />
      <InstanceUniqueId Value="EMPTY" />
      <LabelName Value="Store" />
      <MemberDetails Value="" />
      <Content Name="DynamicMembers">
        <Items>
          <OpenSpan.DynamicMembers.DynamicMethodInfo dynamicType="Method" name="GoToLabel" aliasName="GoToLabel" visibility="AlwaysHidden" source="" blockTypeName="" returnType="System.Void" />
        </Items>
      </Content>
    </OpenSpan.Automation.LabelHost>
    <OpenSpan.Automation.JumpHost Name="jumpHost5" Id="JumpHost-8D60755C68DE0E7">
      <ComponentName Value="labelHost3" />
      <DisplayName Value="GoToLabel" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Automation.LabelHost" />
      <InstanceUniqueId Value="Automator-8D607434C2DEFF4\LabelHost-8D60755B82A82C3" />
      <MemberDetails Value=" - Store" />
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
    <OpenSpan.Automation.ConnectableMethod Name="connectableMethod2" Id="ConnectableMethod-8D6075C04F0F66B">
      <ComponentName Value="ACMElnkStores" />
      <DisplayName Value="PerformClick" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="OpenSpan.Adapters.Web.Controls.Link" />
      <InstanceUniqueId Value="WebAdapter-8D6036EE92E82A8\Link-8D60759691DE487" />
      <MemberDetails Value=".PerformClick() Method" />
      <ParamsLength Value="0" />
      <SerializedParamsDefaultValues Value="" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="PerformClick" />
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
    <OpenSpan.Automation.ConnectableProperties Name="connectableProperties3" Id="ConnectableProperties-8D6076C94BAD81F">
      <ComponentName Value="zipCode" />
      <DefaultValues Value="" />
      <DisplayName Value="Properties" />
      <ExceptionsHandled Value="False" />
      <InstanceTypeName Value="System.String" />
      <InstanceUniqueId Value="Automator-8D607434C2DEFF4\HiddenTypeProxy-8D607444453F00D" />
      <MemberDetails Value=".This Property" />
      <Content Name="MemberPrototypes">
        <Items>
          <OpenSpan.Automation.MemberPrototype>
            <MemberName Value="This" />
            <MemberType Value="Property" />
            <TypeName Value="System.String" />
          </OpenSpan.Automation.MemberPrototype>
        </Items>
      </Content>
    </OpenSpan.Automation.ConnectableProperties>
  </Component>
</OpenSpanDesignDocument>