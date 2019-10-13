using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using MobileClient.Shared;
using MobileClient.Shared.Models;
using MobileClient.Shared.Services;
using Xamarin.Forms;

namespace MobileClient
{
    public class MainViewModel : BindableObject
    {
        private ObservableCollection<Todo> _todos;

        public ObservableCollection<Todo> Todos
        {
            get => _todos;
            set
            {
                _todos = value;
                OnPropertyChanged(nameof(Todos));
            }
        }

        private bool _isRefreshing;

        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        public ICommand RefreshCommand => new Command(() => Task.Run(GetTodosAsync));

        public MainViewModel()
        {
            Task.Run(GetTodosAsync);
        }

        private async Task GetTodosAsync()
        {
            if (!IsRefreshing) IsRefreshing = true;
#if DEBUG
            // Simulate heavy network traffic
            await Task.Delay(3000);
#endif
            try
            {
                var todos = await DependencyService.Get<IApiFactory<ITodoService>>()
                .CreateConnection(AppSettings.ApiBaseUrl)
                .GetTodos();
                Device.BeginInvokeOnMainThread(() =>
                {
                    IsRefreshing = false;
                    Todos = new ObservableCollection<Todo>(todos);
                });
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"Error :: {ex.Message}");
            }
            finally
            {
                IsRefreshing = false;
            }
        }
    }
}
