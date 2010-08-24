using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using VVVV.PluginInterfaces.V1;
using VVVV.PluginInterfaces.V2;

namespace VVVV.Hosting
{
	[Guid("2B24AC85-E543-40B3-9090-2828D26978A0"),
	 InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	/// <summary>
	/// HDE host as seen by vvvv.
	/// </summary>
	public interface IInternalHDEHost 
	{
		void Initialize(IVVVVHost vvvvHost, INodeBrowserHost nodeBrowserHost, IWindowSwitcherHost windowSwitcherHost, IKommunikatorHost kommunikatorHost);
		
		void GetHDEPlugins(out IPluginBase nodeBrowser, out IPluginBase windowSwitcher, out IPluginBase kommunikator);
	
	    void ExtractNodeInfos(string filename, out INodeInfo[] nodeInfos);
	
	    void Add(IAddonHost host, INodeInfo nodeInfo);
	
	    void Remove(IAddonHost host, INodeInfo nodeInfo);
	    
	    void Clone(INodeInfo nodeInfo, string path, out INodeInfo newNodeInfo);
	}
}
