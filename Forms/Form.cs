using LinuxForms.Helper;

namespace LinuxForms.Forms;

public class Form : ContainerControl
{
    protected override Eto.Forms.Form panel { get; } = new Eto.Forms.Form();

    protected virtual void Dispose(bool disposing) { }

    public string Text
    {
        get => panel.Title;
        set => panel.Title = value;
    }

    public void Close() => panel.Close();

    public Eto.Forms.Form AsEtoForm() => panel;
}