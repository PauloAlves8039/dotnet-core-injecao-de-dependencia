using src.ExemploDI.interfaces;

namespace src.ExemploDI.Classes
{
    public class Servico
    {
        private readonly IAcolhimento _acolhimento;

        public Servico(IAcolhimento acolhimento)
        {
            _acolhimento = acolhimento;
        }

        public string MensagemRecepcao(string nome)
        {
            return _acolhimento.RecepcaoFuncionario(nome);
        }
    }
}
