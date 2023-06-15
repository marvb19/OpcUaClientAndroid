using Opc.UaFx.Client;

namespace OpcUaClientAndroid;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnConnectClicked(object sender, EventArgs e) {
		using (OpcClient client = new OpcClient("opc.tcp://localhost:4840")) {
			client.Connect();
			var status = client.State.ToString();
			DisplayAlert("State", $"Current state is {status}", "OK");
		}
	}
}

