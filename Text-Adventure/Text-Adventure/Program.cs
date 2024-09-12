//--------------------------------------Introductie--------------------------------------

//hier begint met een welkomstbericht

static void ToonIntroductie()
{
    Console.WriteLine("Welkom bij dit Harry Potter tekstavontuur!");
    Console.WriteLine();
    Console.WriteLine("Beleef een magisch avontuur in de wereld van Harry Potter.");
    Console.WriteLine("Maak keuzes die jouw verhaal bepalen.");
    Console.WriteLine("Ervaar een jaar op Zweinstein.");
    Console.WriteLine();
    Console.WriteLine("En voorkom dat voldemort de steen der wijzen te pakken krijgt");
    Console.WriteLine("Veel plezier!");
    Console.WriteLine();
    Console.WriteLine("Druk op Enter om te beginnen.");
    Console.ReadLine();
    Console.Clear();
}

static void ToonUitleg()
{
    //hier komt de uitleg van het spel
    Console.WriteLine("Dit is een tekstavontuur. Je leest een verhaal en maakt keuzes.");
    Console.WriteLine("De keuzes die je maakt bepalen het verloop van het verhaal.");
    Console.WriteLine("Soms moet je een getal of een tekst invoeren.");
    Console.WriteLine("Kies wijs en beleef een magisch avontuur!");
}

//hier komt een keuze menu

static void ToonKeuzeMenu()
{
    Console.WriteLine("Kies een optie:");
    Console.WriteLine("1. Start het avontuur");
    Console.WriteLine("2. Uitleg van het spel");
    Console.WriteLine("3. Stoppen");
}

//hier komt het keuze menu

ToonKeuzeMenu();

//hier komt de keuze van de speler

string keuze = Console.ReadLine();

//hier komt een if statement voor de keuze van de speler

if (keuze == "1")
{
    ToonIntroductie();
}
else if (keuze == "2")
{
    ToonUitleg();
}
else if (keuze == "3")
{
    Console.WriteLine("Bedankt voor het spelen. Tot ziens!");
    return;
}
else
{
    Console.WriteLine("Ongeldige keuze. Probeer het opnieuw.");
}






//--------------------------------Begin van het verhaal--------------------------------
//Hier komt de introductie van het verhaal en welke naam je wilt hebben
//--------------------------------------Naam--------------------------------------
// Vraag de speler om zijn/haar naam en sla deze op

Console.WriteLine("Voordat we beginnen hebben we je naar nodig!");
Console.WriteLine();
Console.Write("Wat is jouw naam, tovenaar/heks? ");
string spelersNaam = Console.ReadLine();

// Toon een persoonlijk welkomsbericht
Console.WriteLine($"Welkom, {spelersNaam}! Bereid je voor op een magisch avontuur.");
Console.ReadLine();
Console.Clear();

//--------------------------------------Start verhaal-------------------------------------
//Eenmaal je naam ingevuld begint het verhaal bij de brief van Hogwarts

//--------------------------------------In het huis--------------------------------------
Console.WriteLine("Het is een normale dag en je zit in de woonkamer van je huis.");
Console.WriteLine("Je zit op de bank en je kijkt tv.");
Console.WriteLine("");
Console.WriteLine("In eens hoor je een raar geluid vanuit buiten en je ziet een uil weg vliegen vanaf je brievenbus. ");
Console.WriteLine("");
Console.WriteLine("Je zit te denken ga je ga je buiten kijken of niet.");
Console.WriteLine("Typ 1 om te gaan kijken en 2 om niks te doen");
string letterChoice = Console.ReadLine();

if (letterChoice == "1")
{
    BuitenKijken();
}
else if (letterChoice == "2")
{
    NiksDoen();
}
else
{
    Console.WriteLine("Ongeldige keuze spel sluit nu af.");

}

