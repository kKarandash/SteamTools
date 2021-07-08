using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;

namespace System.Application.UI.Activities
{
    [Register(JavaPackageConstants.Activities + nameof(ExportAuthActivity))]
    [Activity(Theme = ManifestConstants.MainTheme_NoActionBar,
        LaunchMode = LaunchMode.SingleTask,
        ConfigurationChanges = ManifestConstants.ConfigurationChanges)]
    internal sealed class ExportAuthActivity : BaseActivity
    {
        protected override int? LayoutResource => throw new NotImplementedException();

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}