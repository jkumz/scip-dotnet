namespace Main.Nested.Alpha
{
    public class Widget
    {
    }
}

namespace Main.Other.Alpha
{
    public class Widget
    {
    }
}

namespace Main
{
    namespace Nested
    {
        namespace Gamma
        {
            public class Widget
            {
                public Alpha.Widget First = new();
                public Main.Other.Alpha.Widget Second = new();
            }
        }
    }
}
