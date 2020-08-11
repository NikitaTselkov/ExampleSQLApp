using Models;
using System;

namespace ViewModels
{
    public class LoginWindowViewModel
    {
        public event Action OnClose;

        public RelayCommand CloseWindow { get; set; }

        public LoginWindowViewModel()
        {
            CloseWindow = new RelayCommand(CloseWindowMetod);
        }

        public void CloseWindowMetod(object param)
        {
            Console.WriteLine(param + "It is Working");
            OnClose?.Invoke();
        }
    }
}
