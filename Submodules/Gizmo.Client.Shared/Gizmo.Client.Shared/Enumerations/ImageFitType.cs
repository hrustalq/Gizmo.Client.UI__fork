using System.ComponentModel;

namespace Gizmo.Client
{
    public enum ImageFitType
    {
        [Description("fill")]
        Fill,

        [Description("contain")]
        Contain,

        [Description("cover")]
        Cover,

        [Description("none")]
        None,

        [Description("scale-down")]
        ScaleDown
    }
}
