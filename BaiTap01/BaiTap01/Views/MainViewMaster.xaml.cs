using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaiTap01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainViewMaster : ContentPage
    {
        public ListView ListView;

        public MainViewMaster()
        {
            InitializeComponent();

            BindingContext = new MainViewMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MainViewMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MainViewMenuItem> MenuItems { get; set; }
            
            public MainViewMasterViewModel()
            {
                MenuItems = new ObservableCollection<MainViewMenuItem>(new[]
                {
                    new MainViewMenuItem { Id = 0, Title = "Home" , Image = "ic_home.png" },
                    new MainViewMenuItem { Id = 1, Title = "Book a room", Image = "ic_bed.png" },
                    new MainViewMenuItem { Id = 2, Title = "My room", Image = "ic_key.png" },
                    new MainViewMenuItem { Id = 3, Title = "Suggestions", Image = "ic_beach.png" },
                    new MainViewMenuItem { Id = 4, Title = "Concierge", Image = "ic_bot.png" },
                    new MainViewMenuItem { Id = 5, Title = "Logout", Image = "ic_logout.png" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}