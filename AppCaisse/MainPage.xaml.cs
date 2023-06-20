namespace AppCaisse;


public class Lists
{
	public string Date { get; set; }
	public double Commande { get; set; }
}

public partial class MainPage : ContentPage
{
	int count = 0;
	List<Lists> list ;

	public MainPage()
	{
		InitializeComponent();
		list = new List<Lists>();
		list.Add(new Lists { Date="15/06/2023 14:30", Commande = 1});
        list.Add(new Lists { Date = "15/06/2023 14:40", Commande = 2 });
        list.Add(new Lists { Date = "15/06/2023 14:50", Commande = 3 });
        list.Add(new Lists { Date = "15/06/2023 15:50", Commande = 4 });
       
		maList.ItemsSource = list;

        maList.ItemSelected += (sender, e) =>
        {
            if (maList.SelectedItem != null)
            {
                Lists item = maList.SelectedItem as Lists;
            }
        };



            }


        }

