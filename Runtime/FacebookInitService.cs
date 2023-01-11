using Facebook.Unity;
using UnityEngine;

namespace LittleBitGames.FacebookModule
{
    public class FacebookInitService
    {
        public FacebookInitService()
        {
            if (!FB.IsInitialized)
            {
                FB.Init(InitCallback, OnHideUnity);
            } 
            else 
            {
                FB.ActivateApp();
            }
        }

        private void InitCallback()
        {
            if (FB.IsInitialized) 
            {
                FB.ActivateApp();
            } 
            else 
            {
                Debug.Log("Failed to Initialize the Facebook SDK");
            }
        }

        private void OnHideUnity(bool isGameShown)
        {
            Time.timeScale = !isGameShown ? 0 : 1;
        }
    }
}