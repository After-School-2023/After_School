using UnityEngine;

public class FirstPersonCam : MonoBehaviour
{
    public Transform player;                                           // Player's reference.
    public float horizontalAimingSpeed = 6f;                           // Horizontal turn speed.
    public float verticalAimingSpeed = 6f;                             // Vertical turn speed.
    public float maxVerticalAngle = 30f;                               // Camera max clamp angle. 
    public float minVerticalAngle = -60f;                              // Camera min clamp angle.
    public string XAxis = "Mouse X";                                   // The default horizontal axis input name.
    public string YAxis = "Mouse Y";                                   // The default vertical axis input name.

    private float angleH = 0;                                          // Float to store camera horizontal angle related to mouse movement.
    private float angleV = 0;                                          // Float to store camera vertical angle related to mouse movement.
    private Transform cam;                                             // This transform.

    void Awake()
    {
        // Reference to the camera transform.
        cam = transform;

        // Set camera default position.
        cam.position = player.position;
        cam.rotation = Quaternion.identity;
    }

    void Update()
    {
        // Get mouse movement to rotate the player.
        // Mouse:
        angleH += Input.GetAxis(XAxis) * horizontalAimingSpeed;
        angleV += Input.GetAxis(YAxis) * verticalAimingSpeed;

        // Set vertical movement limit.
        angleV = Mathf.Clamp(angleV, minVerticalAngle, maxVerticalAngle);

        // Set player orientation.
        Quaternion playerRotation = Quaternion.Euler(0, angleH, 0);
        player.rotation = playerRotation;

        // Set camera orientation.
        Quaternion camRotation = Quaternion.Euler(-angleV, angleH, 0);
        cam.rotation = camRotation;
    }
}
