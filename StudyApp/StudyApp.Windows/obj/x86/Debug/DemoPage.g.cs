﻿

#pragma checksum "D:\Mod\Documents\New folder\StudyApp\StudyApp\StudyApp.Shared\DemoPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "372D9668DFFC78687E1A1F0486C3B009"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudyApp
{
    partial class DemoPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 15 "..\..\..\DemoPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnEnglish_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 23 "..\..\..\DemoPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.btnMaths_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 71 "..\..\..\DemoPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.linkQuit_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 72 "..\..\..\DemoPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.comboList_SelectionChanged;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


