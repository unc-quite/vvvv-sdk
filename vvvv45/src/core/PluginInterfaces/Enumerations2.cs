﻿namespace VVVV.PluginInterfaces.V2
{
   #region enums
	/// <summary>
	/// Used in <see cref="VVVV.PluginInterfaces.V1.INodeInfo">INodeInfo</see> to specify the type of the provided node.
	/// </summary>
	public enum TNodeType {
		/// <summary>
		/// Specifies a native node.
		/// </summary>
		Native,
		/// <summary>
		/// Specifies a patch node that may be a module or not.
		/// </summary>
		Patch,
		/// <summary>
		/// Specifies a freeframe node.
		/// </summary>
		Freeframe,
		/// <summary>
		/// Specifies a VST node.
		/// </summary>
		VST,
		/// <summary>
		/// Specifies an effect node.
		/// </summary>
		Effect,
		/// <summary>
		/// Specifies a static plugin node.
		/// </summary>
		Plugin,
		/// <summary>
		/// Specifies a dynamic plugin node.
		/// </summary>
		Dynamic};
	
	/// <summary>
	/// Used in the pin creating functions of <see cref="VVVV.PluginInterfaces.V1.IPluginHost">IPluginHost</see> to specifiy possible SliceCounts.
	/// </summary>
	public enum TWindowType {
		/// <summary>
		/// A patch editor window.
		/// </summary>
		Patch,
		/// <summary>
		/// A modules window.
		/// </summary>
		Module,
		/// <summary>
		/// A code editor window.
		/// </summary>
		Editor,
	    /// <summary>
		/// A renderer window.
		/// </summary>
		Renderer,
	    /// <summary>
		/// A plugins window.
		/// </summary>
		Plugin,
	    /// <summary>
		/// A HDE window.
		/// </summary>
		HDE};
	
	#endregion enums
}