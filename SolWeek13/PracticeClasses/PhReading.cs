using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHReading_Class_Example
{
    internal class PhReading
    {
        private double _pH;
        private string _date;

        /// <summary>
        /// Creates a new pH reading
        /// </summary>
        /// <param name="ph">The actual pH value recorded</param>
        /// <param name="date">The date the pH value was recorded</param>
        public PhReading(double ph, string date)
        {
            Ph = ph;
            Date = date;
        }

        /// <summary>
        /// Ph property used to set and get the internal pH
        /// </summary>
        public double Ph
        {
            get
            {
                return _pH;
            }

            set
            {
                if (value < 0 || value > 14)
                {
                    throw new Exception("ph must be between 0 and 14");
                }

                _pH = value;
            }
        }


        /// <summary>
        /// Sets and gets the date internal value
        /// </summary>
        public string Date
        {
            get
            {
                return _date;
            }

            set
            {
                if (IsValidDateFormat(value) == false)
                {
                    throw new Exception("Date must be in the format MM-DD-YYYY");
                }

                _date = value;
            }
        }

        /// <summary>
        /// Validates a date. Must be in the format MM-DD-YYYY.
        /// </summary>
        /// <param name="date">The date to check</param>
        /// <returns>True if the date is valid, false otherwise.</returns>
        public static bool IsValidDateFormat(string date)
        {
            bool isValid = true;
            string[] parts = date.Split('-');
            int day;
            int month;
            int year;

            try
            {
                if (parts.Length != 3)
                {
                    isValid = false;
                }
                else if (parts[0].Length != 2 || parts[1].Length != 2 || parts[2].Length != 4)
                {
                    isValid = false;
                }
                else
                {
                    // check that all parts are ints
                    month = int.Parse(parts[0]);
                    day = int.Parse(parts[1]);
                    year = int.Parse(parts[2]);

                    // check for correct ranges
                    if (month < 1 || month > 12)
                    {
                        isValid = false;
                    }
                    else if (day < 1 || day > 31)
                    {
                        isValid = false;
                    }
                    else if (year < 1000 || year > 9999)
                    {
                        isValid = false;
                    }
                }
            }
            catch
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
