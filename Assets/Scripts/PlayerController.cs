using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    [SerializeField] private GameObject player;
    [SerializeField] private float speedMod = .1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        // Align to player position
        //transform.position = player.transform.position;
        
        // Rotate left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(0, -1, 0) * speedMod * Time.deltaTime * 100, Space.World);
        }
        
        // Rotate right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(0, 1, 0) * speedMod * Time.deltaTime * 100, Space.World);
        }
    
    }
}
