using UnityEngine;

[CreateAssetMenu(fileName = "GameSettings", menuName = "Configs/Game settings")]
public class GameSettings : ScriptableObject
{
    [Header("Controller")]
    public float rotationSmoothDuration;
    public float maxRotation;
    public float fallingSpeed;

    [Header("Physics")] 
    public float speedMultiplier;
    public float drag;
    public float mass;
    
    [Header("Camera")]
    public float cameraOffsetY;
    public float cameraLerpYDuration;
    public float cameraLerpXDuration;
    public float thresholdBlockX;
}