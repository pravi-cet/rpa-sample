using ACME_ACMESearchSystem = Project1.ACMESearchSystem;

using ACME_ACME_E_btnTestClicked = Project1.ACME_E_btnTestClicked;

using ACME_frmTest = Project1.frmTest;

using ACME_ACME_P_GetNearestStore = Project1.ACME_P_GetNearestStore;

using ACME_ACME_P_NavToHome = Project1.ACME_P_NavToHome;

using ACME_ACME_P_SearchByZip = Project1.ACME_P_SearchByZip;

using ACME_ACME_P_Signin = Project1.ACME_P_Signin;

using ACME__ACME_GC = Project1._ACME_GC;

using System;

namespace Project1.Project
{
// Project-8D6035A73EEF0FC
/// <summary>
/// OpenSpan project.
/// </summary>
[OpenSpan.Design.TargetEnvironmentAttribute(OpenSpan.Design.TargetEnvironment.Driver)]
[OpenSpan.Design.ComponentIdentityAttribute("Project-8D6035A73EEF0FC")]
[OpenSpan.Design.DeploymentVersionAttribute("1.0")]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.Present)]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.ContainsAdapters)]
public sealed class ACME : OpenSpan.Runtime.RuntimeProject
{
	
	public ACME() : 
			base()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.ACME_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public ACME(System.ComponentModel.ISynchronizeInvoke syncObject) : 
			base(syncObject)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.ACME_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public ACME(System.IServiceProvider serviceProvider) : 
			base(serviceProvider)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.ACME_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public ACME(bool initializeScout) : 
			base(initializeScout)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.ACME_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private ACME(System.IServiceProvider serviceProvider, OpenSpan.Runtime.RuntimeHostCommandLineHelper commandLineHelper, OpenSpan.Deployment.DeploymentManifest deploymentManifest) : 
			base(serviceProvider, commandLineHelper, deploymentManifest)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.ACME_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private void ACME_Initialize()
	{
		this.mId = new OpenSpan.Design.ComponentIdentity("Project-8D6035A73EEF0FC");
		this.mVersion = new System.Version("8.0.1090.0");
		this.mDeploymentVersion = "1.0";
		this.mTransformationVersion = new System.Version("8.0.1026.0");
		this.mTargetEnvironment = OpenSpan.Design.TargetEnvironment.Driver;
		this.mInteractionConfigXml = "<Interaction Name=\"Call\" xmlns:json=\'http://james.newtonking.com/projects/json\'>\r" +
			"\n\r\n\t<!--\tThe Context section defines what information is stored about an interac" +
			"tion. Property values are set and\r\n\t        retrieved via the InteractionManager" +
			" component. Defining a context incudes defining these values:\r\n\t\t\t\r\n\t\t\tName - Us" +
			"ed to identify the property in automations and in the plug-in configuration.\r\n\t\t" +
			"\tType - Specifies the property\'s underlying data type. Supported types include: " +
			"String, Number, Boolean, and Date. \r\n\t\t\tDefault - Use this property to specify a" +
			" default value. The property is populated with this value when an \r\n\t\t\t   intera" +
			"ction is created.\r\n\t\t\t-->\r\n\r\n\t<Context>\r\n\t\t<Value Name=\"AcctNum\" Type=\"String\" D" +
			"efault=\"10000\" />\r\n\t\t<Value Name=\"Name\" Type=\"String\" Default=\"[No Active Call]\"" +
			" />\r\n\t\t<Value Name=\"Address\" Type=\"String\" Default=\"xxxx\"/>\t\t\r\n\t\t<Value Name=\"Ci" +
			"ty\" Type=\"String\" Default=\"xxxx\"/>\r\n    <Value Name=\"State\" Type=\"String\" Defaul" +
			"t=\"xxxx\"/>\r\n    <Value Name=\"ZipCode\" Type=\"String\" Default=\"xxxx\"/>\r\n    <Value" +
			" Name=\"NearestStore\" Type=\"String\" Default=\"xxxx\"/>\r\n  </Context>\r\n\r\n\t<!--\tAn Ac" +
			"tivity describes a piece of work that needs to done. An automation can request f" +
			"or activity to be performed\r\n\t        or perform and activity when requested. Ac" +
			"tivities are queued and run sequetially. Only one activity can be processed\r\n\t\t\t" +
			"at a time. Any automation can request for an activity to be peformed by calling " +
			"Activity.StartActivity().  \r\n\t\t\tThe activity is placed at the bottom of the queu" +
			"e and is processing when the activities higher in the queue are \r\n\t\t\tcompleted. " +
			"An activity is completed when all automations that are listening to Activity.Act" +
			"ivityStarted have completed\r\n\t\t\ttheir execution.\r\n\r\n            Name – Provides " +
			"a descriptive name of an activity.\r\n            Value – Specifies the parameters" +
			" and properties of an activity.\r\n            Type – Specifies the type of the Va" +
			"lue, such as Boolean or String.\r\n\t\t\t \r\n\t\t\tIn the example below the Close Account" +
			" activity will have a StartActivity() method with \r\n\t\t\ttwo parameters: CustomerI" +
			"d and Effective Date.\r\n\t\t\tThere will also be an ActivityStarted event with Custo" +
			"merId and EffectiveDate outputs.\r\n\t\t\tAdditionally, an activity component for Clo" +
			"se Account will have a CustomerId property\r\n\t\t\tand an EffectiveDate property. Th" +
			"ese property values can be set or retrieved during the execution\r\n\t\t\tof the acti" +
			"vity or in response to the ActivityCompleted event.\r\n\t\t\t\r\n\t\t\t<Activity Name=\"Clo" +
			"se Account\">\r\n\t\t\t\t<Value Name=\"CustomerId\" Type=\"String\" />\r\n\t\t\t\t<Value Name=\"Ef" +
			"fectiveDate\" Type=\"Date\" />\r\n\t\t\t</Activity>\r\n\r\n\t\t\tWhen defining an activity, mak" +
			"e sure that all of the information required to perform the\r\n\t\t\tactivity is avail" +
			"able through context values or the Activity properties.\r\n\t\t\t-->\r\n\r\n\t<Activities>" +
			"\r\n\t\t<Activity Name=\"GetCustomerInformation\">\r\n\t\t</Activity>\r\n\t\t<Activity Name=\"U" +
			"pdate Display\">\r\n\t\t</Activity>\r\n\t\t<Activity Name=\"SaveAddress\">\r\n\t\t</Activity>\r\n" +
			"\t\t<Activity Name=\"Answer Call\">\r\n\t\t\t<Value Name=\"BI_Initiated\" Type=\"Boolean\" />" +
			"\r\n\t\t</Activity>\r\n\t</Activities>\r\n\r\n\t<!--  Plug-ins are HTML user interface secti" +
			"ons in the toolbar. Agile Desktop includes these plug-ins:\r\n\t\t\t- 360 View - Prov" +
			"ides access to key customer information at a glance.\r\n\t\t\t- Notes - Lets you add " +
			"notes and search historic notes.\r\n\t\t\t- Shortcuts - Provides buttons to launch an" +
			" exe, go to a web site, execute an automation\r\n\t\t\t     or start an activity.\r\n\r\n" +
			"          GENERIC PLUG-IN SETTINGS\r\n\r\n\t\t\t\tPlugin:isActive - Indicates if the plu" +
			"g-in appears in the toolbar.\r\n\t\t\t\tPlugin:hasExtendedView - Indicates if the plug" +
			"-in can be expanded to show more information.\r\n\t\t\t\tPlugin:enableWithNoActiveInte" +
			"raction - Indicates if the user can interact with the plug-in when \r\n\t\t\t\t   ther" +
			"e is no active interaction.\r\n\t\t\t\tPlugin:canHide - If false, the user cannot hide" +
			" the plug-in from the gear menu.\r\n\t\t\t\tPlugin/Section - Provides a logical groupi" +
			"ng of the elements that comprise the plug-in.\r\n\t\t\t\tPlugin/Section:visibility - Y" +
			"ou can choose from these options:\r\n\t\t\t\t   Primary - The section is added to the " +
			"Primary view.\r\n\t\t\t\t   Extended - The section is added to the Extended view.\r\n\t\t\t" +
			"\t   Both - The section is added to both the Primary and Extended views.\r\n       " +
			"         -->\r\n\r\n\t<Plugins>\r\n\r\n\t\t<!--    360 View - This plug-in displays interac" +
			"tion context values that may be needed at a glance.\r\n\t\t\t\t\r\n\t\t\tPLUG-IN SPECIFIC S" +
			"ETTINGS\r\n\r\n\t\t\t\tPlugin/Section name - Indicates the type of styling to use for th" +
			"e section. You can choose from these styles:\r\n\t\t\t\t\tIdentity, Ratings, Custom, Ba" +
			"lances, Eligibility, or Information.\r\n\t\t\t\tPlugin/Section/Item:Name - Specifies t" +
			"he name of the plug-in.\r\n\t\t\t\tPlugin/Section/Item/Context:Name - The name of cont" +
			"ext value (defined in the Context section) used to populate\r\n\t\t\t\t\tthis item. As " +
			"the associated context property value changes, this item is automatically update" +
			"d.\r\n\t\t\t\tPlugin/Section/Item/Label - Defines the text label that appears to left " +
			"of the value in the toolbar. If omitted,\r\n\t\t\t\t    the Name value is used.\r\n\t\t\t\t-" +
			"->\r\n\r\n\t\t<Plugin name=\"360AppBar\" isActive=\"true\" hasExtendedView=\"true\" canHide=" +
			"\"true\" enableWithNoActiveInteraction=\"false\" Label=\"360 View\">\r\n\t\t\t<section name" +
			"=\"Identity\" Visibility=\"Primary\">\r\n\t\t\t\t<Item name=\"FullName\">\r\n\t\t\t\t\t<Context Nam" +
			"e=\"Name\" />\r\n\t\t\t\t\t<Label></Label>\r\n\t\t\t\t</Item>\r\n\t\t\t</section>\t\t\t\r\n\t\t\t<section na" +
			"me=\"Products\" Visibility=\"Primary\">\r\n\t\t\t\t<Item name=\"AccountNumber\">\r\n\t\t\t\t\t<Cont" +
			"ext Name=\"AcctNum\" />\r\n\t\t\t\t\t<Label>Account Number</Label>\t\t\t\t\r\n\t\t\t\t</Item>\r\n\t\t\t<" +
			"/section>\r\n\t\t\t<section name=\"Balances\" Visibility=\"Extended\">\r\n\t\t\t\t<Item name=\"A" +
			"ddress\">\r\n\t\t\t\t\t<Context Name=\"Address\" />\r\n\t\t\t\t\t<Label>Address</Label>\r\n\t\t\t\t</It" +
			"em>\r\n\t\t\t    <Item name=\"City\">\r\n\t\t\t\t\t<Context Name=\"City\" />\r\n\t\t\t\t\t<Label>City</" +
			"Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item name=\"State\">\r\n\t\t\t\t\t<Context Name=\"State\" />\r\n\t\t\t" +
			"\t\t<Label>State</Label>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item name=\"Zipcode\">\r\n\t\t\t\t\t<Context Na" +
			"me=\"Zipcode\" />\r\n\t\t\t\t\t<Label>Zipcode</Label>\t\t\t\t\r\n\t\t\t\t</Item>\r\n\t\t\t</section>\r\n\t\t" +
			"</Plugin>\r\n\r\n\t\t<!--    NOTES - This plug-in lets you add predefined notes, manua" +
			"lly enter notes, and review the historical notes for\r\n\t\t\tan interaction. The nam" +
			"e of this plug-in is Notes.\r\n\t\t\t\t\r\n\t\t\tPLUG-IN SPECIFIC SETTINGS\r\n\r\n\t\t\t\tsection/I" +
			"tem:Name - Name of the item to add to the plug-in.\r\n\t\t\t\tsection/Item/Context:Nam" +
			"e - The name of context value (defined in the Context section) used to \r\n\t\t\t\t   " +
			"populate this item. As the associated context property value changes, this item " +
			"is automatically updated.\r\n\t\t\t\tsection/Item/Label - Defines the text label that " +
			"appears to left of the value in the toolbar. If omitted,\r\n\t\t\t\t   the Name value " +
			"is used.\r\n\t\t\t\t-->\r\n\r\n\t\t<Plugin name=\"Notes\" isActive=\"true\"  hasExtendedView=\"tr" +
			"ue\"  canHide=\"true\" enableWithNoActiveInteraction=\"false\">\r\n\t\t\t<section name=\"No" +
			"teTemplates\" Visibility=\"None\" >\r\n\t\t\t\t<Item name=\"CallStarted\" isActive=\"true\" >" +
			"\r\n\t\t\t\t\t<Content>Call with {{Name}} started</Content>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item nam" +
			"e=\"InformDueAmount\" isActive=\"true\">\r\n\t\t\t\t\t<Content>Informed of {{TotalDue}} due" +
			" amount</Content>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item name=\"Hided Note\" isActive=\"false\">\r\n\t" +
			"\t\t\t\t<Content>This is hide</Content>\r\n\t\t\t\t</Item>\r\n\t\t\t\t<Item name=\"Note With Acti" +
			"vity\" isActive=\"true\">\r\n\t\t\t\t\t<Content>Note added with the validate caller activi" +
			"ty</Content>\r\n\t\t\t\t\t<Activity>ValidateCaller</Activity>\r\n\t\t\t\t</Item>\r\n\t\t\t</sectio" +
			"n>\r\n\t\t\t<config>\r\n\t\t\t\t<TimeZone>GMT-5</TimeZone>\r\n\t\t\t\t<MaxNotesToReturn>100</MaxN" +
			"otesToReturn>\r\n\t\t\t\t<MaxDaysToReturn>365</MaxDaysToReturn>\r\n\t\t\t\t<LineBreak>\\r\\n</" +
			"LineBreak>\r\n\t\t\t</config>\r\n\t\t</Plugin>\r\n\r\n\t\t<!--    SHORTCUTS - This plug-in prov" +
			"ides shortcut buttons for calling an automation, going to a web page,\r\n\t\t\tstarti" +
			"ng an executable, or starting an activity.\r\n\t\t\t\t\r\n\t\t\tPLUG-IN SPECIFIC SETTINGS\r\n" +
			"\r\n\t\t\t\tPlugin/Label - Use to define the heading text that appears for this sectio" +
			"n. The default is Quick Links.\r\n\t\t\t\tPlugin/config/Layout- Use to define the numb" +
			"er of columns in which shortcuts are displayed (2 or 3).\r\n\t\t\t\tPlugin/Section/Nam" +
			"e - Specifies the name of shortcut section. This description does not appear in " +
			"the Agile Desktop UI.\r\n\t\t\t\tPlugin/Section/Item:Name - Enter the text you want to" +
			" appear on the shortcut button.\r\n\t\t\t\tPlugin/Section/Item:ShortcutType - Indicate" +
			"s type of shortcut. Choose from these options:\r\n\t\t\t\t\t* Activity - Starts an acti" +
			"vity.\r\n\t\t\t\t\t* Url - Navigates to a web page.\r\n\t\t\t\t\t* External - Starts an execut" +
			"able.\r\n\t\t\t\t\t* Automation - Starts an automation.\r\n\t\t\t\tPlugin/Section/Item:Activi" +
			"tyName - For Activity shortcuts, enter the name of the activity pressing the but" +
			"ton should start.\r\n\t\t\t\tPlugin/Section/Item:Target - Enter the destination for th" +
			"e shortcut. For instance, if the shortcut is a web site, you enter \r\n\t\t\t\t    the" +
			" URL. If the shortcut launches an executable file, enter the name of that file.\r" +
			"\n\t\t\t\tPlugin/Section/Item:Project - For automation shortcuts, enter the name of t" +
			"he project that will run the automation.\r\n\t\t        -->\r\n\r\n\t\t<Plugin name=\"Short" +
			"cuts\" isActive=\"true\"  hasExtendedView=\"false\" canHide=\"true\" enableWithNoActive" +
			"Interaction=\"false\" Label=\"Shortcut\">\r\n\t\t\t<config>\r\n\t\t\t\t<Layout>2</Layout>\r\n\t\t\t<" +
			"/config>\r\n\t\t\t<section name=\"Links\" Visibility=\"Primary\" >\r\n\t\t\t\t<Item Name=\"OpenS" +
			"pan Web Site\" ShortcutType=\"Url\" Target=\"http://www.openspan.com/\"/>\r\n\t\t\t</secti" +
			"on>\r\n\t\t\t<section name=\"Launch\"  Visibility=\"Primary\">\r\n\t\t\t<Item Name=\"Notepad\" T" +
			"arget=\"Notepad\" ShortcutType=\"External\"/>\r\n\t\t\t</section>\r\n\t\t\t<section name=\"Tabs" +
			"\"  Visibility=\"Primary\" >\r\n\t\t\t\t<Item Name=\"CRM\" ShortcutType=\"Tab\" Target=\"TabNa" +
			"me\"/>\r\n\t\t\t</section>\r\n\t\t</Plugin>\r\n\t\t\r\n\t\t<!--    InteractionManager - This plug-" +
			"in displays a list from which you can select the active interaction. close an\r\n\t" +
			"\t\tinteraction, and optionally start an interaction. \r\n\t\t\t\t\r\n\t\t\tPLUG-IN SPECIFIC " +
			"SETTINGS\r\n\r\n\t\t\t\tSection/Item/Context Name - Enter the context property you want " +
			"to use in the list from which the end user will\r\n\t\t\t\t   select an active interac" +
			"tion. For instance, if there is a context property named ClientFullName and you " +
			"want your\r\n\t\t\t\t   end users to select an interaction based on the client\'s name," +
			" you would enter ClientFullName here.\r\n\t\t\t\tconfig/EnableStartInteraction - Enter" +
			" True if you want to show a plus (+) button to let the user manually start an\r\n\t" +
			"\t\t\t   interaction.\r\n\t\t\t\t-->\r\n\r\n\t\t<Plugin name=\"InteractionManager\" isActive=\"fal" +
			"se\" showOn=\"360AppBar\">\r\n\t\t\t<section name=\"selector\" Visibility=\"Primary\">\r\n\t\t\t\t" +
			"<Item name=\"InteractionName\" >\r\n\t\t\t\t\t<Context Name=\"Name\" />\r\n\t\t\t\t\t<Label/>\r\n\t\t\t" +
			"\t</Item>\r\n\t\t\t</section>\r\n\t\t\t<config>\r\n\t\t\t\t<EnableStartInteraction>true</EnableSt" +
			"artInteraction>\r\n\t\t\t</config>\r\n\t\t</Plugin>\r\n\r\n\t\t<!--    StartInteraction - This " +
			"plug-in displays a modal dialog inside the plug-in that lets you start a new int" +
			"eraction.\r\n\t\t\t\t\r\n\t\t\tPLUG-IN SPECIFIC SETTINGS\r\n\r\n\t\t\t\tenableWithNoActiveInteracti" +
			"on - Enter True if you want to display the StartInteraction dialog when no \r\n\t\t\t" +
			"\t   interactions exist.\r\n\t\t\t\tconfig/label - Enter the text you want to appear on" +
			" the dialog\'s heading  This text should describe what the \r\n\t\t\t\t   user needs to" +
			" do to start a new interaction, such as Enter Claim Number.\r\n\t\t\t\tconfig/project " +
			"- Enter the name of the OpenSpan project that contains the automation which star" +
			"ts a new \r\n\t\t\t\t   interaction.\r\n\t\t\t\tconfig/automation - Enter the name of the au" +
			"tomation which starts a new interaction. This automation can validate \r\n\t\t\t\t   u" +
			"ser input and initiate a new interaction by calling InteractionManager.StartInte" +
			"raction().\r\n\t\t\t\tconfig/defaultErrorMessage - Enter the text of the message you w" +
			"ant to display if an error occurs while starting\r\n\t\t\t\t   an interaction and the " +
			"start interaction automation does not return error text.\r\n\t\t\t\t-->\r\n\r\n\t\t<Plugin n" +
			"ame=\"StartInteraction\" isActive=\"false\" enableWithNoActiveInteraction=\"true\">\r\n\t" +
			"\t\t<config>\r\n\t\t\t\t<label>Enter Claim Number</label>\r\n\t\t\t\t<project>AgileDesktopTest" +
			"</project>\r\n\t\t\t\t<automation>StartInteraction</automation>\r\n\t\t\t\t<defaultErrorMess" +
			"age>Unable to start interaction</defaultErrorMessage>\r\n\t\t\t</config>\r\n\t\t</Plugin>" +
			"\r\n\t</Plugins>\r\n</Interaction>";
	}
	
