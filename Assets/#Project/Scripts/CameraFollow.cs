using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private PlayerControl player;
    [SerializeField] private float decal = -3;
    [SerializeField] private float speed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (player == null)
        {
            player = FindFirstObjectByType<PlayerControl>();
        }
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 goalPosition = transform.position;
        goalPosition.z = player.transform.position.z + decal;

        Vector3 direction = (goalPosition - transform.position).normalized;

        transform.position += Time.deltaTime * speed * direction;


    }
}
