namespace LinuxForms.Forms;

public class Button : ButtonBase
{
    protected override Eto.Forms.Panel panel { get; } = new();
    private readonly Eto.Forms.Button button = new();

    public Button()
    {
        panel.Content = button;
    }

    public override string Text
    {
        get => button.Text;
        set => button.Text = value;
    }
}