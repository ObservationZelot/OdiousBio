using Unity.Netcode;
using UnityEngine;

public class PlayerCameraSetup : NetworkBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private AudioListener audioListener;

    public override void OnNetworkSpawn()
    {
        if (IsOwner)
        {
            // Enable camera and listener for the local player
            playerCamera.enabled = true;
            audioListener.enabled = true;
        }
        else
        {
            // Disable camera and listener for all remote players
            playerCamera.enabled = false;
            audioListener.enabled = false;
        }
    }
}
