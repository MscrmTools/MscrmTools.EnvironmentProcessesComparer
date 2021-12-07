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
        ExportMetadata("SmallImageBase64", "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAMAAABEpIrGAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAADwUExURWBgYDNCVig7VKysrL+/v76+vpycnGlpaXNUVKkzM9cYGNUZGRYuUAMiTN/f3/////7+/tra2mpqamJfX60xMfEJCf8AAN8TE8jIyGJiYm1YWNEbG/j4+Hx8fGJeXqampmFgYLEvL7y8vHlRUfQGBv4AANgXF5NBQTtHWLspKfsCAqE4OKimpu8JCbMtLfn5+ZltbegODmtZWcrKypVERL4nJ9zc3GxsbJ86OqM4ONnZ2Z2dnZw8PKCgoItGRhkxUW5XV9wVFaI4OGpaWuIREYpGRv0BAaM3N/oDA5s8PPgEBHdSUsUiIvUGBoaGhpg+PokREgoAAAAJcEhZcwAADsIAAA7CARUoSoAAAADsSURBVDhP1dLZUsIwGAXgn01QlgLVqmyygyKLorIvAiIKwvu/DT1JhmYghVs5N+nkfDPZSv8iDqcIudyI58IrGt/lld8cAkERCmks4UgUtX59Yxi3KqBpd/dEsbhhxgYkkpRivR3QHtIZ1tuCbC6PulAscVA2BzMSeET/VNExrQLPVYAan1YsUW+gf3m1Bc03gHfeH4LwR6sN0FGDrqcXpf4RMMDcEEBaYsQfywJjAGmT8jEZoE8I65iHYAJgXRSPDKYziN1V88iAvuYQqscSgL4XJ4D+83scEC1Xfwzs/bRr3iLp5WYiPs87RFvmryjIUChdNAAAAABJRU5ErkJggg=="),
        ExportMetadata("BigImageBase64", "iVBORw0KGgoAAAANSUhEUgAAAFAAAABQCAMAAAC5zwKfAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAD8UExURWBgYGxYWJRAQLkqKtIbG+sMDAMiTP////X19dLS0p6enmRkZGRcXJs7O9QZGfwBAf8AAO3t7YyMjGlZWa8vL/UGBqWlpZk9PfAJCaCgoM8cHPz8/ICAgIJKSu0KCuHh4WJiYoxERPcEBJaWlo9DQ/oDA97e3nZ2dm5WVmJeXsrKyqU1NePj43FVVcUiIsMkJHZSUq8wMMAlJeESEnNTU/f392dbW546Os0eHqqqqodHR3t7e4pGRqoyMn1NTZubm8ghIebm5twVFYWFhbGxsfDw8JGRkdfX16Ojo94TE8ofH60xMfIHB4VJSaA4OLEuLqM3N9kWFpY+PrsoKHY4sm0AAAAJcEhZcwAADsIAAA7CARUoSoAAAAK4SURBVFhH7dhZV1MxFIbhMFlUwKHihAg4AoKoIAoqzvOs//+/uJPvPZxkt1w0i+XVea5sdvKu0um0hk6n8z+NjU9MTvHvE0PZoOdMnzx1Wkecmdm5M2cNNyk4NqCTO3deZ3L9C/OxVhfs9S7qUOvSZXKVwd4VncLYVWIRaxQcG1BwFq7pWLJ4nVbCIgXHBhS8pWWdMys3SAmrFBwbEBhwU+dCuHWbElim4NiA8wPu6FxYLO9ffbB3N51bbZ9epOWaYHrprM2RacVlQ8GxAccHrcdj96hk4rKh4NiA44M2bLjpnpAo5WqC0za8T+TQ/NZsytUEeyE8INOYf9hXzVCIiRKnhwjhESFs73AmojdC8HHYLR/BrfbuGXojBDfCE0rylAOgN0JwPUySSqaK+1cT3Jsp/uJ99jfoOTbg+KBnz0kl7g+uCC6FF7SSA2VaFBwbcH7Ay/CKVrStSoaCYwPOe6+Xwxti0YQqGQqODQg4C29DmCIW+adk5OCeTdJVGPl7RCg4NqBQeheP0Eri7RIFxwYkcu8/pCO0krRQoODYgMih6Y+f+CpCK9FKjoJjAzqivciflNrHUHvxmVhU+yxrL74Qi2pfh9qLr8Si2neK9mKFWHLke5mbLVLCmuzmr+wjP2242SIlrKG4yB/1ecjNFilhDcUloO4TmzWMFR/ZVdcU1hrldb7mqsda44AUhl6XSzYgJdrbyl/bZtg3h5INSIn2tnbyV0406ncb7c3k7xYwoeDYgJRob2Yt/4QQJhQcG5AS7c3tfKNziAEFxwakRHsL+/5hZJ2CYwNSor2lcVdkmYJjA1Kivc54+a2OVQqODUiJ9nrfi58WLFJwbEBKtHfAZv65wxoFxwakRHuH+NH8Wj6uYOj/bH6isUDBsQEp0d7hdn/9Pt6gWf3zd675T4xOp9PphPAPvhxzIrOLImsAAAAASUVORK5CYII="),
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