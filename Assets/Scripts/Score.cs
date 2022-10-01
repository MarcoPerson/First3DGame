using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public GameObject player;
    public TMPro.TextMeshProUGUI score;
    // Update is called once per frame
    void Update()
    {
        score.text = player.transform.position.z.ToString("0");
    }
}
