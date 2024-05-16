using System.Text.RegularExpressions;

namespace Domain.ValueObjects
{
    public class Email 
    {
        public Email(string valor)
        {
            if (string.IsNullOrEmpty(valor))
                return;

            Valor = valor.ToLower();
        }

        public string Valor { get; set; }
        public bool EhValido()
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(br|com|net|org|gov)$";

            return Regex.IsMatch(Valor, regex, RegexOptions.IgnoreCase);
        }
    }
}
