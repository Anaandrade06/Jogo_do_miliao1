
namespace Controle
{
    public class Questao 
    {
       public string Questoes;

       public string Questao1;

       public string Questao2;

       public string Questao3;

       public string Questao4;

        public string Questao5;

       public int respostacoreta =0;

       public int Level;

       private Label labelPergunta;

       private Button butResposta01;

       private Button butResposta02;

       private Button butResposta03;

       private Button butResposta04; 

       private Button butResposta05;


        public  Questao ()
        {

        }
       
        public Questao(Label lp, Button BT01, Button BT02, Button BT03, Button BT04, Button BT05)
                {
                    labelPergunta = lp;
                    butResposta01 = BT01;
                    butResposta02 = BT02;
                    butResposta03 = BT03;
                    butResposta04 = BT04;
                    butResposta05 = BT05;
                }

        public int Respostacoreta { get; private set; }

        public void ConfigurarDesenho(Label lp, Button BT01, Button BT02, Button BT03, Button BT04, Button BT05)
                {
                    labelPergunta = lp;
                    butResposta01 = BT01;
                    butResposta02 = BT02;
                    butResposta03 = BT03;
                    butResposta04 = BT04;
                    butResposta05 = BT05;
                }
       public void Desenhar ()
                {
                    butResposta01.Text = Questao1;
                    butResposta02.Text = Questao2;
                    butResposta03.Text = Questao3;
                    butResposta04.Text = Questao4;
                    butResposta05.Text = Questao5;

                    butResposta01!.BackgroundColor = Colors.DarkBlue;
                    butResposta01!.TextColor       = Colors.White;
                    butResposta02!.BackgroundColor = Colors.DarkBlue;
                    butResposta02!.TextColor       = Colors.White;
                    butResposta03!.BackgroundColor = Colors.DarkBlue;
                    butResposta03!.TextColor       = Colors.White;
                    butResposta04!.BackgroundColor = Colors.DarkBlue;
                    butResposta04!.TextColor       = Colors.White;
                    butResposta05!.BackgroundColor = Colors.DarkBlue;
                    butResposta05!.TextColor       = Colors.White;
                }
       public bool VerificarSeEstaCorreta(int RR )
                {
                if (Respostacoreta == RR)       
                    { 
                        var btn = QualBTN( RR);
                         btn.BackgroundColor = Colors.Green;
                        return true;
                    }
                    else 
                    {
                        var btnCorreto =  QualBTN(RR);
                        
                        var btnIncorreto = QualBTN(RR);
                         btnCorreto.BackgroundColor = Colors.Yellow;
                         btnIncorreto.BackgroundColor = Colors.Red;
                        return false;
                    }
                }

        private Button QualBTN (int RespostaSelected)
        {
            if (RespostaSelected == 1 )
            return butResposta01;
            else if (RespostaSelected == 2)
            return butResposta02;
            else if (RespostaSelected == 3)
            return butResposta03;
            else if (RespostaSelected == 4)
            return butResposta04;
            else if (RespostaSelected == 5)
            return butResposta05;
            else 
            return butResposta03;
        }
        public bool equals( Questao questao)
        {return this.Level == questao.Level &&
        this.Pergunta == questao.Pergunta;
        }
        
  }
}