using System;

namespace Project1
{
/// <summary>
/// OpenSpan design component.
/// </summary>
// GlobalContainer-8D6077D15334602
[OpenSpan.Design.ComponentIdentityAttribute("GlobalContainer-8D6077D15334602")]
[System.ComponentModel.ToolboxItemAttribute(false)]
public sealed class _ACME_GC : OpenSpan.Automation.GlobalContainer
{
	
	public _ACME_GC()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Setup field members
		// 
		// 
		// Initialize design component
		// 
		this.Initialize();
		// 
		// Set design component Id
		// 
		this.Id = new OpenSpan.Design.ComponentIdentity("GlobalContainer-8D6077D15334602");
		// 
		// _ACME_GC
		// 
		ComponentInfo.CodeDomData = @"OSVSXbwIAALWSy2rDMBBFf0VkbWwnjRsb7EDi0FK6aGlC9pJ8DaLSyOix0N+3WRWTErJomd2dOfNue2smS6DwQqPdtqc0gZ25jugWbxPoOHHKdzFYw4OylD9rK7juLQWuCG7Bim278x5G6HSDm8V9YIQDSfhr1nhpnVYiY2c4/01267y8WMb6qEN06AgxOK4z9h6FVvIV6WQ/QZ3YbHglq8dl87BGWTc3e/vJX9+bf6wG0SwxyHI11LLCvbP/V6lj8gHmrxZV/HadQyJulLx2XYgnpTFX9lHpYS4V8//6Ag==";
		this.IsStartStoppable = false;
		this.Name = "_ACME_GC";
		// 
		// Add components
		// 
		this.mComponents = new System.Collections.Generic.List<System.ComponentModel.IComponent>(20);
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
}

}

