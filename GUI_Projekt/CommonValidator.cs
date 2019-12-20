using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GUI_Projekt
{
    class CommonValidator : ValidationRule
    {
        public bool Required { get; set; } = false;
        public int MinLength { get; set; } = 0;
        public int MaxLength { get; set; } = int.MaxValue;
        public string FieldName { get; set; } = "Feld";

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string myString = Convert.ToString(value);
            if (string.IsNullOrEmpty(myString) && Required)
            {
                return new ValidationResult(false, $"{this.FieldName} darf nicht leer gelassen werden");
            }
            else if (myString.Length < this.MinLength && myString.Length > 0)
            {
                return new ValidationResult(false, $"{this.FieldName} muss mindestens {this.MinLength} Zeichen lang sein.");
            }
            else if (myString.Length > this.MaxLength)
            {
                return new ValidationResult(false, $"{this.FieldName} darf maximal {this.MaxLength} Zeichen lang sein ({myString.Length})");
            }
            else
            {
                return new ValidationResult(true, "");
            }
        }
    }
}
