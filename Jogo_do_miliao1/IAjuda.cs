namespace Jogo_do_miliao1
{
public abstract class IAjuda
{
    protected Button butResposta01;
    protected Button butResposta02;
    protected Button butResposta03;
    protected Button butResposta04;
    protected Button butResposta05;
    protected Frame frameAjuda;
    public void ConfigurarDesenho(Button butResposta01, Button butResposta02, Button butResposta03, Button butResposta04, Button butResposta05);    
    {
    this.butResposta01= butResposta01;
    this.butResposta02= butResposta02;
    this.butResposta03= butResposta03;
    this.butResposta04= butResposta04; 
    this.butResposta05= butResposta05;
    }
    public void ConfigurarDesenho(Frame frameAjuda)
    {
        this.frameAjuda = frameAjuda;
    }
    public abstract void RealizaAjuda ( Questao questao);

}
}