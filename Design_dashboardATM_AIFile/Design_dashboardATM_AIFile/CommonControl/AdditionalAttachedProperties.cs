﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Design_dashboardATM_AIFile.CommonControl
{
    public class AdditionalAttachedProperties
    {
        public static readonly DependencyProperty GeometryDataProperty = DependencyProperty.RegisterAttached(
            "GeometryData",
            typeof(ImageSource),
            typeof(AdditionalAttachedProperties),
            new PropertyMetadata(null));

        public static readonly DependencyProperty PathDataProperty = DependencyProperty.RegisterAttached(
            "PathData",
            typeof(Geometry),
            typeof(AdditionalAttachedProperties),
            new PropertyMetadata(null));


        public static ImageSource GetGeometryData(DependencyObject obj)
        {
            return (ImageSource)obj.GetValue(GeometryDataProperty);
        }


        public static void SetGeometryData(DependencyObject obj, ImageSource value)
        {
            obj.SetValue(GeometryDataProperty, value);
        }

        public static Geometry GetPathData(DependencyObject obj)
        {
            return (Geometry)obj.GetValue(PathDataProperty);
        }

        public static void SetPathData(DependencyObject obj, Geometry value)
        {
            obj.SetValue(PathDataProperty, value);
        }
    }
}
