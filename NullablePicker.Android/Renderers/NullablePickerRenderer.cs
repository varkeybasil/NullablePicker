using System;
using System.ComponentModel;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Widget;
using NullablePicker.Controls;
using NullablePicker.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ClearablePicker), typeof(NullablePickerRenderer))]
namespace NullablePicker.Droid.Renderers
{
    public class NullablePickerRenderer : ViewRenderer<ClearablePicker, EditText>
    {
        readonly Context _context;
        public NullablePickerRenderer(Context context) : base(context)
        {
            _context = context;                                                                      
        }

        protected override void OnElementChanged(ElementChangedEventArgs<ClearablePicker> e)
        {
            base.OnElementChanged(e);
            SetControlStyle();
        }


        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            SetControlStyle();
        }

        private void SetControlStyle()
        {
            if (Control != null)
            {
                Drawable imgDropDownArrow = Resources.GetDrawable(Resource.Drawable.create);
                imgDropDownArrow.SetBounds(5, 5, 5, 5);

                Control.SetCompoundDrawablesRelativeWithIntrinsicBounds(null, null, imgDropDownArrow, null);
            }
        }

      

       
    }
}
