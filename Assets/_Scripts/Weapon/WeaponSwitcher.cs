using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    [SerializeField] private Weapon[] weapons;
    [SerializeField] private Weapon _currentWeapon;
    private int _currentWeaponIndex = 0;

    private void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            _currentWeaponIndex++;

            if(_currentWeaponIndex > weapons.Length - 1)
            {
                _currentWeaponIndex = 0;
            }

            ChangeWeapon(_currentWeaponIndex);
        }
        else if(Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            _currentWeaponIndex--;

            if (_currentWeaponIndex < 0)
            {
                _currentWeaponIndex = weapons.Length - 1;
            }

            ChangeWeapon(_currentWeaponIndex);
        }
    }

    private void ChangeWeapon(int weaponIndex)
    {
        if (_currentWeapon != null)
        {
            _currentWeapon.Hide();
        }

        _currentWeapon = weapons[weaponIndex];

        _currentWeapon.Show();
    }
}
