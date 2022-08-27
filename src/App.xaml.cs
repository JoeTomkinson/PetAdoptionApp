using Newtonsoft.Json;

namespace PetAdoptionApp;

public partial class App : Application
{
    public static ResourceDictionary ColourDictionary { get; private set; }

	public App(AppShell appShell)
	{
		InitializeComponent();
        ColourDictionary = Application.Current.Resources.MergedDictionaries.Where(md => md.Source.OriginalString == "Resources/Styles/Colors.xaml;assembly=PetAdoptionApp").FirstOrDefault();
        MainPage = appShell;
    }

#if __IOS__
  private DisplayOrientation _lastOrientation;
  
	protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);


        window.Created += (s, e) =>
        {
            UpdateStatusBarColor();
        };

        window.Destroying += (s, e) =>
        {
            NSNotificationCenter.DefaultCenter.RemoveObserver(new NSString("UIDeviceOrientationDidChangeNotification"));
        };

        return window;
    }

    private void UpdateStatusBarColor()
    {
        UIView statusBar;
        if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
        {
            int tag = 4567890;

            UIWindow window = UIApplication.SharedApplication.Delegate.GetWindow();
            statusBar = window.ViewWithTag(tag);

            if (statusBar == null || statusBar.Frame != UIApplication.SharedApplication.StatusBarFrame)
            {
                statusBar = statusBar ?? new(UIApplication.SharedApplication.StatusBarFrame);
                statusBar.Frame = UIApplication.SharedApplication.StatusBarFrame;
                statusBar.Tag = tag;

                window.AddSubview(statusBar);
            }
        }
        else
        {
            statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) as UIView;
        }

        if (statusBar != null)
        {
            // TODO Make this color come from somewhere shared
            statusBar.BackgroundColor = Color.FromArgb("#2B0B98").ToUIColor();
        }

        NSNotificationCenter.DefaultCenter.AddObserver(new NSString("UIDeviceOrientationDidChangeNotification"), NotificationCenter =>
        {
            // This gets called multiple times on iOS, let's optimize a little bit
            if (_lastOrientation != DeviceDisplay.MainDisplayInfo.Orientation)
            {
                UpdateStatusBarColor();
                _lastOrientation = DeviceDisplay.MainDisplayInfo.Orientation;
            }
        });
    }
#endif
}
