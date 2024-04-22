namespace mchuquinTS3.Vistas;

public partial class vElementos : ContentPage
{
	public vElementos(string usuario)
	{
		InitializeComponent();
        lbUsuario.Text = "Usuario conectado " + usuario;
    }

    private void btnFinal1_Clicked(object sender, EventArgs e)
    {
        int valorMaximo = 10;
        int valorMinimo = 1;
        if (Int32.TryParse(txtNota1.Text, out int seguimiento1))
        {
            if (seguimiento1 > valorMaximo)
            {
                DisplayAlert("Validaci�n", "El valor ingresado en la Nota de Seguimiento 1 es mayor que " + valorMaximo, "OK");
            }
            else if (seguimiento1 < valorMinimo)
            {
                DisplayAlert("Validaci�n", "El valor ingresado en la Nota de Seguimiento 1 es menor que " + valorMinimo, "OK");
            }
        }
        else
        {
            DisplayAlert("Error", "Introduce un valor v�lido", "OK");
        }

        if (Int32.TryParse(txtNota2.Text, out int examen1))
        {
            if (examen1 > valorMaximo)
            {
                DisplayAlert("Validaci�n", "El valor ingresado en la Nota de Ex�men 1 es mayor que " + valorMaximo, "OK");
            }
            else if (examen1 < valorMinimo)
            {
                DisplayAlert("Validaci�n", "El valor ingresado en la Nota de Ex�men 1 es menor que " + valorMinimo, "OK");
            }

        }
        else
        {
            DisplayAlert("Error", "Introduce un valor v�lido", "OK");
        }

        if (pkAlumnos.SelectedIndex == -1)
        {
            DisplayAlert("Alerta", "Seleccione un Alumno", "cerrar");
        }
        else
        {
            try
            {
                Double a = float.Parse(txtNota1.Text);
                Double b = float.Parse(txtNota2.Text);
                Double c;
                {
                    c = a * 0.3 + b * 0.2;
                    string cR = c.ToString("F2");
                    txtFinal1.Text = cR.ToString();
                }

            }
            catch
            {
                resultado.Text = "Error en la captura de datos";
            }

        }
    }

    private void btnFinal2_Clicked(object sender, EventArgs e)
    {
        int valorMaximo = 10;
        int valorMinimo = 1;
        if (Int32.TryParse(txtNota1S2.Text, out int seguimiento1))
        {
            if (seguimiento1 > valorMaximo)
            {
                DisplayAlert("Validaci�n", "El valor ingresado en la Nota de Seguimiento 1 es mayor que " + valorMaximo, "OK");
            }
            else if (seguimiento1 < valorMinimo)
            {
                DisplayAlert("Validaci�n", "El valor ingresado en la Nota de Seguimiento 1 es menor que " + valorMinimo, "OK");
            }
        }
        else
        {
            DisplayAlert("Error", "Introduce un valor v�lido", "OK");
        }

        if (Int32.TryParse(txtNota2S2.Text, out int examen1))
        {
            if (examen1 > valorMaximo)
            {
                DisplayAlert("Validaci�n", "El valor ingresado en la Nota de Ex�men 1 es mayor que " + valorMaximo, "OK");
            }
            else if (examen1 < valorMinimo)
            {
                DisplayAlert("Validaci�n", "El valor ingresado en la Nota de Ex�men 1 es menor que " + valorMinimo, "OK");
            }

        }
        else
        {
            DisplayAlert("Error", "Introduce un valor v�lido", "OK");
        }

        if (pkAlumnos.SelectedIndex == -1)
        {
            DisplayAlert("Alerta", "Seleccione un Alumno", "cerrar");
        }
        else
        {
            try
            {
                Double a = float.Parse(txtNota1S2.Text);
                Double b = float.Parse(txtNota2S2.Text);
                Double c;
                Double d = float.Parse(txtFinal1.Text);
                Double final;
                {
                    c = a * 0.3 + b * 0.2;
                    string cR = c.ToString("F2");
                    txtFinal2.Text = cR.ToString();
                    final = d + c;

                    string finalD = final.ToString("F2");
                    txtFinal.Text = finalD.ToString();
                    string estado;

                    if (final >= 7)
                    {
                        estado = "Aprobado";
                    }
                    else if (final >= 5 && final <= 6.9)
                    {
                        estado = "Complementario";
                    }
                    else
                    {
                        estado = "REPROBADO";
                    }

                    txtEstado.Text = estado.ToString();
                }
            }
            catch
            {
                resultado.Text = "Error en la captura de datos";
            }

        }
    }

    private void btnEstado_Clicked(object sender, EventArgs e)
    {
        if (pkAlumnos.SelectedIndex == -1)
        {
            DisplayAlert("Alerta", "Seleccione un Alummno e ingrese sus calificaciones", "cerrar");

        }
        else
        {
            string parcial1 = txtFinal1.Text;
            string parcial2 = txtFinal2.Text;
            string notaFinal = txtFinal.Text;
            string estado = txtEstado.Text;
            string fecha = dpFecha.Date.ToString();

            DisplayAlert("RESULTADO", "PRIMER PARCIAL: " + parcial1 + "\n SEGUNDO PARCIAL: " + parcial2 + " \n NOTA FINAL: " + notaFinal + "\n ESTADO: " + estado + "\n Fecha " + fecha, "Cerrar");
        }
    }

    private void pkAlumnos_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}