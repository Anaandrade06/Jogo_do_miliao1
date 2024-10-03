namespace Jogo_do_miliao1
{
public class RetiraErrada: IAjuda
{
    public override void RealizaAjuda (Questao questao);
{
    switch (Questao Respostacoreta)
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
}
}