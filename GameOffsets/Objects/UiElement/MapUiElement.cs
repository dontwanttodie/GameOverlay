namespace GameOffsets.Objects.UiElement
{
    using System.Runtime.InteropServices;
    using Natives;

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct MapUiElementOffset
    {
        [FieldOffset(0x000)] public UiElementBaseOffset UiElementBase;
        [FieldOffset(0x268)] public StdTuple2D<float> Shift;
        [FieldOffset(0x270)] public StdTuple2D<float> DefaultShift; //new v2=(0, -20f)
        [FieldOffset(0x2A8)] public float Zoom; // range[0.5~1.5], Game settings->interface->map zoom
    }
}
