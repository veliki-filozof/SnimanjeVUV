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

**NAPOMENA:** *U trenutnoj verziji programa implementirana je isključivo procedura za kontinualno snimanje. Nezavisno od odabira tipa u glavnom meniju klik na "Snimanje" vodi u ovu proceduru. Da bi program vršio snimanje impulsnih izvora potrebno ga je modifikovati (vidi: "Smernice za modifikovanje").*
### Pomeranje rešetke
<a href="url"><img src="https://user-images.githubusercontent.com/23122428/233867320-0f23882a-21da-436c-99dd-30fd26de9bb2.png" height="50%" width="50%" ></a>
1. Odabrati rešetku koja je ugrađena. U padajućoj listi odabrati broj stepova na koje je podeljen jedan obrtaj motora; manji brojevi omogućavaju brže skeniranje, ali manju preciznost u konačnom položaju. Pritisnuti dugme "Zapamti podešavanje".
2. Ukoliko želite da izvršite izmenu sačuvanog podešavanja (na primer da promenite brzinu obrtanja), pritisnite na dugme "Promeni podešavanje" i ponovite prethodni postupak.
3. Unesite početni položaj rešetke očitan sa skale spektrometra i talasnu dužinu na koju želite da podesite rešetku. Pritiskom na dugme "Proračunaj" aplikacija će proračunati trenutnu talasnu dužinu na koju je podešena rešetka, kao i poziciju na skali koja odgovara traženoj talasnoj dužini.
4. Odaberite jednu od tri brzine skeniranja. Nasuprot padajućoj listi iz prve tačke, ova brzina predstavlja frekvenciju kojom Arduino šalje impulse motoru; veličina koraka je jednaka za sve tri brzine.
5. Klikom na dugme "Pokreni motor" aplikacija šalje komande Arduinu da napravi odgovarajući broj koraka željene dužine željenom brzinom. Aplikacija je blokirana dok je rešetka u pokretu, i biće osposobljena kada Arduino odgovori da je pomeranje završeno.
6. Nakon završenog podešavanja položaja, u glavni meni možete se vratiti zatvaranjem prozora "Podešavanje položaja". </br>

**Napomene:**
- U trenutnoj implementaciji kalibracija je dostupna isključivo za rešetku 50 - 300 nm. Aplikacija će da izbaci grešku ukoliko je odabrana bilo koja druga rešetka.
- Aplikacija softverski neće dozvoliti unos krajnje talasne dužine koja odgovara položaju van opsega 100 - 3500 na skali, kako bi zaštitila osovinu od iskliznuća. Međutim, aplikacija ne može da verifikuje da li je unet ispravan početni položaj, pa je stoga potrebno obratiti posebnu pažnju na ovaj podatak kako ne bi došlo do oštećenja aparature.
- Pri promeni smera pokretanja rešetka ima opseg "mrtvog hoda" koji je neophodno kompenzovati. Na primer: ukoliko se planira snimanje sa talasne dužine A do talasne dužine B (A<B), preporučljivo je prvobitno podesiti rešetku do talasne dužine A' (A'<A), pa je vratiti na A onom brzinom i brojem koraka po obrtaju kojom je planirano snimanje; često je podešavanje sa A' na A potrebno uraditi nekoliko puta, svaki put očitavajući i upisujući u odgovarajuće polje tačan položaj rešetke. Za više detalja o ovome, ručnom pripremanju kuplunga i drugom konsultovati master rad.
### Snimanje - kontinualno
Kao što je napomenuto u odeljku "Glavni meni", trenutna implementacija aplikacije podržava isključivo snimanje kontinualnih pražnjenja. Klik na dugme "Snimanje" u glavnom meniju rezultuje otvaranjem sledećeg prozora: </br>
<a href="url"><img src="https://user-images.githubusercontent.com/23122428/233868029-b5f00bab-b1c0-46c6-8bc2-0c60ef808251.png" height="70%" width="70%" ></a>
1. **Program neće raditi ukoliko se ne poveže sa osciloskopom, te je stoga preporučljivo najpre ovo obezbediti.** Klikom na dugme "Osveži portove" omogućavaju se odgovarajuće padajuće liste. Izabrati port putem kojeg je povezan osciloskop i broj kanala na kome se nalazi snimani signal, a zatim pritisnuti "Konektuj se".
2. Ugrađenu rešetku i željeni broj stepova po obrtaju odabrati po postupku opisanom u odeljku "Pomeranje rešetke". Pritisnuti dugme "Zapamti podešavanje".
3. Uneti trenutni *položaj* rešetke očitan sa skale spektrometra i krajnju talasnu dužinu opsega snimka. Uneti "Ekvidistantni korak" u nm koji predstavlja rastojanje u spektru između dvaju susednih tačaka na snimku (vidi napomene za smernice). Odabrati brzinu skeniranja kao u odeljku "Pomeranje rešetke".
4. Klikom na dugme "Nađi..." otvara se meni za biranje putanje ka direktorijumu za čuvanje izlaznih podataka. Pronaći i odabrati željeni direktorijum.
5. Kliknuti na dugme "Proračunaj" i verifikovati ispravno unete podatke o snimanom spektru.
6. Kliknuti na dugme "Spremi". Ovim se pamte svi parametri snimanja i program kreira i otvara datoteke u kojima će biti sačuvani rezultati. Omogućava se dugme "POKRENI MERENJE".
7. Klikom na dugme "POKRENI MERENJE" aplikacija započinje automatsko skeniranje. Aplikacija će periodično ispisivati svoj status. Ukoliko nastane greška u komunikaciji, aplikacija će obavestiti korisnika i ispisati postignuti rezultat.
8. U glavni meni moguće je vratiti se gašenjem ovog prozora.

**Napomene:**
- Funkcije "NASTAVI MERENJE" i "ZAUSTAVI MERENJE" nisu omogućene u trenutnoj implementaciji. Njihova idejna svrha je da olakšaju proceduru nastavka snimanja prekinutog usled grešaka u komunikaciji sa perifernim uređajima uzrokovanim najčešće elektromagnetnim smetnjama. Nisu neophodne za redovan rad programa ukoliko ove smetnje nisu česte, a za njihovo implementiranje neophodno je uvesti multi-threading (paralelno procesuiranje) u program.
- Postoji mogućnost da bez paralelnog procesuiranja prozor "Status:" ne bude pravilno osvežavan u toku snimanja. Ovo nije znak greške, već nusproizvod implementacije u jednoj procesorskoj niti.
- Preporučuje se snimanje sa što je praktično moguće većim brojem stepova po obrtaju i manjom brzinom skeniranja. Ukoliko je brzina prevelika i broj stepova po obrtaju mali, zbog nesavršenosti aparature pri svakom pomeranju stvoriće se mala greška u položaju. U slučaju velikog broja snimanih tačaka ovo može rezultovati značajnom greškom u kasnije snimanim tačkama. *Kada god ukupno vreme snimanja to dozvoljava, preporučuje se sporije skeniranje.*
- Veličina "Ekvidistantni korak" treba da bude proračunata kao opseg snimljenog spektra u nm podeljen sa brojem tačaka koje je potrebno snimiti; obrnuto je srazmerna rezoluciji snimka.
- Snimak se čuva u zadatom direktorijumu u fajlu "Rezultat.csv". Prva kolona odgovara talasnoj dužini u nm, a druga snimljenom intenzitetu na tom položaju.
- Za informacije o ručnom podešavanju osciloskopa koje je neophodno izvršiti pre početka snimanja, kao i o detaljima algoritma za snimanje, konsultovati master rad.

## Smernice za modifikovanje

