﻿using Android.App;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Views;
using Com.Wang.Avi;

namespace PrivateGallery.Android.Helpers
{
    internal static class UiInitializators
    {
        public static void InitializeLoadingDialog(this Dialog dialog)
        {
            dialog.SetContentView(Resource.Layout.LoadingDialog);
            dialog.SetCancelable(false);
            dialog.Window.SetBackgroundDrawable(new ColorDrawable(Color.Transparent));
            var layoutParams = new WindowManagerLayoutParams();
            layoutParams.CopyFrom(dialog.Window.Attributes);
            layoutParams.Height = layoutParams.Width = ViewGroup.LayoutParams.WrapContent;
            dialog.Window.Attributes = layoutParams;
            //dialog.Window.RequestFeature(WindowFeatures.NoTitle);
            var indicatorView = dialog.FindViewById<AVLoadingIndicatorView>(Resource.Id.indicator);
            indicatorView.SmoothToShow();
        }

    }
}