	// WebAdapter-8D6036EE92E82A8
	public ACME_ACMESearchSystem ACMESearchSystem
	{
		get
		{
			return ((ACME_ACMESearchSystem)(this["ACMESearchSystem"]));
		}
	}
	
	// Automator-8D60746BA6B3502
	public ACME_ACME_E_btnTestClicked ACME_E_btnTestClicked
	{
		get
		{
			return ((ACME_ACME_E_btnTestClicked)(this["ACME_E_btnTestClicked"]));
		}
	}
	
	// DesignForm-8D606A4AD253690
	public ACME_frmTest frmTest
	{
		get
		{
			return ((ACME_frmTest)(this["frmTest"]));
		}
	}
	
	// Automator-8D60745A57D1929
	public ACME_ACME_P_GetNearestStore ACME_P_GetNearestStore
	{
		get
		{
			return ((ACME_ACME_P_GetNearestStore)(this["ACME_P_GetNearestStore"]));
		}
	}
	
	// Automator-8D606A84F759AFD
	public ACME_ACME_P_NavToHome ACME_P_NavToHome
	{
		get
		{
			return ((ACME_ACME_P_NavToHome)(this["ACME_P_NavToHome"]));
		}
	}
	
	// Automator-8D607434C2DEFF4
	public ACME_ACME_P_SearchByZip ACME_P_SearchByZip
	{
		get
		{
			return ((ACME_ACME_P_SearchByZip)(this["ACME_P_SearchByZip"]));
		}
	}
	
	// Automator-8D6073ACBE170E9
	public ACME_ACME_P_Signin ACME_P_Signin
	{
		get
		{
			return ((ACME_ACME_P_Signin)(this["ACME_P_Signin"]));
		}
	}
	
	// GlobalContainer-8D6077D15334602
	public ACME__ACME_GC _ACME_GC
	{
		get
		{
			return ((ACME__ACME_GC)(this["_ACME_GC"]));
		}
	}
}

}

