using Unity.Netcode;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : NetworkBehaviour
{
    [SerializeField]
    private InputActionReference m_playerInput;
    [SerializeField]
    private AgentMover m_agentMover;

    private void Update()
    {
        if (!IsOwner) return;

        Vector2 movementInput = m_playerInput.MovementInput;
        m_agentMover.Move(movementInput);
    }
}