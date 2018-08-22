using System;

namespace Project1
{
/// <summary>
/// OpenSpan design component.
/// </summary>
// WebAdapter-8D6036EE92E82A8
[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8")]
[System.ComponentModel.ToolboxItemAttribute(false)]
public sealed class ACMESearchSystem : OpenSpan.Adapters.Web.WebAdapter
{
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8\\ActiveXFactory-8D60375BC16A2A3")]
	public OpenSpan.Adapters.ActiveX.ActiveXFactory ActiveXFactory;
	
	private OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule1;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8\\WinInetFactory-8D60375BC39237D")]
	public OpenSpan.Adapters.WinInet.WinInetFactory WinInetFactory;
	
	private OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule2;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8\\MicrosoftHTMLFactory-8D60375BCF65D34")]
	public OpenSpan.Adapters.Web.MicrosoftHTMLFactory MicrosoftHTMLFactory;
	
	private OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule3;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8\\WebPage-8D60375DAC432D3")]
	public OpenSpan.Adapters.Web.Controls.WebPage ACMEwpSignIn;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8\\Form-8D60375DABD2934")]
	public OpenSpan.Adapters.Web.Controls.Form ACMEfrmCredentials;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8\\Button-8D60375F99A1A32")]
	public OpenSpan.Adapters.Web.Controls.Button ACMEbtnSignin;
	
	private OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule2;
	
	private OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule3;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8\\TextBox-8D6037673EE53C6")]
	public OpenSpan.Adapters.Web.Controls.TextBox ACMEtxtUserName;
	
	private OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule1;
	
	private OpenSpan.Adapters.Web.MatchRules.AttributeMatchRule attributeMatchRule1;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8\\TextBox-8D60376773446F4")]
	public OpenSpan.Adapters.Web.Controls.TextBox ACMEtxtPassword;
	
	private OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule3;
	
	private OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule2;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8\\HiddenField-8D60687B4A0E5E5")]
	public OpenSpan.Adapters.Web.Controls.HiddenField ACMElblVersion;
	
	private OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule6;
	
	private OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule inputNameMatchRule1;
	
	private OpenSpan.Adapters.Web.MatchRules.FormActionMatchRule formActionMatchRule1;
	
	private OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule documentUrlMatchRule1;
	
	private OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule documentTitleMatchRule1;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8\\WebPage-8D60376ACF65820")]
	public OpenSpan.Adapters.Web.Controls.WebPage ACMEwpHome;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8\\WebControl-8D606A37B633563")]
	public OpenSpan.Adapters.Web.Controls.WebControl ACMENewsAlert;
	
	private OpenSpan.Adapters.Web.MatchRules.ElementIndexMatchRule elementIndexMatchRule1;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8\\Link-8D60759691DE487")]
	public OpenSpan.Adapters.Web.Controls.Link ACMElnkStores;
	
	private OpenSpan.Adapters.Web.MatchRules.InnerTextMatchRule innerTextMatchRule1;
	
	private OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule documentUrlMatchRule2;
	
	private OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule documentTitleMatchRule2;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8\\WebPage-8D60376C9808448")]
	public OpenSpan.Adapters.Web.Controls.WebPage ACMEwpStores;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8\\Form-8D60376C97A3E68")]
	public OpenSpan.Adapters.Web.Controls.Form ACMEfrmSearch;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8\\TextBox-8D60376C973831A")]
	public OpenSpan.Adapters.Web.Controls.TextBox ACMEtxtZip;
	
	private OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule4;
	
	private OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule6;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8\\Button-8D60376CB53752D")]
	public OpenSpan.Adapters.Web.Controls.Button ACMEbtnFindStore;
	
	private OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule5;
	
	private OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule7;
	
	private OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule5;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8\\WebControl-8D607584308FAAA")]
	public OpenSpan.Adapters.Web.Controls.WebControl Stores_Store_Listing;
	
	private OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule1;
	
	private OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule documentUrlMatchRule3;
	
	private OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule documentTitleMatchRule3;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8\\WebPage-8D60377D61EC8D0")]
	public OpenSpan.Adapters.Web.Controls.WebPage ACMEwpResults;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8\\Form-8D60377D61882F1")]
	public OpenSpan.Adapters.Web.Controls.Form ACMEfrmResults;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WebAdapter-8D6036EE92E82A8\\Table-8D60377D611EEA8")]
	public OpenSpan.Adapters.Web.Controls.Table ACMEtblNearestStore;
	
	private OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule9;
	
	private OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule8;
	
	private OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule documentUrlMatchRule4;
	
	private OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule documentTitleMatchRule4;
	
	public ACMESearchSystem()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Setup field members
		// 
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(ACMESearchSystem));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata5 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata6 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata7 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata8 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata9 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata10 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata11 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata12 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata13 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata14 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata15 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata16 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata17 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata18 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata19 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata20 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata21 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata22 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata23 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata24 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata25 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata26 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata27 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata28 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata29 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata30 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata31 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata32 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata33 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata34 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata35 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata36 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata37 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata38 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata39 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata40 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata41 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata42 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata43 = new OpenSpan.Adapters.TextMatchData();
		this.ActiveXFactory = new OpenSpan.Adapters.ActiveX.ActiveXFactory();
		this.moduleNameMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.WinInetFactory = new OpenSpan.Adapters.WinInet.WinInetFactory();
		this.moduleNameMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.MicrosoftHTMLFactory = new OpenSpan.Adapters.Web.MicrosoftHTMLFactory();
		this.moduleNameMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.ACMEwpSignIn = new OpenSpan.Adapters.Web.Controls.WebPage();
		this.ACMEfrmCredentials = new OpenSpan.Adapters.Web.Controls.Form();
		this.ACMEbtnSignin = new OpenSpan.Adapters.Web.Controls.Button();
		this.inputTypeMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.elementIdMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.ACMEtxtUserName = new OpenSpan.Adapters.Web.Controls.TextBox();
		this.inputTypeMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.attributeMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.AttributeMatchRule();
		this.ACMEtxtPassword = new OpenSpan.Adapters.Web.Controls.TextBox();
		this.inputTypeMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.elementIdMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.ACMElblVersion = new OpenSpan.Adapters.Web.Controls.HiddenField();
		this.inputTypeMatchRule6 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.inputNameMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule();
		this.formActionMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.FormActionMatchRule();
		this.documentUrlMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule();
		this.documentTitleMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule();
		this.ACMEwpHome = new OpenSpan.Adapters.Web.Controls.WebPage();
		this.ACMENewsAlert = new OpenSpan.Adapters.Web.Controls.WebControl();
		this.elementIndexMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.ElementIndexMatchRule();
		this.ACMElnkStores = new OpenSpan.Adapters.Web.Controls.Link();
		this.innerTextMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InnerTextMatchRule();
		this.documentUrlMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule();
		this.documentTitleMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule();
		this.ACMEwpStores = new OpenSpan.Adapters.Web.Controls.WebPage();
		this.ACMEfrmSearch = new OpenSpan.Adapters.Web.Controls.Form();
		this.ACMEtxtZip = new OpenSpan.Adapters.Web.Controls.TextBox();
		this.inputTypeMatchRule4 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.elementIdMatchRule6 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.ACMEbtnFindStore = new OpenSpan.Adapters.Web.Controls.Button();
		this.inputTypeMatchRule5 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.elementIdMatchRule7 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.elementIdMatchRule5 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.Stores_Store_Listing = new OpenSpan.Adapters.Web.Controls.WebControl();
		this.elementIdMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.documentUrlMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule();
		this.documentTitleMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule();
		this.ACMEwpResults = new OpenSpan.Adapters.Web.Controls.WebPage();
		this.ACMEfrmResults = new OpenSpan.Adapters.Web.Controls.Form();
		this.ACMEtblNearestStore = new OpenSpan.Adapters.Web.Controls.Table();
		this.elementIdMatchRule9 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.elementIdMatchRule8 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.documentUrlMatchRule4 = new OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule();
		this.documentTitleMatchRule4 = new OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule();
		// 
		// Initialize design component
		// 
		this.Initialize();
		// 
		// Set design component Id
		// 
		this.Id = new OpenSpan.Design.ComponentIdentity("WebAdapter-8D6036EE92E82A8");
		// 
		// Set component Ids
		// 
		this.SetId(this.ActiveXFactory, new OpenSpan.Design.ComponentIdentity("ActiveXFactory-8D60375BC16A2A3"));
		this.SetId(this.moduleNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D60375BC23CAFB"));
		this.SetId(this.WinInetFactory, new OpenSpan.Design.ComponentIdentity("WinInetFactory-8D60375BC39237D"));
		this.SetId(this.moduleNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D60375BC407B70"));
		this.SetId(this.MicrosoftHTMLFactory, new OpenSpan.Design.ComponentIdentity("MicrosoftHTMLFactory-8D60375BCF65D34"));
		this.SetId(this.moduleNameMatchRule3, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D60375BD007635"));
		this.SetId(this.ACMEwpSignIn, new OpenSpan.Design.ComponentIdentity("WebPage-8D60375DAC432D3"));
		this.SetId(this.ACMEfrmCredentials, new OpenSpan.Design.ComponentIdentity("Form-8D60375DABD2934"));
		this.SetId(this.ACMEbtnSignin, new OpenSpan.Design.ComponentIdentity("Button-8D60375F99A1A32"));
		this.SetId(this.inputTypeMatchRule2, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60375F9A2D758"));
		this.SetId(this.elementIdMatchRule3, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60375F9A8C390"));
		this.SetId(this.ACMEtxtUserName, new OpenSpan.Design.ComponentIdentity("TextBox-8D6037673EE53C6"));
		this.SetId(this.inputTypeMatchRule1, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D6037673F79509"));
		this.SetId(this.attributeMatchRule1, new OpenSpan.Design.ComponentIdentity("AttributeMatchRule-8D606A0B1280F1A"));
		this.SetId(this.ACMEtxtPassword, new OpenSpan.Design.ComponentIdentity("TextBox-8D60376773446F4"));
		this.SetId(this.inputTypeMatchRule3, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60376773E0072"));
		this.SetId(this.elementIdMatchRule2, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D603767743D0BD"));
		this.SetId(this.ACMElblVersion, new OpenSpan.Design.ComponentIdentity("HiddenField-8D60687B4A0E5E5"));
		this.SetId(this.inputTypeMatchRule6, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60687B4AA0D4B"));
		this.SetId(this.inputNameMatchRule1, new OpenSpan.Design.ComponentIdentity("InputNameMatchRule-8D60687B4AF7BB0"));
		this.SetId(this.formActionMatchRule1, new OpenSpan.Design.ComponentIdentity("FormActionMatchRule-8D60375DADE86B7"));
		this.SetId(this.documentUrlMatchRule1, new OpenSpan.Design.ComponentIdentity("DocumentUrlMatchRule-8D60375DACFFDE5"));
		this.SetId(this.documentTitleMatchRule1, new OpenSpan.Design.ComponentIdentity("DocumentTitleMatchRule-8D60375DAD57FE1"));
		this.SetId(this.ACMEwpHome, new OpenSpan.Design.ComponentIdentity("WebPage-8D60376ACF65820"));
		this.SetId(this.ACMENewsAlert, new OpenSpan.Design.ComponentIdentity("WebControl-8D606A37B633563"));
		this.SetId(this.elementIndexMatchRule1, new OpenSpan.Design.ComponentIdentity("ElementIndexMatchRule-8D606A3D27BEEE2"));
		this.SetId(this.ACMElnkStores, new OpenSpan.Design.ComponentIdentity("Link-8D60759691DE487"));
		this.SetId(this.innerTextMatchRule1, new OpenSpan.Design.ComponentIdentity("InnerTextMatchRule-8D60759692BD0BA"));
		this.SetId(this.documentUrlMatchRule2, new OpenSpan.Design.ComponentIdentity("DocumentUrlMatchRule-8D60376ACFCBE85"));
		this.SetId(this.documentTitleMatchRule2, new OpenSpan.Design.ComponentIdentity("DocumentTitleMatchRule-8D60376AD01CA8C"));
		this.SetId(this.ACMEwpStores, new OpenSpan.Design.ComponentIdentity("WebPage-8D60376C9808448"));
		this.SetId(this.ACMEfrmSearch, new OpenSpan.Design.ComponentIdentity("Form-8D60376C97A3E68"));
		this.SetId(this.ACMEtxtZip, new OpenSpan.Design.ComponentIdentity("TextBox-8D60376C973831A"));
		this.SetId(this.inputTypeMatchRule4, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60376C99DAE3B"));
		this.SetId(this.elementIdMatchRule6, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60376C9A5063B"));
		this.SetId(this.ACMEbtnFindStore, new OpenSpan.Design.ComponentIdentity("Button-8D60376CB53752D"));
		this.SetId(this.inputTypeMatchRule5, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60376CB5B9886"));
		this.SetId(this.elementIdMatchRule7, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60376CB61DE5D"));
		this.SetId(this.elementIdMatchRule5, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60376C9952B9E"));
		this.SetId(this.Stores_Store_Listing, new OpenSpan.Design.ComponentIdentity("WebControl-8D607584308FAAA"));
		this.SetId(this.elementIdMatchRule1, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D607584316A959"));
		this.SetId(this.documentUrlMatchRule3, new OpenSpan.Design.ComponentIdentity("DocumentUrlMatchRule-8D60376C9871857"));
		this.SetId(this.documentTitleMatchRule3, new OpenSpan.Design.ComponentIdentity("DocumentTitleMatchRule-8D60376C98C7330"));
		this.SetId(this.ACMEwpResults, new OpenSpan.Design.ComponentIdentity("WebPage-8D60377D61EC8D0"));
		this.SetId(this.ACMEfrmResults, new OpenSpan.Design.ComponentIdentity("Form-8D60377D61882F1"));
		this.SetId(this.ACMEtblNearestStore, new OpenSpan.Design.ComponentIdentity("Table-8D60377D611EEA8"));
		this.SetId(this.elementIdMatchRule9, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60377D63C28B1"));
		this.SetId(this.elementIdMatchRule8, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60377D6337017"));
		this.SetId(this.documentUrlMatchRule4, new OpenSpan.Design.ComponentIdentity("DocumentUrlMatchRule-8D60377D626209C"));
		this.SetId(this.documentTitleMatchRule4, new OpenSpan.Design.ComponentIdentity("DocumentTitleMatchRule-8D60377D62B5445"));
		// 
		// ACMESearchSystem
		// 
		this.AddressBarVisible = OpenSpan.Adapters.Web.WebAdapter.WebBrowserShowToolbar.Default;
		this.AdvancedConfiguration = null;
		ComponentInfo.CodeDomData = _resources_.GetString("_ACMESearchSystem_1_");
		// 
		// ActiveXFactory
		// 
		this.ActiveXFactory.Extender = null;
		this.ActiveXFactory.FactoryName = null;
		this.ActiveXFactory.ForwardObjectExplorerEvent = true;
		this.ActiveXFactory.MatchingIndex = 0;
		// 
		// moduleNameMatchRule1
		// 
		textmatchdata1.Text = "ole32.dll";
		this.moduleNameMatchRule1.Text = textmatchdata1;
		this.ActiveXFactory.MatchRules.Add(this.moduleNameMatchRule1);
		this.ActiveXFactory.Name = "ActiveXFactory";
		this.ActiveXFactory.TargetTypeString = "OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows";
		this.ActiveXFactory.UseKeys = true;
		// 
		// WinInetFactory
		// 
		this.WinInetFactory.Extender = null;
		this.WinInetFactory.FactoryName = null;
		this.WinInetFactory.ForwardObjectExplorerEvent = true;
		this.WinInetFactory.MatchingIndex = 0;
		// 
		// moduleNameMatchRule2
		// 
		textmatchdata2.Text = "wininet.dll";
		this.moduleNameMatchRule2.Text = textmatchdata2;
		this.WinInetFactory.MatchRules.Add(this.moduleNameMatchRule2);
		this.WinInetFactory.Name = "WinInetFactory";
		this.WinInetFactory.TargetTypeString = "OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows";
		this.WinInetFactory.UseKeys = true;
		// 
		// MicrosoftHTMLFactory
		// 
		this.MicrosoftHTMLFactory.Extender = null;
		this.MicrosoftHTMLFactory.FactoryName = null;
		this.MicrosoftHTMLFactory.ForwardObjectExplorerEvent = true;
		this.MicrosoftHTMLFactory.MatchingIndex = 0;
		// 
		// moduleNameMatchRule3
		// 
		textmatchdata3.Text = "mshtml.dll";
		this.moduleNameMatchRule3.Text = textmatchdata3;
		this.MicrosoftHTMLFactory.MatchRules.Add(this.moduleNameMatchRule3);
		this.MicrosoftHTMLFactory.Name = "MicrosoftHTMLFactory";
		this.MicrosoftHTMLFactory.TargetTypeString = "OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows";
		this.MicrosoftHTMLFactory.UseKeys = true;
		// 
		// ACMEwpSignIn
		// 
		// 
		// ACMEfrmCredentials
		// 
		// 
		// ACMEbtnSignin
		// 
		this.ACMEbtnSignin.ElementId = "login_button";
		this.ACMEbtnSignin.Extender = null;
		this.ACMEbtnSignin.ForwardObjectExplorerEvent = true;
		this.ACMEbtnSignin.MatchingIndex = 2;
		// 
		// inputTypeMatchRule2
		// 
		this.inputTypeMatchRule2.Type = OpenSpan.Adapters.Web.InputType.Submit;
		// 
		// elementIdMatchRule3
		// 
		textmatchdata4.Text = "login_button";
		this.elementIdMatchRule3.Text = textmatchdata4;
		this.ACMEbtnSignin.MatchRules.Add(this.inputTypeMatchRule2);
		this.ACMEbtnSignin.MatchRules.Add(this.elementIdMatchRule3);
		this.ACMEbtnSignin.Name = "ACMEbtnSignin";
		this.ACMEbtnSignin.TagName = "INPUT";
		this.ACMEbtnSignin.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputSubmitElement, OpenSpan.Adapters.Web";
		this.ACMEbtnSignin.UseElementId = true;
		// 
		// ACMEtxtUserName
		// 
		this.ACMEtxtUserName.ElementId = "user_name";
		this.ACMEtxtUserName.Extender = null;
		this.ACMEtxtUserName.ForwardObjectExplorerEvent = true;
		this.ACMEtxtUserName.MatchingIndex = 0;
		// 
		// inputTypeMatchRule1
		// 
		this.inputTypeMatchRule1.Type = OpenSpan.Adapters.Web.InputType.Text;
		// 
		// attributeMatchRule1
		// 
		this.attributeMatchRule1.Attribute = "name";
		textmatchdata5.Text = "user_name";
		this.attributeMatchRule1.Text = textmatchdata5;
		this.ACMEtxtUserName.MatchRules.Add(this.inputTypeMatchRule1);
		this.ACMEtxtUserName.MatchRules.Add(this.attributeMatchRule1);
		this.ACMEtxtUserName.Name = "ACMEtxtUserName";
		this.ACMEtxtUserName.TagName = "INPUT";
		this.ACMEtxtUserName.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputTextElement, OpenSpan.Adapters.Web";
		this.ACMEtxtUserName.UseElementId = true;
		// 
		// ACMEtxtPassword
		// 
		this.ACMEtxtPassword.ElementId = "user_pass";
		this.ACMEtxtPassword.Extender = null;
		this.ACMEtxtPassword.ForwardObjectExplorerEvent = true;
		this.ACMEtxtPassword.MatchingIndex = 1;
		// 
		// inputTypeMatchRule3
		// 
		this.inputTypeMatchRule3.Type = OpenSpan.Adapters.Web.InputType.Password;
		// 
		// elementIdMatchRule2
		// 
		textmatchdata6.Text = "user_pass";
		this.elementIdMatchRule2.Text = textmatchdata6;
		this.ACMEtxtPassword.MatchRules.Add(this.inputTypeMatchRule3);
		this.ACMEtxtPassword.MatchRules.Add(this.elementIdMatchRule2);
		this.ACMEtxtPassword.Name = "ACMEtxtPassword";
		this.ACMEtxtPassword.TagName = "INPUT";
		this.ACMEtxtPassword.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputPasswordElement, OpenSpan.Adapters.Web";
		this.ACMEtxtPassword.UseElementId = true;
		// 
		// ACMElblVersion
		// 
		this.ACMElblVersion.ElementId = null;
		this.ACMElblVersion.Extender = null;
		this.ACMElblVersion.ForwardObjectExplorerEvent = true;
		this.ACMElblVersion.MatchingIndex = 3;
		// 
		// inputTypeMatchRule6
		// 
		this.inputTypeMatchRule6.Type = OpenSpan.Adapters.Web.InputType.Hidden;
		// 
		// inputNameMatchRule1
		// 
		textmatchdata7.Text = "pegasystem_version";
		this.inputNameMatchRule1.Text = textmatchdata7;
		this.ACMElblVersion.MatchRules.Add(this.inputTypeMatchRule6);
		this.ACMElblVersion.MatchRules.Add(this.inputNameMatchRule1);
		this.ACMElblVersion.Name = "ACMElblVersion";
		this.ACMElblVersion.TagName = "INPUT";
		this.ACMElblVersion.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputHiddenElement, OpenSpan.Adapters.Web";
		this.ACMElblVersion.UseElementId = false;
		this.ACMEfrmCredentials.Controls.Add(this.ACMEbtnSignin);
		this.ACMEfrmCredentials.Controls.Add(this.ACMEtxtUserName);
		this.ACMEfrmCredentials.Controls.Add(this.ACMEtxtPassword);
		this.ACMEfrmCredentials.Controls.Add(this.ACMElblVersion);
		this.ACMEfrmCredentials.ElementId = null;
		this.ACMEfrmCredentials.Extender = null;
		this.ACMEfrmCredentials.ForwardObjectExplorerEvent = true;
		this.ACMEfrmCredentials.MatchingIndex = 0;
		// 
		// formActionMatchRule1
		// 
		this.formActionMatchRule1.Fragment = textmatchdata8;
		textmatchdata9.Text = "training.openspan.com";
		this.formActionMatchRule1.Host = textmatchdata9;
		textmatchdata10.Text = "/home";
		this.formActionMatchRule1.Path = textmatchdata10;
		this.formActionMatchRule1.Port = 80;
		this.formActionMatchRule1.Query = textmatchdata11;
		textmatchdata12.Text = "http";
		this.formActionMatchRule1.Scheme = textmatchdata12;
		this.ACMEfrmCredentials.MatchRules.Add(this.formActionMatchRule1);
		this.ACMEfrmCredentials.Name = "ACMEfrmCredentials";
		this.ACMEfrmCredentials.TagName = "FORM";
		this.ACMEfrmCredentials.TargetTypeString = "OpenSpan.Adapters.Web.HtmlFormElement, OpenSpan.Adapters.Web";
		this.ACMEfrmCredentials.UseElementId = false;
		this.ACMEwpSignIn.Controls.Add(this.ACMEfrmCredentials);
		this.ACMEwpSignIn.Extender = null;
		this.ACMEwpSignIn.ForwardObjectExplorerEvent = true;
		this.ACMEwpSignIn.IsGlobal = true;
		this.ACMEwpSignIn.MatchingIndex = 0;
		// 
		// documentUrlMatchRule1
		// 
		this.documentUrlMatchRule1.Fragment = textmatchdata13;
		textmatchdata14.Text = "training.openspan.com";
		this.documentUrlMatchRule1.Host = textmatchdata14;
		textmatchdata15.Text = "/login";
		this.documentUrlMatchRule1.Path = textmatchdata15;
		this.documentUrlMatchRule1.Port = 80;
		this.documentUrlMatchRule1.Query = textmatchdata16;
		textmatchdata17.Text = "http";
		this.documentUrlMatchRule1.Scheme = textmatchdata17;
		// 
		// documentTitleMatchRule1
		// 
		textmatchdata18.Text = "Sign In | Pega Studio Training Web Application";
		this.documentTitleMatchRule1.Text = textmatchdata18;
		this.ACMEwpSignIn.MatchRules.Add(this.documentUrlMatchRule1);
		this.ACMEwpSignIn.MatchRules.Add(this.documentTitleMatchRule1);
		this.ACMEwpSignIn.Name = "ACMEwpSignIn";
		this.ACMEwpSignIn.TargetTypeString = "OpenSpan.Adapters.Web.HtmlDocument, OpenSpan.Adapters.Web";
		// 
		// ACMEwpHome
		// 
		// 
		// ACMENewsAlert
		// 
		this.ACMENewsAlert.ElementId = null;
		this.ACMENewsAlert.Extender = null;
		this.ACMENewsAlert.ForwardObjectExplorerEvent = true;
		this.ACMENewsAlert.MatchingIndex = 2;
		// 
		// elementIndexMatchRule1
		// 
		this.elementIndexMatchRule1.Index = 2;
		this.ACMENewsAlert.MatchRules.Add(this.elementIndexMatchRule1);
		this.ACMENewsAlert.Name = "ACMENewsAlert";
		this.ACMENewsAlert.TagName = "P";
		this.ACMENewsAlert.TargetTypeString = "OpenSpan.Adapters.Web.HtmlElement, OpenSpan.Adapters.Web";
		this.ACMENewsAlert.UseElementId = false;
		// 
		// ACMElnkStores
		// 
		this.ACMElnkStores.ElementId = null;
		this.ACMElnkStores.Extender = null;
		this.ACMElnkStores.ForwardObjectExplorerEvent = true;
		this.ACMElnkStores.MatchingIndex = 20;
		// 
		// innerTextMatchRule1
		// 
		textmatchdata19.Text = "Stores";
		this.innerTextMatchRule1.Text = textmatchdata19;
		this.ACMElnkStores.MatchRules.Add(this.innerTextMatchRule1);
		this.ACMElnkStores.Name = "ACMElnkStores";
		this.ACMElnkStores.TagName = "A";
		this.ACMElnkStores.TargetTypeString = "OpenSpan.Adapters.Web.HtmlAnchorElement, OpenSpan.Adapters.Web";
		this.ACMElnkStores.UseElementId = false;
		this.ACMEwpHome.Controls.Add(this.ACMENewsAlert);
		this.ACMEwpHome.Controls.Add(this.ACMElnkStores);
		this.ACMEwpHome.Extender = null;
		this.ACMEwpHome.ForwardObjectExplorerEvent = true;
		this.ACMEwpHome.IsGlobal = true;
		this.ACMEwpHome.MatchingIndex = 0;
		// 
		// documentUrlMatchRule2
		// 
		this.documentUrlMatchRule2.Fragment = textmatchdata20;
		textmatchdata21.Text = "training.openspan.com";
		this.documentUrlMatchRule2.Host = textmatchdata21;
		textmatchdata22.Text = "/home";
		this.documentUrlMatchRule2.Path = textmatchdata22;
		this.documentUrlMatchRule2.Port = 80;
		this.documentUrlMatchRule2.Query = textmatchdata23;
		textmatchdata24.Text = "http";
		this.documentUrlMatchRule2.Scheme = textmatchdata24;
		// 
		// documentTitleMatchRule2
		// 
		textmatchdata25.Text = "Home | Pega Studio Training Web Application";
		this.documentTitleMatchRule2.Text = textmatchdata25;
		this.ACMEwpHome.MatchRules.Add(this.documentUrlMatchRule2);
		this.ACMEwpHome.MatchRules.Add(this.documentTitleMatchRule2);
		this.ACMEwpHome.Name = "ACMEwpHome";
		this.ACMEwpHome.TargetTypeString = "OpenSpan.Adapters.Web.HtmlDocument, OpenSpan.Adapters.Web";
		// 
		// ACMEwpStores
		// 
		// 
		// ACMEfrmSearch
		// 
		// 
		// ACMEtxtZip
		// 
		this.ACMEtxtZip.ElementId = "txtZip";
		this.ACMEtxtZip.Extender = null;
		this.ACMEtxtZip.ForwardObjectExplorerEvent = true;
		this.ACMEtxtZip.MatchingIndex = 0;
		// 
		// inputTypeMatchRule4
		// 
		this.inputTypeMatchRule4.Type = OpenSpan.Adapters.Web.InputType.Text;
		// 
		// elementIdMatchRule6
		// 
		textmatchdata26.Text = "txtZip";
		this.elementIdMatchRule6.Text = textmatchdata26;
		this.ACMEtxtZip.MatchRules.Add(this.inputTypeMatchRule4);
		this.ACMEtxtZip.MatchRules.Add(this.elementIdMatchRule6);
		this.ACMEtxtZip.Name = "ACMEtxtZip";
		this.ACMEtxtZip.TagName = "INPUT";
		this.ACMEtxtZip.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputTextElement, OpenSpan.Adapters.Web";
		this.ACMEtxtZip.UseElementId = true;
		// 
		// ACMEbtnFindStore
		// 
		this.ACMEbtnFindStore.ElementId = "submit_find";
		this.ACMEbtnFindStore.Extender = null;
		this.ACMEbtnFindStore.ForwardObjectExplorerEvent = true;
		this.ACMEbtnFindStore.MatchingIndex = 2;
		// 
		// inputTypeMatchRule5
		// 
		this.inputTypeMatchRule5.Type = OpenSpan.Adapters.Web.InputType.Submit;
		// 
		// elementIdMatchRule7
		// 
		textmatchdata27.Text = "submit_find";
		this.elementIdMatchRule7.Text = textmatchdata27;
		this.ACMEbtnFindStore.MatchRules.Add(this.inputTypeMatchRule5);
		this.ACMEbtnFindStore.MatchRules.Add(this.elementIdMatchRule7);
		this.ACMEbtnFindStore.Name = "ACMEbtnFindStore";
		this.ACMEbtnFindStore.TagName = "INPUT";
		this.ACMEbtnFindStore.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputSubmitElement, OpenSpan.Adapters.Web";
		this.ACMEbtnFindStore.UseElementId = true;
		this.ACMEfrmSearch.Controls.Add(this.ACMEtxtZip);
		this.ACMEfrmSearch.Controls.Add(this.ACMEbtnFindStore);
		this.ACMEfrmSearch.ElementId = "form1";
		this.ACMEfrmSearch.Extender = null;
		this.ACMEfrmSearch.ForwardObjectExplorerEvent = true;
		this.ACMEfrmSearch.MatchingIndex = 0;
		// 
		// elementIdMatchRule5
		// 
		textmatchdata28.Text = "form1";
		this.elementIdMatchRule5.Text = textmatchdata28;
		this.ACMEfrmSearch.MatchRules.Add(this.elementIdMatchRule5);
		this.ACMEfrmSearch.Name = "ACMEfrmSearch";
		this.ACMEfrmSearch.TagName = "FORM";
		this.ACMEfrmSearch.TargetTypeString = "OpenSpan.Adapters.Web.HtmlFormElement, OpenSpan.Adapters.Web";
		this.ACMEfrmSearch.UseElementId = true;
		// 
		// Stores_Store_Listing
		// 
		this.Stores_Store_Listing.ElementId = "store_menu";
		this.Stores_Store_Listing.Extender = null;
		this.Stores_Store_Listing.ForwardObjectExplorerEvent = true;
		this.Stores_Store_Listing.MatchingIndex = 6;
		// 
		// elementIdMatchRule1
		// 
		textmatchdata29.Text = "store_menu";
		this.elementIdMatchRule1.Text = textmatchdata29;
		this.Stores_Store_Listing.MatchRules.Add(this.elementIdMatchRule1);
		this.Stores_Store_Listing.Name = "Stores_Store_Listing";
		this.Stores_Store_Listing.TagName = "LI";
		this.Stores_Store_Listing.TargetTypeString = "OpenSpan.Adapters.Web.HtmlElement, OpenSpan.Adapters.Web";
		this.Stores_Store_Listing.UseElementId = true;
		this.ACMEwpStores.Controls.Add(this.ACMEfrmSearch);
		this.ACMEwpStores.Controls.Add(this.Stores_Store_Listing);
		this.ACMEwpStores.Extender = null;
		this.ACMEwpStores.ForwardObjectExplorerEvent = true;
		this.ACMEwpStores.IsGlobal = true;
		this.ACMEwpStores.MatchingIndex = 0;
		// 
		// documentUrlMatchRule3
		// 
		this.documentUrlMatchRule3.Fragment = textmatchdata30;
		textmatchdata31.Text = "training.openspan.com";
		this.documentUrlMatchRule3.Host = textmatchdata31;
		textmatchdata32.Text = "/store_locator";
		this.documentUrlMatchRule3.Path = textmatchdata32;
		this.documentUrlMatchRule3.Port = 80;
		this.documentUrlMatchRule3.Query = textmatchdata33;
		textmatchdata34.Text = "http";
		this.documentUrlMatchRule3.Scheme = textmatchdata34;
		// 
		// documentTitleMatchRule3
		// 
		textmatchdata35.Text = "Stores | Pega Studio Training Web Application";
		this.documentTitleMatchRule3.Text = textmatchdata35;
		this.ACMEwpStores.MatchRules.Add(this.documentUrlMatchRule3);
		this.ACMEwpStores.MatchRules.Add(this.documentTitleMatchRule3);
		this.ACMEwpStores.Name = "ACMEwpStores";
		this.ACMEwpStores.TargetTypeString = "OpenSpan.Adapters.Web.HtmlDocument, OpenSpan.Adapters.Web";
		// 
		// ACMEwpResults
		// 
		// 
		// ACMEfrmResults
		// 
		// 
		// ACMEtblNearestStore
		// 
		this.ACMEtblNearestStore.ElementId = "search_locator_result_table";
		this.ACMEtblNearestStore.Extender = null;
		this.ACMEtblNearestStore.ForwardObjectExplorerEvent = true;
		this.ACMEtblNearestStore.MatchingIndex = 0;
		// 
		// elementIdMatchRule9
		// 
		textmatchdata36.Text = "search_locator_result_table";
		this.elementIdMatchRule9.Text = textmatchdata36;
		this.ACMEtblNearestStore.MatchRules.Add(this.elementIdMatchRule9);
		this.ACMEtblNearestStore.Name = "ACMEtblNearestStore";
		this.ACMEtblNearestStore.Schema.Id = new System.Guid("87500b59-005e-4e0b-817d-307c97697e2e");
		this.ACMEtblNearestStore.Schema.Name = "ACMEtblNearestStore";
		this.ACMEtblNearestStore.TagName = "TABLE";
		this.ACMEtblNearestStore.TargetTypeString = "OpenSpan.Adapters.Web.HtmlTableElement, OpenSpan.Adapters.Web";
		this.ACMEtblNearestStore.UseElementId = true;
		this.ACMEfrmResults.Controls.Add(this.ACMEtblNearestStore);
		this.ACMEfrmResults.ElementId = "form1";
		this.ACMEfrmResults.Extender = null;
		this.ACMEfrmResults.ForwardObjectExplorerEvent = true;
		this.ACMEfrmResults.MatchingIndex = 0;
		// 
		// elementIdMatchRule8
		// 
		textmatchdata37.Text = "form1";
		this.elementIdMatchRule8.Text = textmatchdata37;
		this.ACMEfrmResults.MatchRules.Add(this.elementIdMatchRule8);
		this.ACMEfrmResults.Name = "ACMEfrmResults";
		this.ACMEfrmResults.TagName = "FORM";
		this.ACMEfrmResults.TargetTypeString = "OpenSpan.Adapters.Web.HtmlFormElement, OpenSpan.Adapters.Web";
		this.ACMEfrmResults.UseElementId = true;
		this.ACMEwpResults.Controls.Add(this.ACMEfrmResults);
		this.ACMEwpResults.Extender = null;
		this.ACMEwpResults.ForwardObjectExplorerEvent = true;
		this.ACMEwpResults.IsGlobal = true;
		this.ACMEwpResults.MatchingIndex = 0;
		// 
		// documentUrlMatchRule4
		// 
		this.documentUrlMatchRule4.Fragment = textmatchdata38;
		textmatchdata39.Text = "training.openspan.com";
		this.documentUrlMatchRule4.Host = textmatchdata39;
		textmatchdata40.Text = "/store/locator_result";
		this.documentUrlMatchRule4.Path = textmatchdata40;
		this.documentUrlMatchRule4.Port = 80;
		this.documentUrlMatchRule4.Query = textmatchdata41;
		textmatchdata42.Text = "http";
		this.documentUrlMatchRule4.Scheme = textmatchdata42;
		// 
		// documentTitleMatchRule4
		// 
		textmatchdata43.Text = "Store Locator | Pega Studio Training Web Application";
		this.documentTitleMatchRule4.Text = textmatchdata43;
		this.ACMEwpResults.MatchRules.Add(this.documentUrlMatchRule4);
		this.ACMEwpResults.MatchRules.Add(this.documentTitleMatchRule4);
		this.ACMEwpResults.Name = "ACMEwpResults";
		this.ACMEwpResults.TargetTypeString = "OpenSpan.Adapters.Web.HtmlDocument, OpenSpan.Adapters.Web";
		this.Controls.Add(this.ActiveXFactory);
		this.Controls.Add(this.WinInetFactory);
		this.Controls.Add(this.MicrosoftHTMLFactory);
		this.Controls.Add(this.ACMEwpSignIn);
		this.Controls.Add(this.ACMEwpHome);
		this.Controls.Add(this.ACMEwpStores);
		this.Controls.Add(this.ACMEwpResults);
		this.ExpressNativeTypes = null;
		this.Extender = null;
		this.FriendlyName = "ACMESearchSystem";
		this.IgnoreMainBrowser = false;
		this.MenuBarVisible = OpenSpan.Adapters.Web.WebAdapter.WebBrowserShowToolbar.Default;
		this.Name = "ACMESearchSystem";
		this.StartMyDay = OpenSpan.ApplicationFramework.StartMyDay.StartOptions.None;
		this.StartMyDayControls = null;
		this.StartOnProjectStart = false;
		this.StartPage = "http://training.openspan.com";
		this.ToolBarVisible = OpenSpan.Adapters.Web.WebAdapter.WebBrowserShowToolbar.Default;
		// 
		// Add components
		// 
		this.mComponents = new System.Collections.Generic.List<System.ComponentModel.IComponent>(20);
		this.Components.Add(this.ActiveXFactory);
		this.Components.Add(this.moduleNameMatchRule1);
		this.Components.Add(this.WinInetFactory);
		this.Components.Add(this.moduleNameMatchRule2);
		this.Components.Add(this.MicrosoftHTMLFactory);
		this.Components.Add(this.moduleNameMatchRule3);
		this.Components.Add(this.ACMEwpSignIn);
		this.Components.Add(this.ACMEfrmCredentials);
		this.Components.Add(this.ACMEbtnSignin);
		this.Components.Add(this.inputTypeMatchRule2);
		this.Components.Add(this.elementIdMatchRule3);
		this.Components.Add(this.ACMEtxtUserName);
		this.Components.Add(this.inputTypeMatchRule1);
		this.Components.Add(this.attributeMatchRule1);
		this.Components.Add(this.ACMEtxtPassword);
		this.Components.Add(this.inputTypeMatchRule3);
		this.Components.Add(this.elementIdMatchRule2);
		this.Components.Add(this.ACMElblVersion);
		this.Components.Add(this.inputTypeMatchRule6);
		this.Components.Add(this.inputNameMatchRule1);
		this.Components.Add(this.formActionMatchRule1);
		this.Components.Add(this.documentUrlMatchRule1);
		this.Components.Add(this.documentTitleMatchRule1);
		this.Components.Add(this.ACMEwpHome);
		this.Components.Add(this.ACMENewsAlert);
		this.Components.Add(this.elementIndexMatchRule1);
		this.Components.Add(this.ACMElnkStores);
		this.Components.Add(this.innerTextMatchRule1);
		this.Components.Add(this.documentUrlMatchRule2);
		this.Components.Add(this.documentTitleMatchRule2);
		this.Components.Add(this.ACMEwpStores);
		this.Components.Add(this.ACMEfrmSearch);
		this.Components.Add(this.ACMEtxtZip);
		this.Components.Add(this.inputTypeMatchRule4);
		this.Components.Add(this.elementIdMatchRule6);
		this.Components.Add(this.ACMEbtnFindStore);
		this.Components.Add(this.inputTypeMatchRule5);
		this.Components.Add(this.elementIdMatchRule7);
		this.Components.Add(this.elementIdMatchRule5);
		this.Components.Add(this.Stores_Store_Listing);
		this.Components.Add(this.elementIdMatchRule1);
		this.Components.Add(this.documentUrlMatchRule3);
		this.Components.Add(this.documentTitleMatchRule3);
		this.Components.Add(this.ACMEwpResults);
		this.Components.Add(this.ACMEfrmResults);
		this.Components.Add(this.ACMEtblNearestStore);
		this.Components.Add(this.elementIdMatchRule9);
		this.Components.Add(this.elementIdMatchRule8);
		this.Components.Add(this.documentUrlMatchRule4);
		this.Components.Add(this.documentTitleMatchRule4);
	}
	
	private System.Collections.Generic.List<System.ComponentModel.IComponent> mComponents;
	
	public System.Collections.Generic.List<System.ComponentModel.IComponent> Components
	{
		get
		{
			return this.mComponents;
		}
	}
	
	/// <summary>
	/// Start design component.
	/// </summary>
	public override void Start()
	{
		base.Start();
	}
	
	/// <summary>
	/// Stop design component.
	/// </summary>
	public override void Stop()
	{
		base.Stop();
	}
	
	internal OpenSpan.Adapters.ActiveX.ActiveXFactory Create_ActiveXFactory(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.ActiveX.ActiveXFactory ActiveXFactory = new OpenSpan.Adapters.ActiveX.ActiveXFactory();
		this.SetId(ActiveXFactory, new OpenSpan.Design.ComponentIdentity("ActiveXFactory-8D60375BC16A2A3"));
		ActiveXFactory.Extender = null;
		ActiveXFactory.FactoryName = null;
		ActiveXFactory.ForwardObjectExplorerEvent = true;
		ActiveXFactory.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule1;
		moduleNameMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		// 
		// moduleNameMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "ole32.dll";
		moduleNameMatchRule1.Text = textmatchdata1;
		ActiveXFactory.MatchRules.Add(moduleNameMatchRule1);
		ActiveXFactory.Name = "ActiveXFactory";
		ActiveXFactory.TargetTypeString = "OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows";
		ActiveXFactory.UseKeys = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(moduleNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D60375BC23CAFB"));
		// 
		// Add components
		// 
		components.Add(moduleNameMatchRule1);
		// 
		// Result
		// 
		return ActiveXFactory;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule Create_moduleNameMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.SetId(moduleNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D60375BC23CAFB"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "ole32.dll";
		moduleNameMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return moduleNameMatchRule1;
	}
	
	internal OpenSpan.Adapters.WinInet.WinInetFactory Create_WinInetFactory(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.WinInet.WinInetFactory WinInetFactory = new OpenSpan.Adapters.WinInet.WinInetFactory();
		this.SetId(WinInetFactory, new OpenSpan.Design.ComponentIdentity("WinInetFactory-8D60375BC39237D"));
		WinInetFactory.Extender = null;
		WinInetFactory.FactoryName = null;
		WinInetFactory.ForwardObjectExplorerEvent = true;
		WinInetFactory.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule2;
		moduleNameMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		// 
		// moduleNameMatchRule2
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "wininet.dll";
		moduleNameMatchRule2.Text = textmatchdata1;
		WinInetFactory.MatchRules.Add(moduleNameMatchRule2);
		WinInetFactory.Name = "WinInetFactory";
		WinInetFactory.TargetTypeString = "OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows";
		WinInetFactory.UseKeys = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(moduleNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D60375BC407B70"));
		// 
		// Add components
		// 
		components.Add(moduleNameMatchRule2);
		// 
		// Result
		// 
		return WinInetFactory;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule Create_moduleNameMatchRule2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.SetId(moduleNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D60375BC407B70"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "wininet.dll";
		moduleNameMatchRule2.Text = textmatchdata1;
		// 
		// Result
		// 
		return moduleNameMatchRule2;
	}
	
	internal OpenSpan.Adapters.Web.MicrosoftHTMLFactory Create_MicrosoftHTMLFactory(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MicrosoftHTMLFactory MicrosoftHTMLFactory = new OpenSpan.Adapters.Web.MicrosoftHTMLFactory();
		this.SetId(MicrosoftHTMLFactory, new OpenSpan.Design.ComponentIdentity("MicrosoftHTMLFactory-8D60375BCF65D34"));
		MicrosoftHTMLFactory.Extender = null;
		MicrosoftHTMLFactory.FactoryName = null;
		MicrosoftHTMLFactory.ForwardObjectExplorerEvent = true;
		MicrosoftHTMLFactory.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule3;
		moduleNameMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		// 
		// moduleNameMatchRule3
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "mshtml.dll";
		moduleNameMatchRule3.Text = textmatchdata1;
		MicrosoftHTMLFactory.MatchRules.Add(moduleNameMatchRule3);
		MicrosoftHTMLFactory.Name = "MicrosoftHTMLFactory";
		MicrosoftHTMLFactory.TargetTypeString = "OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows";
		MicrosoftHTMLFactory.UseKeys = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(moduleNameMatchRule3, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D60375BD007635"));
		// 
		// Add components
		// 
		components.Add(moduleNameMatchRule3);
		// 
		// Result
		// 
		return MicrosoftHTMLFactory;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule Create_moduleNameMatchRule3(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule3 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.SetId(moduleNameMatchRule3, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D60375BD007635"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "mshtml.dll";
		moduleNameMatchRule3.Text = textmatchdata1;
		// 
		// Result
		// 
		return moduleNameMatchRule3;
	}
	
	internal OpenSpan.Adapters.Web.Controls.WebPage Create_ACMEwpSignIn(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.WebPage ACMEwpSignIn = new OpenSpan.Adapters.Web.Controls.WebPage();
		this.SetId(ACMEwpSignIn, new OpenSpan.Design.ComponentIdentity("WebPage-8D60375DAC432D3"));
		OpenSpan.Adapters.Web.Controls.Form ACMEfrmCredentials;
		ACMEfrmCredentials = new OpenSpan.Adapters.Web.Controls.Form();
		// 
		// ACMEfrmCredentials
		// 
		OpenSpan.Adapters.Web.Controls.Button ACMEbtnSignin;
		ACMEbtnSignin = new OpenSpan.Adapters.Web.Controls.Button();
		// 
		// ACMEbtnSignin
		// 
		ACMEbtnSignin.ElementId = "login_button";
		ACMEbtnSignin.Extender = null;
		ACMEbtnSignin.ForwardObjectExplorerEvent = true;
		ACMEbtnSignin.MatchingIndex = 2;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule2;
		inputTypeMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule2
		// 
		inputTypeMatchRule2.Type = OpenSpan.Adapters.Web.InputType.Submit;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule3;
		elementIdMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule3
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "login_button";
		elementIdMatchRule3.Text = textmatchdata1;
		ACMEbtnSignin.MatchRules.Add(inputTypeMatchRule2);
		ACMEbtnSignin.MatchRules.Add(elementIdMatchRule3);
		ACMEbtnSignin.Name = "ACMEbtnSignin";
		ACMEbtnSignin.TagName = "INPUT";
		ACMEbtnSignin.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputSubmitElement, OpenSpan.Adapters.Web";
		ACMEbtnSignin.UseElementId = true;
		OpenSpan.Adapters.Web.Controls.TextBox ACMEtxtUserName;
		ACMEtxtUserName = new OpenSpan.Adapters.Web.Controls.TextBox();
		// 
		// ACMEtxtUserName
		// 
		ACMEtxtUserName.ElementId = "user_name";
		ACMEtxtUserName.Extender = null;
		ACMEtxtUserName.ForwardObjectExplorerEvent = true;
		ACMEtxtUserName.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule1;
		inputTypeMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule1
		// 
		inputTypeMatchRule1.Type = OpenSpan.Adapters.Web.InputType.Text;
		OpenSpan.Adapters.Web.MatchRules.AttributeMatchRule attributeMatchRule1;
		attributeMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.AttributeMatchRule();
		// 
		// attributeMatchRule1
		// 
		attributeMatchRule1.Attribute = "name";
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "user_name";
		attributeMatchRule1.Text = textmatchdata2;
		ACMEtxtUserName.MatchRules.Add(inputTypeMatchRule1);
		ACMEtxtUserName.MatchRules.Add(attributeMatchRule1);
		ACMEtxtUserName.Name = "ACMEtxtUserName";
		ACMEtxtUserName.TagName = "INPUT";
		ACMEtxtUserName.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputTextElement, OpenSpan.Adapters.Web";
		ACMEtxtUserName.UseElementId = true;
		OpenSpan.Adapters.Web.Controls.TextBox ACMEtxtPassword;
		ACMEtxtPassword = new OpenSpan.Adapters.Web.Controls.TextBox();
		// 
		// ACMEtxtPassword
		// 
		ACMEtxtPassword.ElementId = "user_pass";
		ACMEtxtPassword.Extender = null;
		ACMEtxtPassword.ForwardObjectExplorerEvent = true;
		ACMEtxtPassword.MatchingIndex = 1;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule3;
		inputTypeMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule3
		// 
		inputTypeMatchRule3.Type = OpenSpan.Adapters.Web.InputType.Password;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule2;
		elementIdMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule2
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "user_pass";
		elementIdMatchRule2.Text = textmatchdata3;
		ACMEtxtPassword.MatchRules.Add(inputTypeMatchRule3);
		ACMEtxtPassword.MatchRules.Add(elementIdMatchRule2);
		ACMEtxtPassword.Name = "ACMEtxtPassword";
		ACMEtxtPassword.TagName = "INPUT";
		ACMEtxtPassword.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputPasswordElement, OpenSpan.Adapters.Web";
		ACMEtxtPassword.UseElementId = true;
		OpenSpan.Adapters.Web.Controls.HiddenField ACMElblVersion;
		ACMElblVersion = new OpenSpan.Adapters.Web.Controls.HiddenField();
		// 
		// ACMElblVersion
		// 
		ACMElblVersion.ElementId = null;
		ACMElblVersion.Extender = null;
		ACMElblVersion.ForwardObjectExplorerEvent = true;
		ACMElblVersion.MatchingIndex = 3;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule6;
		inputTypeMatchRule6 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule6
		// 
		inputTypeMatchRule6.Type = OpenSpan.Adapters.Web.InputType.Hidden;
		OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule inputNameMatchRule1;
		inputNameMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule();
		// 
		// inputNameMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata4.Text = "pegasystem_version";
		inputNameMatchRule1.Text = textmatchdata4;
		ACMElblVersion.MatchRules.Add(inputTypeMatchRule6);
		ACMElblVersion.MatchRules.Add(inputNameMatchRule1);
		ACMElblVersion.Name = "ACMElblVersion";
		ACMElblVersion.TagName = "INPUT";
		ACMElblVersion.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputHiddenElement, OpenSpan.Adapters.Web";
		ACMElblVersion.UseElementId = false;
		ACMEfrmCredentials.Controls.Add(ACMEbtnSignin);
		ACMEfrmCredentials.Controls.Add(ACMEtxtUserName);
		ACMEfrmCredentials.Controls.Add(ACMEtxtPassword);
		ACMEfrmCredentials.Controls.Add(ACMElblVersion);
		ACMEfrmCredentials.ElementId = null;
		ACMEfrmCredentials.Extender = null;
		ACMEfrmCredentials.ForwardObjectExplorerEvent = true;
		ACMEfrmCredentials.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.FormActionMatchRule formActionMatchRule1;
		formActionMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.FormActionMatchRule();
		// 
		// formActionMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata5 = new OpenSpan.Adapters.TextMatchData();
		formActionMatchRule1.Fragment = textmatchdata5;
		OpenSpan.Adapters.TextMatchData textmatchdata6 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata6.Text = "training.openspan.com";
		formActionMatchRule1.Host = textmatchdata6;
		OpenSpan.Adapters.TextMatchData textmatchdata7 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata7.Text = "/home";
		formActionMatchRule1.Path = textmatchdata7;
		formActionMatchRule1.Port = 80;
		OpenSpan.Adapters.TextMatchData textmatchdata8 = new OpenSpan.Adapters.TextMatchData();
		formActionMatchRule1.Query = textmatchdata8;
		OpenSpan.Adapters.TextMatchData textmatchdata9 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata9.Text = "http";
		formActionMatchRule1.Scheme = textmatchdata9;
		ACMEfrmCredentials.MatchRules.Add(formActionMatchRule1);
		ACMEfrmCredentials.Name = "ACMEfrmCredentials";
		ACMEfrmCredentials.TagName = "FORM";
		ACMEfrmCredentials.TargetTypeString = "OpenSpan.Adapters.Web.HtmlFormElement, OpenSpan.Adapters.Web";
		ACMEfrmCredentials.UseElementId = false;
		ACMEwpSignIn.Controls.Add(ACMEfrmCredentials);
		ACMEwpSignIn.Extender = null;
		ACMEwpSignIn.ForwardObjectExplorerEvent = true;
		ACMEwpSignIn.IsGlobal = true;
		ACMEwpSignIn.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule documentUrlMatchRule1;
		documentUrlMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule();
		// 
		// documentUrlMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata10 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule1.Fragment = textmatchdata10;
		OpenSpan.Adapters.TextMatchData textmatchdata11 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata11.Text = "training.openspan.com";
		documentUrlMatchRule1.Host = textmatchdata11;
		OpenSpan.Adapters.TextMatchData textmatchdata12 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata12.Text = "/login";
		documentUrlMatchRule1.Path = textmatchdata12;
		documentUrlMatchRule1.Port = 80;
		OpenSpan.Adapters.TextMatchData textmatchdata13 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule1.Query = textmatchdata13;
		OpenSpan.Adapters.TextMatchData textmatchdata14 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata14.Text = "http";
		documentUrlMatchRule1.Scheme = textmatchdata14;
		OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule documentTitleMatchRule1;
		documentTitleMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule();
		// 
		// documentTitleMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata15 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata15.Text = "Sign In | Pega Studio Training Web Application";
		documentTitleMatchRule1.Text = textmatchdata15;
		ACMEwpSignIn.MatchRules.Add(documentUrlMatchRule1);
		ACMEwpSignIn.MatchRules.Add(documentTitleMatchRule1);
		ACMEwpSignIn.Name = "ACMEwpSignIn";
		ACMEwpSignIn.TargetTypeString = "OpenSpan.Adapters.Web.HtmlDocument, OpenSpan.Adapters.Web";
		// 
		// Set designComp Ids
		// 
		this.SetId(ACMEfrmCredentials, new OpenSpan.Design.ComponentIdentity("Form-8D60375DABD2934"));
		this.SetId(ACMEbtnSignin, new OpenSpan.Design.ComponentIdentity("Button-8D60375F99A1A32"));
		this.SetId(inputTypeMatchRule2, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60375F9A2D758"));
		this.SetId(elementIdMatchRule3, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60375F9A8C390"));
		this.SetId(ACMEtxtUserName, new OpenSpan.Design.ComponentIdentity("TextBox-8D6037673EE53C6"));
		this.SetId(inputTypeMatchRule1, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D6037673F79509"));
		this.SetId(attributeMatchRule1, new OpenSpan.Design.ComponentIdentity("AttributeMatchRule-8D606A0B1280F1A"));
		this.SetId(ACMEtxtPassword, new OpenSpan.Design.ComponentIdentity("TextBox-8D60376773446F4"));
		this.SetId(inputTypeMatchRule3, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60376773E0072"));
		this.SetId(elementIdMatchRule2, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D603767743D0BD"));
		this.SetId(ACMElblVersion, new OpenSpan.Design.ComponentIdentity("HiddenField-8D60687B4A0E5E5"));
		this.SetId(inputTypeMatchRule6, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60687B4AA0D4B"));
		this.SetId(inputNameMatchRule1, new OpenSpan.Design.ComponentIdentity("InputNameMatchRule-8D60687B4AF7BB0"));
		this.SetId(formActionMatchRule1, new OpenSpan.Design.ComponentIdentity("FormActionMatchRule-8D60375DADE86B7"));
		this.SetId(documentUrlMatchRule1, new OpenSpan.Design.ComponentIdentity("DocumentUrlMatchRule-8D60375DACFFDE5"));
		this.SetId(documentTitleMatchRule1, new OpenSpan.Design.ComponentIdentity("DocumentTitleMatchRule-8D60375DAD57FE1"));
		// 
		// Add components
		// 
		components.Add(ACMEfrmCredentials);
		components.Add(ACMEbtnSignin);
		components.Add(inputTypeMatchRule2);
		components.Add(elementIdMatchRule3);
		components.Add(ACMEtxtUserName);
		components.Add(inputTypeMatchRule1);
		components.Add(attributeMatchRule1);
		components.Add(ACMEtxtPassword);
		components.Add(inputTypeMatchRule3);
		components.Add(elementIdMatchRule2);
		components.Add(ACMElblVersion);
		components.Add(inputTypeMatchRule6);
		components.Add(inputNameMatchRule1);
		components.Add(formActionMatchRule1);
		components.Add(documentUrlMatchRule1);
		components.Add(documentTitleMatchRule1);
		// 
		// Result
		// 
		return ACMEwpSignIn;
	}
	
	internal OpenSpan.Adapters.Web.Controls.Form Create_ACMEfrmCredentials(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.Form ACMEfrmCredentials = new OpenSpan.Adapters.Web.Controls.Form();
		this.SetId(ACMEfrmCredentials, new OpenSpan.Design.ComponentIdentity("Form-8D60375DABD2934"));
		OpenSpan.Adapters.Web.Controls.Button ACMEbtnSignin;
		ACMEbtnSignin = new OpenSpan.Adapters.Web.Controls.Button();
		// 
		// ACMEbtnSignin
		// 
		ACMEbtnSignin.ElementId = "login_button";
		ACMEbtnSignin.Extender = null;
		ACMEbtnSignin.ForwardObjectExplorerEvent = true;
		ACMEbtnSignin.MatchingIndex = 2;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule2;
		inputTypeMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule2
		// 
		inputTypeMatchRule2.Type = OpenSpan.Adapters.Web.InputType.Submit;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule3;
		elementIdMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule3
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "login_button";
		elementIdMatchRule3.Text = textmatchdata1;
		ACMEbtnSignin.MatchRules.Add(inputTypeMatchRule2);
		ACMEbtnSignin.MatchRules.Add(elementIdMatchRule3);
		ACMEbtnSignin.Name = "ACMEbtnSignin";
		ACMEbtnSignin.TagName = "INPUT";
		ACMEbtnSignin.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputSubmitElement, OpenSpan.Adapters.Web";
		ACMEbtnSignin.UseElementId = true;
		OpenSpan.Adapters.Web.Controls.TextBox ACMEtxtUserName;
		ACMEtxtUserName = new OpenSpan.Adapters.Web.Controls.TextBox();
		// 
		// ACMEtxtUserName
		// 
		ACMEtxtUserName.ElementId = "user_name";
		ACMEtxtUserName.Extender = null;
		ACMEtxtUserName.ForwardObjectExplorerEvent = true;
		ACMEtxtUserName.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule1;
		inputTypeMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule1
		// 
		inputTypeMatchRule1.Type = OpenSpan.Adapters.Web.InputType.Text;
		OpenSpan.Adapters.Web.MatchRules.AttributeMatchRule attributeMatchRule1;
		attributeMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.AttributeMatchRule();
		// 
		// attributeMatchRule1
		// 
		attributeMatchRule1.Attribute = "name";
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "user_name";
		attributeMatchRule1.Text = textmatchdata2;
		ACMEtxtUserName.MatchRules.Add(inputTypeMatchRule1);
		ACMEtxtUserName.MatchRules.Add(attributeMatchRule1);
		ACMEtxtUserName.Name = "ACMEtxtUserName";
		ACMEtxtUserName.TagName = "INPUT";
		ACMEtxtUserName.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputTextElement, OpenSpan.Adapters.Web";
		ACMEtxtUserName.UseElementId = true;
		OpenSpan.Adapters.Web.Controls.TextBox ACMEtxtPassword;
		ACMEtxtPassword = new OpenSpan.Adapters.Web.Controls.TextBox();
		// 
		// ACMEtxtPassword
		// 
		ACMEtxtPassword.ElementId = "user_pass";
		ACMEtxtPassword.Extender = null;
		ACMEtxtPassword.ForwardObjectExplorerEvent = true;
		ACMEtxtPassword.MatchingIndex = 1;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule3;
		inputTypeMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule3
		// 
		inputTypeMatchRule3.Type = OpenSpan.Adapters.Web.InputType.Password;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule2;
		elementIdMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule2
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "user_pass";
		elementIdMatchRule2.Text = textmatchdata3;
		ACMEtxtPassword.MatchRules.Add(inputTypeMatchRule3);
		ACMEtxtPassword.MatchRules.Add(elementIdMatchRule2);
		ACMEtxtPassword.Name = "ACMEtxtPassword";
		ACMEtxtPassword.TagName = "INPUT";
		ACMEtxtPassword.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputPasswordElement, OpenSpan.Adapters.Web";
		ACMEtxtPassword.UseElementId = true;
		OpenSpan.Adapters.Web.Controls.HiddenField ACMElblVersion;
		ACMElblVersion = new OpenSpan.Adapters.Web.Controls.HiddenField();
		// 
		// ACMElblVersion
		// 
		ACMElblVersion.ElementId = null;
		ACMElblVersion.Extender = null;
		ACMElblVersion.ForwardObjectExplorerEvent = true;
		ACMElblVersion.MatchingIndex = 3;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule6;
		inputTypeMatchRule6 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule6
		// 
		inputTypeMatchRule6.Type = OpenSpan.Adapters.Web.InputType.Hidden;
		OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule inputNameMatchRule1;
		inputNameMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule();
		// 
		// inputNameMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata4.Text = "pegasystem_version";
		inputNameMatchRule1.Text = textmatchdata4;
		ACMElblVersion.MatchRules.Add(inputTypeMatchRule6);
		ACMElblVersion.MatchRules.Add(inputNameMatchRule1);
		ACMElblVersion.Name = "ACMElblVersion";
		ACMElblVersion.TagName = "INPUT";
		ACMElblVersion.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputHiddenElement, OpenSpan.Adapters.Web";
		ACMElblVersion.UseElementId = false;
		ACMEfrmCredentials.Controls.Add(ACMEbtnSignin);
		ACMEfrmCredentials.Controls.Add(ACMEtxtUserName);
		ACMEfrmCredentials.Controls.Add(ACMEtxtPassword);
		ACMEfrmCredentials.Controls.Add(ACMElblVersion);
		ACMEfrmCredentials.ElementId = null;
		ACMEfrmCredentials.Extender = null;
		ACMEfrmCredentials.ForwardObjectExplorerEvent = true;
		ACMEfrmCredentials.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.FormActionMatchRule formActionMatchRule1;
		formActionMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.FormActionMatchRule();
		// 
		// formActionMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata5 = new OpenSpan.Adapters.TextMatchData();
		formActionMatchRule1.Fragment = textmatchdata5;
		OpenSpan.Adapters.TextMatchData textmatchdata6 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata6.Text = "training.openspan.com";
		formActionMatchRule1.Host = textmatchdata6;
		OpenSpan.Adapters.TextMatchData textmatchdata7 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata7.Text = "/home";
		formActionMatchRule1.Path = textmatchdata7;
		formActionMatchRule1.Port = 80;
		OpenSpan.Adapters.TextMatchData textmatchdata8 = new OpenSpan.Adapters.TextMatchData();
		formActionMatchRule1.Query = textmatchdata8;
		OpenSpan.Adapters.TextMatchData textmatchdata9 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata9.Text = "http";
		formActionMatchRule1.Scheme = textmatchdata9;
		ACMEfrmCredentials.MatchRules.Add(formActionMatchRule1);
		ACMEfrmCredentials.Name = "ACMEfrmCredentials";
		ACMEfrmCredentials.TagName = "FORM";
		ACMEfrmCredentials.TargetTypeString = "OpenSpan.Adapters.Web.HtmlFormElement, OpenSpan.Adapters.Web";
		ACMEfrmCredentials.UseElementId = false;
		// 
		// Set designComp Ids
		// 
		this.SetId(ACMEbtnSignin, new OpenSpan.Design.ComponentIdentity("Button-8D60375F99A1A32"));
		this.SetId(inputTypeMatchRule2, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60375F9A2D758"));
		this.SetId(elementIdMatchRule3, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60375F9A8C390"));
		this.SetId(ACMEtxtUserName, new OpenSpan.Design.ComponentIdentity("TextBox-8D6037673EE53C6"));
		this.SetId(inputTypeMatchRule1, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D6037673F79509"));
		this.SetId(attributeMatchRule1, new OpenSpan.Design.ComponentIdentity("AttributeMatchRule-8D606A0B1280F1A"));
		this.SetId(ACMEtxtPassword, new OpenSpan.Design.ComponentIdentity("TextBox-8D60376773446F4"));
		this.SetId(inputTypeMatchRule3, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60376773E0072"));
		this.SetId(elementIdMatchRule2, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D603767743D0BD"));
		this.SetId(ACMElblVersion, new OpenSpan.Design.ComponentIdentity("HiddenField-8D60687B4A0E5E5"));
		this.SetId(inputTypeMatchRule6, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60687B4AA0D4B"));
		this.SetId(inputNameMatchRule1, new OpenSpan.Design.ComponentIdentity("InputNameMatchRule-8D60687B4AF7BB0"));
		this.SetId(formActionMatchRule1, new OpenSpan.Design.ComponentIdentity("FormActionMatchRule-8D60375DADE86B7"));
		// 
		// Add components
		// 
		components.Add(ACMEbtnSignin);
		components.Add(inputTypeMatchRule2);
		components.Add(elementIdMatchRule3);
		components.Add(ACMEtxtUserName);
		components.Add(inputTypeMatchRule1);
		components.Add(attributeMatchRule1);
		components.Add(ACMEtxtPassword);
		components.Add(inputTypeMatchRule3);
		components.Add(elementIdMatchRule2);
		components.Add(ACMElblVersion);
		components.Add(inputTypeMatchRule6);
		components.Add(inputNameMatchRule1);
		components.Add(formActionMatchRule1);
		// 
		// Result
		// 
		return ACMEfrmCredentials;
	}
	
	internal OpenSpan.Adapters.Web.Controls.Button Create_ACMEbtnSignin(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.Button ACMEbtnSignin = new OpenSpan.Adapters.Web.Controls.Button();
		this.SetId(ACMEbtnSignin, new OpenSpan.Design.ComponentIdentity("Button-8D60375F99A1A32"));
		ACMEbtnSignin.ElementId = "login_button";
		ACMEbtnSignin.Extender = null;
		ACMEbtnSignin.ForwardObjectExplorerEvent = true;
		ACMEbtnSignin.MatchingIndex = 2;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule2;
		inputTypeMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule2
		// 
		inputTypeMatchRule2.Type = OpenSpan.Adapters.Web.InputType.Submit;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule3;
		elementIdMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule3
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "login_button";
		elementIdMatchRule3.Text = textmatchdata1;
		ACMEbtnSignin.MatchRules.Add(inputTypeMatchRule2);
		ACMEbtnSignin.MatchRules.Add(elementIdMatchRule3);
		ACMEbtnSignin.Name = "ACMEbtnSignin";
		ACMEbtnSignin.TagName = "INPUT";
		ACMEbtnSignin.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputSubmitElement, OpenSpan.Adapters.Web";
		ACMEbtnSignin.UseElementId = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(inputTypeMatchRule2, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60375F9A2D758"));
		this.SetId(elementIdMatchRule3, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60375F9A8C390"));
		// 
		// Add components
		// 
		components.Add(inputTypeMatchRule2);
		components.Add(elementIdMatchRule3);
		// 
		// Result
		// 
		return ACMEbtnSignin;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule Create_inputTypeMatchRule2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.SetId(inputTypeMatchRule2, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60375F9A2D758"));
		inputTypeMatchRule2.Type = OpenSpan.Adapters.Web.InputType.Submit;
		// 
		// Result
		// 
		return inputTypeMatchRule2;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule Create_elementIdMatchRule3(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.SetId(elementIdMatchRule3, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60375F9A8C390"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "login_button";
		elementIdMatchRule3.Text = textmatchdata1;
		// 
		// Result
		// 
		return elementIdMatchRule3;
	}
	
	internal OpenSpan.Adapters.Web.Controls.TextBox Create_ACMEtxtUserName(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.TextBox ACMEtxtUserName = new OpenSpan.Adapters.Web.Controls.TextBox();
		this.SetId(ACMEtxtUserName, new OpenSpan.Design.ComponentIdentity("TextBox-8D6037673EE53C6"));
		ACMEtxtUserName.ElementId = "user_name";
		ACMEtxtUserName.Extender = null;
		ACMEtxtUserName.ForwardObjectExplorerEvent = true;
		ACMEtxtUserName.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule1;
		inputTypeMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule1
		// 
		inputTypeMatchRule1.Type = OpenSpan.Adapters.Web.InputType.Text;
		OpenSpan.Adapters.Web.MatchRules.AttributeMatchRule attributeMatchRule1;
		attributeMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.AttributeMatchRule();
		// 
		// attributeMatchRule1
		// 
		attributeMatchRule1.Attribute = "name";
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "user_name";
		attributeMatchRule1.Text = textmatchdata1;
		ACMEtxtUserName.MatchRules.Add(inputTypeMatchRule1);
		ACMEtxtUserName.MatchRules.Add(attributeMatchRule1);
		ACMEtxtUserName.Name = "ACMEtxtUserName";
		ACMEtxtUserName.TagName = "INPUT";
		ACMEtxtUserName.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputTextElement, OpenSpan.Adapters.Web";
		ACMEtxtUserName.UseElementId = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(inputTypeMatchRule1, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D6037673F79509"));
		this.SetId(attributeMatchRule1, new OpenSpan.Design.ComponentIdentity("AttributeMatchRule-8D606A0B1280F1A"));
		// 
		// Add components
		// 
		components.Add(inputTypeMatchRule1);
		components.Add(attributeMatchRule1);
		// 
		// Result
		// 
		return ACMEtxtUserName;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule Create_inputTypeMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.SetId(inputTypeMatchRule1, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D6037673F79509"));
		inputTypeMatchRule1.Type = OpenSpan.Adapters.Web.InputType.Text;
		// 
		// Result
		// 
		return inputTypeMatchRule1;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.AttributeMatchRule Create_attributeMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.AttributeMatchRule attributeMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.AttributeMatchRule();
		this.SetId(attributeMatchRule1, new OpenSpan.Design.ComponentIdentity("AttributeMatchRule-8D606A0B1280F1A"));
		attributeMatchRule1.Attribute = "name";
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "user_name";
		attributeMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return attributeMatchRule1;
	}
	
	internal OpenSpan.Adapters.Web.Controls.TextBox Create_ACMEtxtPassword(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.TextBox ACMEtxtPassword = new OpenSpan.Adapters.Web.Controls.TextBox();
		this.SetId(ACMEtxtPassword, new OpenSpan.Design.ComponentIdentity("TextBox-8D60376773446F4"));
		ACMEtxtPassword.ElementId = "user_pass";
		ACMEtxtPassword.Extender = null;
		ACMEtxtPassword.ForwardObjectExplorerEvent = true;
		ACMEtxtPassword.MatchingIndex = 1;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule3;
		inputTypeMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule3
		// 
		inputTypeMatchRule3.Type = OpenSpan.Adapters.Web.InputType.Password;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule2;
		elementIdMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule2
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "user_pass";
		elementIdMatchRule2.Text = textmatchdata1;
		ACMEtxtPassword.MatchRules.Add(inputTypeMatchRule3);
		ACMEtxtPassword.MatchRules.Add(elementIdMatchRule2);
		ACMEtxtPassword.Name = "ACMEtxtPassword";
		ACMEtxtPassword.TagName = "INPUT";
		ACMEtxtPassword.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputPasswordElement, OpenSpan.Adapters.Web";
		ACMEtxtPassword.UseElementId = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(inputTypeMatchRule3, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60376773E0072"));
		this.SetId(elementIdMatchRule2, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D603767743D0BD"));
		// 
		// Add components
		// 
		components.Add(inputTypeMatchRule3);
		components.Add(elementIdMatchRule2);
		// 
		// Result
		// 
		return ACMEtxtPassword;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule Create_inputTypeMatchRule3(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.SetId(inputTypeMatchRule3, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60376773E0072"));
		inputTypeMatchRule3.Type = OpenSpan.Adapters.Web.InputType.Password;
		// 
		// Result
		// 
		return inputTypeMatchRule3;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule Create_elementIdMatchRule2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.SetId(elementIdMatchRule2, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D603767743D0BD"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "user_pass";
		elementIdMatchRule2.Text = textmatchdata1;
		// 
		// Result
		// 
		return elementIdMatchRule2;
	}
	
	internal OpenSpan.Adapters.Web.Controls.HiddenField Create_ACMElblVersion(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.HiddenField ACMElblVersion = new OpenSpan.Adapters.Web.Controls.HiddenField();
		this.SetId(ACMElblVersion, new OpenSpan.Design.ComponentIdentity("HiddenField-8D60687B4A0E5E5"));
		ACMElblVersion.ElementId = null;
		ACMElblVersion.Extender = null;
		ACMElblVersion.ForwardObjectExplorerEvent = true;
		ACMElblVersion.MatchingIndex = 3;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule6;
		inputTypeMatchRule6 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule6
		// 
		inputTypeMatchRule6.Type = OpenSpan.Adapters.Web.InputType.Hidden;
		OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule inputNameMatchRule1;
		inputNameMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule();
		// 
		// inputNameMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "pegasystem_version";
		inputNameMatchRule1.Text = textmatchdata1;
		ACMElblVersion.MatchRules.Add(inputTypeMatchRule6);
		ACMElblVersion.MatchRules.Add(inputNameMatchRule1);
		ACMElblVersion.Name = "ACMElblVersion";
		ACMElblVersion.TagName = "INPUT";
		ACMElblVersion.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputHiddenElement, OpenSpan.Adapters.Web";
		ACMElblVersion.UseElementId = false;
		// 
		// Set designComp Ids
		// 
		this.SetId(inputTypeMatchRule6, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60687B4AA0D4B"));
		this.SetId(inputNameMatchRule1, new OpenSpan.Design.ComponentIdentity("InputNameMatchRule-8D60687B4AF7BB0"));
		// 
		// Add components
		// 
		components.Add(inputTypeMatchRule6);
		components.Add(inputNameMatchRule1);
		// 
		// Result
		// 
		return ACMElblVersion;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule Create_inputTypeMatchRule6(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule6 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.SetId(inputTypeMatchRule6, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60687B4AA0D4B"));
		inputTypeMatchRule6.Type = OpenSpan.Adapters.Web.InputType.Hidden;
		// 
		// Result
		// 
		return inputTypeMatchRule6;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule Create_inputNameMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule inputNameMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InputNameMatchRule();
		this.SetId(inputNameMatchRule1, new OpenSpan.Design.ComponentIdentity("InputNameMatchRule-8D60687B4AF7BB0"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "pegasystem_version";
		inputNameMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return inputNameMatchRule1;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.FormActionMatchRule Create_formActionMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.FormActionMatchRule formActionMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.FormActionMatchRule();
		this.SetId(formActionMatchRule1, new OpenSpan.Design.ComponentIdentity("FormActionMatchRule-8D60375DADE86B7"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		formActionMatchRule1.Fragment = textmatchdata1;
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "training.openspan.com";
		formActionMatchRule1.Host = textmatchdata2;
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "/home";
		formActionMatchRule1.Path = textmatchdata3;
		formActionMatchRule1.Port = 80;
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		formActionMatchRule1.Query = textmatchdata4;
		OpenSpan.Adapters.TextMatchData textmatchdata5 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata5.Text = "http";
		formActionMatchRule1.Scheme = textmatchdata5;
		// 
		// Result
		// 
		return formActionMatchRule1;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule Create_documentUrlMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule documentUrlMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule();
		this.SetId(documentUrlMatchRule1, new OpenSpan.Design.ComponentIdentity("DocumentUrlMatchRule-8D60375DACFFDE5"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule1.Fragment = textmatchdata1;
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "training.openspan.com";
		documentUrlMatchRule1.Host = textmatchdata2;
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "/login";
		documentUrlMatchRule1.Path = textmatchdata3;
		documentUrlMatchRule1.Port = 80;
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule1.Query = textmatchdata4;
		OpenSpan.Adapters.TextMatchData textmatchdata5 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata5.Text = "http";
		documentUrlMatchRule1.Scheme = textmatchdata5;
		// 
		// Result
		// 
		return documentUrlMatchRule1;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule Create_documentTitleMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule documentTitleMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule();
		this.SetId(documentTitleMatchRule1, new OpenSpan.Design.ComponentIdentity("DocumentTitleMatchRule-8D60375DAD57FE1"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "Sign In | Pega Studio Training Web Application";
		documentTitleMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return documentTitleMatchRule1;
	}
	
	internal OpenSpan.Adapters.Web.Controls.WebPage Create_ACMEwpHome(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.WebPage ACMEwpHome = new OpenSpan.Adapters.Web.Controls.WebPage();
		this.SetId(ACMEwpHome, new OpenSpan.Design.ComponentIdentity("WebPage-8D60376ACF65820"));
		OpenSpan.Adapters.Web.Controls.WebControl ACMENewsAlert;
		ACMENewsAlert = new OpenSpan.Adapters.Web.Controls.WebControl();
		// 
		// ACMENewsAlert
		// 
		ACMENewsAlert.ElementId = null;
		ACMENewsAlert.Extender = null;
		ACMENewsAlert.ForwardObjectExplorerEvent = true;
		ACMENewsAlert.MatchingIndex = 2;
		OpenSpan.Adapters.Web.MatchRules.ElementIndexMatchRule elementIndexMatchRule1;
		elementIndexMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.ElementIndexMatchRule();
		// 
		// elementIndexMatchRule1
		// 
		elementIndexMatchRule1.Index = 2;
		ACMENewsAlert.MatchRules.Add(elementIndexMatchRule1);
		ACMENewsAlert.Name = "ACMENewsAlert";
		ACMENewsAlert.TagName = "P";
		ACMENewsAlert.TargetTypeString = "OpenSpan.Adapters.Web.HtmlElement, OpenSpan.Adapters.Web";
		ACMENewsAlert.UseElementId = false;
		OpenSpan.Adapters.Web.Controls.Link ACMElnkStores;
		ACMElnkStores = new OpenSpan.Adapters.Web.Controls.Link();
		// 
		// ACMElnkStores
		// 
		ACMElnkStores.ElementId = null;
		ACMElnkStores.Extender = null;
		ACMElnkStores.ForwardObjectExplorerEvent = true;
		ACMElnkStores.MatchingIndex = 20;
		OpenSpan.Adapters.Web.MatchRules.InnerTextMatchRule innerTextMatchRule1;
		innerTextMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InnerTextMatchRule();
		// 
		// innerTextMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "Stores";
		innerTextMatchRule1.Text = textmatchdata1;
		ACMElnkStores.MatchRules.Add(innerTextMatchRule1);
		ACMElnkStores.Name = "ACMElnkStores";
		ACMElnkStores.TagName = "A";
		ACMElnkStores.TargetTypeString = "OpenSpan.Adapters.Web.HtmlAnchorElement, OpenSpan.Adapters.Web";
		ACMElnkStores.UseElementId = false;
		ACMEwpHome.Controls.Add(ACMENewsAlert);
		ACMEwpHome.Controls.Add(ACMElnkStores);
		ACMEwpHome.Extender = null;
		ACMEwpHome.ForwardObjectExplorerEvent = true;
		ACMEwpHome.IsGlobal = true;
		ACMEwpHome.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule documentUrlMatchRule2;
		documentUrlMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule();
		// 
		// documentUrlMatchRule2
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule2.Fragment = textmatchdata2;
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "training.openspan.com";
		documentUrlMatchRule2.Host = textmatchdata3;
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata4.Text = "/home";
		documentUrlMatchRule2.Path = textmatchdata4;
		documentUrlMatchRule2.Port = 80;
		OpenSpan.Adapters.TextMatchData textmatchdata5 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule2.Query = textmatchdata5;
		OpenSpan.Adapters.TextMatchData textmatchdata6 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata6.Text = "http";
		documentUrlMatchRule2.Scheme = textmatchdata6;
		OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule documentTitleMatchRule2;
		documentTitleMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule();
		// 
		// documentTitleMatchRule2
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata7 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata7.Text = "Home | Pega Studio Training Web Application";
		documentTitleMatchRule2.Text = textmatchdata7;
		ACMEwpHome.MatchRules.Add(documentUrlMatchRule2);
		ACMEwpHome.MatchRules.Add(documentTitleMatchRule2);
		ACMEwpHome.Name = "ACMEwpHome";
		ACMEwpHome.TargetTypeString = "OpenSpan.Adapters.Web.HtmlDocument, OpenSpan.Adapters.Web";
		// 
		// Set designComp Ids
		// 
		this.SetId(ACMENewsAlert, new OpenSpan.Design.ComponentIdentity("WebControl-8D606A37B633563"));
		this.SetId(elementIndexMatchRule1, new OpenSpan.Design.ComponentIdentity("ElementIndexMatchRule-8D606A3D27BEEE2"));
		this.SetId(ACMElnkStores, new OpenSpan.Design.ComponentIdentity("Link-8D60759691DE487"));
		this.SetId(innerTextMatchRule1, new OpenSpan.Design.ComponentIdentity("InnerTextMatchRule-8D60759692BD0BA"));
		this.SetId(documentUrlMatchRule2, new OpenSpan.Design.ComponentIdentity("DocumentUrlMatchRule-8D60376ACFCBE85"));
		this.SetId(documentTitleMatchRule2, new OpenSpan.Design.ComponentIdentity("DocumentTitleMatchRule-8D60376AD01CA8C"));
		// 
		// Add components
		// 
		components.Add(ACMENewsAlert);
		components.Add(elementIndexMatchRule1);
		components.Add(ACMElnkStores);
		components.Add(innerTextMatchRule1);
		components.Add(documentUrlMatchRule2);
		components.Add(documentTitleMatchRule2);
		// 
		// Result
		// 
		return ACMEwpHome;
	}
	
	internal OpenSpan.Adapters.Web.Controls.WebControl Create_ACMENewsAlert(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.WebControl ACMENewsAlert = new OpenSpan.Adapters.Web.Controls.WebControl();
		this.SetId(ACMENewsAlert, new OpenSpan.Design.ComponentIdentity("WebControl-8D606A37B633563"));
		ACMENewsAlert.ElementId = null;
		ACMENewsAlert.Extender = null;
		ACMENewsAlert.ForwardObjectExplorerEvent = true;
		ACMENewsAlert.MatchingIndex = 2;
		OpenSpan.Adapters.Web.MatchRules.ElementIndexMatchRule elementIndexMatchRule1;
		elementIndexMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.ElementIndexMatchRule();
		// 
		// elementIndexMatchRule1
		// 
		elementIndexMatchRule1.Index = 2;
		ACMENewsAlert.MatchRules.Add(elementIndexMatchRule1);
		ACMENewsAlert.Name = "ACMENewsAlert";
		ACMENewsAlert.TagName = "P";
		ACMENewsAlert.TargetTypeString = "OpenSpan.Adapters.Web.HtmlElement, OpenSpan.Adapters.Web";
		ACMENewsAlert.UseElementId = false;
		// 
		// Set designComp Ids
		// 
		this.SetId(elementIndexMatchRule1, new OpenSpan.Design.ComponentIdentity("ElementIndexMatchRule-8D606A3D27BEEE2"));
		// 
		// Add components
		// 
		components.Add(elementIndexMatchRule1);
		// 
		// Result
		// 
		return ACMENewsAlert;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.ElementIndexMatchRule Create_elementIndexMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.ElementIndexMatchRule elementIndexMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.ElementIndexMatchRule();
		this.SetId(elementIndexMatchRule1, new OpenSpan.Design.ComponentIdentity("ElementIndexMatchRule-8D606A3D27BEEE2"));
		elementIndexMatchRule1.Index = 2;
		// 
		// Result
		// 
		return elementIndexMatchRule1;
	}
	
	internal OpenSpan.Adapters.Web.Controls.Link Create_ACMElnkStores(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.Link ACMElnkStores = new OpenSpan.Adapters.Web.Controls.Link();
		this.SetId(ACMElnkStores, new OpenSpan.Design.ComponentIdentity("Link-8D60759691DE487"));
		ACMElnkStores.ElementId = null;
		ACMElnkStores.Extender = null;
		ACMElnkStores.ForwardObjectExplorerEvent = true;
		ACMElnkStores.MatchingIndex = 20;
		OpenSpan.Adapters.Web.MatchRules.InnerTextMatchRule innerTextMatchRule1;
		innerTextMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InnerTextMatchRule();
		// 
		// innerTextMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "Stores";
		innerTextMatchRule1.Text = textmatchdata1;
		ACMElnkStores.MatchRules.Add(innerTextMatchRule1);
		ACMElnkStores.Name = "ACMElnkStores";
		ACMElnkStores.TagName = "A";
		ACMElnkStores.TargetTypeString = "OpenSpan.Adapters.Web.HtmlAnchorElement, OpenSpan.Adapters.Web";
		ACMElnkStores.UseElementId = false;
		// 
		// Set designComp Ids
		// 
		this.SetId(innerTextMatchRule1, new OpenSpan.Design.ComponentIdentity("InnerTextMatchRule-8D60759692BD0BA"));
		// 
		// Add components
		// 
		components.Add(innerTextMatchRule1);
		// 
		// Result
		// 
		return ACMElnkStores;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.InnerTextMatchRule Create_innerTextMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.InnerTextMatchRule innerTextMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.InnerTextMatchRule();
		this.SetId(innerTextMatchRule1, new OpenSpan.Design.ComponentIdentity("InnerTextMatchRule-8D60759692BD0BA"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "Stores";
		innerTextMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return innerTextMatchRule1;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule Create_documentUrlMatchRule2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule documentUrlMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule();
		this.SetId(documentUrlMatchRule2, new OpenSpan.Design.ComponentIdentity("DocumentUrlMatchRule-8D60376ACFCBE85"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule2.Fragment = textmatchdata1;
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "training.openspan.com";
		documentUrlMatchRule2.Host = textmatchdata2;
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "/home";
		documentUrlMatchRule2.Path = textmatchdata3;
		documentUrlMatchRule2.Port = 80;
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule2.Query = textmatchdata4;
		OpenSpan.Adapters.TextMatchData textmatchdata5 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata5.Text = "http";
		documentUrlMatchRule2.Scheme = textmatchdata5;
		// 
		// Result
		// 
		return documentUrlMatchRule2;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule Create_documentTitleMatchRule2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule documentTitleMatchRule2 = new OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule();
		this.SetId(documentTitleMatchRule2, new OpenSpan.Design.ComponentIdentity("DocumentTitleMatchRule-8D60376AD01CA8C"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "Home | Pega Studio Training Web Application";
		documentTitleMatchRule2.Text = textmatchdata1;
		// 
		// Result
		// 
		return documentTitleMatchRule2;
	}
	
	internal OpenSpan.Adapters.Web.Controls.WebPage Create_ACMEwpStores(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.WebPage ACMEwpStores = new OpenSpan.Adapters.Web.Controls.WebPage();
		this.SetId(ACMEwpStores, new OpenSpan.Design.ComponentIdentity("WebPage-8D60376C9808448"));
		OpenSpan.Adapters.Web.Controls.Form ACMEfrmSearch;
		ACMEfrmSearch = new OpenSpan.Adapters.Web.Controls.Form();
		// 
		// ACMEfrmSearch
		// 
		OpenSpan.Adapters.Web.Controls.TextBox ACMEtxtZip;
		ACMEtxtZip = new OpenSpan.Adapters.Web.Controls.TextBox();
		// 
		// ACMEtxtZip
		// 
		ACMEtxtZip.ElementId = "txtZip";
		ACMEtxtZip.Extender = null;
		ACMEtxtZip.ForwardObjectExplorerEvent = true;
		ACMEtxtZip.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule4;
		inputTypeMatchRule4 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule4
		// 
		inputTypeMatchRule4.Type = OpenSpan.Adapters.Web.InputType.Text;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule6;
		elementIdMatchRule6 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule6
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "txtZip";
		elementIdMatchRule6.Text = textmatchdata1;
		ACMEtxtZip.MatchRules.Add(inputTypeMatchRule4);
		ACMEtxtZip.MatchRules.Add(elementIdMatchRule6);
		ACMEtxtZip.Name = "ACMEtxtZip";
		ACMEtxtZip.TagName = "INPUT";
		ACMEtxtZip.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputTextElement, OpenSpan.Adapters.Web";
		ACMEtxtZip.UseElementId = true;
		OpenSpan.Adapters.Web.Controls.Button ACMEbtnFindStore;
		ACMEbtnFindStore = new OpenSpan.Adapters.Web.Controls.Button();
		// 
		// ACMEbtnFindStore
		// 
		ACMEbtnFindStore.ElementId = "submit_find";
		ACMEbtnFindStore.Extender = null;
		ACMEbtnFindStore.ForwardObjectExplorerEvent = true;
		ACMEbtnFindStore.MatchingIndex = 2;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule5;
		inputTypeMatchRule5 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule5
		// 
		inputTypeMatchRule5.Type = OpenSpan.Adapters.Web.InputType.Submit;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule7;
		elementIdMatchRule7 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule7
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "submit_find";
		elementIdMatchRule7.Text = textmatchdata2;
		ACMEbtnFindStore.MatchRules.Add(inputTypeMatchRule5);
		ACMEbtnFindStore.MatchRules.Add(elementIdMatchRule7);
		ACMEbtnFindStore.Name = "ACMEbtnFindStore";
		ACMEbtnFindStore.TagName = "INPUT";
		ACMEbtnFindStore.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputSubmitElement, OpenSpan.Adapters.Web";
		ACMEbtnFindStore.UseElementId = true;
		ACMEfrmSearch.Controls.Add(ACMEtxtZip);
		ACMEfrmSearch.Controls.Add(ACMEbtnFindStore);
		ACMEfrmSearch.ElementId = "form1";
		ACMEfrmSearch.Extender = null;
		ACMEfrmSearch.ForwardObjectExplorerEvent = true;
		ACMEfrmSearch.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule5;
		elementIdMatchRule5 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule5
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "form1";
		elementIdMatchRule5.Text = textmatchdata3;
		ACMEfrmSearch.MatchRules.Add(elementIdMatchRule5);
		ACMEfrmSearch.Name = "ACMEfrmSearch";
		ACMEfrmSearch.TagName = "FORM";
		ACMEfrmSearch.TargetTypeString = "OpenSpan.Adapters.Web.HtmlFormElement, OpenSpan.Adapters.Web";
		ACMEfrmSearch.UseElementId = true;
		OpenSpan.Adapters.Web.Controls.WebControl Stores_Store_Listing;
		Stores_Store_Listing = new OpenSpan.Adapters.Web.Controls.WebControl();
		// 
		// Stores_Store_Listing
		// 
		Stores_Store_Listing.ElementId = "store_menu";
		Stores_Store_Listing.Extender = null;
		Stores_Store_Listing.ForwardObjectExplorerEvent = true;
		Stores_Store_Listing.MatchingIndex = 6;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule1;
		elementIdMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata4.Text = "store_menu";
		elementIdMatchRule1.Text = textmatchdata4;
		Stores_Store_Listing.MatchRules.Add(elementIdMatchRule1);
		Stores_Store_Listing.Name = "Stores_Store_Listing";
		Stores_Store_Listing.TagName = "LI";
		Stores_Store_Listing.TargetTypeString = "OpenSpan.Adapters.Web.HtmlElement, OpenSpan.Adapters.Web";
		Stores_Store_Listing.UseElementId = true;
		ACMEwpStores.Controls.Add(ACMEfrmSearch);
		ACMEwpStores.Controls.Add(Stores_Store_Listing);
		ACMEwpStores.Extender = null;
		ACMEwpStores.ForwardObjectExplorerEvent = true;
		ACMEwpStores.IsGlobal = true;
		ACMEwpStores.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule documentUrlMatchRule3;
		documentUrlMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule();
		// 
		// documentUrlMatchRule3
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata5 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule3.Fragment = textmatchdata5;
		OpenSpan.Adapters.TextMatchData textmatchdata6 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata6.Text = "training.openspan.com";
		documentUrlMatchRule3.Host = textmatchdata6;
		OpenSpan.Adapters.TextMatchData textmatchdata7 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata7.Text = "/store_locator";
		documentUrlMatchRule3.Path = textmatchdata7;
		documentUrlMatchRule3.Port = 80;
		OpenSpan.Adapters.TextMatchData textmatchdata8 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule3.Query = textmatchdata8;
		OpenSpan.Adapters.TextMatchData textmatchdata9 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata9.Text = "http";
		documentUrlMatchRule3.Scheme = textmatchdata9;
		OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule documentTitleMatchRule3;
		documentTitleMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule();
		// 
		// documentTitleMatchRule3
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata10 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata10.Text = "Stores | Pega Studio Training Web Application";
		documentTitleMatchRule3.Text = textmatchdata10;
		ACMEwpStores.MatchRules.Add(documentUrlMatchRule3);
		ACMEwpStores.MatchRules.Add(documentTitleMatchRule3);
		ACMEwpStores.Name = "ACMEwpStores";
		ACMEwpStores.TargetTypeString = "OpenSpan.Adapters.Web.HtmlDocument, OpenSpan.Adapters.Web";
		// 
		// Set designComp Ids
		// 
		this.SetId(ACMEfrmSearch, new OpenSpan.Design.ComponentIdentity("Form-8D60376C97A3E68"));
		this.SetId(ACMEtxtZip, new OpenSpan.Design.ComponentIdentity("TextBox-8D60376C973831A"));
		this.SetId(inputTypeMatchRule4, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60376C99DAE3B"));
		this.SetId(elementIdMatchRule6, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60376C9A5063B"));
		this.SetId(ACMEbtnFindStore, new OpenSpan.Design.ComponentIdentity("Button-8D60376CB53752D"));
		this.SetId(inputTypeMatchRule5, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60376CB5B9886"));
		this.SetId(elementIdMatchRule7, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60376CB61DE5D"));
		this.SetId(elementIdMatchRule5, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60376C9952B9E"));
		this.SetId(Stores_Store_Listing, new OpenSpan.Design.ComponentIdentity("WebControl-8D607584308FAAA"));
		this.SetId(elementIdMatchRule1, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D607584316A959"));
		this.SetId(documentUrlMatchRule3, new OpenSpan.Design.ComponentIdentity("DocumentUrlMatchRule-8D60376C9871857"));
		this.SetId(documentTitleMatchRule3, new OpenSpan.Design.ComponentIdentity("DocumentTitleMatchRule-8D60376C98C7330"));
		// 
		// Add components
		// 
		components.Add(ACMEfrmSearch);
		components.Add(ACMEtxtZip);
		components.Add(inputTypeMatchRule4);
		components.Add(elementIdMatchRule6);
		components.Add(ACMEbtnFindStore);
		components.Add(inputTypeMatchRule5);
		components.Add(elementIdMatchRule7);
		components.Add(elementIdMatchRule5);
		components.Add(Stores_Store_Listing);
		components.Add(elementIdMatchRule1);
		components.Add(documentUrlMatchRule3);
		components.Add(documentTitleMatchRule3);
		// 
		// Result
		// 
		return ACMEwpStores;
	}
	
	internal OpenSpan.Adapters.Web.Controls.Form Create_ACMEfrmSearch(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.Form ACMEfrmSearch = new OpenSpan.Adapters.Web.Controls.Form();
		this.SetId(ACMEfrmSearch, new OpenSpan.Design.ComponentIdentity("Form-8D60376C97A3E68"));
		OpenSpan.Adapters.Web.Controls.TextBox ACMEtxtZip;
		ACMEtxtZip = new OpenSpan.Adapters.Web.Controls.TextBox();
		// 
		// ACMEtxtZip
		// 
		ACMEtxtZip.ElementId = "txtZip";
		ACMEtxtZip.Extender = null;
		ACMEtxtZip.ForwardObjectExplorerEvent = true;
		ACMEtxtZip.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule4;
		inputTypeMatchRule4 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule4
		// 
		inputTypeMatchRule4.Type = OpenSpan.Adapters.Web.InputType.Text;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule6;
		elementIdMatchRule6 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule6
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "txtZip";
		elementIdMatchRule6.Text = textmatchdata1;
		ACMEtxtZip.MatchRules.Add(inputTypeMatchRule4);
		ACMEtxtZip.MatchRules.Add(elementIdMatchRule6);
		ACMEtxtZip.Name = "ACMEtxtZip";
		ACMEtxtZip.TagName = "INPUT";
		ACMEtxtZip.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputTextElement, OpenSpan.Adapters.Web";
		ACMEtxtZip.UseElementId = true;
		OpenSpan.Adapters.Web.Controls.Button ACMEbtnFindStore;
		ACMEbtnFindStore = new OpenSpan.Adapters.Web.Controls.Button();
		// 
		// ACMEbtnFindStore
		// 
		ACMEbtnFindStore.ElementId = "submit_find";
		ACMEbtnFindStore.Extender = null;
		ACMEbtnFindStore.ForwardObjectExplorerEvent = true;
		ACMEbtnFindStore.MatchingIndex = 2;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule5;
		inputTypeMatchRule5 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule5
		// 
		inputTypeMatchRule5.Type = OpenSpan.Adapters.Web.InputType.Submit;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule7;
		elementIdMatchRule7 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule7
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "submit_find";
		elementIdMatchRule7.Text = textmatchdata2;
		ACMEbtnFindStore.MatchRules.Add(inputTypeMatchRule5);
		ACMEbtnFindStore.MatchRules.Add(elementIdMatchRule7);
		ACMEbtnFindStore.Name = "ACMEbtnFindStore";
		ACMEbtnFindStore.TagName = "INPUT";
		ACMEbtnFindStore.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputSubmitElement, OpenSpan.Adapters.Web";
		ACMEbtnFindStore.UseElementId = true;
		ACMEfrmSearch.Controls.Add(ACMEtxtZip);
		ACMEfrmSearch.Controls.Add(ACMEbtnFindStore);
		ACMEfrmSearch.ElementId = "form1";
		ACMEfrmSearch.Extender = null;
		ACMEfrmSearch.ForwardObjectExplorerEvent = true;
		ACMEfrmSearch.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule5;
		elementIdMatchRule5 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule5
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "form1";
		elementIdMatchRule5.Text = textmatchdata3;
		ACMEfrmSearch.MatchRules.Add(elementIdMatchRule5);
		ACMEfrmSearch.Name = "ACMEfrmSearch";
		ACMEfrmSearch.TagName = "FORM";
		ACMEfrmSearch.TargetTypeString = "OpenSpan.Adapters.Web.HtmlFormElement, OpenSpan.Adapters.Web";
		ACMEfrmSearch.UseElementId = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(ACMEtxtZip, new OpenSpan.Design.ComponentIdentity("TextBox-8D60376C973831A"));
		this.SetId(inputTypeMatchRule4, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60376C99DAE3B"));
		this.SetId(elementIdMatchRule6, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60376C9A5063B"));
		this.SetId(ACMEbtnFindStore, new OpenSpan.Design.ComponentIdentity("Button-8D60376CB53752D"));
		this.SetId(inputTypeMatchRule5, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60376CB5B9886"));
		this.SetId(elementIdMatchRule7, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60376CB61DE5D"));
		this.SetId(elementIdMatchRule5, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60376C9952B9E"));
		// 
		// Add components
		// 
		components.Add(ACMEtxtZip);
		components.Add(inputTypeMatchRule4);
		components.Add(elementIdMatchRule6);
		components.Add(ACMEbtnFindStore);
		components.Add(inputTypeMatchRule5);
		components.Add(elementIdMatchRule7);
		components.Add(elementIdMatchRule5);
		// 
		// Result
		// 
		return ACMEfrmSearch;
	}
	
	internal OpenSpan.Adapters.Web.Controls.TextBox Create_ACMEtxtZip(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.TextBox ACMEtxtZip = new OpenSpan.Adapters.Web.Controls.TextBox();
		this.SetId(ACMEtxtZip, new OpenSpan.Design.ComponentIdentity("TextBox-8D60376C973831A"));
		ACMEtxtZip.ElementId = "txtZip";
		ACMEtxtZip.Extender = null;
		ACMEtxtZip.ForwardObjectExplorerEvent = true;
		ACMEtxtZip.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule4;
		inputTypeMatchRule4 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule4
		// 
		inputTypeMatchRule4.Type = OpenSpan.Adapters.Web.InputType.Text;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule6;
		elementIdMatchRule6 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule6
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "txtZip";
		elementIdMatchRule6.Text = textmatchdata1;
		ACMEtxtZip.MatchRules.Add(inputTypeMatchRule4);
		ACMEtxtZip.MatchRules.Add(elementIdMatchRule6);
		ACMEtxtZip.Name = "ACMEtxtZip";
		ACMEtxtZip.TagName = "INPUT";
		ACMEtxtZip.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputTextElement, OpenSpan.Adapters.Web";
		ACMEtxtZip.UseElementId = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(inputTypeMatchRule4, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60376C99DAE3B"));
		this.SetId(elementIdMatchRule6, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60376C9A5063B"));
		// 
		// Add components
		// 
		components.Add(inputTypeMatchRule4);
		components.Add(elementIdMatchRule6);
		// 
		// Result
		// 
		return ACMEtxtZip;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule Create_inputTypeMatchRule4(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule4 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.SetId(inputTypeMatchRule4, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60376C99DAE3B"));
		inputTypeMatchRule4.Type = OpenSpan.Adapters.Web.InputType.Text;
		// 
		// Result
		// 
		return inputTypeMatchRule4;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule Create_elementIdMatchRule6(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule6 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.SetId(elementIdMatchRule6, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60376C9A5063B"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "txtZip";
		elementIdMatchRule6.Text = textmatchdata1;
		// 
		// Result
		// 
		return elementIdMatchRule6;
	}
	
	internal OpenSpan.Adapters.Web.Controls.Button Create_ACMEbtnFindStore(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.Button ACMEbtnFindStore = new OpenSpan.Adapters.Web.Controls.Button();
		this.SetId(ACMEbtnFindStore, new OpenSpan.Design.ComponentIdentity("Button-8D60376CB53752D"));
		ACMEbtnFindStore.ElementId = "submit_find";
		ACMEbtnFindStore.Extender = null;
		ACMEbtnFindStore.ForwardObjectExplorerEvent = true;
		ACMEbtnFindStore.MatchingIndex = 2;
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule5;
		inputTypeMatchRule5 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		// 
		// inputTypeMatchRule5
		// 
		inputTypeMatchRule5.Type = OpenSpan.Adapters.Web.InputType.Submit;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule7;
		elementIdMatchRule7 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule7
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "submit_find";
		elementIdMatchRule7.Text = textmatchdata1;
		ACMEbtnFindStore.MatchRules.Add(inputTypeMatchRule5);
		ACMEbtnFindStore.MatchRules.Add(elementIdMatchRule7);
		ACMEbtnFindStore.Name = "ACMEbtnFindStore";
		ACMEbtnFindStore.TagName = "INPUT";
		ACMEbtnFindStore.TargetTypeString = "OpenSpan.Adapters.Web.HtmlInputSubmitElement, OpenSpan.Adapters.Web";
		ACMEbtnFindStore.UseElementId = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(inputTypeMatchRule5, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60376CB5B9886"));
		this.SetId(elementIdMatchRule7, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60376CB61DE5D"));
		// 
		// Add components
		// 
		components.Add(inputTypeMatchRule5);
		components.Add(elementIdMatchRule7);
		// 
		// Result
		// 
		return ACMEbtnFindStore;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule Create_inputTypeMatchRule5(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule inputTypeMatchRule5 = new OpenSpan.Adapters.Web.MatchRules.InputTypeMatchRule();
		this.SetId(inputTypeMatchRule5, new OpenSpan.Design.ComponentIdentity("InputTypeMatchRule-8D60376CB5B9886"));
		inputTypeMatchRule5.Type = OpenSpan.Adapters.Web.InputType.Submit;
		// 
		// Result
		// 
		return inputTypeMatchRule5;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule Create_elementIdMatchRule7(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule7 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.SetId(elementIdMatchRule7, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60376CB61DE5D"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "submit_find";
		elementIdMatchRule7.Text = textmatchdata1;
		// 
		// Result
		// 
		return elementIdMatchRule7;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule Create_elementIdMatchRule5(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule5 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.SetId(elementIdMatchRule5, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60376C9952B9E"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "form1";
		elementIdMatchRule5.Text = textmatchdata1;
		// 
		// Result
		// 
		return elementIdMatchRule5;
	}
	
	internal OpenSpan.Adapters.Web.Controls.WebControl Create_Stores_Store_Listing(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.WebControl Stores_Store_Listing = new OpenSpan.Adapters.Web.Controls.WebControl();
		this.SetId(Stores_Store_Listing, new OpenSpan.Design.ComponentIdentity("WebControl-8D607584308FAAA"));
		Stores_Store_Listing.ElementId = "store_menu";
		Stores_Store_Listing.Extender = null;
		Stores_Store_Listing.ForwardObjectExplorerEvent = true;
		Stores_Store_Listing.MatchingIndex = 6;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule1;
		elementIdMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "store_menu";
		elementIdMatchRule1.Text = textmatchdata1;
		Stores_Store_Listing.MatchRules.Add(elementIdMatchRule1);
		Stores_Store_Listing.Name = "Stores_Store_Listing";
		Stores_Store_Listing.TagName = "LI";
		Stores_Store_Listing.TargetTypeString = "OpenSpan.Adapters.Web.HtmlElement, OpenSpan.Adapters.Web";
		Stores_Store_Listing.UseElementId = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(elementIdMatchRule1, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D607584316A959"));
		// 
		// Add components
		// 
		components.Add(elementIdMatchRule1);
		// 
		// Result
		// 
		return Stores_Store_Listing;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule Create_elementIdMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule1 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.SetId(elementIdMatchRule1, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D607584316A959"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "store_menu";
		elementIdMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return elementIdMatchRule1;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule Create_documentUrlMatchRule3(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule documentUrlMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule();
		this.SetId(documentUrlMatchRule3, new OpenSpan.Design.ComponentIdentity("DocumentUrlMatchRule-8D60376C9871857"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule3.Fragment = textmatchdata1;
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "training.openspan.com";
		documentUrlMatchRule3.Host = textmatchdata2;
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "/store_locator";
		documentUrlMatchRule3.Path = textmatchdata3;
		documentUrlMatchRule3.Port = 80;
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule3.Query = textmatchdata4;
		OpenSpan.Adapters.TextMatchData textmatchdata5 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata5.Text = "http";
		documentUrlMatchRule3.Scheme = textmatchdata5;
		// 
		// Result
		// 
		return documentUrlMatchRule3;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule Create_documentTitleMatchRule3(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule documentTitleMatchRule3 = new OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule();
		this.SetId(documentTitleMatchRule3, new OpenSpan.Design.ComponentIdentity("DocumentTitleMatchRule-8D60376C98C7330"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "Stores | Pega Studio Training Web Application";
		documentTitleMatchRule3.Text = textmatchdata1;
		// 
		// Result
		// 
		return documentTitleMatchRule3;
	}
	
	internal OpenSpan.Adapters.Web.Controls.WebPage Create_ACMEwpResults(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.WebPage ACMEwpResults = new OpenSpan.Adapters.Web.Controls.WebPage();
		this.SetId(ACMEwpResults, new OpenSpan.Design.ComponentIdentity("WebPage-8D60377D61EC8D0"));
		OpenSpan.Adapters.Web.Controls.Form ACMEfrmResults;
		ACMEfrmResults = new OpenSpan.Adapters.Web.Controls.Form();
		// 
		// ACMEfrmResults
		// 
		OpenSpan.Adapters.Web.Controls.Table ACMEtblNearestStore;
		ACMEtblNearestStore = new OpenSpan.Adapters.Web.Controls.Table();
		// 
		// ACMEtblNearestStore
		// 
		ACMEtblNearestStore.ElementId = "search_locator_result_table";
		ACMEtblNearestStore.Extender = null;
		ACMEtblNearestStore.ForwardObjectExplorerEvent = true;
		ACMEtblNearestStore.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule9;
		elementIdMatchRule9 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule9
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "search_locator_result_table";
		elementIdMatchRule9.Text = textmatchdata1;
		ACMEtblNearestStore.MatchRules.Add(elementIdMatchRule9);
		ACMEtblNearestStore.Name = "ACMEtblNearestStore";
		ACMEtblNearestStore.Schema.Id = new System.Guid("87500b59-005e-4e0b-817d-307c97697e2e");
		ACMEtblNearestStore.Schema.Name = "ACMEtblNearestStore";
		ACMEtblNearestStore.TagName = "TABLE";
		ACMEtblNearestStore.TargetTypeString = "OpenSpan.Adapters.Web.HtmlTableElement, OpenSpan.Adapters.Web";
		ACMEtblNearestStore.UseElementId = true;
		ACMEfrmResults.Controls.Add(ACMEtblNearestStore);
		ACMEfrmResults.ElementId = "form1";
		ACMEfrmResults.Extender = null;
		ACMEfrmResults.ForwardObjectExplorerEvent = true;
		ACMEfrmResults.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule8;
		elementIdMatchRule8 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule8
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "form1";
		elementIdMatchRule8.Text = textmatchdata2;
		ACMEfrmResults.MatchRules.Add(elementIdMatchRule8);
		ACMEfrmResults.Name = "ACMEfrmResults";
		ACMEfrmResults.TagName = "FORM";
		ACMEfrmResults.TargetTypeString = "OpenSpan.Adapters.Web.HtmlFormElement, OpenSpan.Adapters.Web";
		ACMEfrmResults.UseElementId = true;
		ACMEwpResults.Controls.Add(ACMEfrmResults);
		ACMEwpResults.Extender = null;
		ACMEwpResults.ForwardObjectExplorerEvent = true;
		ACMEwpResults.IsGlobal = true;
		ACMEwpResults.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule documentUrlMatchRule4;
		documentUrlMatchRule4 = new OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule();
		// 
		// documentUrlMatchRule4
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule4.Fragment = textmatchdata3;
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata4.Text = "training.openspan.com";
		documentUrlMatchRule4.Host = textmatchdata4;
		OpenSpan.Adapters.TextMatchData textmatchdata5 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata5.Text = "/store/locator_result";
		documentUrlMatchRule4.Path = textmatchdata5;
		documentUrlMatchRule4.Port = 80;
		OpenSpan.Adapters.TextMatchData textmatchdata6 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule4.Query = textmatchdata6;
		OpenSpan.Adapters.TextMatchData textmatchdata7 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata7.Text = "http";
		documentUrlMatchRule4.Scheme = textmatchdata7;
		OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule documentTitleMatchRule4;
		documentTitleMatchRule4 = new OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule();
		// 
		// documentTitleMatchRule4
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata8 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata8.Text = "Store Locator | Pega Studio Training Web Application";
		documentTitleMatchRule4.Text = textmatchdata8;
		ACMEwpResults.MatchRules.Add(documentUrlMatchRule4);
		ACMEwpResults.MatchRules.Add(documentTitleMatchRule4);
		ACMEwpResults.Name = "ACMEwpResults";
		ACMEwpResults.TargetTypeString = "OpenSpan.Adapters.Web.HtmlDocument, OpenSpan.Adapters.Web";
		// 
		// Set designComp Ids
		// 
		this.SetId(ACMEfrmResults, new OpenSpan.Design.ComponentIdentity("Form-8D60377D61882F1"));
		this.SetId(ACMEtblNearestStore, new OpenSpan.Design.ComponentIdentity("Table-8D60377D611EEA8"));
		this.SetId(elementIdMatchRule9, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60377D63C28B1"));
		this.SetId(elementIdMatchRule8, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60377D6337017"));
		this.SetId(documentUrlMatchRule4, new OpenSpan.Design.ComponentIdentity("DocumentUrlMatchRule-8D60377D626209C"));
		this.SetId(documentTitleMatchRule4, new OpenSpan.Design.ComponentIdentity("DocumentTitleMatchRule-8D60377D62B5445"));
		// 
		// Add components
		// 
		components.Add(ACMEfrmResults);
		components.Add(ACMEtblNearestStore);
		components.Add(elementIdMatchRule9);
		components.Add(elementIdMatchRule8);
		components.Add(documentUrlMatchRule4);
		components.Add(documentTitleMatchRule4);
		// 
		// Result
		// 
		return ACMEwpResults;
	}
	
	internal OpenSpan.Adapters.Web.Controls.Form Create_ACMEfrmResults(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.Form ACMEfrmResults = new OpenSpan.Adapters.Web.Controls.Form();
		this.SetId(ACMEfrmResults, new OpenSpan.Design.ComponentIdentity("Form-8D60377D61882F1"));
		OpenSpan.Adapters.Web.Controls.Table ACMEtblNearestStore;
		ACMEtblNearestStore = new OpenSpan.Adapters.Web.Controls.Table();
		// 
		// ACMEtblNearestStore
		// 
		ACMEtblNearestStore.ElementId = "search_locator_result_table";
		ACMEtblNearestStore.Extender = null;
		ACMEtblNearestStore.ForwardObjectExplorerEvent = true;
		ACMEtblNearestStore.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule9;
		elementIdMatchRule9 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule9
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "search_locator_result_table";
		elementIdMatchRule9.Text = textmatchdata1;
		ACMEtblNearestStore.MatchRules.Add(elementIdMatchRule9);
		ACMEtblNearestStore.Name = "ACMEtblNearestStore";
		ACMEtblNearestStore.Schema.Id = new System.Guid("87500b59-005e-4e0b-817d-307c97697e2e");
		ACMEtblNearestStore.Schema.Name = "ACMEtblNearestStore";
		ACMEtblNearestStore.TagName = "TABLE";
		ACMEtblNearestStore.TargetTypeString = "OpenSpan.Adapters.Web.HtmlTableElement, OpenSpan.Adapters.Web";
		ACMEtblNearestStore.UseElementId = true;
		ACMEfrmResults.Controls.Add(ACMEtblNearestStore);
		ACMEfrmResults.ElementId = "form1";
		ACMEfrmResults.Extender = null;
		ACMEfrmResults.ForwardObjectExplorerEvent = true;
		ACMEfrmResults.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule8;
		elementIdMatchRule8 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule8
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "form1";
		elementIdMatchRule8.Text = textmatchdata2;
		ACMEfrmResults.MatchRules.Add(elementIdMatchRule8);
		ACMEfrmResults.Name = "ACMEfrmResults";
		ACMEfrmResults.TagName = "FORM";
		ACMEfrmResults.TargetTypeString = "OpenSpan.Adapters.Web.HtmlFormElement, OpenSpan.Adapters.Web";
		ACMEfrmResults.UseElementId = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(ACMEtblNearestStore, new OpenSpan.Design.ComponentIdentity("Table-8D60377D611EEA8"));
		this.SetId(elementIdMatchRule9, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60377D63C28B1"));
		this.SetId(elementIdMatchRule8, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60377D6337017"));
		// 
		// Add components
		// 
		components.Add(ACMEtblNearestStore);
		components.Add(elementIdMatchRule9);
		components.Add(elementIdMatchRule8);
		// 
		// Result
		// 
		return ACMEfrmResults;
	}
	
	internal OpenSpan.Adapters.Web.Controls.Table Create_ACMEtblNearestStore(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.Controls.Table ACMEtblNearestStore = new OpenSpan.Adapters.Web.Controls.Table();
		this.SetId(ACMEtblNearestStore, new OpenSpan.Design.ComponentIdentity("Table-8D60377D611EEA8"));
		ACMEtblNearestStore.ElementId = "search_locator_result_table";
		ACMEtblNearestStore.Extender = null;
		ACMEtblNearestStore.ForwardObjectExplorerEvent = true;
		ACMEtblNearestStore.MatchingIndex = 0;
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule9;
		elementIdMatchRule9 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		// 
		// elementIdMatchRule9
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "search_locator_result_table";
		elementIdMatchRule9.Text = textmatchdata1;
		ACMEtblNearestStore.MatchRules.Add(elementIdMatchRule9);
		ACMEtblNearestStore.Name = "ACMEtblNearestStore";
		ACMEtblNearestStore.Schema.Id = new System.Guid("87500b59-005e-4e0b-817d-307c97697e2e");
		ACMEtblNearestStore.Schema.Name = "ACMEtblNearestStore";
		ACMEtblNearestStore.TagName = "TABLE";
		ACMEtblNearestStore.TargetTypeString = "OpenSpan.Adapters.Web.HtmlTableElement, OpenSpan.Adapters.Web";
		ACMEtblNearestStore.UseElementId = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(elementIdMatchRule9, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60377D63C28B1"));
		// 
		// Add components
		// 
		components.Add(elementIdMatchRule9);
		// 
		// Result
		// 
		return ACMEtblNearestStore;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule Create_elementIdMatchRule9(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule9 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.SetId(elementIdMatchRule9, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60377D63C28B1"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "search_locator_result_table";
		elementIdMatchRule9.Text = textmatchdata1;
		// 
		// Result
		// 
		return elementIdMatchRule9;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule Create_elementIdMatchRule8(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule elementIdMatchRule8 = new OpenSpan.Adapters.Web.MatchRules.ElementIdMatchRule();
		this.SetId(elementIdMatchRule8, new OpenSpan.Design.ComponentIdentity("ElementIdMatchRule-8D60377D6337017"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "form1";
		elementIdMatchRule8.Text = textmatchdata1;
		// 
		// Result
		// 
		return elementIdMatchRule8;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule Create_documentUrlMatchRule4(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule documentUrlMatchRule4 = new OpenSpan.Adapters.Web.MatchRules.DocumentUrlMatchRule();
		this.SetId(documentUrlMatchRule4, new OpenSpan.Design.ComponentIdentity("DocumentUrlMatchRule-8D60377D626209C"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule4.Fragment = textmatchdata1;
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "training.openspan.com";
		documentUrlMatchRule4.Host = textmatchdata2;
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "/store/locator_result";
		documentUrlMatchRule4.Path = textmatchdata3;
		documentUrlMatchRule4.Port = 80;
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		documentUrlMatchRule4.Query = textmatchdata4;
		OpenSpan.Adapters.TextMatchData textmatchdata5 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata5.Text = "http";
		documentUrlMatchRule4.Scheme = textmatchdata5;
		// 
		// Result
		// 
		return documentUrlMatchRule4;
	}
	
	internal OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule Create_documentTitleMatchRule4(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule documentTitleMatchRule4 = new OpenSpan.Adapters.Web.MatchRules.DocumentTitleMatchRule();
		this.SetId(documentTitleMatchRule4, new OpenSpan.Design.ComponentIdentity("DocumentTitleMatchRule-8D60377D62B5445"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "Store Locator | Pega Studio Training Web Application";
		documentTitleMatchRule4.Text = textmatchdata1;
		// 
		// Result
		// 
		return documentTitleMatchRule4;
	}
}

}

