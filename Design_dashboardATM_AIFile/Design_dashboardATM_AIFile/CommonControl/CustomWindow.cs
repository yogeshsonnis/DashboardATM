using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Design_dashboardATM_AIFile.CommonControl
{
    public class CustomWindow : Window
    {
        static CustomWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomWindow), new FrameworkPropertyMetadata(typeof(CustomWindow)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            var btnClose = this.GetTemplateChild("PART_CLOSE") as Button;
            var btnMinimize = this.GetTemplateChild("PART_MINIMIZE") as Button;
            var btnMaximize = this.GetTemplateChild("PART_MAXIMIZE_RESTORE") as Button;
            //var btnDragMove = this.GetTemplateChild("PART_TITLEBAR") as Button;

            btnMinimize.Click += btnMinimize_Click;

            btnClose.Click += btnClose_Click;
            btnMaximize.Click += btnmaximize_Click;
            //btnDragMove.Click += btnDragMove_Click;

        }

        void btnDragMove_Click(object sender, RoutedEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        void btnmaximize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = (WindowState == WindowState.Normal) ? WindowState.Maximized : WindowState.Normal;
        }

        void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
