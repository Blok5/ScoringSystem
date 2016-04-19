using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ScoringSystem {
    /// <summary>
    /// Class which content validation functions
    /// </summary>
    public static class Validation {

        /// <summary>
        /// Check field on the numerical value
        /// </summary>
        /// <param name="checkStr">checked field</param>
        /// <param name="errorMessage">Error message</param>
        /// <returns>Valid or not(true folse)</returns>
        public static bool isNumberValue(string checkStr, out string errorMessage) {
            int parsedValue;

            if (!int.TryParse(checkStr, out parsedValue)) {
                errorMessage = "Пожалуйста, введите числовое значение!";
                return false;
            }

            if (checkStr.Length == 0) {
                errorMessage = "Поле не должно быть пустым!";
                return false;
            }

            errorMessage = "";
            return true;
        }

        /// <summary>
        /// Check field on the telephone number
        /// </summary>
        /// <param name="checkStr">checked field</param>
        /// <param name="errorMessage">Error message</param>
        /// <returns>Valid or not(true folse)</returns>
        public static bool isPhoneNumber(string checkStr, out string errorMessage) {
            //Regex.Match(checkStr, @"^(\+[0-9]{9})$").Success
            if (true) {
                errorMessage = "";
                return true;
            } else {
                errorMessage = "Введите корректный номер телефона!";
                return false;
            }

        }
    }


}
