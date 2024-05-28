namespace LinuxForms.Helper;

public static class Converter
{
    public static Eto.Drawing.Point ToEto(this System.Drawing.Point p) => new(p.X, p.Y);
    public static System.Drawing.Point ToSystem(this Eto.Drawing.Point p) => new(p.X, p.Y);

    public static System.Drawing.Size ToSystem(this Eto.Drawing.Size s) => new(s.Width, s.Height);
    public static Eto.Drawing.Size ToEto(this System.Drawing.Size s) => new(s.Width, s.Height);
}