static void BuitenKijken()
{
    Console.WriteLine("Je loopt naar buiten en ziet de uil nog op een hek zitten en naar je staren.");
    Console.WriteLine("En dan ga je naar de brievenbus toe opent hem.");
    Console.WriteLine("Je ziet een brief er in liggen en pakt hem. Je ziet staan **Hogwarts the school for witches and wizards**  ");
    Console.WriteLine("Je loopt weer naar binnen om aan je ouders te laten zien.");
    
}

static void NiksDoen()
{
    Console.WriteLine("Je blijft lekker op de bank tv zitten kijken");
    Console.WriteLine("Na een paar uur zie je weer een uil wegvliegen en je denk er nogsteeds niks van.");
    Console.WriteLine("Je gaat weer verder met tv kijken.");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("**Paar uur verder**");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Je zit lekker aan het avondeten en een van je ouders zegt 'Waarom zitten er zoveel uilen bij ons in de tuin?'");
    Console.WriteLine("Je kijkt wat beter naar de uilen en ziet dat ze een envelop in hun bek hebben zitten.");
    Console.WriteLine("Je staat op en loopt naar buiten om en envelop te pakken.");
    Console.WriteLine("Je opent de envelop en ziet staan **Hogwarts the school for witches and wizards**");
    Console.WriteLine("Je loopt weer naar binnen toe om het aan je ouders te laten zien");
}

Console.ReadKey();
Console.Clear();

//--------------------------------------Brief--------------------------------------
//Na het openen van de brief vertelt het dat je bent aangenomen op Hogwarts en dat je een tovenaar bent.


Console.WriteLine("Je ouders zijn verbaasd en zeggen dat je een heks/tovenaar bent.");
Console.WriteLine("Ze vertellen je dat ze ook op Hogwarts hebben gezeten.");
Console.WriteLine("");
Console.WriteLine("Je opent de brief samen met je ouders");
Console.WriteLine("De brief vertelt dat je bent aangenomen op Hogwarts en dat je een tovenaar bent.");
Console.WriteLine("Je ziet in de brief dat er een lijstje staan met spullen die je moet hebben in Diagon Alley.");
Console.ReadKey();
Console.Clear();

//--------------------------------------Diagon Alley--------------------------------------
//Na het lezen van de brief vertelt het dat je naar Diagon Alley moet om je spullen te halen.

Console.WriteLine("Je gaat samen met je ouders richting Diagon Alley in London.");
Console.WriteLine("Eerst moet je een door een pub lopen de Leakey Cauldron.");
Console.WriteLine("Je ouders vertellen je dat je door de muur moet lopen om bij Diagon Alley te komen.");
Console.WriteLine("Je loopt naar de muur en je ouders zeggen dat je moet rennen.");
Console.WriteLine("Je rent en je komt door de muur heen en je ziet Diagon Alley.");
Console.WriteLine();
Console.WriteLine("Je gaat het lijstje af om te kijken van wat je allemaal nodig hebt");
Console.WriteLine("Op een gegeven moment kom je hagrid tegen en zie je een pakketje in zijn handen");
Console.WriteLine("Je vraagt er naar en hij zegt dat hij een pakketje heeft opgehaald bij de bank voor hogwarts");
Console.WriteLine();
Console.WriteLine("Je hebt alles gehaald en je gaat weer terug naar huis.");
Console.ReadKey();
Console.Clear();

//--------------------------------------Terug naar huis--------------------------------------

Console.WriteLine("Je maakt je koffer klaar om over een paar dagen richting kings cross te gaan om met de hogwarts express te gaan.");
Console.ReadKey();
Console.Clear();

//--------------------------------------Kings Cross--------------------------------------
//Na het pakken van je spullen ga je naar Kings Cross om de trein te pakken naar Hogwarts.

