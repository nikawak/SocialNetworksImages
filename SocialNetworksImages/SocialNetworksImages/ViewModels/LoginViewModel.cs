using SocialNetworksImages.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SocialNetworksImages.ViewModels;

public class LoginViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject 
{
    public ICommand? OpenVKCommand;
    private readonly HttpClient client;


    public LoginViewModel() 
    {
        OpenVKCommand = new RelayCommand(ExternalVKLogin);
        client = new HttpClient();
    }

    public static async void ExternalVKLogin(object obj)
    {
        //HttpResponseMessage responseMessage = await client.GetAsync();
    }


}
