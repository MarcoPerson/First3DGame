using UnityEngine;

public class LevelCompleted : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<GameManagement>().LevelCompleted();
    }

}
