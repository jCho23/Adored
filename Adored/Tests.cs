using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace Adored
{
	[TestFixture]
	public class Tests
	{
		AndroidApp app;

		[SetUp]
		public void BeforeEachTest()
		{
			// TODO: If the Android app being tested is included in the solution then open
			// the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			app = ConfigureApp
				.Android
				// TODO: Update this path to point to your Android app and uncomment the
				// code if the app is not included in the solution.
				.ApkFile ("/Users/junecho/Desktop/Adored.apk")
				.StartApp();
		}

		[Test]
		public void AppLaunches()
		{
			app.Query(c => c.Class("webview").Css("iframe").
			app.Repl();

			app.Query(x => x.Raw("XWalkCordovaView css:'iframe' css:'*'"));
			app.Query(x => x.Raw("XWalkCordovaView css:'iframe' css:'*' {textContcvbent LIKE 'Allow Location Access'}"));
			app.Query(x => x.Raw("XWalkCordovaView css:'iframe' css:'*'"));
			app.Tap(x => x.Raw("XWalkCordovaView css:'iframe' css:'#next-page-button'"));
			app.Tap(x => x.Raw("XWalkCordovaView css:'iframe' css:'#next-page-button'"));
			app.Tap(x => x.Raw("XWalkCordovaView css:'iframe' css:'*'"));
			app.Tap(x => x.Raw("XWalkCordovaView css:'iframe' css:'*'"));
			app.Query(x => x.Raw("XWalkCordovaView css:'iframe' css:'*'"));
			app.Query(x => x.Raw("XWalkCordovaView css:'iframe' css:'*' {y < 930}"));
			app.Query(x => x.Raw("XWalkCordovaView css:'iframe' css:'*' {y > 930}"));
			app.Query(x => x.Raw("XWalkCordovaView css:'iframe' css:'*' {y > 130}"));
			app.Query(x => x.Raw("XWalkCordovaView css:'iframe' css:'*' {y > 30}"));
			app.Query(x => x.Raw("XWalkCordovaView css:'iframe' css:'*' {y > 0}"));
			app.Query(x => x.Raw("XWalkCordovaView css:'iframe' css:'*'"));
			app.Query(x => x.Raw("XWalkCordovaView css:'iframe' css:'*'")).Select(c => c.Rect.Y > 930);
			app.Query(x => x.Raw("XWalkCordovaView css:'iframe' css:'*'")).Where(c => c.Rect.Y > 930);
			app.Query(x => x.Raw("XWalkCordovaView css:'iframe' css:'*'")).Where(c => c.Rect.Y > 930).Where(c => c.Rect.Y < 1550);
			app.Query(x => x.Raw("ALL XWalkCordovaView css:'iframe' css:'*'"));
			app.Query(x => x.Raw("all XWalkCordovaView css:'iframe' css:'*'"));
		}
	}
}

