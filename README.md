# PI20-015 Alca transport 
mentor: Zlatko Stapić 

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Silvio Mihalic | smihalic@foi.hr | 0016131292 | silvio931
Sandro Mrvčić | smrvcic@foi.hr | 0016131635 | msandro9
Domagoj Mahnet | dmahnet@foi.hr | 0016134621 | domagojmahnet

## Opis domene
Naša aplikacija koristit će se u transportnom poduzeću koje dostavlja robu od dobavljača do kupaca. U poduzeću postoji problem što ne postoji nikakav programski sustav koji spaja vozače i disponente koji slažu rute za vozače. Disponent svaku večer zove vozače na mobilne telefone jednog po jednog te im javlja rutu koju voze sljedeći dan. Pozivi se obavljaju obično navečer, a vozači kreću tu istu noć te se tu javlja problem umora i iscrpljenosti vozača. Također na kraju svakog radnog dana svaki vozač mora osobno doći u firmu te napisati zapisnike za svoje dostave ukoliko se pojavila pogreška kod dostave ili otpremnica. Naš cilj je taj dio automatizirati gdje bi napravili aplikaciju u koju se mogu prijaviti disponenti koji bi tada slagali rute za određene vozače, otpremnice, pridruživali vozila itd. S druge strane prijavljivali bi se sami vozači koji bi unaprijed već znali gdje sljedeći dan ili za 2 dana putuju kako bi sve mogli unaprijed isplanirati. Vozači bi u aplikaciji mogli vidjeti svoje prošle, trenutne i buduće rute, otpremnice, vozila, obavljati zapisnike umjesto odlaska u firmu što bi uvelike olakšalo posao i skratilo vrijeme.

## Specifikacija projekta
Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Registracija korisnika | Administrator u bazu podataka unosi zaposlenike koji će imati pristup aplikaciji, dodjeljuje im uloge (disponent ili vozač) | Sandro Mrvčić
F02 | Prijava korisnika  | Korisnik se prijavljuje kao disponent, vozač ili administrator. Na temelju uloge dobiva pristup različitim dijelovima aplikacije i različitim funkcionalnostima| Sandro Mrvčić
F03 | Unos, ažuriranje i brisanje podataka | Administrator ima mogućnost unosa novih zaposlenika, vozila, skladišta | Silvio Mihalic
F04 | Kreiranje i pregled ruta | Disponent slaže rute, unosi i pridružuje otpremnice, vozila, vozače, vremena i mjesta polazišta i odredišta i zatim rute šalje odgovarajućim vozačima, može vidjeti rute koje je kreirao  | Domagoj Mahnet
F05 | Pregled ruta | Vozač čita svoje prošle, trenutne i buduće rute, očekivana vremena dolaska, otpremnice, vozila | Domagoj Mahnet
F06 | Kreiranje zapisnika | Vozač kreira zapisnike o otpremnicama ukoliko je potrebno te ih šalje svojim disponentima | Silvio Mihalic
F07 | Zapisnici | Disponenti mogu pristupiti i čitati sve zapisnike koje je vozač sastavio na temelju kojih kasnije provode radnje poput ponovnog slaganja otpremnica | Silvio Mihalic
F08 | Statistika | Keriranje raznih grafova o poslovanju, vozači bi vidjeli vlastitu statistiku npr. broj odvoženih ruta, broj kilometara za vozače, a disponenti statistiku na temelju poduzeća, generiranje PDF izvješća, ispis na pisač | Domagoj Mahnet
F09 | Profil | Vozači i disponenti mogu vidjeti svoj profil, uređivati ga | Sandro Mrvčić
F10 | E-mail podsjetnik | Automatski e-mail podsjetnik na kraju dana za disponente ili vozače koji nisu obavili svoje obveze, implementiran kao pozadinski servis | Silvio Mihalic
F11 | Kreiranje tvrtke i dodjela administratora | Prilikom prodaje aplikacije tvrtka se unosi u bazu podataka i kreira se račun administratora za tu tvrtku | Sandro Mrvčić




## Tehnologije i oprema
Alati za razvoj aplikacije:

Visual studio - alat za razvoj aplikacija

Visual Paradigm - alat za izradu različitih dijagrama

MySQL Workbench - alat za izgradu ERA modela i baze podataka

Microsoft Project - alat za izradu gantograma, projektnog plana

Kod implementacije aplikacija bi se instalirala na računala disponenata, te bi ih vozači instalirali na svoja računala kod kuće, a kasnije nakon izrade i na pametne telefone.
