namespace Jogo_do_miliao

public class Questao
{
    public string Perguntas;
    public string Resposta_1;
    public string Resposta_2;
    public string Resposta_3;
    public string Resposta_4;
    public string Resposta_5;
    public int RespostaCorreta;
    public int Nivel;
     private Label labelPergunta;
     private Button botaoResposta1;
     private Button botaoResposta2;
     private Button botaoResposta3;
     private Button botaoResposta4;
     private Button botaoResposta5;

     public void Desenhar()
    {
    labelPergunta.Text = Perguntas;
    botaoResposta1.Text = Resposta_1;
    botaoResposta2.Text = Resposta_2;
    botaoResposta3.Text = Resposta_3;
    botaoResposta4.Text = Resposta_4;
    botaoResposta5.Text = Resposta_5;

    }
    public Questao()
    {

    }
    public Questao(Label pg, Button bot1, Button bot2, Button bot3, Button bot4, Button bot5)
    {
    labelPergunta=pg;
    botaoResposta1=bot1;
    botaoResposta2=bot2;
    botaoResposta3=bot3;
    botaoResposta4=bot4;
    botaoResposta5=bot5;
    }
    public void ConfigurarDesenho (Label pg, Button bot1, Button bot2, Button bot3, Button bot4, Button bot5)
    {

    }
    public bool VerificarResposta( int RespostaRespondida)
    {
        if (RespostaRespondida == RespostaRespondida)
    {
        var bot = Qual bot (int RespostaRespondida);
        bot BackgroudColor = Color Green; 
        return true;
     
    }
     else
     {
        var botCorreto = Qual bot ( RespostaCorreta);
        var botIncorreto = Qual bot (RespostaRespondida);
        botaoCorreto. BackgroudColor= color pink;
        botaoIncorreta. BackgroudColor= color red;
        return false;
     }
    
    }

    private  Button Qualbot(int RespostaRespondida);
    {
        if (RespostaRespondida == RespostaCorreta);
    }



}