using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class SignInScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
            Social.localUser.Authenticate((bool success) => {
                if (success)
                {   
                    Debug.Log("Not logged in.");
                }
                else
                {
                    Debug.Log("Error occured while logging in");
                }
    });

            Social.ReportProgress("CgkI_s-66aUGEAIQBg", 100.0f, (bool success) => {
            if (success)
            {   
                Debug.Log("Loaded achievement");
            }
            else
            {
                Debug.Log("Couldn't load achievement");
            }
            });
    }
}