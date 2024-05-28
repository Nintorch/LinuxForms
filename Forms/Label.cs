namespace LinuxForms.Forms;

public class Label : Control
{
    protected override Eto.Forms.Panel panel { get; } = new();
    private readonly Eto.Forms.Label label = new();

    public Label()
    {
        panel.Content = label;
    }

    public bool AutoSize { get; set; } // doesn't work though
    public string Text
    {
        get => label.Text;
        set => label.Text = value;
    }
}