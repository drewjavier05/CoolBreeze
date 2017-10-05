using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CoolBreeze;
using CoolBreeze.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButton_Android))]
namespace CoolBreeze.Droid
{
    using Android.Graphics.Drawables;
    using  Xamarin.Forms;
    using Xamarin.Forms.Platform.Android;

    class CustomButton_Android : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (Control == null) return;
            var gradientDrawable = new GradientDrawable();
            gradientDrawable.SetShape(ShapeType.Rectangle);
            gradientDrawable.SetColor(Element.BackgroundColor.ToAndroid(Color.FromRgb(26, 35, 126)));
            gradientDrawable.SetStroke(4, Element.BorderColor.ToAndroid());
            gradientDrawable.SetCornerRadius(30.0f);


            Control.SetBackground(gradientDrawable);
        }

    }
}