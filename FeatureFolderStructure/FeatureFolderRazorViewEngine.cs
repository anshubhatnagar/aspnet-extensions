using System.Web.Mvc;

namespace FeatureFolderStructure
{
    public class FeatureFolderRazorViewEngine : RazorViewEngine
    {
        public FeatureFolderRazorViewEngine() : base()
        {
            /* Parameters:
             * {2} - Area Name
             * {1} - Controller Name
             * {0} - View Name
             */

            var featureFolderViewLocationFormats = new string[]
            {
                "~/Features/{1}/{0}.cshtml",
                "~/Features/Shared/{0}.cshtml"
            };

            ViewLocationFormats = featureFolderViewLocationFormats;
            MasterLocationFormats = featureFolderViewLocationFormats;
            PartialViewLocationFormats = featureFolderViewLocationFormats;

            var areaFeatureFolderViewLocationFormats = new string[]
            {
                "~/Areas/{2}/{1}/{0}.cshtml",
                "~/Areas/{2}/Shared/{0}.cshtml"
            };

            AreaViewLocationFormats = areaFeatureFolderViewLocationFormats;
            AreaMasterLocationFormats = areaFeatureFolderViewLocationFormats;
            AreaPartialViewLocationFormats = areaFeatureFolderViewLocationFormats;
        }
    }
}