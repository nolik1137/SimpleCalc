namespace SimpleCalc;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    public void Click(object sender, EventArgs e)
    {
        // Берём знак операции прямо из текста нажатой кнопки
        string operation = ((Button)sender).Text;

        if (!double.TryParse(Number1.Text, out double a) ||
            !double.TryParse(Number2.Text, out double b))
        {
            ResultLabel.Text = "Введите два числа";
            return;
        }

        double result = 0;

        switch (operation)
        {
            case "+": 
            result = a + b; 
            break;
            case "-": 
            result = a - b;
            break;
            case "×": 
            result = a * b; 
            break;
            case "÷":
                if (b == 0)
                {
                    ResultLabel.Text = "Деление на ноль!";
                    return;
                }
                result = a / b;
                break;
        }

        ResultLabel.Text = $"Результат: {result}";
    }
}