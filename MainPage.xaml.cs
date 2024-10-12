namespace ConversorDeUnidades;

public partial class MainPage : TabbedPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    // Função para conversão de distância
    private void ConverterDistancia(object sender, EventArgs e)
    {
        double valor = double.Parse(entryValorDistancia.Text);
        string unidadeOrigem = pickerOrigemDistancia.SelectedItem.ToString();
        string unidadeDestino = pickerDestinoDistancia.SelectedItem.ToString();
        
        double resultado = 0;

        if (unidadeOrigem == "Metros" && unidadeDestino == "Quilômetros")
            resultado = valor / 1000;
        else if (unidadeOrigem == "Metros" && unidadeDestino == "Milhas")
            resultado = valor * 0.000621371;
        else if (unidadeOrigem == "Quilômetros" && unidadeDestino == "Metros")
            resultado = valor * 1000;
        else if (unidadeOrigem == "Quilômetros" && unidadeDestino == "Milhas")
            resultado = valor * 0.621371;
        else if (unidadeOrigem == "Milhas" && unidadeDestino == "Metros")
            resultado = valor / 0.000621371;
        else if (unidadeOrigem == "Milhas" && unidadeDestino == "Quilômetros")
            resultado = valor / 0.621371;
        else
            resultado = valor;

        labelResultadoDistancia.Text = $"Resultado: {resultado}";
    }

    // Função para conversão de peso
    private void ConverterPeso(object sender, EventArgs e)
    {
        double valor = double.Parse(entryValorPeso.Text);
        string unidadeOrigem = pickerOrigemPeso.SelectedItem.ToString();
        string unidadeDestino = pickerDestinoPeso.SelectedItem.ToString();

        double resultado = 0;

        if (unidadeOrigem == "Gramas" && unidadeDestino == "Quilogramas")
            resultado = valor / 1000;
        else if (unidadeOrigem == "Gramas" && unidadeDestino == "Libras")
            resultado = valor * 0.00220462;
        else if (unidadeOrigem == "Quilogramas" && unidadeDestino == "Gramas")
            resultado = valor * 1000;
        else if (unidadeOrigem == "Quilogramas" && unidadeDestino == "Libras")
            resultado = valor * 2.20462;
        else if (unidadeOrigem == "Libras" && unidadeDestino == "Gramas")
            resultado = valor / 0.00220462;
        else if (unidadeOrigem == "Libras" && unidadeDestino == "Quilogramas")
            resultado = valor / 2.20462;
        else
            resultado = valor;

        labelResultadoPeso.Text = $"Resultado: {resultado}";
    }

    // Função para conversão de temperatura
    private void ConverterTemperatura(object sender, EventArgs e)
    {
        double valor = double.Parse(entryValorTemperatura.Text);
        string unidadeOrigem = pickerOrigemTemperatura.SelectedItem.ToString();
        string unidadeDestino = pickerDestinoTemperatura.SelectedItem.ToString();

        double resultado = 0;

        if (unidadeOrigem == "Celsius" && unidadeDestino == "Fahrenheit")
            resultado = (valor * 9 / 5) + 32;
        else if (unidadeOrigem == "Celsius" && unidadeDestino == "Kelvin")
            resultado = valor + 273.15;
        else if (unidadeOrigem == "Fahrenheit" && unidadeDestino == "Celsius")
            resultado = (valor - 32) * 5 / 9;
        else if (unidadeOrigem == "Fahrenheit" && unidadeDestino == "Kelvin")
            resultado = (valor - 32) * 5 / 9 + 273.15;
        else if (unidadeOrigem == "Kelvin" && unidadeDestino == "Celsius")
            resultado = valor - 273.15;
        else if (unidadeOrigem == "Kelvin" && unidadeDestino == "Fahrenheit")
            resultado = (valor - 273.15) * 9 / 5 + 32;
        else
            resultado = valor;

        labelResultadoTemperatura.Text = $"Resultado: {resultado}";
    }
}
