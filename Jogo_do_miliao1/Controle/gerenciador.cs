using Jogo_do_miliao;
using Jogo_do_miliao1;

namespace Controle
{
   public class Gerenciador
   {
      public int Pontuacao { get; private set; }
      int LevelAtual = 0;
      List<Questao> ListaQuestoes = new List<Questao>();
      List<int> ListaQuestoesRespondidas = new List<int>();
      Questao QuestaoCorrente;
      public Gerenciador(Label lp, Button BT01, Button BT02, Button BT03, Button BT04, Button BT05)
      {
         CriarPerguntas(lp, BT01, BT02, BT03, BT04, BT05);

      }
      public Questao GetQuestaoCorrente()
      {
         return QuestaoCorrente;
      }
      public void ProximaQuestao()
      {
         var numAleatorio = Random.Shared.Next(0, ListaQuestoes.Count);
         while (ListaQuestoesRespondidas.Contains(numAleatorio))
            numAleatorio = Random.Shared.Next(0, ListaQuestoes.Count);
         ListaQuestoesRespondidas.Add(numAleatorio);
         QuestaoCorrente = ListaQuestoes[numAleatorio];
         QuestaoCorrente.Desenhar();
      }
      void Inicializar()
      {
         Pontuacao = 0;
         LevelAtual = 1;
         ProximaQuestao();
      }
      public async void VerificarSeEstaCorreta(int RR)
      {
         if (QuestaoCorrente.RespostaCoreta ==RR)
         {
            await Task.Delay(1000);
            AdicionaPontuacao(LevelAtual);
            LevelAtual++;
            ProximaQuestao();
         }
         else
         {
            await App.Current.MainPage.DisplayAlert("FIM", "vOCE eRROU", "OK");
            Inicializar();
         }
      }
      public void AdicionaPergunta(Questao questao)
      {
         ListaQuestoes.Add(questao);
      }
      void AdicionaPontuacao(int n)
      {
         if (n == 1)
            Pontuacao = 1000;
         else if (n == 2)
            Pontuacao = 2000;
         else if (n == 3)
            Pontuacao = 5000;
         else if (n == 4)
            Pontuacao = 10000;
         else if (n == 5)
            Pontuacao = 20000;
         else if (n == 6)
            Pontuacao = 50000;
         else if (n == 7)
            Pontuacao = 100000;
         else if (n == 8)
            Pontuacao = 200000;
         else if (n == 9)
            Pontuacao = 500000;
         else
            Pontuacao = 1000000;

      }

      void CriarPerguntas(Label lp, Button BT01, Button BT02, Button BT03, Button BT04, Button BT05)
      {
         var Q1 = new Questao();
         Q1.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);

         Q1.Questao1 = "5";
         Q1.Questao2 = "12";
         Q1.Questao3 = "22";
         Q1.Questao4 = "4";
         Q1.Questao5 = "17";
         Q1.respostacoreta = 4;
         Q1.Level = 1;
         ListaQuestoes.Add(Q1);

         ProximaQuestao();
         var Q2 = new Questao();
         Q2.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q2.Questoes = "Qual é a capital do Brasil?";
         Q2.Questao1 = "São Paulo";
         Q2.Questao2 = "Rio de Janeiro";
         Q2.Questao3 = "Brasília";
         Q2.Questao4 = "Salvador";
         Q2.Questao5 = "Recife";
         Q1.respostacoreta = 3;
         Q2.Level = 1;
         ListaQuestoes.Add(Q2);

         ProximaQuestao();
         var Q3 = new Questao();
         Q3.ConfigurarDesenho(lp, BT01, BT02, BT03, BT04, BT05);
         Q3.Questoes ="Qual o maior planeta do sistema solar?";
         Q3.Questao1 = "Júpiter";
         Q3.Questao2 = "Saturno";
         Q3.Questao3 = "Brasília";
         Q3.Questao4 = "Marte";
         Q3.Questao5 = "Terra";
         Q1.respostacoreta = 1;
         Q3.Level = 1;
         ListaQuestoes.Add(Q3);

      }


   }

}