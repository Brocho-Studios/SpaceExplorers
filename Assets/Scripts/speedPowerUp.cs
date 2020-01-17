using UnityEngine;

public class speedPowerUp : MonoBehaviour
{
public GameObject player;

public void SpeedButton ()
{   
    player.transform.position = new Vector2(transform.position.x, 3);
}

}
