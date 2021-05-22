using src.ExemploDI.interfaces;

namespace src.ExemploDI.Classes
{
    public class Acolhimento : IAcolhimento
    {
        public string RecepcaoFuncionario(string nome)
        {
            return $"Olá {nome}, seja bem-vindo(a) a empresa XPTO!";
        }
    }
}
