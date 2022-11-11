using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("This thing is friendly");
                break;
            case "Finish":
                Debug.Log("Congrats you finished!");
                break;
            case "Fuel":
                Debug.Log("Fuel!");
                break;
            default:
                Debug.Log("You lost!");
                break;
        }
    }
}
