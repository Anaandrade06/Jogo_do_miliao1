

using Controle;

namespace Jogo_do_miliao1;

public partial class MainPage : ContentPage
{
	private Gerenciador gerenciador;
	private object butResposta01;
	private object butResposta03;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
	public MainPage()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
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
	void OnAjudaClicked(object sender, EventArgs e)
	{
		var ajuda = new RetiraErrada();
		ajuda.ConfigurarDesenho(buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
		ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
		(sender as Button).IsVisible = false;
	}

	void OnAjudaPulaClicked(object sender, EventArgs e)
	{
		gerenciador.ProximaQuestao();
		(sender as Button).IsVisible = false;
	}


}