using System;
using NullablePicker.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using System.Collections.Generic;
using NullablePicker.Controls;

[assembly: ExportRenderer(typeof(ClearablePicker), typeof(NullablePickerRenderer))]
namespace NullablePicker.iOS.Renderers
{
    public class NullablePickerRenderer : PickerRenderer
    {
       

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null && this.Control != null)
            {
                this.AddClearButton();
            }

        }

        private void AddClearButton()
        {

            if (this.Control.InputAccessoryView is UIToolbar originalToolbar && originalToolbar.Items.Length <= 2)
            {
                string clearLabel = "clear";

                var clearButton = new UIBarButtonItem(clearLabel, UIBarButtonItemStyle.Plain, ((sender, ev) =>
                {
                    ClearablePicker baseDatePicker = this.Element as ClearablePicker;
                    this.Element.Unfocus();
                    baseDatePicker.SelectedIndex = -1;

                }));

                var newItems = new List<UIBarButtonItem>();
                foreach (var item in originalToolbar.Items)
                {
                    newItems.Add(item);
                }

                newItems.Insert(0, clearButton);

                originalToolbar.Items = newItems.ToArray();
                originalToolbar.SetNeedsDisplay();
            }

        }
    }
}
