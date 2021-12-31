using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour, IWeapon, IProjectileWeapon
{
    public Animator animator;
    public Transform ProjectileSpawn { get; set; }
    public List<BaseStat> Stats { get; set; }
    Bullet bullet;


    void Start() {
        bullet = Resources.Load<Bullet>("Weapon/Prefabs/projectiles/bullet");
        animator = GetComponent<Animator>();
    }

    public void CastProjectile()
    {
        Bullet bulletInstance = (Bullet)Instantiate(bullet, ProjectileSpawn.position, ProjectileSpawn.rotation);
        bulletInstance.Direction = ProjectileSpawn.forward;
    }

    public void PreformAttack()
    {
        animator.SetTrigger("Base_Attack");
    }
}
