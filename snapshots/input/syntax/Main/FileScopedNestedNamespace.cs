using Main.Nested.Alpha;

namespace Main.FileScoped.Alpha;

public class Widget
{
    public Main.Nested.Alpha.Widget Nested = new();
    public Main.Other.Alpha.Widget Other = new();
    public Main.Nested.Gamma.Widget Gamma = new();
}
