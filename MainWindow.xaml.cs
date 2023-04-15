using System.Collections.Generic;
using System.Windows;

namespace CourseWork
{
	public partial class MainWindow : Window
	{
		List<Door.Product> products = Door.ListOfProducts();
		public MainWindow()
		{
			InitializeComponent();
			foreach(Door.Product product in products)
			{
				if(!ProductsComboBox.Items.Contains(product.Name))
					ProductsComboBox.Items.Add(product.Name);
			}
		}

		private void FindButton_Click(object sender, RoutedEventArgs e)
		{
			FoundItems.Children.Clear();
            if (ProductsComboBox.SelectedItem != null) {
				foreach (Door.Product product in products)
				{
					if (product.Name == ProductsComboBox.SelectedItem.ToString())
					{
					FoundItem founditem = new();
					founditem.ProductName.Content = product.Name;
					founditem.Amount.Content = product.Amount.ToString();
					founditem.NomerSklada.Content = product.NomerSklada.ToString();
					FoundItems.Children.Add(founditem);
					}
				}
            }
        }
	}
}
