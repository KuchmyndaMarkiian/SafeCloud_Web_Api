﻿using Android.App;
using Android.OS;
using Android.Widget;
using ReactiveUI;
using SafeCloud.Droid.Abstractions.View;
using SafeCloud.Droid.ViewModels;

namespace SafeCloud.Droid.Views
{
    [Activity(Label = "AuthorizationView")]
    public class AuthorizationView : ReactiveView<AuthorizationViewModel>
    {
        public override void Init()
        {
            ViewModel?.Init();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetContentView(Resource.Layout.Authorization);

            ViewModel = new AuthorizationViewModel();

            this.Bind(ViewModel, x => x.Login, x => x.LoginEditView.Text);
            this.Bind(ViewModel, x => x.Password, x => x.PasswordEditView.Text);
            this.Bind(ViewModel, x => x.FullContent, x => x.ResultTextView.Text);

            base.OnCreate(savedInstanceState);
        }
        

        public EditText LoginEditView => this.GetControl<EditText>();
        public EditText PasswordEditView => this.GetControl<EditText>();
        public TextView ResultTextView => this.GetControl<TextView>();
    }
}