Console.WriteLine("Eenmaal aangekomen weet je nog niet echt waar je naar toe moet je loopt naar perron 9 en 10 maar er is helemaal geen 9 3/4.");
Console.WriteLine("Je ziet een gezin lopen en je vraagt aan hun waar perron 9 3/4 is.");
Console.WriteLine("Ze vertellen je dat je door de muur moet lopen.");
Console.WriteLine("Je loopt naar de muur en je rent er doorheen en je ziet perron 9 3/4.");
Console.WriteLine("Daar staat een stoomlocometief klaar");
Console.ReadKey();
Console.Clear();
//--------------------------------------In de trein--------------------------------------
Console.WriteLine("Je stapt in en je gaat opzoek naar een plekje.");
Console.WriteLine("Je vind een plekje en je gaat zitten.");
Console.WriteLine("De trein vertrekt en je ziet dat je een paar uur onderweg bent.");
Console.WriteLine("Je ziet dat er een trolley met eten en drinken langs komt.");
Console.WriteLine("Je koopt wat eten en drinken en je gaat weer zitten.");
Console.WriteLine("Je ziet dat er een jongen naar je toe komt lopen en vraagt of je alleen zit.");
Console.WriteLine("Je zegt ja en hij komt bij je zitten.");
Console.WriteLine("Hij stelt zich voor als Rowan Beagsby.");
Console.WriteLine("Jullie raken aan de praat en jullie worden vrienden.");
Console.WriteLine("Jullie praten over van alles en nog wat.");
Console.ReadKey();
Console.Clear();
//--------------------------------------Aankomst op Hogwarts--------------------------------------
Console.WriteLine("Na een paar uur kom je aan op Hogwarts.");
Console.WriteLine("Jullie komen aan op het station van hogsmeade het dorpje wat naast hogwarts ligt ");
Console.WriteLine("Daar zie je een schaduw van een grote man genaamd Hagrid");
Console.WriteLine("Samen met hem stappen jullie op de bootjes om richting hogwarts te gaan");
Console.WriteLine("Jullie komen aan bij het kasteel en jullie gaan naar binnen.");
Console.WriteLine("Daar ontmoet Proffesor McGonnigal iedereen en begeleid iedereen naar de 'great hall' ");
Console.WriteLine("Daar zie je de sorteerhoed liggen en iedereen gaat staan in een rij.");
Console.WriteLine("McGonnigal Roept iedereen een voor een op om te laten sorteren");
Console.WriteLine("Jij bent aan de beurt en je gaat zitten op de kruk en de sorteerhoed wordt op je hoofd gezet.");
Console.ReadKey();
Console.Clear();
//--------------------------------------Sorteren--------------------------------------
//Hier wordt je gesorteerd in een van de vier huizen van Hogwarts

Console.WriteLine("Je hoort de sorteerhoed denken over je kwaliteiten");
//Hier mag je kiezen in welk huis je wilt komen
Console.WriteLine("In welk huis wil je komen?");
Console.WriteLine("Typ 1 voor Gryffindor");
Console.WriteLine("Typ 2 voor Hufflepuff");
Console.WriteLine("Typ 3 voor Ravenclaw");
Console.WriteLine("Typ 4 voor Slytherin");
string houseChoice = Console.ReadLine();

if (houseChoice == "1")
{
    Gryffindor();
}
else if (houseChoice == "2")
{
    Hufflepuff();
}
else if (houseChoice == "3")
{
    Ravenclaw();
}
else if (houseChoice == "4")
{
    Slytherin();
}
else
{
    Console.WriteLine("Ongeldige keuze spel sluit nu af.");
}

static void Gryffindor()
{
    Console.WriteLine("De sorteerhoed roept uit dat je in Gryffindor zit!");
    Console.WriteLine("Je gaat naar de tafel van Gryffindor en je ziet dat Rowan ook in Gryffindor zit.");
    Console.WriteLine("Jullie gaan samen zitten en jullie eten wat.");
    Console.WriteLine("Na het eten gaan jullie naar de common room van Gryffindor.");
    Console.WriteLine("Daar ontmoet je de rest van je huisgenoten en jullie praten wat.");
    Console.WriteLine("Jullie gaan naar bed en de volgende dag begint het echte school leven.");
}

