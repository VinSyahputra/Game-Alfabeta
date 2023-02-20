using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;
public class ManagerKata : MonoBehaviour
{
	public static ManagerKata Instance {get; private set;}
	[SerializeField] private GameObject gameSelesai, gameGagal;
	[SerializeField] Drag hurufPrefab;
	[SerializeField] Transform slotAwal, slotAkhir;
	[SerializeField] string[] listKataKata;
	private int poinKata, poin;
	private int skor;
	string[] kataPertama = {"ANDI MEMAKAI BAJU HITAM", "ANTON BERADA DI DALAM KELAS", "ANTON SEDANG BELAJAR BERHITUNG", "ANTON SEDANG NONTON TV", "AYAH DAN IBU BERANGKAT KE KANTOR", "AYAH MENGANTAR ADIK KE SEKOLAH", "AYAH PERGI BEKERJA", "AYAH PULANG DARI KANTOR", "AYAH SEDANG MEMBACA KORAN", "AYU DAN SINTA BELAJAR BERSAMA", "BUDI DAN SINTA PERGI KE SEKOLAH", "BUDI MENGERJAKAN TUGAS SEKOLAH", "BUDI SEDANG BERMAIN", "BUDI SEDANG MANDI", "BUDI SEDANG TIDUR SIANG", "BUKU SINTA BERWARNA MERAH", "FIKRI BERMAIN SEPAK BOLA", "HAVINDI SEDANG MENCUCI BAJU", "IBU MEMBERSIHKAN HALAMAN RUMAH", "IBU SEDANG MEMASAK", "RIRI PERGI KE WARUNG", "RIRI PULANG DARI SEKOLAH", "SINTA SEDANG MENYANYI", "AYU MEMBERSIHKAN KAMAR TIDUR"};
    // Start is called before the first frame update
    void Start()
    {
		if(!PlayerPrefs.HasKey("number")){
			PlayerPrefs.SetInt("number", 0);
		}else{
			PlayerPrefs.GetInt("number");
		}

		for (int i = 0; i < kataPertama.Length; i++){
    		kataPertama[i] = kataPertama[i].ToLower();
		}

        Instance = this;

        InitKata(kataPertama[PlayerPrefs.GetInt("number")]);
        // InitKata(kataPertama[UnityEngine.Random.Range(0, kataPertama.Length)]);

    }

    void InitKata(string kata){
    	string hurufKata = kata;

		string[] hurufKata2 = kata.Split(' ');
    	char[] hurufAcak = new char[hurufKata2.Length];

    	List<char> hurufKataCopy = new List<char>();
    	hurufKataCopy = hurufKata.ToList();

		// random pilihan kata
		int[] rand = new int[hurufKata2.Length];
		for(int i = 0; i<hurufAcak.Length; i++){
            rand[i] = i;
        }

		// random pilihan tanpa ada yang diulang
		System.Random random = new System.Random();
        rand = rand.OrderBy(x => random.Next()).ToArray();


    	for(int i = 0; i < hurufAcak.Length; i++){
    		int randomIndex = UnityEngine.Random.Range(0, hurufKataCopy.Count);
    		hurufAcak[i] = hurufKataCopy[randomIndex];
    		hurufKataCopy.RemoveAt(randomIndex);

			

    		Drag temp = Instantiate(hurufPrefab, slotAwal);
    		temp.Inisialisasi(slotAwal, hurufKata2[rand[i]].ToString(), false);
    	}

    	for(int i = 0; i < hurufKata2.Length; i++){
			// Debug.Log("copy : " + hurufKata2.Length);
    		Drag temp = Instantiate(hurufPrefab, slotAkhir);
    		temp.Inisialisasi(slotAkhir, hurufKata2[i].ToString(), true);

    	}

    	poinKata = hurufKata2.Length;
    }

    public void TambahPoin(){
    	poin++;
    	if(poin == poinKata){
    		// Debug.Log(kataPertama.Length);
			
			PlayerPrefs.SetInt("number", PlayerPrefs.GetInt("number") + 1);
			
			if(PlayerPrefs.GetInt("number") != kataPertama.Length){
				PlayerPrefs.SetInt("getSkor", PlayerPrefs.GetInt("getSkor") + 100);
				SceneManager.LoadScene(11);
			}else{
				PlayerPrefs.SetInt("totalSkor", PlayerPrefs.GetInt("totalSkor") + PlayerPrefs.GetInt("getSkor"));
				gameSelesai.SetActive(true);
				PlayerPrefs.DeleteKey("number");
				PlayerPrefs.DeleteKey("getSkor");
				// SceneManager.LoadScene(10);
				return;
			}
    	}
    }

	void Update(){
		if(PlayerPrefs.GetInt("timerActive") == 0){
			gameGagal.SetActive(true);
			PlayerPrefs.DeleteKey("number");
			PlayerPrefs.DeleteKey("getSkor");
		}
	}
}
