namespace mchuquinTS3.Vistas;

public partial class vLogin : ContentPage
{
    string[] usuarios = { "Carlos", "Ana", "Jose" };
    string[] contrasenas = { "carlos123", "ana123", "jose123" };
    public vLogin()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrasena = txtContrase�a.Text;

        int index = Array.IndexOf(usuarios, usuario);
        if (index != -1 && contrasenas[index] == contrasena)
        {
            DisplayAlert("�Bienvenido!", $"�Hola {usuario}!", "OK");
            Navigation.PushAsync(new vElementos(usuario));
        }
        else
        {
            DisplayAlert("Error", "Usuario o contrase�a incorrectos", "OK");
        }
    }
}