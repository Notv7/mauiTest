using Android.App;
using Android.Appwidget;
using Android.Content;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Platforms.Android
{
    
        [BroadcastReceiver(Label = "HellApp Widget", Exported = true)]
        [IntentFilter(new string[] { "android.appwidget.action.APPWIDGET_UPDATE" })]
        [MetaData("android.appwidget.provider", Resource = "@xml/appwidget_provider_metadata")]
        [Service(Exported = true)]
        public class AppWidget : AppWidgetProvider
        {
            public override void OnUpdate(Context context, AppWidgetManager appWidgetManager, int[] appWidgetIds)
            {
                var me = new ComponentName(context, Java.Lang.Class.FromType(typeof(AppWidget)).Name);
                appWidgetManager.UpdateAppWidget(me, BuildRemoteViews(context, appWidgetIds));
            }

            private RemoteViews BuildRemoteViews(Context context, int[] appWidgetIds)
            {
                var widgetView = new RemoteViews(context.PackageName, Resource.Layout.Widget);

           /*     SetTextViewText(widgetView);*/

                return widgetView;
            }
/*            private void SetTextViewText(RemoteViews widgetView)
            {
                widgetView.SetTextViewText(Resource.Id.widgetMedium, "HelloAppWidget");
                widgetView.SetTextViewText(Resource.Id.widgetSmall,
                    string.Format("Last update: {0:H:mm:ss}", DateTime.Now));
            }*/

/*            public override void OnReceive(Context context, Intent intent) { }*/

        }
    }

