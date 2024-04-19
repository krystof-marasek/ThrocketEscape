using UnityEngine;

public class RocketField : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ThrowItem"))
        {
            Debug.Log("ThowItem detected");
            GameManager.instance.UpdateScoreAndPosition();
        }
    }
}
