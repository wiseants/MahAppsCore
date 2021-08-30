using Prism.Ioc;
using Prism.Unity;

namespace MahAppsCore.Tools
{
    /// <summary>
    /// 어플리케이션 툴.
    /// </summary>
    public class AppTool
    {
        /// <summary>
        /// APP의 컨테이너.
        /// </summary>
        public static IContainerProvider Container => ((PrismApplication)System.Windows.Application.Current).Container;
    }
}
