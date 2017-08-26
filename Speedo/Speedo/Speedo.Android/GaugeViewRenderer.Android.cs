﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Speedo.Droid;
using Java.Lang;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(GaugeView), typeof(GaugeViewRenderer))]
namespace Speedo.Droid
{
    class GaugeViewRenderer : ViewRenderer<Gauge, GaugeView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Gauge> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {

            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == Gauge.AccentColorProperty.PropertyName)
            {
                //......
            }
        }
    }
}