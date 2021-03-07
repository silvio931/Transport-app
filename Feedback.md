## UVID U PROJEKT

## Projektna dokumentacija
* Metodika razvoja: Vodopadni model 
* Projektni plan: Usklađen s modelom razvoja. Gant je teško povezati sa aktivnostima (s lijeve strane ganta bi trebao biti popis aktivnosti).
* Izračun troškova -> Kako su nastale cijene koštanja? Uzeli ste u obzir samo cijene rada? Trebalo bi ukalkulirati i ostale troškove (od hladnog pogona, amortizacije) i dobit.
* Ponuda naručitelju -> Jako lijepo.
* Praćenje provedbe -> Nije uključeno.

## Tehnička dokumentacija
* Pohvalno je što ste tražili i pokušali primijeniti predloške / primjere dobre prakse u raspisu dokumentacije. Pri korištenju predložaka treba biti oprezan, jer ako poglavlja i teme koje se navode a nisu važne za vaš projekt možete ih izostaviti ili grupirati. Time bi se izbjegla rascjepkanost dokumenta u mnošvo poglavlja od po jednu-dvije rečenice. Isto tako postoje poglavlja koja se po svojoj prirodi mogu spojiti.
* SRS: poglavlje 2.2.2. nije dovoljno detaljno. Slobodno prekopirajte tablicu iz prijave, te da se kroz cijeli dokument vodite oznakama funkcionalnosti, od F00 na dalje. Naravno, osim funkcionalnih zahtjeva iz prijave, definirajte i nefunkcionalne zahtjeve ako postoje.
* SDS: Poglavlje 2.4. pretvoriti u poglavlje 3.
* Nemojte poglavlja imenovati po dijagramima. Npr. poglavlje 2.4.1. bi se moglo zvati "Tipični slučajevi korištenja aplikacije" ukoliko takvo poglavlje želite imati. Dokumentaciju ne pišemo zbog dijagrama, već dijagrame koristimo zbog pojednostavljenja i formalizacije dokumentacije.
* Modele klasa i podataka također stavite u raspis svake pojedine funkcionalnosti.
dokument nije dovršen. U konačnici ne prikazuje funkcionalne i nefunkcionalne zahtjeve. 
* UC: Sintaksički ispravni. 
* AD: Na dosta čvorova odluke nije definiran uvjet grananja...
* SD: Provjerite stereotipe objekata. Dijagram bi najčešće trebao imati samo jedan objekt stereotipa "Sustav", kod vas to nije tako.
* CD: Može ostati cijeli dijagram kao prilog dokumentaciji, ali važnije je podijeliti ga na više specifičnih dijagrama kako je navedeno u komentaru o restrukturiranju.
* Semantiku i usklađenost svih dijagama s kodom ćemo provjeravati na obrani.
* U dokumentaciju dodati poglavlje s uputama za podešavanje razvojne i produkcijske okoline te s podacima o testiranju programa (npr. korisnička imena i lozinke).


## Implementacija
* Pogledana trenutna verzija aplikacije.
* Objektno orijentirano programiranje -> Ok.
* Struktura projekta -> Predlažem klase grupirati u više područja imena (to su mape u rješenju). Pazite samo da nakon premještanja klase u novi namespace u klasi namespace i promijenite ali obvezno pomoću automatskog renaminga kako se ne bi potrgale reference na klasu.
* Vaše korisničko sučelje je dizajnirano. Ne znam jeste li razmišljali o korištenju cijelog zaslona u dizajnu vaših formi. Pomoću sidra (anchor) možete podesiti da aplikacija iskorištava cijeli dostupni prostor. Isto tako, jeste li razmišljali o korištenju MDI pristupa. Jednu formu proglasite MDI formom, a ostale proglasite MDI djecom. To vam u mnogočemu olakšava.
* Implementirane funkcionalnosti - Prihvatljiva razina.
* Verzioniranje - Vidim da imate granu "Dokumentacija", ali ste dokumentaciju pohranjivali i kroz master granu. Također, koristite Development granu u koju ćete spajati svaku funkcionalnost kada je gotova. Nakon što se integracija (na development grani) istestira i nakon što je sve u redu, tek onda se kod spaja na master (produkcijsku granu). Vezano za workflow razvoja (ne vezano za dokumentaciju) pokušajte primijeniti feature-branch workflow koji je opisan ovdje: https://www.atlassian.com/git/tutorials/comparing-workflows/feature-branch-workflow. Više pozornosti usmjerite na pripremu dokumenata za verziju (staging) i na kvalitetne komentare pri slanju verzija. U rješenju nedostaju neki dokumenti (slike), pa je možda problem kod verzioniranja.
* .gitignore: ok.


## Ostalo
* U dokumentaciji bi bilo dobro složiti da se klikom na sliku ista slika otvori u full screen prikazu.
* Pazite na minimalne zahtjeve za programske proizvode prije nego što pristupite obrani (npr. izdvajanje jednog dijela projekta u dll, kontekstualna pomoć i drugo navedeno na Moodleu).

## Bodovi
P1: 13 bodova

---
---

## Opća povratna informacija
Projektna prijava se prihvaća uz elemente dopune koje navodim u nastavku. Projektna ideja je u skladu sa zahtjevima kolegija. Implementacijom konačnog seta funkcionalnosti (nadopunjeno) studenti će moći postići sve ishode učenja na kolegiju. Molim da temeljem ovih informacija sami dopunite vašu projektnu prijavu.

## Arhitektura u odnosu na bazu podataka
Također molim da arhitektura sustava bude temeljena na centraliziranoj bazi podataka na koju će se spajati jedna ili više aplikacija istovremeno.

## Zahtijevane dopune
1. Omogućiti prodaju ove aplikacije različitim tvrtkama. Svakoj tvrtci se pri prodaju kreira jedan master admin račun koji onda dalje upravlja tom tvrtkom kako je sada prijavljeno.
2. U izvješćima uključiti tablične i grafičke prikaze, te omogućiti pohranu izvješća u PDF te ispis na pisač.
3. Omogućiti automatski e-mail podsjetnik na kraju dana za disponente ili vozače koji nisu obavili svoje obveze (npr. popunili izvješće). Ovu aplikaciju implementirati kao pozadinski windows servis koji administrator može upaliti ili ugasiti na trenutnom računalu.

Svaku od navedenih funkcionalnosti neka preuzme po jedan član tima, uz mogućnost da drugu stavku podijelite na dvije kako bi balansirali opterećenje članova tima (ako je to potrebno). Inače tu stavku neka preuzme onaj član tima koji trenutno ima najmanje opterećenje.
