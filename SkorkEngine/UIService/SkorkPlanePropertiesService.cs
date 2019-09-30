using Skork.Language.Configurations;
using Skork.Window.Draw.Plane;
using System.Windows.Media;

namespace SkorkEngine.UIService
{
    public class SkorkPlanePropertiesService
    {
        static SkorkPlanePropertiesService()
        {
            Instance = new SkorkPlaneProperties
            {
                ColorPrimary = Colors.Black,
                ColorSecondary = Colors.White,
                Width = SkorkProperties.SpriteWidth,
                Height = SkorkProperties.SpriteHeight
            };
        }

        public static SkorkPlaneProperties Instance { get; set; }
    }
}
