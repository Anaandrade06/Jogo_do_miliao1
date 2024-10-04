using Controle;

namespace Jogo_do_miliao1
{
    public class RetiraErrada : IAjuda
    {
        public override void RealizaAjuda(Questao questao)
{
    switch (questao.RespostaCoreta)
    { 
        case 1:
        butResposta05.IsVisible = false;
        butResposta02.IsVisible = false;
        butResposta03.IsVisible = false;
        break;
        
        case 2:
        butResposta01.IsVisible = false;
        butResposta03.IsVisible = false;
        butResposta04.IsVisible = false;
        break;
    }

}

        internal void ConfigurarDesenho(Button butResposta01, Button butResposta02, Button butResposta03, Button butResposta04, Button butResposta05)
        {
            throw new NotImplementedException();
        }
    }
}