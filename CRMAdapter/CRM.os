<OpenSpanDesignDocument Version="8.0.1026.0" Serializer="2.0" Culture="en-US">
  <ComponentInfo>
    <Type Value="OpenSpan.Adapters.Windows.WindowsAdapter" />
    <Assembly Value="OpenSpan.Adapters.Windows" />
    <AssemblyReferences>
      <Assembly Value="mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
      <Assembly Value="OpenSpan, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters.ActiveX, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters.DotNet, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters.Virtual, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="OpenSpan.Adapters.Windows, Version=8.0.0.0, Culture=neutral, PublicKeyToken=f5db91edc02d8c5e" />
      <Assembly Value="System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
    </AssemblyReferences>
    <DynamicAssemblyReferences />
    <FileReferences />
    <BuildReferences>
      <File Value="DefaultWindowFactoryConfiguration.xml" />
      <File Value="OpenSpan.ActiveX.x32.dll" />
      <File Value="OpenSpan.ActiveX.x64.dll" />
      <File Value="OpenSpan.Brokers.Windows.x32.dll" />
      <File Value="OpenSpan.Brokers.Windows.x64.dll" />
      <File Value="openspan.ini" />
      <File Value="OpenSpan.IPC.tlb" />
      <File Value="OpenSpan.Native.IPC.x32.dll" />
      <File Value="OpenSpan.Native.IPC.x64.dll" />
      <File Value="OpenSpan.RemoteFunctions.x32.dll" />
      <File Value="OpenSpan.RemoteFunctions.x64.dll" />
      <File Value="OpenSpan.Scout.x32.dll" />
      <File Value="OpenSpan.Scout.x64.dll" />
      <File Value="OpenSpan.Security.x32.dll" />
      <File Value="OpenSpan.Security.x64.dll" />
      <File Value="OpenSpan.SharedMemory.x32.dll" />
      <File Value="OpenSpan.SharedMemory.x64.dll" />
      <File Value="OpenSpan.Sinon.x32.dll" />
      <File Value="OpenSpan.Sinon.x64.dll" />
      <File Value="OpenSpan.Utilities.x32.dll" />
      <File Value="OpenSpan.Utilities.x64.dll" />
      <File Value="OpenSpan.Virtual.Interfaces.delegates.tlb" />
      <File Value="OpenSpan.Virtual.Interfaces.tlb" />
      <File Value="OpenSpan.WER.x32.dll" />
      <File Value="OpenSpan.WER.x64.dll" />
      <File Value="OpenSpan.x32.sys" />
      <File Value="OpenSpan.x64.sys" />
    </BuildReferences>
  </ComponentInfo>
  <Component Version="1.0">
    <OpenSpan.Adapters.Windows.WindowsAdapter Name="CRM" Id="WindowsAdapter-8D6077AF402B27D">
      <Path Value="C:\Program Files (x86)\OpenSpan\CRM Setup\CRM.exe" />
      <WorkingDirectory Value="C:\Program Files (x86)\OpenSpan\CRM Setup" />
      <Content Name="Controls">
        <Items>
          <OpenSpan.Adapters.DotNet.DotNet20Factory Name="DotNet20Factory" Id="DotNet20Factory-8D6077B1DAE5689">
            <DummyPropertyToDetectReplaceUndo Value="0" />
            <ForwardObjectExplorerEvent Value="True" />
            <MatchingIndex Value="0" />
            <TargetTypeString Value="OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows" />
            <UseKeys Value="True" />
            <Content Name="MatchRules">
              <Items>
                <OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule Name="moduleNameMatchRule1" Id="ModuleNameMatchRule-8D6077B1DBB7EF1">
                  <Text Value="Simple|True|(User Culture)|mscorwks.dll" />
                </OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule>
                <OpenSpan.Adapters.Windows.MatchRules.ModuleVersionMatchRule Name="moduleVersionMatchRule1" Id="ModuleVersionMatchRule-8D6077B1DBF794C">
                  <Text Value="Wildcard|True|(User Culture)|2.0.*.*" />
                </OpenSpan.Adapters.Windows.MatchRules.ModuleVersionMatchRule>
              </Items>
            </Content>
          </OpenSpan.Adapters.DotNet.DotNet20Factory>
          <OpenSpan.Adapters.ActiveX.ActiveXFactory Name="ActiveXFactory" Id="ActiveXFactory-8D6077B1DC71F9D">
            <DummyPropertyToDetectReplaceUndo Value="0" />
            <ForwardObjectExplorerEvent Value="True" />
            <MatchingIndex Value="0" />
            <TargetTypeString Value="OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows" />
            <UseKeys Value="True" />
            <Content Name="MatchRules">
              <Items>
                <OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule Name="moduleNameMatchRule2" Id="ModuleNameMatchRule-8D6077B1DCE77A4">
                  <Text Value="Simple|True|(User Culture)|ole32.dll" />
                </OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule>
              </Items>
            </Content>
          </OpenSpan.Adapters.ActiveX.ActiveXFactory>
          <OpenSpan.Adapters.Controls.Form Name="CRMfrmLogin" Id="Form-8D6077B2350AB06">
            <DummyPropertyToDetectReplaceUndo Value="0" />
            <ForwardObjectExplorerEvent Value="True" />
            <MatchingIndex Value="3" />
            <TargetTypeString Value="OpenSpan.Adapters.DotNet.WindowsForms.DotNetFormTarget, OpenSpan.Adapters.DotNet" />
            <Content Name="Controls">
              <Items>
                <OpenSpan.Adapters.Controls.TextBox Name="CRMtxtUserName" Id="TextBox-8D6077B234ADA1E">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ExtensibleTypeName Value="System.Windows.Forms.TextBox, System.Windows.Forms" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <MatchingIndex Value="6" />
                  <TargetTypeString Value="OpenSpan.Adapters.Virtual.VirtualTargets.VirtualTextBox, OpenSpan.Adapters.Virtual" />
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Name="virtualControlNativeControlNameMat1" Id="VirtualControlNativeControlNameMatchRule-8D6077B2361F453">
                        <NativeControlName Value="Simple|True|(User Culture)|txtCredentials" />
                      </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Controls.TextBox>
                <OpenSpan.Adapters.Controls.TextBox Name="CRMtxtPassword" Id="TextBox-8D6077B255112F4">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ExtensibleTypeName Value="System.Windows.Forms.TextBox, System.Windows.Forms" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <MatchingIndex Value="4" />
                  <TargetTypeString Value="OpenSpan.Adapters.Virtual.VirtualTargets.VirtualTextBox, OpenSpan.Adapters.Virtual" />
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Name="virtualControlNativeControlNameMat2" Id="VirtualControlNativeControlNameMatchRule-8D6077B25555B98">
                        <NativeControlName Value="Simple|True|(User Culture)|txtPassword" />
                      </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Controls.TextBox>
                <OpenSpan.Adapters.Controls.Button Name="CRMbtnLogin" Id="Button-8D6077B2713F0A8">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ExtensibleTypeName Value="System.Windows.Forms.Button, System.Windows.Forms" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <MatchingIndex Value="2" />
                  <TargetTypeString Value="OpenSpan.Adapters.Virtual.VirtualTargets.VirtualButton, OpenSpan.Adapters.Virtual" />
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Name="virtualControlNativeControlNameMat3" Id="VirtualControlNativeControlNameMatchRule-8D6077B27189C42">
                        <NativeControlName Value="Simple|True|(User Culture)|btnLogin" />
                      </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Controls.Button>
                <OpenSpan.Adapters.Controls.Label Name="CRMlblVersion" Id="Label-8D6077B618AB172">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <MatchingIndex Value="8" />
                  <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.Label, OpenSpan.Adapters.Windows" />
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Windows.MatchRules.DotNetControlTypeMatchRule Name="dotNetControlTypeMatchRule1" Id="DotNetControlTypeMatchRule-8D6077B618F339F">
                        <ControlType Value="TestGDI.GDILabel" />
                      </OpenSpan.Adapters.Windows.MatchRules.DotNetControlTypeMatchRule>
                      <OpenSpan.Adapters.Windows.MatchRules.DotNetControlNameMatchRule Name="dotNetControlNameMatchRule1" Id="DotNetControlNameMatchRule-8D6077B61950403">
                        <Text Value="Simple|True|(User Culture)|gdilblVersion" />
                      </OpenSpan.Adapters.Windows.MatchRules.DotNetControlNameMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Controls.Label>
              </Items>
            </Content>
            <Content Name="MatchRules">
              <Items>
                <OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule Name="windowTextMatchRule1" Id="WindowTextMatchRule-8D6077B23567AD2">
                  <Text Value="Simple|True|(User Culture)|Login" />
                </OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule>
                <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlContainerNativeWindowNameMatchRule Name="virtualControlContainerNativeWindo1" Id="VirtualControlContainerNativeWindowNameMatchRule-8D6077B235BD5B2">
                  <VirtualWindowName Value="Simple|True|(User Culture)|WindowsForms10.Window.8.app.0.378734a" />
                </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlContainerNativeWindowNameMatchRule>
              </Items>
            </Content>
          </OpenSpan.Adapters.Controls.Form>
          <OpenSpan.Adapters.Controls.Form Name="CRMfrmOpenSpan" Id="Form-8D6077BA5295BFC">
            <DummyPropertyToDetectReplaceUndo Value="0" />
            <ForwardObjectExplorerEvent Value="True" />
            <MatchingIndex Value="2" />
            <TargetTypeString Value="OpenSpan.Adapters.DotNet.WindowsForms.DotNetFormTarget, OpenSpan.Adapters.DotNet" />
            <Content Name="Controls">
              <Items>
                <OpenSpan.Adapters.Controls.ToolBar Name="CRMToolBar" Id="ToolBar-8D6077BA525890D">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ExtensibleTypeName Value="System.Windows.Forms.ToolBar, System.Windows.Forms" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <MatchingIndex Value="0" />
                  <TargetTypeString Value="OpenSpan.Adapters.Virtual.VirtualTargets.VirtualToolBar, OpenSpan.Adapters.Virtual" />
                  <Content Name="Controls">
                    <Items>
                      <OpenSpan.Adapters.Controls.Button Name="CRMbtnNewCall" Id="Button-8D6077BA51F4328">
                        <DummyPropertyToDetectReplaceUndo Value="0" />
                        <ForwardObjectExplorerEvent Value="True" />
                        <MatchingIndex Value="0" />
                        <TargetTypeString Value="OpenSpan.Adapters.Virtual.VirtualTargets.VirtualButton, OpenSpan.Adapters.Virtual" />
                        <Content Name="MatchRules">
                          <Items>
                            <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Name="virtualControlNativeControlNameMat5" Id="VirtualControlNativeControlNameMatchRule-8D6077BA53BDEC0">
                              <NativeControlName Value="Simple|True|(User Culture)|btnNewCall" />
                            </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule>
                          </Items>
                        </Content>
                      </OpenSpan.Adapters.Controls.Button>
                      <OpenSpan.Adapters.Controls.Button Name="CRMbtnUser1" Id="Button-8D6077BA6F819F2">
                        <DummyPropertyToDetectReplaceUndo Value="0" />
                        <ForwardObjectExplorerEvent Value="True" />
                        <MatchingIndex Value="1" />
                        <TargetTypeString Value="OpenSpan.Adapters.Virtual.VirtualTargets.VirtualButton, OpenSpan.Adapters.Virtual" />
                        <Content Name="MatchRules">
                          <Items>
                            <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Name="virtualControlNativeControlNameMat6" Id="VirtualControlNativeControlNameMatchRule-8D6077BA6FBC5EC">
                              <NativeControlName Value="Simple|True|(User Culture)|bntUser1" />
                            </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule>
                          </Items>
                        </Content>
                      </OpenSpan.Adapters.Controls.Button>
                      <OpenSpan.Adapters.Controls.Button Name="CRMbtnUser2" Id="Button-8D6077BA8ABE6C3">
                        <DummyPropertyToDetectReplaceUndo Value="0" />
                        <ForwardObjectExplorerEvent Value="True" />
                        <MatchingIndex Value="2" />
                        <TargetTypeString Value="OpenSpan.Adapters.Virtual.VirtualTargets.VirtualButton, OpenSpan.Adapters.Virtual" />
                        <Content Name="MatchRules">
                          <Items>
                            <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Name="virtualControlNativeControlNameMat7" Id="VirtualControlNativeControlNameMatchRule-8D6077BA8AFB69F">
                              <NativeControlName Value="Simple|True|(User Culture)|bntUser2" />
                            </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule>
                          </Items>
                        </Content>
                      </OpenSpan.Adapters.Controls.Button>
                      <OpenSpan.Adapters.Controls.Button Name="CRMbtnUser3" Id="Button-8D6077BAA8599F5">
                        <DummyPropertyToDetectReplaceUndo Value="0" />
                        <ForwardObjectExplorerEvent Value="True" />
                        <MatchingIndex Value="3" />
                        <TargetTypeString Value="OpenSpan.Adapters.Virtual.VirtualTargets.VirtualButton, OpenSpan.Adapters.Virtual" />
                        <Content Name="MatchRules">
                          <Items>
                            <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Name="virtualControlNativeControlNameMat8" Id="VirtualControlNativeControlNameMatchRule-8D6077BAA896C27">
                              <NativeControlName Value="Simple|True|(User Culture)|btnUser3" />
                            </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule>
                          </Items>
                        </Content>
                      </OpenSpan.Adapters.Controls.Button>
                    </Items>
                  </Content>
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Name="virtualControlNativeControlNameMat4" Id="VirtualControlNativeControlNameMatchRule-8D6077BA53720B8">
                        <NativeControlName Value="Simple|True|(User Culture)|toolBar1" />
                      </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Controls.ToolBar>
                <OpenSpan.Adapters.Controls.MdiClient Name="CRMClient" Id="MdiClient-8D6077BF75BDCA9">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ExtensibleTypeName Value="System.Windows.Forms.MdiClient, System.Windows.Forms" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <MatchingIndex Value="1" />
                  <TargetTypeString Value="OpenSpan.Adapters.Virtual.VirtualTargets.VirtualMdiClient, OpenSpan.Adapters.Virtual" />
                  <Content Name="Controls">
                    <Items>
                      <OpenSpan.Adapters.Controls.MdiChild Name="CRMchild" Id="MdiChild-8D6077BF754366D">
                        <DummyPropertyToDetectReplaceUndo Value="0" />
                        <ExtensibleTypeName Value="CRM.CRMchild, CRM" />
                        <ForwardObjectExplorerEvent Value="True" />
                        <MatchingIndex Value="0" />
                        <TargetTypeString Value="OpenSpan.Adapters.Virtual.VirtualTargets.VirtualMdiChild, OpenSpan.Adapters.Virtual" />
                        <Content Name="Controls">
                          <Items>
                            <OpenSpan.Adapters.Controls.Control Name="CRMpnlCustomerInfo" Id="Control-8D6077BF74A6C00">
                              <DummyPropertyToDetectReplaceUndo Value="0" />
                              <ExtensibleTypeName Value="System.Windows.Forms.Panel, System.Windows.Forms" />
                              <ForwardObjectExplorerEvent Value="True" />
                              <MatchingIndex Value="0" />
                              <TargetTypeString Value="OpenSpan.Adapters.Virtual.VirtualTargets.VirtualControl, OpenSpan.Adapters.Virtual" />
                              <Content Name="Controls">
                                <Items>
                                  <OpenSpan.Adapters.Controls.Label Name="CRMlblAcctNum" Id="Label-8D6077BF74228AE">
                                    <DummyPropertyToDetectReplaceUndo Value="0" />
                                    <ExtensibleTypeName Value="System.Windows.Forms.Label, System.Windows.Forms" />
                                    <ForwardObjectExplorerEvent Value="True" />
                                    <MatchingIndex Value="1" />
                                    <TargetTypeString Value="OpenSpan.Adapters.Virtual.VirtualTargets.VirtualLabel, OpenSpan.Adapters.Virtual" />
                                    <Content Name="MatchRules">
                                      <Items>
                                        <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Name="virtualControlNativeControlNameMa12" Id="VirtualControlNativeControlNameMatchRule-8D6077BF77B8838">
                                          <NativeControlName Value="Simple|True|(User Culture)|lblAcctNum" />
                                        </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule>
                                      </Items>
                                    </Content>
                                  </OpenSpan.Adapters.Controls.Label>
                                  <OpenSpan.Adapters.Controls.TextBox Name="CRMtxtName" Id="TextBox-8D6077BF8EA50C9">
                                    <DummyPropertyToDetectReplaceUndo Value="0" />
                                    <ExtensibleTypeName Value="System.Windows.Forms.TextBox, System.Windows.Forms" />
                                    <ForwardObjectExplorerEvent Value="True" />
                                    <MatchingIndex Value="7" />
                                    <TargetTypeString Value="OpenSpan.Adapters.Virtual.VirtualTargets.VirtualTextBox, OpenSpan.Adapters.Virtual" />
                                    <Content Name="MatchRules">
                                      <Items>
                                        <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Name="virtualControlNativeControlNameMa13" Id="VirtualControlNativeControlNameMatchRule-8D6077BF8EDAE82">
                                          <NativeControlName Value="Simple|True|(User Culture)|txtName" />
                                        </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule>
                                      </Items>
                                    </Content>
                                  </OpenSpan.Adapters.Controls.TextBox>
                                  <OpenSpan.Adapters.Controls.TextBox Name="CRMtxtStreetAdd" Id="TextBox-8D6077BFCD27518">
                                    <DummyPropertyToDetectReplaceUndo Value="0" />
                                    <ExtensibleTypeName Value="System.Windows.Forms.TextBox, System.Windows.Forms" />
                                    <ForwardObjectExplorerEvent Value="True" />
                                    <MatchingIndex Value="6" />
                                    <TargetTypeString Value="OpenSpan.Adapters.Virtual.VirtualTargets.VirtualTextBox, OpenSpan.Adapters.Virtual" />
                                    <Content Name="MatchRules">
                                      <Items>
                                        <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Name="virtualControlNativeControlNameMa14" Id="VirtualControlNativeControlNameMatchRule-8D6077BFCD62132">
                                          <NativeControlName Value="Simple|True|(User Culture)|txtStreetAdd" />
                                        </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule>
                                      </Items>
                                    </Content>
                                  </OpenSpan.Adapters.Controls.TextBox>
                                  <OpenSpan.Adapters.Controls.TextBox Name="CRMtxtCity" Id="TextBox-8D6077BFEAD86C4">
                                    <DummyPropertyToDetectReplaceUndo Value="0" />
                                    <ExtensibleTypeName Value="System.Windows.Forms.TextBox, System.Windows.Forms" />
                                    <ForwardObjectExplorerEvent Value="True" />
                                    <MatchingIndex Value="5" />
                                    <TargetTypeString Value="OpenSpan.Adapters.Virtual.VirtualTargets.VirtualTextBox, OpenSpan.Adapters.Virtual" />
                                    <Content Name="MatchRules">
                                      <Items>
                                        <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Name="virtualControlNativeControlNameMa15" Id="VirtualControlNativeControlNameMatchRule-8D6077BFEB159FD">
                                          <NativeControlName Value="Simple|True|(User Culture)|txtCity" />
                                        </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule>
                                      </Items>
                                    </Content>
                                  </OpenSpan.Adapters.Controls.TextBox>
                                  <OpenSpan.Adapters.Controls.TextBox Name="CRMtxtState" Id="TextBox-8D6077C00ACB337">
                                    <DummyPropertyToDetectReplaceUndo Value="0" />
                                    <ExtensibleTypeName Value="System.Windows.Forms.TextBox, System.Windows.Forms" />
                                    <ForwardObjectExplorerEvent Value="True" />
                                    <MatchingIndex Value="4" />
                                    <TargetTypeString Value="OpenSpan.Adapters.Virtual.VirtualTargets.VirtualTextBox, OpenSpan.Adapters.Virtual" />
                                    <Content Name="MatchRules">
                                      <Items>
                                        <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Name="virtualControlNativeControlNameMa16" Id="VirtualControlNativeControlNameMatchRule-8D6077C00B0B1B9">
                                          <NativeControlName Value="Simple|True|(User Culture)|txtState" />
                                        </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule>
                                      </Items>
                                    </Content>
                                  </OpenSpan.Adapters.Controls.TextBox>
                                  <OpenSpan.Adapters.Controls.TextBox Name="CRMtxtZip" Id="TextBox-8D6077C02443B23">
                                    <DummyPropertyToDetectReplaceUndo Value="0" />
                                    <ExtensibleTypeName Value="System.Windows.Forms.TextBox, System.Windows.Forms" />
                                    <ForwardObjectExplorerEvent Value="True" />
                                    <MatchingIndex Value="3" />
                                    <TargetTypeString Value="OpenSpan.Adapters.Virtual.VirtualTargets.VirtualTextBox, OpenSpan.Adapters.Virtual" />
                                    <Content Name="MatchRules">
                                      <Items>
                                        <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Name="virtualControlNativeControlNameMa17" Id="VirtualControlNativeControlNameMatchRule-8D6077C02480E5C">
                                          <NativeControlName Value="Simple|True|(User Culture)|txtZip" />
                                        </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule>
                                      </Items>
                                    </Content>
                                  </OpenSpan.Adapters.Controls.TextBox>
                                </Items>
                              </Content>
                              <Content Name="MatchRules">
                                <Items>
                                  <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Name="virtualControlNativeControlNameMa11" Id="VirtualControlNativeControlNameMatchRule-8D6077BF7771871">
                                    <NativeControlName Value="Simple|True|(User Culture)|pnlCustomerInfo" />
                                  </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule>
                                </Items>
                              </Content>
                            </OpenSpan.Adapters.Controls.Control>
                            <OpenSpan.Adapters.Controls.TabStrip Name="CRMtabMain" Id="TabStrip-8D6077C550BC7AD">
                              <DummyPropertyToDetectReplaceUndo Value="0" />
                              <ExtensibleTypeName Value="System.Windows.Forms.TabControl, System.Windows.Forms" />
                              <ForwardObjectExplorerEvent Value="True" />
                              <MatchingIndex Value="1" />
                              <TargetTypeString Value="OpenSpan.Adapters.Virtual.VirtualTargets.VirtualTabStrip, OpenSpan.Adapters.Virtual" />
                              <Content Name="Controls">
                                <Items>
                                  <OpenSpan.Adapters.Controls.Control Name="CRMtabComments" Id="Control-8D6077C5504214C">
                                    <DummyPropertyToDetectReplaceUndo Value="0" />
                                    <ExtensibleTypeName Value="System.Windows.Forms.TabPage, System.Windows.Forms" />
                                    <ForwardObjectExplorerEvent Value="True" />
                                    <MatchingIndex Value="1" />
                                    <TargetTypeString Value="OpenSpan.Adapters.Virtual.VirtualTargets.VirtualControl, OpenSpan.Adapters.Virtual" />
                                    <Content Name="Controls">
                                      <Items>
                                        <OpenSpan.Adapters.Controls.TextBox Name="CRMtxtComments" Id="TextBox-8D6077C54FD44B3">
                                          <DummyPropertyToDetectReplaceUndo Value="0" />
                                          <ExtensibleTypeName Value="System.Windows.Forms.TextBox, System.Windows.Forms" />
                                          <ForwardObjectExplorerEvent Value="True" />
                                          <MatchingIndex Value="0" />
                                          <TargetTypeString Value="OpenSpan.Adapters.Virtual.VirtualTargets.VirtualTextBox, OpenSpan.Adapters.Virtual" />
                                          <Content Name="MatchRules">
                                            <Items>
                                              <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Name="virtualControlNativeControlNameMa20" Id="VirtualControlNativeControlNameMatchRule-8D6077C551A77AC">
                                                <NativeControlName Value="Simple|True|(User Culture)|txtComments" />
                                              </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule>
                                            </Items>
                                          </Content>
                                        </OpenSpan.Adapters.Controls.TextBox>
                                      </Items>
                                    </Content>
                                    <Content Name="MatchRules">
                                      <Items>
                                        <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Name="virtualControlNativeControlNameMa19" Id="VirtualControlNativeControlNameMatchRule-8D6077C55151CCC">
                                          <NativeControlName Value="Simple|True|(User Culture)|tabComments" />
                                        </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule>
                                      </Items>
                                    </Content>
                                  </OpenSpan.Adapters.Controls.Control>
                                </Items>
                              </Content>
                              <Content Name="MatchRules">
                                <Items>
                                  <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Name="virtualControlNativeControlNameMa18" Id="VirtualControlNativeControlNameMatchRule-8D6077C55108624">
                                    <NativeControlName Value="Simple|True|(User Culture)|tabMain" />
                                  </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule>
                                </Items>
                              </Content>
                            </OpenSpan.Adapters.Controls.TabStrip>
                          </Items>
                        </Content>
                        <Content Name="MatchRules">
                          <Items>
                            <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Name="virtualControlNativeControlNameMa10" Id="VirtualControlNativeControlNameMatchRule-8D6077BF772A908">
                              <NativeControlName Value="Simple|True|(User Culture)|CRMchild" />
                            </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule>
                          </Items>
                        </Content>
                      </OpenSpan.Adapters.Controls.MdiChild>
                    </Items>
                  </Content>
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlVirtualClassNameMatchRule Name="virtualControlVirtualClassNameMatc1" Id="VirtualControlVirtualClassNameMatchRule-8D6077BF7692C30">
                        <VirtualClassName Value="Simple|True|(User Culture)|MdiClient" />
                      </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlVirtualClassNameMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Controls.MdiClient>
                <OpenSpan.Adapters.Controls.MenuItem Name="Orders_Console" Id="MenuItem-8D6077C81F3C258">
                  <DummyPropertyToDetectReplaceUndo Value="0" />
                  <ForwardObjectExplorerEvent Value="True" />
                  <FullPath Value="" />
                  <MatchingIndex Value="8" />
                  <TargetTypeString Value="OpenSpan.Adapters.Windows.Targets.MenuItem, OpenSpan.Adapters.Windows" />
                  <Content Name="MatchRules">
                    <Items>
                      <OpenSpan.Adapters.Windows.MatchRules.MenuItemPathMatchRule Name="menuItemPathMatchRule1" Id="MenuItemPathMatchRule-8D6077C81FA07EB">
                        <Path Value="Tools/Orders Console" />
                      </OpenSpan.Adapters.Windows.MatchRules.MenuItemPathMatchRule>
                    </Items>
                  </Content>
                </OpenSpan.Adapters.Controls.MenuItem>
              </Items>
            </Content>
            <Content Name="MatchRules">
              <Items>
                <OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule Name="windowTextMatchRule2" Id="WindowTextMatchRule-8D6077BA52D2EA5">
                  <Text Value="Simple|True|(User Culture)|CRM - OpenSpan" />
                </OpenSpan.Adapters.Windows.MatchRules.WindowTextMatchRule>
                <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlContainerNativeWindowNameMatchRule Name="virtualControlContainerNativeWindo2" Id="VirtualControlContainerNativeWindowNameMatchRule-8D6077BA531C5BB">
                  <VirtualWindowName Value="Simple|True|(User Culture)|WindowsForms10.Window.8.app.0.378734a" />
                </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlContainerNativeWindowNameMatchRule>
              </Items>
            </Content>
          </OpenSpan.Adapters.Controls.Form>
        </Items>
      </Content>
    </OpenSpan.Adapters.Windows.WindowsAdapter>
    <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule Name="virtualControlNativeControlNameMat9" Id="VirtualControlNativeControlNameMatchRule-8D6077BF761105B">
      <NativeControlName Value="Simple|True|(User Culture)|" />
    </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlNativeControlNameMatchRule>
    <OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlIdMatchRule Name="virtualControlIdMatchRule1" Id="VirtualControlIdMatchRule-8D6077BF764E383">
      <ControlId Value="Simple|True|(User Culture)|" />
    </OpenSpan.Adapters.Virtual.VirtualMatchRules.VirtualControlIdMatchRule>
  </Component>
</OpenSpanDesignDocument>