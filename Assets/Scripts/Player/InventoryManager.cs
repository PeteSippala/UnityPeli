using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<WeaponController> weaponSlots = new List<WeaponController>(6);
    public int[] weaponLevels = new int[6];
    public List<PassiveItem> passiveItemSlots = new List<PassiveItem>(6);
    public int[] passiveItemLevels = new int[6];

    public void AddWeapon(int slotIndex, WeaponController weapon)
    {
        weaponSlots[slotIndex] = weapon;
        weaponLevels[slotIndex] = weapon.weaponData.Level;
    }

    public void AddPassiveItem(int slotIndex, PassiveItem passiveItem)
    {
        passiveItemSlots[slotIndex] = passiveItem;
        passiveItemLevels[slotIndex] = passiveItem.passiveItemData.Level;
    }

    public void LevelUpWeapon(int slotIndex)
    {
       // if (weaponSlots.Count > slotIndex)
        //{ 
       // WeaponController weapon = weaponSlots[slotIndex];
        //GameObject upgradedWeapon = Instantiate (weapon.weaponData.NextLevelPrefab,transform.position,Quaternion.identity);
       // upgradedWeapon.transform.SetParent(transform);
       // AddWeapon(slotIndex, upgradedWeapon.GetComponent<WeaponController>());
         //   Destroy(weapon.gameObject);
          //  weaponLevels[slotIndex] = upgradedWeapon.GetComponent<WeaponController>().weaponData.Level;
   // }
    }

    public void LevelUpPassiveItem(int slotIndex)
    {
       // if (passiveItemSlots.Count > slotIndex)
       // {
         //   WeaponController weapon = weaponSlots[slotIndex];
            //GameObject upgradedWeapon = Instantiate (weapon.weaponData.NextLevelPrefab,transform.position,Quaternion.identity);
          //  upgradedWeapon.transform.SetParent(transform);
           // AddWeapon(slotIndex, upgradedWeapon.GetComponent<WeaponController>());
           // Destroy(weapon.gameObject);
           // weaponLevels[slotIndex] = upgradedWeapon.GetComponent<WeaponController>().weaponData.Level;
      // }
    }
}
