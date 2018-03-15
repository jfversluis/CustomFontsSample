using System;
using System.Text;
using Foundation;
using UIKit;

namespace CustomFontsSample.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            // Nifty helper to get all fonts with the right names in your console
#if DEBUG
            var fontList = new StringBuilder();
            var familyNames = UIFont.FamilyNames;
            foreach (var familyName in familyNames)
            {
                fontList.Append(String.Format("Family: {0}\n", familyName));
                Console.WriteLine("Family: {0}\n", familyName);
                var fontNames = UIFont.FontNamesForFamilyName(familyName);
                foreach (var fontName in fontNames)
                {
                    Console.WriteLine("\tFont: {0}\n", fontName);
                    fontList.Append(String.Format("\tFont: {0}\n", fontName));
                }
            };
#endif
            global::Xamarin.Forms.Forms.Init();

            UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes
            {
                TextColor = UIColor.Black,
                Font = UIFont.FromName("ComicSansMS", 24)
            });

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}