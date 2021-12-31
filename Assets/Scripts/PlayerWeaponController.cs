using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerWeaponController : MonoBehaviour
{
    public GameObject playerHand;
    public GameObject EquippedWeapon { get; set; }
    private PlayerControls playerControls;
    private InputAction preformAttack;

    Transform spawnProjectile;
    IWeapon equippedWeapon;
    CharacterStats characterStats;

    private void Awake()
    {
        playerControls = new PlayerControls();
        preformAttack = playerControls.Gameplay.PreformAttack;
    }

    private void OnEnable()
    {
        preformAttack.Enable();
    }

    private void OnDisable() 
    {
        preformAttack.Disable();
    }

    private void Start()
    {
        spawnProjectile = transform.Find("ProjectileSpawn");
        characterStats = GetComponent<CharacterStats>();
    }

    public void EquipWeapon(Item itemToEquip) {
        if (EquippedWeapon != null) {
            characterStats.RemoveStatBonus(EquippedWeapon.GetComponent<IWeapon>().Stats);
            Destroy(playerHand.transform.GetChild(0).gameObject);
        }
        EquippedWeapon = (GameObject)Instantiate(Resources.Load<GameObject>("Weapon/" + "Prefabs/" + itemToEquip.ObjectSlug+ "/" + itemToEquip.ObjectSlug), playerHand.transform.position, playerHand.transform.rotation);


        equippedWeapon = EquippedWeapon.GetComponent<IWeapon>();
        equippedWeapon.Stats = itemToEquip.Stats;

        if (EquippedWeapon.GetComponent<IProjectileWeapon>() != null)
        {
            EquippedWeapon.transform.Rotate(new Vector3(90, 90, 90));
            EquippedWeapon.GetComponent<IProjectileWeapon>().ProjectileSpawn = spawnProjectile;
        }
        EquippedWeapon.transform.SetParent(playerHand.transform);
        characterStats.AddStatBonus(itemToEquip.Stats);
    }

    public void PreformWeaponAttack() {
        equippedWeapon.PreformAttack();
    }

    private void Update()
    {
        if (preformAttack.WasPerformedThisFrame())
        {
            PreformWeaponAttack();
        } 
    }
}
