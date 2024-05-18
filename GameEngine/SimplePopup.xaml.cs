    using CommunityToolkit.Maui.Views;
    using Microsoft.Maui.Controls;
    using Microsoft.Maui.Controls.Xaml;
    using System;
    using System.Diagnostics;

namespace GameEngine;

    public partial class SimplePopup : Popup
    {
        public SimplePopup()
        {
            InitializeComponent();
        }

    private void Button_Clicked(object sender, EventArgs e)
    {
#if WINDOWS
    Console.WriteLine("Button clicked - attempting to open folder");
    try
    {
        Process.Start(new ProcessStartInfo
        {
            FileName = "explorer.exe",
            Arguments = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}",
            UseShellExecute = true
        });
        Console.WriteLine("Explorer started");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Failed to open folder: {ex.Message}");
    }
#else
        Console.WriteLine("This functionality is only available on Windows.");
#endif
    }
}
    
