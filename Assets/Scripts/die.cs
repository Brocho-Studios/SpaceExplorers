using UnityEngine;

public class die : MonoBehaviour
{

public GameObject explosion;

void OnTriggerEnter2D (Collider2D collider)
{   
    Destroy(collider.gameObject);
    Instantiate(explosion, collider.transform.position, Quaternion.identity);
}
}
