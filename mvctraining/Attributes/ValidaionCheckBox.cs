﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
namespace mvctraining.Attributes
{
     
        public class ValidateCheckBox : ValidationAttribute , IClientModelValidator
        {
            public void AddValidation(ClientModelValidationContext context)
            {
            //context.Attributes.Add("", ErrorMessage);
            context.Attributes.Add("data-val-checkbox", ErrorMessage);
        }

            public override bool IsValid(object value)
            {
                return (bool)value;
            }
        }

     
}
