using UnityEngine;

public class RocketField : MonoBehaviour
{
    private float stayTimer = 0f;

    private void OnTriggerStay2D(Collider2D other)
    {
        stayTimer += Time.deltaTime;

        Debug.Log(stayTimer);

        if (stayTimer >= 2f)
        {
            if (other.CompareTag("ThrowItem"))
            {
                Debug.Log("ThowItem detected");
                GameManager.instance.UpdateScoreAndPosition();
                Destroy(other.gameObject);
            }

            stayTimer = 0f;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        stayTimer = 0f;

        Debug.Log(stayTimer);
    }
}
