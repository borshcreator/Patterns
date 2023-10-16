using UnityEngine;
using System.Collections;

public class MultiShotWeapon : Weapon
{
    [SerializeField] private float _shotDelay = 0.1f;

    protected override void Fire()
    {
        if (_currentAmmo >= _bulletsPerShot)
        {
            StartCoroutine(FireRoutine());

            _currentAmmo -= _bulletsPerShot;

            Debug.Log("�������� " + _currentAmmo + " ��������");
        }
        else
        {
            Debug.Log("������������ �������� ��� ��������");
        }
    }

    private IEnumerator FireRoutine()
    {
        for (int i = 0; i < _bulletsPerShot; i++)
        {
            Instantiate(_bulletPrefab, _muzzleTform.position, _muzzleTform.rotation);
            yield return new WaitForSeconds(_shotDelay);
        }
    }
}
