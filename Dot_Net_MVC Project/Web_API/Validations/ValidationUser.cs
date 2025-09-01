//using Web_API.Models;
//using FluentValidation;
//using System;

//namespace Web_API.Validations
//{
//    public class ValidationUser : AbstractValidator<User>
//    {
//        public ValidationUser()
//        {
//            RuleFor(user => user.Email)
//                .NotEmpty().WithMessage("Email is required.")
//                .EmailAddress().WithMessage("Invalid email address.")
//                .Must(BeUniqueEmail).WithMessage("Email is already registered.");

//            RuleFor(user => user.BirthDate)
//                .Must(BeAtLeast18YearsOld).WithMessage("You must be at least 18 years old to register.");

//            RuleFor(user => user.UserName)
//                .Must(NotContainEmailDomain).WithMessage("Username cannot contain the email domain.");

//            RuleFor(user => user.Password)
//                .Must(ContainLetterAndNumber).WithMessage("Password must contain both letters and numbers.")
//                .MinimumLength(8).WithMessage("Password must be at least 8 characters long.");
//        }

//        Define your custom validation methods here
//        private bool BeUniqueEmail(string email)
//        {
//            Check if the email is unique in the database
//             You should implement your logic here, e.g., querying the database
//             Return true if the email is unique, false if it's not
//            return true;
//        }

//        private bool BeAtLeast18YearsOld(DateTime birthDate)
//        {
//            var today = DateTime.Today;
//            var age = today.Year - birthDate.Year;

//            if (birthDate.Date > today.AddYears(-age))
//                age--;

//            return age >= 18;
//        }

//        private bool NotContainEmailDomain(string userName, string email)
//        {
//            var userNameParts = userName.Split('@');
//            if (userNameParts.Length > 1)
//            {
//                var emailDomain = userNameParts.Last();
//                return !email.EndsWith(emailDomain, StringComparison.OrdinalIgnoreCase);
//            }

//            return true;
//        }

//        private bool ContainLetterAndNumber(string password)
//        {
//            return !string.IsNullOrEmpty(password) && password.Any(char.IsLetter) && password.Any(char.IsDigit);
//        }
//    }
//}


