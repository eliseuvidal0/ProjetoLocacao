using System;
using System.Text.RegularExpressions;

namespace ProjetoLocacao.Utility
{
    class Validacao
    {
        public static Boolean ValidarCpf(string cpf)
        {
            cpf = Formatar(cpf);
            if (cpf.Length != 11) return false;
            if (!DigitosCpf(cpf)) return false;

            int total = CalculoCpf(cpf, 10);
            int validador = 1;

            if (!ValidarDigito(cpf, validador, total))
            {
                return false;
            }

            total = CalculoCpf(cpf, 11);
            validador = 0;

            if (!ValidarDigito(cpf, validador, total))
            {
                return false;
            }

            return true;
        }
        private static Boolean ValidarDigito(string cpf, int validador, int total)
        {
            if (total % 11 < 2)
            {
                int cont = 10;
                foreach (char c in cpf)
                {
                    if (cont == validador)
                    {
                        if (Char.GetNumericValue(c) != 0)
                        { return false; }
                        break;
                    }
                    --cont;
                }
            }
            else
            {
                int resto = total % 11;
                int cont = 10;

                foreach (char c in cpf)
                {
                    if (cont == validador)
                    {
                        if (Char.GetNumericValue(c) != 11 - resto)
                        { return false; }
                        break;
                    }
                    --cont;
                }
            }
            return true;
        }
        private static int CalculoCpf(string cpf, int cont)
        {
            int total = 0;
            foreach (char c in cpf)
            {
                int numero = Convert.ToInt32(Char.GetNumericValue(c));
                total += (numero * cont);

                --cont;
                if (cont < 2)
                {
                    break;
                }
            }
            return total;
        }
        private static Boolean DigitosCpf(string cpf)
        {
            switch (cpf)
            {
                case "00000000000": return false;
                case "11111111111": return false;
                case "22222222222": return false;
                case "33333333333": return false;
                case "44444444444": return false;
                case "55555555555": return false;
                case "66666666666": return false;
                case "77777777777": return false;
                case "88888888888": return false;
                case "99999999999": return false;

            }
            return true;
        }
        public static string Formatar(string cpf) => cpf.Replace(".", "").Replace("-", "");
        public static bool ValidarPlaca(string placa)
        {
            if (placa.Length == 8)
            {
                Regex regex = new Regex("[A-Z]{3}[0-9]{1}[A-Z]{1}[0-9]{2}");
                if (regex.IsMatch(placa))
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
