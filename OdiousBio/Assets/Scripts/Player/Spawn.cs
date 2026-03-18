using Unity.Netcode;
using UnityEngine;

public class OwnershipManager : NetworkBehaviour
{
    public void SetOwner(ulong newOwnerClientId)
    {
        if (!IsServer) return;

        // Get the NetworkObject component
        var networkObject = GetComponent<NetworkObject>();

        // Change ownership to the new client ID
        networkObject.ChangeOwnership(newOwnerClientId);
        Debug.Log($"Ownership transferred to: {newOwnerClientId}");
    }
}
