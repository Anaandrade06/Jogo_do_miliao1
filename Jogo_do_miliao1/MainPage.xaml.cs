

using Controle;

namespace Jogo_do_miliao1;

public partial class MainPage : ContentPage
{
	private Gerenciador gerenciador;
	private object butResposta01;
	private object butResposta03;

	public MainPage()
	{
		InitializeComponent();
		gerenciador = new Gerenciador(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
	}
	private void OnBtnResposta01Clicked(object sender, EventArgs e)
	{
		gerenciador!.VerificarSeEstaCorreta(1);
	}

	private void OnBtnResposta02Clicked(object sender, EventArgs e)
	{
		gerenciador!.VerificarSeEstaCorreta(2);
	}

	private void OnBtnResposta03Clicked(object sender, EventArgs e)
	{
		gerenciador!.VerificarSeEstaCorreta(3);
	}

	private void OnBtnResposta04Clicked(object sender, EventArgs e)
	{
		gerenciador!.VerificarSeEstaCorreta(4);
	}

	private void OnBtnResposta05Clicked(object sender, EventArgs e)
	{
		gerenciador!.VerificarSeEstaCorreta(5);
	}

	private Button OnAjudaRetirarClick(object s, EventArgs e)
	{
		var ajuda = new RetiraErrada();
		ajuda.ConfigurarDesenho(butResposta01, butResposta02, butResposta03, butResposta04, butResposta05);
		ajuda.Realiza(gerenciador.GetQuestaoCorrente());
		(s as Button).IsVisible = false;
	}
	void OnAjudaPulaClicked(object s, EventArgs e)
	{
		gerenciador.ProximaQuestao();
	(s as Button).IsVisible=false;
	}


}