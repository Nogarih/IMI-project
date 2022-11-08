# Project voorstel - PIN

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

## Blazor CRUD pagina
Je bent als admin gebruiker ingelogd.
Als gebruiker zie je een overzicht van de verschillende films.
Deze komt van de MyWatchlist api.

Je kan een movie aanpassen, toevoegen en verwijderen.


## Blazor game pagina
Hier wil ik graag een klein spelletje maken Guess the movie. Je ziet een afbeelding(scene van de film) en het aantal letters van de movie titel. Je ziet verschillende letter knopjes met een paar juiste letters en een paar foute letters. Bij het klikken op een juiste letter komt deze op de juiste plaatst te staan, doe dit tot je de volledig titel krijgt. Kies je een foute letter dan verlies je een leven (je start per movie met 6 levens). Heb je 6x fout gekozen verlies je het spel en zie je de game lost scherm met de juiste oplossing.  De game kan je winnen door alle juiste letters in te geven met nog genoeg levens op het einde. Wanneer alle letters zijn ingegeven ga je automatisch naar het win scherm/

EXTRA
Je kan tussen volgende categorieën kiezen
* movies
* series
* anime 

