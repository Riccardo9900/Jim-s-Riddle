using System.Collections;
using System.Collections.Generic;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using UnityEngine.SceneManagement;

public class PlayfabManager : MonoBehaviour
{
    [Header("UI")]
    public Text messageText;
    public InputField emailInput;
    public InputField passwordInput;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void RegisterButton()
    {
        if(passwordInput.text.Length < 6) { 
            messageText.text = "Password troppo corta";
            return;
        }
        var request = new RegisterPlayFabUserRequest
        {
            Email = emailInput.text,
            Password = passwordInput.text,
            RequireBothUsernameAndEmail = false
        };
        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnError);

    }

    void OnRegisterSuccess (RegisterPlayFabUserResult result)
    {
        messageText.text = "Registrato!";
    }

    void OnError (PlayFabError error)
    {
        messageText.text = error.ErrorMessage;
    }

    public void LoginButton()
    {
        var request = new LoginWithEmailAddressRequest
        {
            Email = emailInput.text,
            Password = passwordInput.text
        };
        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnError);
    }

    void OnLoginSuccess (LoginResult result )
    {
        SceneManager.LoadScene("MenuPrincipale");
        GetCharacters();
    }

    public void ResetPasswordButton ()
    {
        var request = new SendAccountRecoveryEmailRequest
        {
            Email = emailInput.text,
            TitleId = "FC013",
        };
        PlayFabClientAPI.SendAccountRecoveryEmail(request, OnPasswordReset, OnError);
    }

    void OnPasswordReset (SendAccountRecoveryEmailResult result)
    {
        messageText.text = "Reset password inviata!";
    }


    public void GetCharacters()
    {
        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnCharactersDataReceived, OnError);
    }

    void OnCharactersDataReceived(GetUserDataResult result)
    {
    }

    void OnSuccess(LoginResult result)
    {
        Debug.Log("Account loggato correttamente!");
        GetCharacters();
    }

}
