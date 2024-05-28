namespace LinuxForms.Forms;

public class ContainerControl : ScrollableControl
{
    protected override Eto.Forms.Panel panel => throw new NotImplementedException();

    public System.Drawing.SizeF AutoScaleDimensions { get; set; }
    public AutoScaleMode AutoScaleMode { get; set; }
}