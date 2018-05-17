﻿using System;
using System.Globalization;
using Xamarin.Forms;
using CRM.Data;

namespace CRM.Models.Converters
{
    public class PaymentStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                //get enum value by index
                return ((PaymentPickerData.Status)((byte)value));
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public string Convert(byte value)
        {
            try
            {
                //get enum value by index
                return ((PaymentPickerData.Status)value).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                PaymentPickerData.Status paymentStatus = (PaymentPickerData.Status)Enum.Parse(typeof(PaymentPickerData.Status), (string)value);

                //get enum index by value
                return (int)paymentStatus;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int ConvertBack(string value)
        {
            try
            {
                PaymentPickerData.Status paymentStatus = (PaymentPickerData.Status)Enum.Parse(typeof(PaymentPickerData.Status), value);

                //get enum index by value
                return (int)paymentStatus;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
