using Microsoft.AspNetCore.SignalR.Client;

namespace Application1;

public partial class Form1 : Form
{
    private HubConnection connection;

    public Form1()
    {
        InitializeComponent();
        InitializeSignalR();
    }

    private async void InitializeSignalR()
    {
        var signalRUrl = Program.Configuration["SignalR:Url"];
        connection = new HubConnectionBuilder()
            .WithUrl(signalRUrl)
            .Build();

        connection.On<string, string>("ReceiveMessage", (source, message) =>
        {
            if (source != "WindowsForms")
            {
                Invoke((Action)(() =>
                {
                    outputLabel.Text = message;
                }));
            }
        });

        try
        {
            await connection.StartAsync();
            outputLabel.Text = "Connection started";
        }
        catch (Exception ex)
        {
            outputLabel.Text = $"Connection failed: {ex.Message}";
        }
    }

    private async void inputTextBox_TextChanged(object sender, EventArgs e)
    {
        var message = inputTextBox.Text;
        await connection.InvokeAsync("SendMessage", "WindowsForms", message);
    }
}
