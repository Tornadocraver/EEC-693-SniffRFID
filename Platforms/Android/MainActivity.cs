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
using SniffRFID.Platforms.Android;
using Android.Net.Eap;
using Android.Media;
using Java.Nio.Channels;

namespace SniffRFID;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity //, NfcAdapter.IReaderCallback
{
    //public static MainActivity ActivityCurrent { get; set; }
    //private NfcAdapter Adapter;

    public MainActivity()
    {
        //ActivityCurrent = this;
    }

    protected override void OnCreate(Bundle savedInstanceState)
    {
        CrossNFC.Init(this);
        base.OnCreate(savedInstanceState);

        // ** CODE BELOW DID NOT WORK, BUT LEFT IN FOR FUTURE REFERENCE ** \\
        //
        //var i = new Intent(this, typeof(EmulatorService));
        //StartService(i);
        //var s = GetSystemService("android.nfc.cardemulation.action.HOST_APDU_SERVICE");

        //var r = new NdefRecord[] { new NdefRecord() {
        //    TypeFormat = NFCNdefTypeFormat.WellKnown,
        //    Payload = System.Text.Encoding.UTF8.GetBytes("HELLO!!!"),
        //    LanguageCode = "en" }
        //};

        //string msg = "HELLO!!";
        //byte[] lang = System.Text.Encoding.ASCII.GetBytes("en");
        //byte[] bytes = System.Text.Encoding.UTF8.GetBytes(msg);

        //byte[] payload = new byte[1 + lang.Length + bytes.Length];
        //payload[0] = (byte)0x02;
        //Array.Copy(lang, 0, payload, 1, lang.Length);
        //Array.Copy(bytes, 0, payload, 1 + lang.Length, bytes.Length);

        //NdefMessage m;
        //NdefRecord[] records = new NdefRecord[1];
        //NdefRecord text = new NdefRecord(NdefRecord.TnfWellKnown, NdefRecord.RtdText.ToArray(), new byte[] { }, payload);
        //records[0] = text;
        //m = new NdefMessage(records);

        //Adapter = NfcAdapter.GetDefaultAdapter(this);
        //Adapter.SetNdefPushMessage(m, this);
        //Adapter.EnableReaderMode(this, this, NfcReaderFlags.NfcA | NfcReaderFlags.SkipNdefCheck, null);
        //Adapter.InvokeBeam(this);
    }

    //private bool isRunning(Java.Lang.Class service)
    //{
    //    ActivityManager man = (ActivityManager)GetSystemService(MainActivity.ActivityService);
    //    foreach (var srv in man.GetRunningServices(500))
    //    {
    //        if (srv.GetType().Name == service.getclass)
    //    }
    //}

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

    //public void OnTagDiscovered(Tag tag)
    //{
    //    IsoDep dep = IsoDep.Get(tag);
    //    dep.Connect();
    //    byte[] res = dep.Transceive(new byte[] { 0x02, 0xF2, 0x5B, 0x0A });
    //}
}