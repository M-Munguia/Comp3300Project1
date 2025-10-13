using MichelleMunguiaProject1.Model;

namespace MichelleMunguiaProject1;

public partial class CarLotForm : Form
{
    private readonly CarLot _carLot;

    public CarLotForm()
    {
        InitializeComponent();
        _carLot = new CarLot();
    }

    private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var addForm = new AddCarForm();

        if (addForm.ShowDialog() != DialogResult.OK)
            return;


        var newCar = addForm.GetCar();

        _carLot.AddCar(newCar.Make, newCar.Model, newCar.Mpg, newCar.Price);
    }
}