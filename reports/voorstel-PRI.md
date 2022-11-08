# Project voorstel - PRI

## Applicatie naam 
MyWatchlist

## Project info 
Als een grote film/serie/anime liefhebber kijk ik enorm veel en hou ik ervan bij te houden wat ik wil kijken, ooit wil zien, of al heb gezien. Daarom dacht ik om een applicatie te maken die dit voor mij bijhoud.

MyWatchlist is een applicatie waar je als gebruiker een account kan aanmaken en je eigen lijst kan bijhouden. Je kan bestaande films, tv series of anime toevoegen aan je eigen watch list.
Deze hebben verschillende details zoals:
* Release year
* Name of the director
* A short description
* ...

Alleen de admin kan deze watchitems(films, series, anime) toevoegen, aanpassen en verwijderen.
De gebruiker kan alleen de watchstatus aanpassen voor de bestaande items , als favoriet toevoegen en details bekijken.

De gebruiker kan deze volgende statussen geven

* Watching
* To watch
* Watched

Je kan er makkelijk op je lijst filteren op 
* Type
* Status

Bij series zie je ook heel duidelijk hoeveel episodes je al hebt gezien.


Een klein voorbeeldje :

*De gebruiker emeuleni ontdekte zojuist de serie "Squid Game" op netflix en is deze beginnen kijken. Op de applicatie zoekt de gerbuiker tussen de series naar 'squid game', voegt deze toe aan haar watch list met de status 'watching'. Omdat ze de serie zo goed vindt kijkt ze ineens 4 episodes na elkaar. Nadien past ze op de applicatie de "Total amount of watched episodes" naar 4. Zo kan ze de volgende dag checken welke laatste episode ze heeft gezien. Heel handig als je meerdere series tegelijk kijkt. Eenmaal ze de serie volledig heeft uitgezien , past ze de status aan naar "Completed". Tijdens een gesprek met vrienden over films kan ze zo makkelijk haar lijst sharen en kan je met vrienden vergelijken wat je al hebt gezien of voeg je aanraders toe.*



## API

### Controllers


Controllers | 
------------ | 
AnimesController | 
DirectorsController | 
GenresController |
LanguagesController |
MoviesController |
TvSeriesController |
UsersController |


### API Endpoints

Movies

METHOD | ENDPOINT | USAGE
------------ | ------------- | -------------
GET | /api/Movies | Get all movies
GET | /api/Movies/{id} | Get a specific movie
PUT | /api/Movies | Edit a specific movie
POST | /api/Movies | Create a  movie
DELETE | /api/Movies/{id} | Delete a specific movie
GET | /api/Movies/search | Get all Movies with search



TvSeries

METHOD | ENDPOINT | USAGE
------------ | ------------- | -------------
GET | /api/TvSeries | Get all TvSeries
GET | /api/TvSeries/{id} | Get a specific TvSerie
PUT | /api/TvSeries | Edit a specific TvSerie
POST | /api/TvSeries | Create a  TvSerie
DELETE | /api/TvSeries/{id} | Delete a specific TvSerie
GET | /api/TvSeries/search | Get all TvSeries with search


Animes

METHOD | ENDPOINT | USAGE
------------ | ------------- | -------------
GET | /api/Animes | Get all Animes
GET | /api/Animes/{id} | Get a specific Anime
PUT | /api/Animes | Edit a specific Anime
POST | /api/Animes | Create an Anime
DELETE | /api/Animes/{id}/ | Delete a specific Anime
GET | /api/Animes/search | Get all Animes with search

Directors

METHOD | ENDPOINT | USAGE
------------ | ------------- | -------------
GET | /api/Directors | Get all Directors
GET | /api/Directors/{id} | Get a specific Director
PUT | /api/Directors | Edit a specific Director
POST | /api/Directors| Create a Director
DELETE | /api/Directors/{id}/ | Delete a specific Director


Languages

METHOD | ENDPOINT | USAGE
------------ | ------------- | -------------
GET | /api/Languages | Get all Languages
GET | /api/Languages/{id} | Get a specific Language
PUT | /api/Languages | Edit a specific Language
POST | /api/Languages | Create a Language
DELETE | /api/Languages/{id}/ | Delete a specific Language

Genres

METHOD | ENDPOINT | USAGE
------------ | ------------- | -------------
GET | /api/Genres | Get all Genres
GET | /api/Genres/{id} | Get a specific Genre
PUT | /api/Genres | Edit a specific Genre
POST | /api/Genres | Create a Genre
DELETE | /api/Genres/{id}/ | Delete a specific Genre

Users

METHOD | ENDPOINT | USAGE
------------ | ------------- | -------------
POST | /api/Users/login | Logs in a user with username and password
POST | /api/Users/register | Register a new user




## Externe API
Een vue pagina met de top 10 films.

Link doucmentatie externe api : https://www.themoviedb.org/documentation/api

Gebruikte api : apiURL = https://api.themoviedb.org/3/movie/top_rated?api_key=6ebfdabc3787595e36413cfef5b5ceec&language=en-US&page=1


## Gebruikers

Username | Passwoord | Rechten
------------ | ------------- | ------------- 
PriAdmin | Test123? | CanRead, CanEdit, CanAdd, CanDelete
PriUser | Test123? | CanRead, CanEdit, CanAdd
PriRefuser | Test123? | geen doordat terms en conditions niet heeft geaccept



## ERD schema
Bij herexamen is schema aangepast naar dit :
![Erd schema](wireframes\IMI_ERD.jpg)

Je kan het vorige schema terug vinden in reports / wireframes map met als titel IMI_ERD_OLD