static void Hufflepuff()
{
    Console.WriteLine("De sorteerhoed roept uit dat je in Hufflepuff zit!");
    Console.WriteLine("Je gaat naar de tafel van Hufflepuff en je ziet dat Rowan ook in Hufflepuff zit.");
    Console.WriteLine("Jullie gaan samen zitten en jullie eten wat.");
    Console.WriteLine("Na het eten gaan jullie naar de common room van Hufflepuff.");
    Console.WriteLine("Daar ontmoet je de rest van je huisgenoten en jullie praten wat.");
    Console.WriteLine("Jullie gaan naar bed en de volgende dag begint het echte school leven.");
}

static void Ravenclaw()
{
    Console.WriteLine("De sorteerhoed roept uit dat je in Ravenclaw zit!");
    Console.WriteLine("Je gaat naar de tafel van Ravenclaw en je ziet dat Rowan ook in Ravenclaw zit.");
    Console.WriteLine("Jullie gaan samen zitten en jullie eten wat.");
    Console.WriteLine("Na het eten gaan jullie naar de common room van Ravenclaw.");
    Console.WriteLine("Daar ontmoet je de rest van je huisgenoten en jullie praten wat.");
    Console.WriteLine("Jullie gaan naar bed en de volgende dag begint het echte school leven.");
}

static void Slytherin()
{
    Console.WriteLine("De sorteerhoed roept uit dat je in Slytherin zit!");
    Console.WriteLine("Je gaat naar de tafel van Slytherin en je ziet dat Rowan ook in Slytherin zit.");
    Console.WriteLine("Jullie gaan samen zitten en jullie eten wat.");
    Console.WriteLine("Na het eten gaan jullie naar de common room van Slytherin.");
    Console.WriteLine("Daar ontmoet je de rest van je huisgenoten en jullie praten wat.");
    Console.WriteLine("Jullie gaan naar bed en de volgende dag begint het echte school leven.");
}

Console.ReadKey();
Console.Clear();

//--------------------------------------Eerste schooldag--------------------------------------
//Na het feest in de great hall begint de eerste schooldag
//En er gebeurt van alles en nog wat

Console.WriteLine(houseChoice + "Je wordt wakker en je gaat naar de common room.");
Console.WriteLine("Daar zie je Rowan en jullie gaan samen naar het ontbijt.");
Console.WriteLine(houseChoice + "Na het ontbijt gaan jullie naar jullie eerste les.");
Console.WriteLine("Na een hele dag school ga je lekker naar het avondmaal toe");
Console.WriteLine("Ineeneens komt er een leraar naar binnen gerent en roept troll in de kelder!!!");
Console.WriteLine("Iedereen schrikt en de leraar vertelt dat iedereen naar zijn of haar common room moet gaan.");
Console.WriteLine("Jullie wisten dat er iemand naar het toilet was gegaan en gaan die persoon redden");
Console.WriteLine("Jullie gaan naar de kelder en jullie zien de troll.");
Console.WriteLine("Jullie weten hem te verslaan en jullie worden beloond met punten voor jullie huis.");

Console.ReadKey();
Console.Clear();

//--------------------------------------midden van het verhaal--------------------------------------
//Na het verslaan van de troll gebeurt er van alles en nog wat
// je besluit om op onderzoek te gaan wat er in de verboden verdieping zit en je komt een drie kopige hond tegen
// en ziet dat er een luik onder zit

Console.WriteLine("Op een gegeven moment wil je wat van het kasteel gaan ontdekken en besluit om naar de verboden 3rde verdieping te gaan");
Console.WriteLine("Je ziet opeens de kat van de congierge er aan komen en je verstopt je achter een deur");
Console.WriteLine("Het is donker daar dus je maakt een licht en ziet opeens een drie koppige hond!");
Console.WriteLine("Je schrikt en je rent weg en je ziet een luik onder de hond");
Console.WriteLine("Uiteindelijk kom je weer terug in je common room en ziet rowan en verteld wat je hebt gezien");

Console.ReadKey();
Console.Clear();
// na een paar dagen hoor je dat mensen probeerde in te breken in de bank en je herinnerde dat hagrid daar wat had opgehaald en gaat er na vragen

Console.WriteLine("");








