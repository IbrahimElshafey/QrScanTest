﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace QrCodeMobileApp.Views
{
    public class BarcodePage : ContentPage
    {
        ZXingBarcodeImageView barcode;

        public BarcodePage()
        {
            Title = "Generate QR Code";
            var stackLayout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            barcode = new ZXingBarcodeImageView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                AutomationId = "zxingBarcodeImageView",
            };
            barcode.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
            barcode.BarcodeOptions.Width = 300;
            barcode.BarcodeOptions.Height = 300;
            barcode.BarcodeOptions.Margin = 10;
            barcode.BarcodeValue = "ZXing.Net.Mobile";

            var text = new Entry
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Text = "ZXing Sample"
            };
            text.TextChanged += Text_TextChanged;

            stackLayout.Children.Add(barcode);
            stackLayout.Children.Add(text);

            Content = stackLayout;
        }

        void Text_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(e.NewTextValue))
                barcode.BarcodeValue = e.NewTextValue;
        }
    }
}
