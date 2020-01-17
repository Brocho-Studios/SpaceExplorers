using UnityEngine;
using UnityEngine.SceneManagement;

public class level5 : MonoBehaviour
{   
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
    SceneManager.LoadScene(4);
        }
    }
}
