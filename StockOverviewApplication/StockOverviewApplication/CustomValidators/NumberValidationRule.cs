using System;
using System.Globalization;
using System.Windows.Controls;

namespace StockOverviewApplication.CustomValidators
{
    /// <summary>
    /// Class that implements validation for numerical data
    /// </summary>
    public class NumberValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value == null)
                return new ValidationResult(false, "Value cannot be empty");
            try
            {
                if(Convert.ToSingle(value) <= 0.0F)
                {
                    return new ValidationResult(false, "Invalid entry.");
                }
                return new ValidationResult(true, "Valid entry");
            }
            catch
            {
                return new ValidationResult(false, "Invalid entry");
            }
        }
    }
}
