using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using AndroidX.AppCompat.App;
using AndroidX.Core.View;
using Microsoft.Maui.Controls;

namespace PetAdoptionApp;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        WindowCompat.SetDecorFitsSystemWindows(Window, false);
        Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#f6f4f0"));
        base.OnCreate(savedInstanceState);
    }

    public override void OnWindowFocusChanged(bool hasFocus)
    {
        if (Build.VERSION.SdkInt >= BuildVersionCodes.R)
        {
            try
            {
                Window?.InsetsController?.SetSystemBarsAppearance((int)WindowInsetsControllerAppearance.LightStatusBars, (int)WindowInsetsControllerAppearance.LightStatusBars);
            }
            catch (Exception ex)
            {

            }
        }
        else
        {
#pragma warning disable CS0618
            Window.DecorView.SystemUiVisibility = (StatusBarVisibility)SystemUiFlags.LightStatusBar;
#pragma warning restore CS0618
        }
        base.OnWindowFocusChanged(hasFocus);
    }
}