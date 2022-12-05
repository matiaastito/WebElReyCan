﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebElReyCan.Validations
{
    public class CheckValidationCellphone:ValidationAttribute
    {
        public CheckValidationCellphone()
        {
            ErrorMessage = "Deben ser solo numeros"; 
        }

        public override bool IsValid(object value)
        {
            string cell = value.ToString();

            Regex miregex = new Regex(@"^\d+");

            if(miregex.IsMatch(cell)) return true;
            else return false;  
        }

    }
}