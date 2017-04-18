using Design_dashboardATM_AIFile.CommonControl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Design_dashboardATM_AIFile
{
    /// <summary>
    /// Interaction logic for Design_dashboardATM.xaml
    /// </summary>
    public partial class Design_dashboardATM : CustomWindow
    {
        public ObservableCollection<string> CalculationCollection { get; set; }
        public ObservableCollection<string> TagsCollection { get; set; }
        public ObservableCollection<string> ProductsCollection { get; set; }
        public Design_dashboardATM()
        {
            InitializeComponent();
            this.DataContext = new ProjectVM();
            LoadCalculationCollection();
            LoadTagsCollection();
            LoadProductsCollection();
        }
        public void LoadCalculationCollection()
        {
            CalculationCollection = new ObservableCollection<string>();

            CalculationCollection.Add("Stingray Calc 1");
            CalculationCollection.Add("Stingray Calc 1");
            CalculationCollection.Add("Stingray Calc 1");
            CalculationCollection.Add("Stingray Calc 1");
            CalculationCollection.Add("Stingray Calc 1");
            CalculationCollection.Add("Stingray Calc 1");
            CalculationCollection.Add("Stingray Calc 1");
            CalculationCollection.Add("Stingray Calc 1");
            CalculationCollection.Add("Stingray Calc 1");

            searchListbox.ItemsSource = CalculationCollection;
        }
        public void LoadTagsCollection()
        {
            TagsCollection = new ObservableCollection<string>();

            TagsCollection.Add("Summen");
            TagsCollection.Add("Lutz");
            TagsCollection.Add("Vektoren");
            TagsCollection.Add("Verhaltnis");
            TagsCollection.Add("Induktion");
            TagsCollection.Add("Summen");
            TagsCollection.Add("Lutz");
            TagsCollection.Add("Vektoren");
            TagsCollection.Add("Verhaltnis");
            TagsCollection.Add("Induktion");

            tagsListbox.ItemsSource = TagsCollection;
        }
        public void LoadProductsCollection()
        {
            ProductsCollection = new ObservableCollection<string>();

            ProductsCollection.Add("Stingray System");
            ProductsCollection.Add("Stingray System");
            ProductsCollection.Add("Stingray System");
            ProductsCollection.Add("Stingray System");
            ProductsCollection.Add("Stingray System");
            ProductsCollection.Add("Stingray System");
            ProductsCollection.Add("Stingray System");
            ProductsCollection.Add("Stingray System");
            ProductsCollection.Add("Stingray System");
            ProductsCollection.Add("Stingray System");

            productsListbox.ItemsSource = ProductsCollection;
        }
    }

    public class ProjectModel
    {
        public string Project { get; set; }
        public string Produkt { get; set; }
        public string CalculationName { get; set; }
        public string Tags { get; set; }
        public string User { get; set; }
        public string Date { get; set; }
    }

    public class ProjectVM
    {
        public ObservableCollection<ProjectModel> ProjectCollection { get; set; }

        public ProjectVM()
        {
            LoadProjectCollection();
        }
        public void LoadProjectCollection()
        {
            ProjectCollection = new ObservableCollection<ProjectModel>();
            ProjectCollection.Add(new ProjectModel { Project = "Project 1", Produkt = "Stingray System", CalculationName = "Calc1", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectCollection.Add(new ProjectModel { Project = "Project 1", Produkt = "Stingray System", CalculationName = "Calc1", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectCollection.Add(new ProjectModel { Project = "Project 1", Produkt = "Stingray System", CalculationName = "Calc1", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectCollection.Add(new ProjectModel { Project = "Project 1", Produkt = "Stingray System", CalculationName = "Calc1", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectCollection.Add(new ProjectModel { Project = "Project 1", Produkt = "Stingray System", CalculationName = "Calc1", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectCollection.Add(new ProjectModel { Project = "Project 1", Produkt = "Stingray System", CalculationName = "Calc1", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectCollection.Add(new ProjectModel { Project = "Project 1", Produkt = "Stingray System", CalculationName = "Calc1", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectCollection.Add(new ProjectModel { Project = "Project 1", Produkt = "Stingray System", CalculationName = "Calc1", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
        }

    }
}
