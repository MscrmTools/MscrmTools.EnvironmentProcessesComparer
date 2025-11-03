using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace MscrmTools.EnvironmentProcessesComparer
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Environment Processes Comparer"),
        ExportMetadata("Description", "This tool allows to compare state of processes across environments"),
        ExportMetadata("SmallImageBase64", "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"),
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "#606060"),
        ExportMetadata("PrimaryFontColor", "White"),
        ExportMetadata("SecondaryFontColor", "White")]
    public class MyPlugin : PluginBase, IPayPalPlugin
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MyPlugin()
        {
            // If you have external assemblies that you need to load, uncomment the following to
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        public string DonationDescription => "Donation for Environment Processes Comparer";

        public string EmailAccount => "tanguy92@hotmail.com";

        public override IXrmToolBoxPluginControl GetControl()
        {
            return new MyPluginControl();
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}