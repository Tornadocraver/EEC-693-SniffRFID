using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Nfc;
using Android.Nfc.Tech;
using Android.Nfc.CardEmulators;
using Android.OS;
using Java.Lang;
using Java.Security;
using Plugin.NFC;
using Android.Net.Eap;
using Android.Media;
using Java.Nio.Channels;

namespace SniffRFID;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    public MainActivity() { }

    protected override void OnCreate(Bundle savedInstanceState)
    {
        CrossNFC.Init(this);
        base.OnCreate(savedInstanceState);
    }

    protected override void OnResume()
    {
        base.OnResume();
        CrossNFC.OnResume();
    }

    protected override void OnNewIntent(Intent intent)
    {
        base.OnNewIntent(intent);
        CrossNFC.OnNewIntent(intent);
    }
}