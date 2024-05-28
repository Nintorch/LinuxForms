namespace LinuxForms.Forms;

public abstract class ButtonBase : Control
{
    public abstract string Text { get; set; }
    public bool UseVisualStyleBackColor { get; set; } // ignore
}