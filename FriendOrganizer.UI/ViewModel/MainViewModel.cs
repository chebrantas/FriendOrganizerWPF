﻿using FriendOrganizer.Model;
using FriendOrganizer.UI.Data;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.ViewModel
{
    public partial class MainViewModel:ViewModelBase
    {
        //private IFriendDataService _friendDataService;
        //private Friend _selectedFriend;

        //public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel(INavigationViewModel navigationViewModel, IFriendDetailViewModel friendDetailViewModel/*IFriendDataService friendDataService*/)
        {
            NavigationViewModel = navigationViewModel;
            FriendDetailViewModel = friendDetailViewModel;
            //Friends = new ObservableCollection<Friend>();
            //_friendDataService = friendDataService;
        }

        public async Task LoadAsync()
        {
            await NavigationViewModel.LoadAsync();
            //var friends = await _friendDataService.GetAllAsync();
            ////clear collection for not have dublicates
            //Friends.Clear();
            //foreach (var friend in friends)
            //{
            //    Friends.Add(friend);
            //}
        }

        public INavigationViewModel NavigationViewModel { get; }
        public IFriendDetailViewModel FriendDetailViewModel { get; }

        //public void Load()
        //{
        //    var friends = _friendDataService.GetAll();
        //    //clear collection for not have dublicates
        //    Friends.Clear();
        //    foreach (var friend in friends)
        //    {
        //        Friends.Add(friend);
        //    }
        //}


        //kadangi turim NavigationViewModel nebereikia pacioj klasej sito
        //ObservableCollection Informs when items added, removed or all list refreshed
        //public ObservableCollection<Friend> Friends { get; set; }

        //public Friend SelectedFriend
        //{
        //    get { return _selectedFriend; }
        //    set { _selectedFriend = value;
        //        //OnPropertyChanged("SelectedFriend");
        //        OnPropertyChanged();
        //    }
        //}
        //helpermethod for change if have more parameters to change 1 versija be tobulinimu
        //private void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        //}
        //
        //del [CallerMemberName] naudojant methoda nebereikia parametro pateikti automatiskai pasiima 
        //private void OnPropertyChanged([CallerMemberName]string propertyName=null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}
