using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public PlayerWeaponController playerWeaponController;
    public Item gun;
    public Item PotionLog;
    public PlayerControls playerControls;
    public InputAction equipWeapon;


    private void Awake()
    {
        playerControls = new PlayerControls();
        equipWeapon = playerControls.Gameplay.EquipWeapon;
    }
    private void Start()
    {
        playerWeaponController = GetComponent<PlayerWeaponController>();
        List<BaseStat> swordStats = new List<BaseStat>();
        swordStats.Add(new BaseStat(6, "Power", "Your power level"));
        gun = new Item(swordStats, "gun");

        PotionLog = new Item(new List<BaseStat>(), "potion_log", "Drink this to log something", "Drink", "Log Potion", false);
    }

    private void OnEnable()
    {
        equipWeapon.Enable();
    }

    private void OnDisable()
    {
        equipWeapon.Disable();
    }

    private void Update()
    {
        if (equipWeapon.ReadValue<float>() == 1) {
            playerWeaponController.EquipWeapon(gun);

        }
    }
}
