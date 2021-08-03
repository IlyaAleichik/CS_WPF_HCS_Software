﻿#pragma checksum "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33CA748DF80E304958A3E93D02B427C620CB6ABC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Xpf.DXBinding;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using TKP.Styles.CustomizedWindow;


namespace TKP.Styles.CustomizedWindow {
    
    
    /// <summary>
    /// WindowStyle
    /// </summary>
    public partial class WindowStyle : System.Windows.ResourceDictionary, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TKP;component/styles/customizedwindow/windowstyle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 86 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TitleBarMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 87 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Controls.Border)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.TitleBarMouseMove);
            
            #line default
            #line hidden
            break;
            case 2:
            
            #line 105 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.IconMouseLeftButtonDown);
            
            #line default
            #line hidden
            break;
            case 3:
            
            #line 126 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MinButtonClick);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 145 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MaxButtonClick);
            
            #line default
            #line hidden
            break;
            case 5:
            
            #line 165 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseButtonClick);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 186 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Shapes.Line)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeNorth);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 194 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Shapes.Line)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeSouth);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 203 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Shapes.Line)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeWest);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 211 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Shapes.Line)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeEast);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 219 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeNorthWest);
            
            #line default
            #line hidden
            break;
            case 11:
            
            #line 220 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeNorthEast);
            
            #line default
            #line hidden
            break;
            case 12:
            
            #line 221 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeSouthWest);
            
            #line default
            #line hidden
            break;
            case 13:
            
            #line 222 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeSouthEast);
            
            #line default
            #line hidden
            break;
            case 14:
            
            #line 298 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TitleBarMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 299 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Controls.Border)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.TitleBarMouseMove);
            
            #line default
            #line hidden
            break;
            case 15:
            
            #line 317 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.IconMouseLeftButtonDown);
            
            #line default
            #line hidden
            break;
            case 16:
            
            #line 338 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MinButtonClick);
            
            #line default
            #line hidden
            break;
            case 17:
            
            #line 357 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MaxButtonClick);
            
            #line default
            #line hidden
            break;
            case 18:
            
            #line 377 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseButtonClick);
            
            #line default
            #line hidden
            break;
            case 19:
            
            #line 398 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Shapes.Line)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeNorth);
            
            #line default
            #line hidden
            break;
            case 20:
            
            #line 406 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Shapes.Line)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeSouth);
            
            #line default
            #line hidden
            break;
            case 21:
            
            #line 415 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Shapes.Line)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeWest);
            
            #line default
            #line hidden
            break;
            case 22:
            
            #line 423 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Shapes.Line)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeEast);
            
            #line default
            #line hidden
            break;
            case 23:
            
            #line 431 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeNorthWest);
            
            #line default
            #line hidden
            break;
            case 24:
            
            #line 432 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeNorthEast);
            
            #line default
            #line hidden
            break;
            case 25:
            
            #line 433 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeSouthWest);
            
            #line default
            #line hidden
            break;
            case 26:
            
            #line 434 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeSouthEast);
            
            #line default
            #line hidden
            break;
            case 27:
            
            #line 508 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TitleBarMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 509 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Controls.Border)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.TitleBarMouseMove);
            
            #line default
            #line hidden
            break;
            case 28:
            
            #line 541 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseButtonClick);
            
            #line default
            #line hidden
            break;
            case 29:
            
            #line 562 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeNorthWest);
            
            #line default
            #line hidden
            break;
            case 30:
            
            #line 563 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeNorthEast);
            
            #line default
            #line hidden
            break;
            case 31:
            
            #line 564 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeSouthWest);
            
            #line default
            #line hidden
            break;
            case 32:
            
            #line 565 "..\..\..\..\Styles\CustomizedWindow\WindowStyle.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSizeSouthEast);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

