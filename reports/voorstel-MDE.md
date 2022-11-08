# Project voorstel - MDE

## Applicatie naam 
MyWatchlist

## Project info 
Als een grote film/serie/anime liefhebber kijk ik enorm veel en hou ik ervan bij te houden wat ik wil kijken, ooit wil zien, of al heb gezien. Daarom dacht ik om een applicatie te maken die dit voor mij bijhoud.

MyWatchlist is een applicatie waar je als gebruiker een account kan aanmaken en je eigen lijst kan bijhouden. Je kan er nieuwe films, tv series en anime series toevoegen. Voor elk van deze kan je verschillende details bijhouden zoals 
* Release year
* Name of the director
* A short description
* ...

Je kan deze volgende statussen geven

* Plan to watch
* Watching
* Completed

Je kan er makkelijk op je lijst filteren op 
* Type
* Status

Bij series zie je ook heel duidelijk hoeveel episodes je al hebt gezien.


Een klein voorbeeldje :

*De gebruiker emeuleni ontdekte zojuist de serie "Squid Game" op netflix en is deze beginnen kijken. Op de applicatie voegt de gebruiker een nieuwe serie toe, vult de tv serie details in en zet de status op "Watching". Omdat ze de serie zo goed vindt kijkt ze ineens 4 episodes na elkaar. Nadien past ze op de applicatie de "Total amount of watched episodes" naar 4. Zo kan ze de volgende dag checken welke laatste episode ze heeft gezien. Heel handig als je meerdere series tegelijk kijkt. Eenmaal ze de serie volledig heeft uitgezien , past ze de status aan naar "Completed". Tijdens een gesprek met vrienden over films kan ze zo makkelijk haar lijst sharen en kan je met vrienden vergelijken wat je al hebt gezien of voeg je aanraders toe.*


## Wireframes demo
Via volgende link kan je de wireframes eens uittesten : https://xd.adobe.com/view/ca657c79-4b3a-4b2f-ac41-1c431efe1aa3-9f36/?fullscreen

Of bekijk het filmpje/schema in de wireframes map.


## Uitleg pages

### Login page
Hier kan je als gebruiker inloggen of een nieuw account aanmaken. Nadien ga je verder naar de Home - movies page

### Home - movies page
Hier zie je al je toegevoegde films, je kan op een film klikken voor de detail pagina te openen. Je kan er een nieuwe film toevoegen door op de knop te klikken. Je kan in de zoekbalk zoeken op titel.

### Tv series page
Hier zie je al je toegevoegde tv series, je kan op een tv serie klikken voor de detail pagina te openen. Je kan er een nieuwe tv serie toevoegen door op de knop te klikken. Je kan in de zoekbalk zoeken op titel.

### Anime page
Hier zie je al je toegevoegde anime, je kan op een anime klikken voor de detail pagina te openen. Je kan er een nieuwe anime toevoegen door op de knop te klikken. Je kan in de zoekbalk zoeken op titel.

### My List page
Hier kom je terecht op je persoonlijke lijst. Origineel kom je op de all tab met daarin een oplijsting van alle films/series/anime die je hebt toegevoegd aan je lijst met alle statussen.

 Je kan er naar volgende paginas swipen (status) :
* All
* Watching
* Plan to watch
* Completed

Je kan er filteren op type
* Movie
* Tv serie
* Anime

Je kan een item naar links swipen en als favorieten toevoegen.
Je kan ook op een item klikken om de detail pagina te openen.

### Detail page Movie/Tv serie/ Anime
Na het klikken op een item kom je op de detail pagina van deze item. Je ziet er verschillende details over deze item, je kan de item deleten, je kan de item editen.

### Edit page Movie/Tv serie/ Anime
Na het klikken op de edit knop in de detail pagina krijg je een nieuwe scherm te zien waar je u item als formulier kan aanpassen.

### Add page Movie/Tv serie/ Anime
Na het klikken op de add button van de speciefieke item, kom je op een nieuw scherm terecht met een form om alle details in te vullen en op te slaan.

### Menu bar // extra
Als je klikt op je profielfoto zal er links een sidebar openen met daar op volgende knoppen
* My Account
* Favourites
* Settings
* Logout

## ERD schema
Bij herexamen is schema aangepast naar dit :
![Erd schema](wireframes\IMI_ERD.jpg)

Je kan het vorige schema terug vinden in reports / wireframes map met als titel IMI_ERD_OLD
