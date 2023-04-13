using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace OpenSilverAttachedProperty
{
    internal class CustomAttachedPropertiesGeneric<TA> : DependencyObject
    {
        // Define the MyTextProperty attached property
        public static readonly DependencyProperty MyStorageProperty =
            DependencyProperty.RegisterAttached("MyStorage", typeof(string), typeof(CustomAttachedPropertiesGeneric<TA>), new PropertyMetadata(null));

        // Get method for the MyTextProperty attached property
        public static TA GetMyStorage(DependencyObject obj)
        {
            return (TA)obj.GetValue(MyStorageProperty);
        }

        // Set method for the MyTextProperty attached property
        public static void SetMyStorage(DependencyObject obj, TA value)
        {
            obj.SetValue(MyStorageProperty, value);
        }
    }
}
