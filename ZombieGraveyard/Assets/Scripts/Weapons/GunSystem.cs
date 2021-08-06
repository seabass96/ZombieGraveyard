using UnityEngine;
using UnityEngine.UI;

public class GunSystem : MonoBehaviour
{
    //Gun stats
    public int damage;
    public float timeBetweenShooting, spread, range, reloadTime, timeBetweenShots;
    public int magazineSize, bulletsPerTap;
    public bool allowButtonHold;
    int bulletsLeft, bulletsShot;

    //bools 
    bool shooting, readyToShoot, reloading;

    //Reference
    public Camera cam;
    public Transform attackPoint;
    public RaycastHit rayHit;
    public LayerMask enemyLayer;

    //Graphics
    //public GameObject muzzleFlash, bulletHoleGraphic;

    //UI
    public Text text;

    private void Start()
    {
        bulletsLeft = magazineSize;
        readyToShoot = true;

        UpdateAmmoText();
    }
    private void Update()
    {
        GetInput();
    }
    private void GetInput()
    {
        //if automatic weapon
        if (allowButtonHold)
        {
            shooting = Input.GetKey(KeyCode.Mouse0);
        }
        else
        {
            shooting = Input.GetKeyDown(KeyCode.Mouse0);
        }

        //if r is pressed, gun has been fired and isnt already reloading
        if (Input.GetKeyDown(KeyCode.R) && bulletsLeft < magazineSize && !reloading)
        {
            Reload();
        }

        //Shoot
        if (readyToShoot && shooting && !reloading && bulletsLeft > 0)
        {
            bulletsShot = bulletsPerTap;
            Shoot();
        }
        else if (readyToShoot && shooting && !reloading && bulletsLeft == 0)
        {
            Reload();
        }
    }
    private void Shoot()
    {
        print("Bang");

        readyToShoot = false;

        //Spread
        float x = Random.Range(-spread, spread);
        float y = Random.Range(-spread, spread);

        //Calculate Direction with Spread
        Vector3 direction = cam.transform.forward + new Vector3(x, y, 0);

        Debug.DrawRay(cam.transform.position, direction, Color.cyan, 0.5f);

        //RayCast
        if (Physics.Raycast(cam.transform.position, direction, out rayHit, range, enemyLayer))
        {
            Debug.Log(rayHit.collider.name);

            //if object hit is enemy
            if (rayHit.collider.CompareTag("Enemy"))
            {
                //call enemy damage function
                rayHit.collider.GetComponent<DamageEnemy>().TakeDamage(damage);
            }
        }

        //Graphics
        //Instantiate(bulletHoleGraphic, rayHit.point, Quaternion.Euler(0, 180, 0));
        //Instantiate(muzzleFlash, attackPoint.position, Quaternion.identity);

        bulletsLeft--;
        bulletsShot--;

        Invoke("ResetShot", timeBetweenShooting);

        if(bulletsShot > 0 && bulletsLeft > 0)
        {
            Invoke("Shoot", timeBetweenShots);
        }

        UpdateAmmoText();
    }
    private void ResetShot()
    {
        readyToShoot = true;
    }
    private void Reload()
    {
        reloading = true;
        Invoke("ReloadFinished", reloadTime);
    }
    private void ReloadFinished()
    {
        bulletsLeft = magazineSize;
        reloading = false;
        UpdateAmmoText();
    }
    private void UpdateAmmoText()
    {
        //SetText
        text.text = (bulletsLeft + " / " + magazineSize);
    }
}
