using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_dashboardATM_AIFile.Classes
{
    public class ATM_ViewModel : BaseHandler
    {
        ObservableCollection<ATM_Model> projectCollection;
        int start = 0;
        int itemCount = 10;
        int totalItems = 0;
        ATM_Model selectedPage;
        int selectedIndex;

        public ATM_ViewModel()
        {
            LoadCalculationCollection();
            LoadTagsCollection();
            LoadProductsCollection();
            LoadProjectCollection();
            FilterProjectList = ProjectList;
            LaodPageNumbers();
            RefreshDatagrid();
        }

        #region properties

        public ObservableCollection<ATM_Model> ProjectCollection
        {
            get
            {
                return projectCollection;
            }
            set
            {
                projectCollection = value;
                NotifyPropertyChanged("ProjectCollection");
            }
        }
        public List<ATM_Model> ProjectList { get; set; }
        public List<ATM_Model> FilterProjectList { get; set; }
        public ObservableCollection<string> CalculationCollection { get; set; }
        public ObservableCollection<string> TagsCollection { get; set; }
        public ObservableCollection<string> ProductsCollection { get; set; }
        public ObservableCollection<ATM_Model> Pagers { get; set; }
        public int PageCount { get; set; }
        public int Start
        {
            get
            {
                return start + 1;
            }
            set
            {
                start = value;
                NotifyPropertyChanged("Start");
            }
        }

        public int SelectedIndex
        {
            get
            {
                return selectedIndex;
            }
            set
            {
                selectedIndex = value;
                NotifyPropertyChanged("SelectedIndex");
            }
        }
        public ATM_Model SelectedPage
        {
            get
            {
                return selectedPage;
            }
            set
            {
                selectedPage = value;
                if (SelectedPage != null)
                {

                    start = 0;
                    start += (itemCount * selectedPage.Pagingtag);
                    RefreshDatagrid();
                }

                NotifyPropertyChanged("SelectedPage");
            }
        }
        #endregion

        #region methods

        public void LoadProjectCollection()
        {
            ProjectList = new List<ATM_Model>();
            ProjectList.Add(new ATM_Model { Project = "Project 1", Produkt = "Stingray System", CalculationName = "Calc1", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 2", Produkt = "Stingray System", CalculationName = "Calc2", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 3", Produkt = "Stingray System", CalculationName = "Calc3", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 4", Produkt = "Stingray System", CalculationName = "Calc4", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 5", Produkt = "Stingray System", CalculationName = "Calc5", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 6", Produkt = "Stingray System", CalculationName = "Calc6", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 7", Produkt = "Stingray System", CalculationName = "Calc7", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 8", Produkt = "Stingray System", CalculationName = "Calc8", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 9", Produkt = "Stingray System", CalculationName = "Calc9", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 10", Produkt = "Stingray System", CalculationName = "Calc10", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 11", Produkt = "Stingray System", CalculationName = "Calc11", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 12", Produkt = "Stingray System", CalculationName = "Calc12", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 13", Produkt = "Stingray System", CalculationName = "Calc13", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 14", Produkt = "Stingray System", CalculationName = "Calc14", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 15", Produkt = "Stingray System", CalculationName = "Calc15", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 16", Produkt = "Stingray System", CalculationName = "Calc16", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 17", Produkt = "Stingray System", CalculationName = "Calc17", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 18", Produkt = "Stingray System", CalculationName = "Calc18", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 19", Produkt = "Stingray System", CalculationName = "Calc19", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 20", Produkt = "Stingray System", CalculationName = "Calc20", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 21", Produkt = "Stingray System", CalculationName = "Calc21", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 22", Produkt = "Stingray System", CalculationName = "Calc22", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 23", Produkt = "Stingray System", CalculationName = "Calc23", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 24", Produkt = "Stingray System", CalculationName = "Calc24", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 25", Produkt = "Stingray System", CalculationName = "Calc25", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 26", Produkt = "Stingray System", CalculationName = "Calc26", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 27", Produkt = "Stingray System", CalculationName = "Calc27", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 28", Produkt = "Stingray System", CalculationName = "Calc28", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 29", Produkt = "Stingray System", CalculationName = "Calc29", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 30", Produkt = "Stingray System", CalculationName = "Calc30", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 31", Produkt = "Stingray System", CalculationName = "Calc31", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 32", Produkt = "Stingray System", CalculationName = "Calc32", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 33", Produkt = "Stingray System", CalculationName = "Calc33", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 34", Produkt = "Stingray System", CalculationName = "Calc34", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 35", Produkt = "Stingray System", CalculationName = "Calc35", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 36", Produkt = "Stingray System", CalculationName = "Calc36", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 37", Produkt = "Stingray System", CalculationName = "Calc37", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 38", Produkt = "Stingray System", CalculationName = "Calc38", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 39", Produkt = "Stingray System", CalculationName = "Calc39", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 40", Produkt = "Stingray System", CalculationName = "Calc40", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 41", Produkt = "Stingray System", CalculationName = "Calc41", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 42", Produkt = "Stingray System", CalculationName = "Calc42", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 43", Produkt = "Stingray System", CalculationName = "Calc43", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 44", Produkt = "Stingray System", CalculationName = "Calc44", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
            ProjectList.Add(new ATM_Model { Project = "Project 45", Produkt = "Stingray System", CalculationName = "Calc45", Tags = "Lutz,Vektoren", User = "Hetzmannseder", Date = "27.02.2017" });
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
        }
        public void LaodPageNumbers()
        {
            totalItems = ProjectList.Count;
            var v = totalItems % itemCount;
            PageCount = v == 0 ? (totalItems / itemCount) : (totalItems / itemCount) + 1;
            Pagers = new ObservableCollection<ATM_Model>();
            for (int i = 1; i <= PageCount; i++)
            {
                Pagers.Add(new ATM_Model { PagingText = i.ToString(), Pagingtag = i - 1 });
            }
        }

        private void RefreshDatagrid()
        {
            LaodDataGridData(start, itemCount, out totalItems);
            NotifyPropertyChanged("Start");
        }

        public void LaodDataGridData(int start, int itemCount, out int totalItems)
        {
            totalItems = FilterProjectList.Count;

            ProjectCollection = new ObservableCollection<ATM_Model>();

            for (int i = start; i < start + itemCount && i < totalItems; i++)
            {
                ProjectCollection.Add(FilterProjectList[i]);
            }

        }

        #endregion
    }
}
