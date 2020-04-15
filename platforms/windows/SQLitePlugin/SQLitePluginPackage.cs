using Microsoft.ReactNative.Managed;
using Microsoft.ReactNative;

namespace SQLitePlugin
{
    public sealed class SQLitePluginPackage : IReactPackageProvider
    {
        public void CreatePackage(IReactPackageBuilder packageBuilder)
        {
            packageBuilder.AddAttributedModules();
        }
    }
}