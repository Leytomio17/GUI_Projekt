using System;
using System.Globalization;
using System.Net.Mail;
using System.Windows.Controls;

namespace GUI_Projekt
{
    class EMailValidator : ValidationRule
    {
        public Type ValidationType { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {


            string strValue = Convert.ToString(value);

            if (!string.IsNullOrEmpty(strValue))
            {
                if (IsValid(strValue))
                {
                    return new ValidationResult(true, "");
                }
                else
                {
                    return new ValidationResult(false, "E-Mail Adresse ungültig!");
                }
            }
            else
            {
                return new ValidationResult(true, "");
            }
        }

        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
