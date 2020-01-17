using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using UnityEngine.SceneManagement;

public class level3 : MonoBehaviour
{
void OnTriggerEnter2D (Collider2D other)
{   
        if (other.CompareTag("Player"))
        {
    SceneManager.LoadScene(2);
        }


                Social.ReportProgress("CgkI_s-66aUGEAIQBA", 100.0f, (bool success) => {
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