﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.Wpf;

namespace Drawing.Utils
{
    internal class OpenPageSelf:ILifeSpanHandler
    {
        public bool DoClose(IWebBrowser browserControl,IBrowser browser)
        {
            return false;
        }

        public void OnAfterCreated(IWebBrowser browserControl,IBrowser browser)
        {
           
        }

        public void OnBeforeClose(IWebBrowser chromiumWebBrowser,IBrowser browser)
        {

        }

        public bool OnBeforePopup(IWebBrowser browserControl, IBrowser browser, IFrame frame, string targetUrl,
            string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures,
            IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
        {
            newBrowser = null;
            var chromiumWebBrowser = (ChromiumWebBrowser)browserControl;
            chromiumWebBrowser.Load(targetUrl);
            return true; //Return true to cancel the popup creation copyright by codebye.com.
        }
    }
}
