# SnimanjeVUV
Program za automatsko snimanje na VUV spektrometru opisan u mom [master radu](https://1drv.ms/b/s!AtP4IU2wTrMwhr1e3T1TBZL9E2Hj9A?e=kkSrOj). Trenutna verzija programa očekuje Arduino Nano kontroler i Tektronix TDS 2024C osciloskop povezane na računar putem USB-a. Arduino, driver motora i napajanje povezati kako je prikazano na slikama: </br>
<a href="url"><img src="https://user-images.githubusercontent.com/23122428/233811105-efaf022b-52ee-4247-81a3-fec1dd66fbb1.jpg" height="49%" width="49%" ></a>
<a href="url"><img src="https://user-images.githubusercontent.com/23122428/233811113-7b8d1554-90e7-4b3d-ab1a-8cfb2c215a8b.jpg" height="49%" width="49%" ></a>
Opis sistema i algoritma dostupni su u radu.

## Instalacija
Da bi sistem funkcionisao potrebno je konfigurisati Arduino i osciloskop. Zatim, ukoliko je cilj pokretanje gotovog programa, potrebno je downloadovati i instalirati objavljeni paket. Ukoliko je namera da se program modifikuje, potrebno je klonirati ovaj repozitorijum pomoću Microsoft Visual Studio.
### Konfigurisanje Arduina
1. Preuzeti [Arduino IDE](https://www.arduino.cc/en/software) i instalirati prateći instrukcije. IDE se automatski konfiguriše pri prvom pokretanju.
2. Otvoriti datoteku [StepperThreeSpeeds.ino](/StepperThreeSpeeds.ino) i kopirati kod: </br>
<a href="url"><img src="https://user-images.githubusercontent.com/23122428/233811480-86d80ab1-3338-4750-9acb-63796ce536fe.png" align="center" height="49%" width="49%" ></a>
3. Pokrenuti Arduino IDE i nalepiti kopirani kod. Sačuvati putem "File -> Save As..." u proizvoljni direktorijum.
4. Prateći instrukcije na [ovom linku](https://support.arduino.cc/hc/en-us/articles/4733418441116-Upload-a-sketch-in-Arduino-IDE) instalirati program na prethodno povezani Arduino Nano.
### Instalacija programa za komunikaciju sa osciloskopom
Ovaj korak može biti potreban ukoliko se za snimanje koristi Tektronix TDS 2024C osciloskop, a aplikacija ga sama ne prepoznaje. U slučaju korišćenja drugih akvizicionih sistema neophodno je izvršiti modifikacije programa koristeći komunikacione biblioteke za C# koje objavljuje proizvođač.
1. Preuzeti [TekVISA](https://www.tek.com/en/support/software/driver/tekvisa-connectivity-software-v411) i instalirati prateći instrukcije. 
2. Ukoliko je kompatibilni Tektronix osciloskop povezan, TekVISA bi trebalo da ga automatski prepozna i poveže. Dodatne informacije u slučaju problema u komunikaciji sa osciloskopom mogu se pronaći na [ovom linku](https://www.tek.com/en/support/faqs/what-tekvisa-and-how-can-i-use-it-communicate-and-control-my-instrument) kao i na drugim izvorima na internetu.
### Instalacija objavljene verzije programa
Instalacioni fajl za verziju aplikacije dostupnu u ovom repozitorijumu moguće je preuzeti sa [ovog linka](https://1drv.ms/u/s!AtP4IU2wTrMwhr1sIizN3ZoCZAraBQ?e=TIAKjO). Preuzeta datoteka će pri pokretanju instalirati program i kreirati poveznicu na radnoj površini. Za deinstalaciju programa koristiti opciju "Add or remove programs" u Control Panel-u. Pokretanjem poveznice "SnimanjeVUV" na radnoj površini otvara se aplikacija.
### Kloniranje repozitorijuma radi modifikovanja izvornog koda
Prateći instrukcije u ovom odeljku moguće je klonirati repozitorijum za potrebe modifikacije.
1. Preuzeti [Microsoft Visual Studio](https://visualstudio.microsoft.com/) i pokrenuti instalaciju.
2. Kada se pojavi sledeći meni, odabrati opciju ".NET desktop development":</br>
<a href="url"><img src="https://user-images.githubusercontent.com/23122428/233812046-9f5650a9-db08-4ba9-8cd1-8104d324d58a.png" height="60%" width="60%" ></a>
3. Pri prvom pokretanju pojaviće se meni nalik sledećem; odabrati opciju "Clone a repository":</br>
<a href="url"><img src="https://user-images.githubusercontent.com/23122428/233812074-3811978c-bb5d-4e95-8390-8cd4f6948546.png" height="60%" width="60%" ></a>
4. Uneti link "https://github.com/veliki-filozof/SnimanjeVUV" u polje "Repository location" i odabrati putanju za lokalno čuvanje na računaru.
5. Klikom na "Clone" Visual Studio automatski duplira podatke sa repozitorijuma i otvara ih u novoj instanci. Pregled datoteka dostupan je u polju "Solution Explorer" sa desne strane prozora.

## Upotreba
### Glavni meni
Pri pokretanju programa otvara se glavni meni:</br>
<a href="url"><img src="https://user-images.githubusercontent.com/23122428/233812923-4e25f315-c683-4457-b0fc-809cf56c594d.png" height="40%" width="40%" ></a>
1. Klikom na dugme "Osveži potrove" program pretražuje otvorene COM serijske portove i upisuje ih u padajuću listu. Odaberite COM port koji odgovara Arduinu i kliknite "Konektuj se".
2. Pre početka snimanja neophodno je izvršiti pomeranje rešetke na početni položaj. Za pristup ovoj funkciji kliknite na dugme "Podešavanje položaja".
3. Po završetku rada procedure za podešavanje položaja program se vraća u glavni meni. Odaberite tip izvora koji je u upotrebi i pritisnite dugme "Snimanje" da bi ste pristupili proceduri za snimanje spektra. </br>

*NAPOMENA: U trenutnoj verziji programa implementirana je isključivo procedura za kontinualno snimanje. Nezavisno od odabira tipa u glavnom meniju klik na "Snimanje" vodi u ovu proceduru. Da bi program vršio snimanje impulsnih izvora potrebno ga je modifikovati (vidi: "Smernice za modifikovanje").*

## Smernice za modifikovanje

