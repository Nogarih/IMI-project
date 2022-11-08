# MyWatchList

## Project
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

## Extra info

### Login gegevens Vue app
Username | Password | Rechten
------------ | ------------- | ------------- 
PriAdmin | Test123? | CanRead, CanEdit, CanAdd, CanDelete
PriUser | Test123? | CanRead, CanEdit, CanAdd
PriRefuser | Test123? | geen doordat terms en conditions niet heeft geaccept

### Login gegevens Blazor app
Je bent automatisch ingelogd als PriAdmin.

### Externe API met key  
https://api.themoviedb.org/3/movie/top_rated?api_key=6ebfdabc3787595e36413cfef5b5ceec&language=en-US&page=1

### Extra opmerkingen
- Database is volledig herwerkt doordat er met het vorige erd schema heel veel duplicate code was. Dit los ik op door gebruik te maken van inheritance. Als parent heb je de WatchlistItem met alle gemeenschappelijke properties. Een watchlistitem is STEEDS ofwel een movie, serie of anime met hun eigen persoonlijke properties. Dotnet 5 zet deze children allemaal samen in de watchlistitem tabel. Het vorig schema kan je terug vinden in de reports/wireframes map met als file titel IMI_ERD_OLD .

- HasApprovedTermsAndConditions is nullable bij admins. Daardoor heb ik de policy canRead ook als vereiste admin toegevoegd zodat alle gebruikers die gebruikersvoorwaarden hebben goedgekeurd EN admins gegevens van API kunnen raadplegen

- Door mijn freshMvvM werken mijn tabbed pages niet meer, wil je de originele mobile design/views zien , commit b4a24245dfd982fced1203cae76005dda6d6c4b3 heeft de correct layout.

### Bronnen

- Cursus mobile, pri en pin 
- Oefeningen mobile, pri en pin 
- HttpClient : https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=net-6.0
- Mediapicker : https://www.youtube.com/watch?v=AYfGxhEHiec&ab_channel=GeraldVersluis
- Adobe xd tutorial : https://www.adobe.com/products/xd/learn/get-started.html
- Externe API :  https://www.themoviedb.org/documentation/api
- Inspiratie guessing game : https://www.microsoft.com/en-us/p/guess-the-movie-quiz/9wzdncrfj0v7?activetab=pivot:overviewtab#


