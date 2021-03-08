using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LAB2_3
{
    public class ProcessorValidationAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string processorName = value.ToString();
                if (processorName.Contains("AMD") || processorName.Contains("Intel"))
                    return true;
                else this.ErrorMessage = "Процессора не существует";
            }
            return false;
        }
    }
}
