using System;
using System.Windows.Forms;
using FluentValidation;
using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tools
{
    public static class ValidatorTool
    {
        public static bool Validate(IValidator validator, IEntity entity)
        {
            var result = true;
            var validationResult = validator.Validate(entity);
            if (!validationResult.IsValid)
            {
                string message = null;
                foreach (var error in validationResult.Errors) message += error.ErrorMessage + Environment.NewLine;

                MessageBox.Show(message);
                result = false;
            }

            return result;
        }
    }
}