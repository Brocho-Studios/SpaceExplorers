using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void PlayButton ()
        {   
            SceneManager.LoadScene(1);
        }

    public void DiscordButton()
    {
        Application.OpenURL("https://discord.gg/RNpgNfB");
    }
}
