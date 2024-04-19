using UnityEngine;

public class RocketField : MonoBehaviour
{
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("ThrowItem"))
        {
            Debug.Log("ThowItem detected");
        }
    }
}
