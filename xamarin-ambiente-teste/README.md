# Teste de Ambiente Xamarin
Este projeto é o primeiro teste que você pode realizar para validar que está com o ambiente de desenvolvimento Xamarin instalado da forma correta.

Para começar a utilizar este projeto, você deve selecionar a opção Download ZIP para obtê-lo.

<img src="https://cloud.githubusercontent.com/assets/2198735/21872316/f90c9fb4-d84e-11e6-94d6-081e44103cef.jpg" width="640" />

Depois de baixado, você deve abri-lo no Visual Studio e o resultado deverá ser parecido com o seguinte em soluções de seu solution explorer.

<img src="https://cloud.githubusercontent.com/assets/2198735/21872317/f90cebb8-d84e-11e6-960d-16df3918f74e.jpg"  width="280" height="800"/>

E abrir todos os projetos, selecione uma das duas opções de exibição pode estar usando **Xamarin Nativo** ou **Xamarin Forms**. Se você quer fazer com a versão nativa selecionar apenas **EnviarCorreo.Nativo** como StartUp Project.

<img src="https://cloud.githubusercontent.com/assets/2198735/21872318/f90f47a0-d84e-11e6-8bbd-33ebf438868a.jpg"  width="380" height="350"/>

Você pode fazer exatamente o mesmo com o projeto **EnviarCorreo.Forms.Droid **, se você quer fazer através de Forms.

# Modificando o projeto Xamarin Nativo

Para alterar o projeto de Xamarin Native, você precisa abrir o arquivo MainActivity.cs e adicionar o nome de sua cidade na frase ``Acompanhando a Maratona da cidade de [ESCREVA O NOME DA SUA CIDADE]`` e adicionar também o e-mail ``maratona@microsoft.com``. 


```csharp
private async void btnReportar_Click(object sender, EventArgs e)
{
    ServiceHelper serviceHelper = new ServiceHelper();
    await serviceHelper.InsertarEntidad("maratona@microsoft.com", "Acompanhando a Maratona da cidade de São Paulo");
    button.Text = "Teste enviado";
}
```

Coloque os dados, executar o aplicativo e, em seguida, pressione para o botão ``Enviar teste`` para confirmar que seu ambiente está ok.

# Modificando o projeto Xamarin Forms

Para alterar o projeto de Xamarin Forms, você terá que abrir o arquivo ViewModelBase.cs e modificar o comando para adicionar o e-mail maratona@microsoft.com e de adicionar o nome de sua cidade no título.

```csharp
IdentificadorCommand = new Command(() =>
{
    //Este é o lugar onde você colocar o seu endereço de e-mail
    string direccionCorreo = "maratona@microsoft.com";
    string evento = "Acompanhando a Maratona da cidade de [ESCREVA O NOME DA SUA CIDADE]";

    ServiceHelper servicioApp = new ServiceHelper();
    await servicioApp.InsertarEntidad(direccionCorreo, evento);
    BtnText = "Teste enviado";
});
```

Coloque seus dados, executar o aplicativo e, em seguida, pressionando o botão para enviar o seu teste. 

Com essas modificações realizadas e o aplicativo rodando, você já terá um ambiente de desenvolvimento pronto para seguir seus estudos com Xamarin. Realize outros testes, como por exemplo adicionando seu e-mail e enviando mensagens de teste via aplicativo.
