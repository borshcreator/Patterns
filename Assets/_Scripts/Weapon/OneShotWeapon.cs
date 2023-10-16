using UnityEngine;

public class OneShotWeapon : Weapon
{
    protected override void Fire()
    {
        if(_currentAmmo >= _bulletsPerShot)
        {
            Instantiate(_bulletPrefab, _muzzleTform.position, _muzzleTform.rotation);
            _currentAmmo -= _bulletsPerShot;

            Debug.Log("Осталось " + _currentAmmo + " патронов");
        }
        else
        {
            Debug.Log("Недостаточно патронов для выстрела");
        }
    }
}
