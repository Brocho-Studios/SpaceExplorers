using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class level2 : MonoBehaviour
{
void OnTriggerEnter2D (Collider2D collider)
{

                Social.ReportProgress("CgkI_s-66aUGEAIQAg", 100.0f, (bool success) => {
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
