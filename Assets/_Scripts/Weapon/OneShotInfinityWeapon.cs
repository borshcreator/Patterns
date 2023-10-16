using UnityEngine;

public class OneShotInfinityWeapon : Weapon
{
    protected override void Fire()
    {
        Instantiate(_bulletPrefab, _muzzleTform.position, _muzzleTform.rotation);
        Debug.Log("Всё ещё бесконечное количество патронов");
    }
}
