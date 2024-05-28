using Eto.Forms;
using LinuxForms.Helper;
using System.Drawing;

namespace LinuxForms.Forms;

public abstract class Control
{
    protected abstract Eto.Forms.Panel panel { get; }

    public class ControlCollection : PixelLayout
    {
        public void Add(Control value) => Add(value.panel, value.Location.ToEto());
    }

    public Control()
    {
        panel.Content = Controls;
    }

    public string Name { get; set; } = "";
    public Point Location
    {
        get => PixelLayout.GetLocation(panel).ToSystem();
        set => PixelLayout.SetLocation(panel, value.ToEto());
    }

    public int Left
    {
        get => Location.X;
        set => Location = new Point(value, Location.Y);
    }
    public int Right => Left + Size.Width;
    public int Top
    {
        get => Location.Y;
        set => Location = new Point(Location.X, value);
    }
    public int Bottom => Top + Size.Height;

    private Size size = Size.Empty;
    public Size Size
    {
        get => size;
        set
        {
            size = value;
            panel.Size = value.ToEto();
        }
    }
    public int Width
    {
        get => Size.Width;
        set => Size = new Size(value, Size.Height);
    }
    public int Height
    {
        get => Size.Height;
        set => Size = new Size(Size.Width, value);
    }

    private Size clientSize = Size.Empty;
    public Size ClientSize
    {
        get => clientSize;
        set
        {
            clientSize = value;
            panel.ClientSize = value.ToEto();
        }
    }

    public int TabIndex
    {
        get => panel.TabIndex;
        set => panel.TabIndex = value;
    }

    public ControlCollection Controls { get; } = new();

    public virtual object? DataContext { get; set; }

    public void SuspendLayout() { }
    public void ResumeLayout(bool performLayout) { }
    public void PerformLayout() { }
}
