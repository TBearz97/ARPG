using System.Collections;
using UnityEngine.InputSystem;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine;

public class WorldInteraction : MonoBehaviour
{
    NavMeshAgent playerAgent;
    private InputAction interaction;
    private InputAction movement;
    public PlayerControls playerControls;

    private void Awake()
    {
        playerControls = new PlayerControls();
        interaction = playerControls.Gameplay.Interaction;
        movement = playerControls.Gameplay.Movement;
    }
    // Start is called before the first frame update
    void Start()
    {
        playerAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInteraction();
    }

    private void OnEnable()
    {
        interaction.Enable();
        movement.Enable();
    }

    private void OnDisable()
    {
        interaction.Disable();
        movement.Disable();
    }

    private void GetInteraction() {
        if (interaction.ReadValue<float>() == 1 && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        {
            Ray interactionRay = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit interactionInfo;

            if (Physics.Raycast(interactionRay, out interactionInfo, Mathf.Infinity))
            {
                GameObject interactObject = interactionInfo.collider.gameObject;
                if (interactObject.GetComponent<Interactable>() != null)
                {
                    interactObject.GetComponent<Interactable>().MoveToInteraction(playerAgent);
                }
                else
                {
                    playerAgent.stoppingDistance = 0;
                    playerAgent.SetDestination(interactionInfo.point);

                }
            }
        }
        else if (movement.ReadValue<Vector2>() != new Vector2(0, 0))
        {
            if (DialogueSystem.Instance.dialoguePanel.activeSelf)
            {
                DialogueSystem.Instance.dialoguePanel.SetActive(false);
            }
            Vector2 input = movement.ReadValue<Vector2>();
            Vector3 move = new Vector3(input.x, 0, input.y);
            playerAgent.stoppingDistance = 0;
            playerAgent.SetDestination(playerAgent.transform.position + move);
        }
    }
}
