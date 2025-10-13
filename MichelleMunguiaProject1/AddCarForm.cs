using MichelleMunguiaProject1.Model;

namespace MichelleMunguiaProject1;

public partial class AddCarForm : Form
{
    private Car? _newCar;

    public AddCarForm()
    {
        InitializeComponent();
    }

    public Car GetCar()
    {
        return _newCar ?? throw new InvalidOperationException("No car created.");
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(MakeText.Text.Trim()) || string.IsNullOrWhiteSpace(ModelText.Text.Trim()))
        {
            const string txt = "Make and Model are both required.";
            MessageBox.Show(txt);
            return;
        }

        // Validate MPG
        if (!decimal.TryParse(MpgText.Text.Trim(), out var mpg))
        {
            const string txt = "Make and Model are both required.";
            MessageBox.Show(txt);
            return;
        }

        if (mpg <= 0)
        {
            const string txt = "MPG must be greater than 0.";
            MessageBox.Show(txt);
            return;
        }

        if (!decimal.TryParse(PriceText.Text.Trim(), out var price))
        {
            const string txt = "Price must be a numeric value.";
            MessageBox.Show(txt);
            return;
        }

        if (price <= 0)
        {
            const string txt = "Price must be greater than 0.";
            MessageBox.Show(txt);
            return;
        }

        _newCar = new Car(
            MakeText.Text.Trim(),
            ModelText.Text.Trim(),
            mpg,
            price
        );

        DialogResult = DialogResult.OK;
        Close();
    }

    private void Cancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}