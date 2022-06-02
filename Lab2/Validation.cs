//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.ComponentModel.DataAnnotations;

//namespace Lab2
//{
//    public class Validator : ValidationAttribute
//    {
//        public override bool IsValid(object? ProcName)
//        {
//            if (ProcName is null)
//            {
//                ErrorMessage = "Не выбрано название процессора";
//            }
//            return false;
//        }

//        internal static bool TryValidateObject(Computer computer, ValidationContext context, List<ValidationResult> results, bool v)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
