# Projet_Nasa

![logo Nasa](https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/NASA_logo.svg/1200px-NASA_logo.svg.png)

## BUT :

Cree un logiciel pour visualiser les asteroide les plus proche de la terre grace à l'api de la Nasa.
Tout en resspectant l'enoncer "projet_nasa.txt" 

### Ques que je dois faire ? :

il y a 3 partie:
- respect de la POO.
- la récupération des donnée api de la nasa.
- la création du logicel et mise en place du visuel.

---
```ascii
  _____   ____   ____  
 |  __ \ / __ \ / __ \ 
 | |__) | |  | | |  | |
 |  ___/| |  | | |  | |
 | |    | |__| | |__| |
 |_|     \____/ \____/ 
 ```
                       
regles:

    tout attribut doit etre privée.
    tout attribut doit avoir un geteur si il a vocation a etre récupéré dans une autre classe.
    tout attribut doit avoir un seteur.
    toutes les classes non-abstract doivent avoir un constructeur au complet.
    toutes méthodes doivent etre ecris en camelCase.
    toutes méthodes doivent etre privée par defaut, et public si elle a vocation a etre 
        récupéré dans une autre classe.
    toutes les classes doivent avoir un objectif precisé en commentaire.
    ces regles sont valable pour tout le projet.

---
```ascii
           _____ _____ 
     /\   |  __ \_   _|
    /  \  | |__) || |  
   / /\ \ |  ___/ | |  
  / ____ \| |    _| |_ 
 /_/    \_\_|   |_____|
 
```
lien utile pour recupérer les donner api:

- [tuto recuperer les donner api](https://learn.microsoft.com/fr-fr/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client)

voici les lien de l'api:

- pour récupéré la votre [clé](https://api.nasa.gov): https://api.nasa.gov

- exemple de [lien](https://api.nasa.gov/neo/rest/v1/feed?start_date=START_DATE&end_date=END_DATE&api_key=API_KEY): https://api.nasa.gov/neo/rest/v1/feed?start_date=START_DATE&end_date=END_DATE&api_key=API_KEY
		
vous devrez recupéré toutes les info nécéssaire a la partie VISUEL.

---
```ascii
 __      _______  _____ _    _ ______ _      
 \ \    / /_   _|/ ____| |  | |  ____| |     
  \ \  / /  | | | (___ | |  | | |__  | |     
   \ \/ /   | |  \___ \| |  | |  __| | |     
    \  /   _| |_ ____) | |__| | |____| |____ 
     \/   |_____|_____/ \____/|______|______|
```	
1. lien d'un tuto complet pour faire des app windows fonctionelle: [video tuto 1](https://www.youtube.com/watch?v=wfWxdh-_k_4)

2. lien d'un tuto complet pour faire des app windows jolie: [video tuto 2](https://www.youtube.com/watch?v=PzP8mw7JUzI)
	
fonctionnalité:

- avoir le nom de votre application d'afficher
- le fond d'ecran de votre logiciel doit etre l'image de APOD
- pouvoir cliquer sur un bouton pour avoir les information de l'image de APOD
- pouvoir voir la liste des astéroîdes proche de la terre
	- nom
	- distance min
- pouvoir selectionner un astéroide pour voir sa liste des approches passé, et future

vous avez champ libre pour le visuel.

tout dois etre mis en forme de facon ergonomique
---

 ### Remarque

 1. pour regarder les format json mieux vaut regarder avec le navigateur web firefox.
 2. pour mieux m'y retrouver j'ai fais une UML.

 
---

### Partie POO 

jai fini jai essaye de faire une uml mais je ne l'ai pas trop respecte hehhe.

### FIN

j'ai fini un peut decu car de base j'ai essaye de faire avec l'axml bref fini
LE 06/02/2023 a 5H37