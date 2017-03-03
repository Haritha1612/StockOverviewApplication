using StockOverviewApplication.Model;
using System;
using System.Globalization;
using System.Windows.Controls;

namespace StockOverviewApplication.CustomValidators
{
    /// <summary>
    /// Class that implements validation for string data
    /// </summary>
    public class StringValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value == null)
                return new ValidationResult(false, "Value cannot be empty");
            try
            {
                if ((StockType)Enum.ToObject(typeof(StockType),value) == StockType.None)
                {
                    return new ValidationResult(false, "Please select the stock type.");
                }
                return new ValidationResult(true, "Valid entry");
            }
            catch
            {
                return new ValidationResult(false, "Invalid Data");
            }
        }
    }
}
