using System.ComponentModel;

namespace LinuxForms;

public static class Application
{
    private static Eto.Forms.Application application;

    static Application()
    {
        application = new();
    }

    internal static void PrivateInitialize() { }

    public static void Run(LinuxForms.Forms.Form form) => application.Run(form.AsEtoForm());
}