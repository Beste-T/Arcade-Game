using UnityEngine;

public class PlayerInteractionScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
