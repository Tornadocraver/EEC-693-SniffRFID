using Android.App;
using Android.Content;
using Android.Nfc;
using Android.Nfc.CardEmulators;
using Android.OS;
using Android.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniffRFID.Platforms.Android
{
    // ** CODE BELOW DID NOT WORK, BUT LEFT IN FOR FUTURE REFERENCE ** \\
    //
    //[Service(Exported = true, Enabled = true, Permission = "android.permission.BIND_NFC_SERVICE"),
    //    IntentFilter(new[] { "android.nfc.cardemulation.action.HOST_APDU_SERVICE" }, Categories = new[] { "android.intent.category.DEFAULT" } )]
    //[Service(Exported = true, Enabled = true)]
    //[IntentFilter(new[] { "android.nfc.cardemulation.action.HOST_APDU_SERVICE" },
    //    Categories = new[] { "android.intent.category.DEFAULT" })]
    //public class EmulatorService : HostApduService
    //{
    //    public override void OnDeactivated([GeneratedEnum] DeactivationReason reason)
    //    {

    //    }

    //    public override byte[] ProcessCommandApdu(byte[] commandApdu, Bundle extras)
    //    {
    //        return new byte[] { 0xFF, 0x11, 0xCC, 0x23 };
    //    }
    //}
}