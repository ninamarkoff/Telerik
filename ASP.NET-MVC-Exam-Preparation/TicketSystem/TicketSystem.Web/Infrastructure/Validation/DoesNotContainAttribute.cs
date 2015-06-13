using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TicketSystem.Web.Infrastructure.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DoesNotContainAttribute : ValidationAttribute
    {
        private string word;
        public DoesNotContainAttribute(string word)
        {
            this.word = word;
            this.ErrorMessage = "{0} should not contain the word: " + word;
        }
        public override bool IsValid(object value)
        {
            var valueAsString = value as string;
            if (valueAsString == null)
            {
                throw new ArgumentException("Attribute not set on string property");
            }

            if (!valueAsString.Contains(word))
            {
                return true;
            }

            return false;            
        }
    }
}